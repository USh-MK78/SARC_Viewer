using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SARCLibrary.Format
{
    public class SFAT
    {
        public char[] SFATHeader { get; set; }
        public short HeaderSize { get; set; }
        public short NodeCount { get; set; }
        public int FileNameHashMultiplier { get; set; } //Default : 0x65

        public List<SFATNode> SFATNodeList { get; set; }
        public class SFATNode
        {
            public byte[] FileNameHash { get; set; }
            public int SFNT_FileNameOffset { get; set; } //SFNTデータセクションからの相対位置
            public int FileData_StartOffset { get; set; }
            public int FileData_EndOffset { get; set; }

            public void Read_SFATNode(BinaryReader br, byte[] BOM)
            {
                EndianConvert endianConvert = new EndianConvert(BOM);
                FileNameHash = br.ReadBytes(4);
                SFNT_FileNameOffset = BitConverter.ToInt32(endianConvert.Convert(br.ReadBytes(4)), 0);
                FileData_StartOffset = BitConverter.ToInt32(endianConvert.Convert(br.ReadBytes(4)), 0);
                FileData_EndOffset = BitConverter.ToInt32(endianConvert.Convert(br.ReadBytes(4)), 0);
            }

            public void Write_SFATNode(BinaryWriter bw)
            {

            }

            public SFATNode()
            {
                FileNameHash = new byte[4];
                SFNT_FileNameOffset = 0;
                FileData_StartOffset = 0;
                FileData_EndOffset = 0;
            }

            public override string ToString()
            {
                return "SFATNode : [Hash 0x" + BitConverter.ToString(FileNameHash).Replace("-", String.Empty) + "]";
            }
        }

        public SFNT SFNTData { get; set; }

        public void ReadSFAT(BinaryReader br, byte[] BOM)
        {
            SFATHeader = br.ReadChars(4);
            if (new string(SFATHeader) != "SFAT") throw new Exception("SFAT : Error");

            EndianConvert endianConvert = new EndianConvert(BOM);

            HeaderSize = BitConverter.ToInt16(endianConvert.Convert(br.ReadBytes(2)), 0);
            NodeCount = BitConverter.ToInt16(endianConvert.Convert(br.ReadBytes(2)), 0);
            FileNameHashMultiplier = BitConverter.ToInt32(endianConvert.Convert(br.ReadBytes(4)), 0);

            for (int i = 0; i < NodeCount; i++)
            {
                SFATNode SFATNode = new SFATNode();
                SFATNode.Read_SFATNode(br, BOM);
                SFATNodeList.Add(SFATNode);
            }

            SFNTData.ReadSFNT(br);
        }

        public void WriteSFAT(BinaryWriter bw)
        {

        }

        public SFAT()
        {
            SFATHeader = "SFAT".ToCharArray();
            HeaderSize = 0; //0xC
            NodeCount = 0;
            FileNameHashMultiplier = 0x65;
            SFATNodeList = new List<SFATNode>();
            SFNTData = new SFNT();
        }
    }
}
