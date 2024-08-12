using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SARCLibrary.Format
{
    public class SFNT
    {
        public char[] SFNTHeader { get; set; }
        public short HeaderSize { get; set; }
        public short UnknownData0 { get; set; }
        public int UnknownData1 { get; set; }
        public int UnknownData2 { get; set; }

        public void ReadSFNT(BinaryReader br)
        {
            SFNTHeader = br.ReadChars(4);
            if (new string(SFNTHeader) != "SFNT") throw new Exception("Error : SFNT");
            HeaderSize = BitConverter.ToInt16(br.ReadBytes(2), 0);
            UnknownData0 = BitConverter.ToInt16(br.ReadBytes(2), 0);
            UnknownData1 = BitConverter.ToInt32(br.ReadBytes(4), 0);
            UnknownData2 = BitConverter.ToInt32(br.ReadBytes(4), 0);
        }

        public void WriteSFNT(BinaryWriter bw)
        {
            bw.Write(SFNTHeader);
            bw.Write(HeaderSize);
            bw.Write(UnknownData0);
            bw.Write(UnknownData1);
            bw.Write(UnknownData2);
        }

        public int GetHeaderSize()
        {
            int size = 0;
            size += SFNTHeader.Length;
            size += sizeof(short);
            size += sizeof(short);

            return size;
        }

        public SFNT()
        {
            SFNTHeader = "SFNT".ToCharArray();
            HeaderSize = 0; //Default : 8
            UnknownData0 = 0;
            UnknownData1 = 0;
            UnknownData2 = 0;
        }
    }
}
