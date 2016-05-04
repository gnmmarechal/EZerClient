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
        bool customset = false;

        string customemu = "";
        private string emulator;
        private string destFileName;
        private bool mexican;

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
            string oldrom = originrom;
            originrom = fileList[0];
            if (originrom.EndsWith(".gbc") || originrom.EndsWith(".gb") || originrom.EndsWith(".gbc.tns") || originrom.EndsWith(".gb.tns"))
            {
                textBox1.Text = originrom;
            }
            else
            {
                if (originrom.EndsWith(".gba") || (originrom.EndsWith(".agb")))
                {
                    customemu = originrom;
                    customset = true;
                    radioButton3.Checked = true;
                    radioButton4.Checked = true;
                    customset = false;
                }
                else
                {
                    MessageBox.Show("Invalid ROM extension.");
                }
                originrom = oldrom;
            }
            label1.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (originrom.EndsWith(".gbc") || originrom.EndsWith("*.gbc.tns"))
            {
                label4.Text = "GBC";
                //tabControl1.TabPages["tabPage1"].Enabled = false;

            }
            if (originrom.EndsWith(".gb") || originrom.EndsWith("*.gb.tns"))
            {
                label4.Text = "GB";
              //  tabControl1.TabPages["tabPage1"].Enabled = true;

            }
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
                    // emulator = "goomba.gba";
                    System.IO.File.WriteAllBytes("goombaemu.bin", EZGoomba_Frontend.Properties.Resources.goomba);
                    emulator = "goombaemu.bin";
                }
                if (radioButton2.Checked)
                {
                    //emulator = "goombaez.gba";
                    System.IO.File.WriteAllBytes("goombaemu.bin", EZGoomba_Frontend.Properties.Resources.goombaez);
                    emulator = "goombaemu.bin";
                }
                if (radioButton3.Checked)
                {
                    emulator = customemu;
                }


            }
            if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage2"])
            {
                if (radioButton6.Checked)
                {
                    //emulator = "goombacolor.gba";
                    System.IO.File.WriteAllBytes("goombaemu.bin", EZGoomba_Frontend.Properties.Resources.goombacolor);
                    emulator = "goombaemu.bin";
                }
                if (radioButton5.Checked)
                {
                    //emulator = "goombacolorez.gba";
                    System.IO.File.WriteAllBytes("goombaemu.bin", EZGoomba_Frontend.Properties.Resources.goombacolorez);
                    emulator = "goombaemu.bin";
                }
                if (radioButton4.Checked)
                {
                    emulator = customemu;
                }
                
            }
            string[] srcFileNames = { emulator, originrom };
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            if (originrom.EndsWith("*.tns"))
            {

                saveFileDialog1.Filter = "TI-Nspire Document GBA ROM (*.gba.tns)|*.gba.tns|All Files|*.*";
                saveFileDialog1.Title = "Save ROM";
                saveFileDialog1.ShowDialog();
                
            }
            else
            {
                saveFileDialog1.Filter = "GameBoy Advance ROM (*.gba)| *.gba|GameBoy Advance ROM (*.agb)|*.agb|All Files|*.*";
                saveFileDialog1.Title = "Save ROM";
                saveFileDialog1.ShowDialog();
            }
            string destFileName = saveFileDialog1.FileName;
            if (string.IsNullOrWhiteSpace(destFileName))
            {
                MessageBox.Show("Canceled Operation.");
            }
            else
            {
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
                if (radioButton2.Checked)
                {
                    string extension = System.IO.Path.GetExtension(destFileName);
                    string finalname = destFileName.Substring(0, destFileName.Length - extension.Length);
                    string savname = finalname + ".sav";
                    System.IO.File.WriteAllBytes(savname, EZGoomba_Frontend.Properties.Resources.goombaezsav);
                }
                if (radioButton4.Checked)
                {
                    string extension = System.IO.Path.GetExtension(destFileName);
                    string finalname = destFileName.Substring(0, destFileName.Length - extension.Length);
                    string savname = finalname + ".sav";
                    System.IO.File.WriteAllBytes(savname, EZGoomba_Frontend.Properties.Resources.goombacolorezsav);
                }
                if (File.Exists("goombaemu.bin"))
                {
                    File.Delete("goombaemu.bin");
                }
            }

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked && customset == false)
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "GameBoy Advance ROM (*.gba)|*.gba|GameBoy Advance ROM (*.agb)|*.agb|All Files|*.*";
                openFileDialog1.Title = "Open Emulator ROM";
                openFileDialog1.ShowDialog();
                customemu = openFileDialog1.FileName;
                customset = false;
            }
        }

        private void loadROMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog2 = new OpenFileDialog();
            openFileDialog2.Filter = "GameBoy ROM (*.gb)|*.gb;|GameBoy Color ROM (*.gbc)|*.gbc|All Files|*.*";
            openFileDialog2.Title = "Select ROM";
            openFileDialog2.ShowDialog();
            string oldrom = originrom;
            originrom = openFileDialog2.FileName;
            if (originrom.EndsWith(".gbc")||originrom.EndsWith(".gb")||originrom.EndsWith(".gbc.tns")||originrom.EndsWith(".gb.tns"))
            {
                originrom = openFileDialog2.FileName;
                textBox1.Text = originrom;
            }
            else
            {
                originrom = oldrom;
                MessageBox.Show("Invalid ROM extension.");
            }
        }

        private void toolsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void manualPathEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not available.");
        }

        private void customEmulatorSetToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutEZGoombaFrontendToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About aboutfrm = new About();
            aboutfrm.Show();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help helpfrm = new Help();
            helpfrm.Show();
        }

        private void changelogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Changelog changelog = new Changelog();
            changelog.Show();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked && customset == false)
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "GameBoy Advance ROM (*.gba)|*.gba|GameBoy Advance ROM (*.agb)|*.agb|All Files|*.*";
                openFileDialog1.Title = "Open Emulator ROM";
                openFileDialog1.ShowDialog();
                customemu = openFileDialog1.FileName;
                customset = false;
            }
        }
    }
}
