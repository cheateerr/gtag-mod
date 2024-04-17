using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/HuHwMjWW6w");
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/iidk");
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/BnfQnzRCXP");
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/channel/UCPBcKmKbrLmbF0hqH_WwiHg");
        }
    }
}
