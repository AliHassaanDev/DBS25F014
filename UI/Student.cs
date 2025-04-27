using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FontAwesome.Sharp;
using System.Windows.Forms;
using System.Windows.Media;
using FinalProjectDB.UI.UserControls;


namespace FinalProjectDB.UI
{
    public partial class Student : KryptonForm
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        public Student()
        {
            InitializeComponent();
            customizePanel();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 40);
            panel1.Controls.Add(leftBorderBtn);
            dashboard1.Visible = true;
        }

        private void Student_Load(object sender, EventArgs e)
        {
            activateBtn(iconButton1, System.Drawing.Color.Black, 81);
        }
        private void activateBtn(object sender, System.Drawing.Color color, int l)
        {
            if (sender != null)
            {
                disableBtn();
                currentBtn = (IconButton)sender;
                currentBtn.BackColor = System.Drawing.Color.MediumSeaGreen;
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.Padding = new Padding(0, 0, 20, 0);
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location= new Point(0, l);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                iconPictureBox1.IconChar = currentBtn.IconChar;
                label2.Text = currentBtn.Text;
            }
        }
        private void disableBtn()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = System.Drawing.Color.SpringGreen;
                currentBtn.ForeColor = System.Drawing.Color.Black;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = System.Drawing.Color.Black;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;

            }
        }
        private void customizePanel()
        {
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;
        }
        private void customizeUserControl()
        {

        }
        private void hidePanel()
        {
            if (panel3.Visible) { panel3.Visible = false; }
            if (panel4.Visible) { panel4.Visible = false; }
            if (panel5.Visible) { panel5.Visible = false; }
            if (panel6.Visible) { panel6.Visible = false; }
            if (panel7.Visible) { panel7.Visible = false; }
            if (panel8.Visible) { panel8.Visible = false; }
            if (panel9.Visible) { panel9.Visible = false; }
        }
        private void hideUserControls()
        {
            if (teach_YourCourses1.Visible) { teach_YourCourses1.Visible = false; }
            if (dashboard1.Visible) { dashboard1.Visible = false; }
        }
        private void showPanels(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hidePanel();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
        private void kryptonPalette1_PalettePaint(object sender, PaletteLayoutEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton24_Click(object sender, EventArgs e)
        {
            activateBtn(sender, System.Drawing.Color.Black, 321);
            showPanels(panel9);
        }

        private void iconButton29_Click(object sender, EventArgs e)
        {
            hidePanel();
            activateBtn(sender, System.Drawing.Color.Black, 401);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            hideUserControls();
            teach_YourCourses1.Visible=true;
            activateBtn(sender, System.Drawing.Color.Black, 121);
            showPanels(panel3);
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            activateBtn(sender, System.Drawing.Color.Black, 161);
            showPanels(panel4);
        }

        private void iconButton12_Click(object sender, EventArgs e)
        {
            activateBtn(sender, System.Drawing.Color.Black, 201);
            showPanels(panel5);
        }

        private void iconButton16_Click(object sender, EventArgs e)
        {
            activateBtn(sender, System.Drawing.Color.Black, 241);
            showPanels(panel6);
        }

        private void iconButton28_Click(object sender, EventArgs e)
        {
            activateBtn(sender, System.Drawing.Color.Black, 281);
            showPanels(panel8);
        }

        private void iconButton23_Click(object sender, EventArgs e)
        {
            activateBtn(sender, System.Drawing.Color.Black, 361);
            showPanels(panel7);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            hidePanel();
            activateBtn(sender, System.Drawing.Color.Black, 81);
            hideUserControls();
            dashboard1.Visible = true;
        }
    }
}
