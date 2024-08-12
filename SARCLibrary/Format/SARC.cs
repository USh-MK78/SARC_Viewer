using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SARCLibrary.Format
{
    /// <summary>
    /// SARC
    /// </summary>
    public class SARC
    {
        public char[] SARCHeader { get; set; }
        public short HeaderSize { get; set; }
        public byte[] BOM { get; set; } //2
        public int FileSize { get; set; }
        public int SARC_DataOffset { get; set; }
        public int UnknownData { get; set; } //Always 0x00000100

        public SFAT SFATData { get; set; }

        //SARCDataSize = FileSize - SARC_DataOffset;
        public Dictionary<int, byte[]> SARCDataDictionary { get; set; }

        public void ReadSARC(BinaryReader br)
        {
            SARCHeader = br.ReadChars(4);
            if (new string(SARCHeader) != "SARC") throw new Exception("SARC : Error");
            HeaderSize = BitConverter.ToInt16(br.ReadBytes(2), 0);
            BOM = br.ReadBytes(2);

            EndianConvert endianConvert = new EndianConvert(BOM);

            FileSize = BitConverter.ToInt32(endianConvert.Convert(br.ReadBytes(4)), 0);
            SARC_DataOffset = BitConverter.ToInt32(endianConvert.Convert(br.ReadBytes(4)), 0);
            UnknownData = BitConverter.ToInt32(endianConvert.Convert(br.ReadBytes(4)), 0);

            SFATData.ReadSFAT(br, BOM);

            //Move Stream Position [ SARC_DataOffset ]
            br.BaseStream.Position = SARC_DataOffset;

            for (int i = 0; i < SFATData.SFATNodeList.Count; i++)
            {
                //Move File Offset
                br.BaseStream.Seek(SFATData.SFATNodeList[i].FileData_StartOffset, SeekOrigin.Current);

                int FileSize = SFATData.SFATNodeList[i].FileData_EndOffset - SFATData.SFATNodeList[i].FileData_StartOffset;
                byte[] Data = br.ReadBytes(FileSize);

                //Leave SARC Data Offset
                br.BaseStream.Position = SARC_DataOffset;

                SARCDataDictionary.Add(i, Data);
            }
        }

        public SARC()
        {
            SARCHeader = "SARC".ToCharArray();
            HeaderSize = 0;
            BOM = new byte[2];
            FileSize = 0;
            SARC_DataOffset = 0;
            UnknownData = 0;
            SFATData = new SFAT();

            SARCDataDictionary = new Dictionary<int, byte[]>();
        }
    }
}
