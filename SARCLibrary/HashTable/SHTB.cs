using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SARCLibrary.HashTable
{
    /// <summary>
    /// SARC Hash Table Binary
    /// </summary>
    public class SHTB
    {
        public char[] SHTB_Header { get; set; }
        public int HeaderSize { get; set; }
        public uint FileSize { get; set; }
        public int HashMultiplier { get; set; }
        public int AuthorNameOffset { get; set; }

        public int StringTableDataOffset { get; set; }
        
        //public List<string> GameNameList { get; set; }

        public int NodeCount { get; set; }
        public int HashTableNodeListOffset { get; set; }
        public List<HashTableNode> HashTableNodeList { get; set; }
        public class HashTableNode
        {
            public byte[] HashName { get; set; }
            public string Value { get; set; }
            
            public void Read_HashTableNode(BinaryReader br)
            {

            }

            public void Write_HashTableNode(BinaryWriter bw)
            {

            }

            public HashTableNode(byte[] HashName, string Value)
            {
                this.HashName = HashName;
                this.Value = Value;
            }

            public HashTableNode()
            {
                HashName = new byte[4];
                Value = "";
            }
        }



        public SHTB()
        {

        }
    }
}
