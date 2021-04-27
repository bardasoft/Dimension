using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Xna.Framework;

namespace Engine_Project
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void runScriptToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void drawTest1_Click(object sender, EventArgs e)
        {

        }

        private void snowToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            drawTest1.background = Microsoft.Xna.Framework.Color.CornflowerBlue;
        }

        private void nightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            drawTest1.background = Microsoft.Xna.Framework.Color.Purple;
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            drawTest1.background = Microsoft.Xna.Framework.Color.DarkRed;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            drawTest1.MenuMessage = textBox1.Text;
        }

        private void button_WOC4_Click(object sender, EventArgs e)
        {
            drawTest1.textColor = Microsoft.Xna.Framework.Color.White;
        }

        private void button_WOC3_Click(object sender, EventArgs e)
        {
            drawTest1.textColor = Microsoft.Xna.Framework.Color.Black;
        }
    }
}