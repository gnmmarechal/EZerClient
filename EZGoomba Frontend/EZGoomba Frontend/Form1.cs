using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace EZGoomba_Frontend
{
    public partial class Form1 : Form
    {
        string originrom = "";
        string goombacolorez = "goombacolor.gba";
        string goombacolorezsav = "goombacolor.sav";
        string goombaez = "goombaez.gba";
        string goombaezsav = "goombaez.sav";
        string goomba = "goomba.gba";
        string goombacolor = Directory.GetCurrentDirectory() + "Emulators/GoombaColor/goombacolor.gba";
        private string emulator;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.AllowDrop = true;
            this.MaximizeBox = false;

        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false))
            {
                e.Effect = DragDropEffects.All;
                label1.Visible = true;
            }

        }

        private void Form1_DragLeave(object sender, EventArgs e)
        {
            label1.Visible = false;
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string[] fileList = e.Data.GetData(DataFormats.FileDrop) as string[];
            originrom = fileList[0];
            label1.Visible = false;
            textBox1.Text = originrom;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (originrom.EndsWith(".gbc") || originrom.EndsWith("*.gbc.tns"))
            {
                label4.Text = "GBC";
            }
            if (originrom.EndsWith(".gb") || originrom.EndsWith("*.gb.tns"))
            {
                label4.Text = "GB";
            }
            radioButton1.Checked = !radioButton2.Checked;
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage1"])
            {
                if (radioButton1.Checked)
                {
                    emulator = "goomba.gba";
                }
                if (radioButton2.Checked)
                {
                    emulator = "goombaez.gba";
                }
                if (radioButton3.Checked)
                {

                }
                string[] srcFileNames = { emulator, originrom};
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "GameBoy Advance ROM (*.gba)| *.gba|GameBoy Advance ROM (*.agb)|*.agb|All Files|*.*";
                saveFileDialog1.Title = "Save ROM";
                saveFileDialog1.ShowDialog();

                string destFileName = saveFileDialog1.FileName;

                using (Stream destStream = File.OpenWrite(destFileName))
                {
                    foreach (string srcFileName in srcFileNames)
                    {
                        using (Stream srcStream = File.OpenRead(srcFileName))
                        {
                            srcStream.CopyTo(destStream);
                        }
                    }
                }

            }
        }
    }
}
