using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using FinalProjectDB.UI;

namespace FinalProjectDB
{
    public partial class EDUMS : KryptonForm
    {
        public EDUMS()
        {
            InitializeComponent();
        }
 
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            SignUp sign = new SignUp();
            sign.StartPosition = FormStartPosition.Manual;
            sign.Location = this.Location;
            sign.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void kryptonButton1_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            Login sign = new Login();
            sign.StartPosition = FormStartPosition.Manual;
            sign.Location = this.Location;
            sign.Show();
        }


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonPalette1_PalettePaint(object sender, PaletteLayoutEventArgs e)
        {

        }

        
    }
}
