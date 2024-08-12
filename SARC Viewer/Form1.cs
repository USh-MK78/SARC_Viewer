using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SARCLibrary;

namespace SARC_Viewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public SARCLibrary.Format.SARC SARC { get; set; }

        private void openSARCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenSARC = new OpenFileDialog
            {
                Title = "Open SARC",
                InitialDirectory = Environment.CurrentDirectory,
                Filter = "sarc file|*.sarc|All File|*.*"
            };

            if (OpenSARC.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(OpenSARC.FileName, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);

                SARC = new SARCLibrary.Format.SARC();
                SARC.ReadSARC(br);

                br.Close();
                fs.Close();

                foreach (var item in SARC.SFATData.SFATNodeList)
                {
                    SARC_ItemListBox.Items.Add(item);
                }
            }
            else return;
        }

        private void extractToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Title = "Save",
                InitialDirectory = Environment.CurrentDirectory,
                Filter = "All File|*.*",
                FileName = SARC.SFATData.SFATNodeList[SARC_ItemListBox.SelectedIndex].ToString()
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                byte[] bytes = SARC.SARCDataDictionary[SARC_ItemListBox.SelectedIndex];

                FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);

                bw.Write(bytes);

                bw.Close();
                fs.Close();
            }
        }

        private void toStringToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
