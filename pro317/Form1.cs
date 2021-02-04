using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Guna.UI2;

namespace pro317
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GunaPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            Guna.UI.Lib.ScrollBar.PanelScrollHelper flowphelper = new Guna.UI.Lib.ScrollBar.PanelScrollHelper(flowLayoutPanel1, gunaHScrollBar1, true);
            guna2ShadowForm1.SetShadowForm(this);
        }

        private void Guna2ImageButton9_Click(object sender, EventArgs e)
        {
         

            Process.Start("https://gunaframework.com");
            Process.Start("https://github.com/sobatdata/Guna.UI-Framework-Lib");
        }

        private void GunaHScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
           
        }

        private void GunaHScrollBar1_MouseHover(object sender, EventArgs e)
        {
          ////  flowLayoutPanel1.BackColor = Color.Black;
        }

        private void GunaHScrollBar1_MouseDown(object sender, MouseEventArgs e)
        {
            flowLayoutPanel1.BackColor = Color.Black;
        }

        private void GunaHScrollBar1_MouseUp(object sender, MouseEventArgs e)
        {
            flowLayoutPanel1.BackColor = Color.FromArgb(100,0,0,0);
        }

        private void GunaPictureBox1_MouseEnter(object sender, EventArgs e)
        {
           gunaPanel4.BackColor=Color.FromArgb(100, 255, 128, 0);
            
        }

        private void GunaPictureBox1_MouseLeave(object sender, EventArgs e)
        {
            gunaPanel4.BackColor = Color.FromArgb(100, 0, 0, 0);
        }
    }
}
