using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewGoomba_Frontend
{
    public partial class mainForm : Form
    {
        String tempROMPath = "goomba.bin";

        public mainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        void writeTempROM()
        {

        }

        void rmTempROM()
        {
            if (File.Exists(tempROMPath))
                File.Delete(tempROMPath);

        }
    }

}
