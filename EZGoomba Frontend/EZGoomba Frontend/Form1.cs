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
        string goombacolorez = Directory.GetCurrentDirectory() + "Emulators/GoombaColor/goombacolor.gba";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.AllowDrop = true;

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
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = originrom;
            if (originrom.EndsWith(".gbc"))
            {
                label4.Text = "GBC";
            }
            else
            {
                label4.Text = "GB";
            }
        }
    }
}
