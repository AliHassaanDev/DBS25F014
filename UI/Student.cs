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
            customizeUserControl();
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
            panel5.Visible = false;
            panel9.Visible = false;
            panel11.Visible = false;
        }
        private void hidePanel()
        {
            if (panel3.Visible) { panel3.Visible = false; }
            if (panel5.Visible) { panel5.Visible = false; }
            if (panel9.Visible) { panel9.Visible = false; }
            if (panel11.Visible) { panel11.Visible = false; }
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

        private void customizeUserControl()
        {
            dashboard1.Visible = false;
            admin_AllCourses1.Visible = false;
            stu_CourseRegister1.Visible= false;
            stu_Lectures1.Visible= false;
            teach_CourseAssessments1.Visible= false;
            stu_SubmitAssignment1.Visible= false;
            stu_Attendence1.Visible = false;
            teach_YourComplaints1.Visible = false;
            teach_ComplaintFile1.Visible = false;
            stu_Result1.Visible = false;
            teach_Announcements1.Visible = false;
            profile1.Visible = false;
            stu_ProfileComplete1.Visible =false;
        }
        private void hideUserControls()
        {
            if (dashboard1.Visible) { dashboard1.Visible = false; }
            if (admin_AllCourses1.Visible) { admin_AllCourses1.Visible = false; }
            if (stu_CourseRegister1.Visible) { stu_CourseRegister1.Visible= false; }
            if (stu_Lectures1.Visible) { stu_Lectures1.Visible= false; }
            if (teach_CourseAssessments1.Visible) { teach_CourseAssessments1.Visible= false; }
            if (stu_SubmitAssignment1.Visible) { stu_SubmitAssignment1.Visible= false; }
            if (stu_Attendence1.Visible) { stu_Attendence1.Visible = false; }
            if (teach_YourComplaints1.Visible) { teach_YourComplaints1.Visible = false; }
            if (teach_ComplaintFile1.Visible) { teach_ComplaintFile1.Visible = false; }
            if (stu_Result1.Visible) { stu_Result1.Visible = false; }
            if (teach_Announcements1.Visible) { teach_Announcements1.Visible = false; }
            if (profile1.Visible) { profile1.Visible = false; }
            if (stu_ProfileComplete1.Visible) { stu_ProfileComplete1.Visible =false; }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            hidePanel();
            activateBtn(sender, System.Drawing.Color.Black, 81);
            hideUserControls();
            dashboard1.Visible = true;
        }
        private void iconButton2_Click(object sender, EventArgs e)
        {
            hideUserControls();
            admin_AllCourses1.Visible=true;
            activateBtn(sender, System.Drawing.Color.Black, 121);
            showPanels(panel3);
        }
        private void iconButton4_Click(object sender, EventArgs e)
        {
            hideUserControls();
            stu_CourseRegister1.Visible=true;
        }
        private void iconButton5_Click(object sender, EventArgs e)
        {
            hidePanel();
            activateBtn(sender, System.Drawing.Color.Black, 161);
            hideUserControls();
            stu_Lectures1.Visible=true;
        }
        private void iconButton12_Click(object sender, EventArgs e)
        {
            activateBtn(sender, System.Drawing.Color.Black, 201);
            showPanels(panel5);
            hideUserControls();
            teach_CourseAssessments1.Visible=true;
        }
        private void iconButton11_Click(object sender, EventArgs e)
        {
            hideUserControls();
            stu_SubmitAssignment1.Visible=true;
        }
   
        private void iconButton28_Click(object sender, EventArgs e)
        {
            hidePanel();
            activateBtn(sender, System.Drawing.Color.Black, 281);
            hideUserControls();
            stu_Attendence1.Visible = true;
        }
        private void iconButton24_Click(object sender, EventArgs e)
        {
            activateBtn(sender, System.Drawing.Color.Black, 321);
            showPanels(panel9);
            hideUserControls();
            teach_YourComplaints1.Visible=true;
        }
        private void iconButton25_Click(object sender, EventArgs e)
        {
            hideUserControls();
            teach_ComplaintFile1.Visible=true;
        }
        private void iconButton23_Click(object sender, EventArgs e)
        {
            hidePanel();
            activateBtn(sender, System.Drawing.Color.Black, 361);
            hideUserControls();
            stu_Result1.Visible = true;
        }
        private void iconButton29_Click(object sender, EventArgs e)
        {
            hidePanel();
            activateBtn(sender, System.Drawing.Color.Black, 401);
            hideUserControls();
            teach_Announcements1.Visible=true;
        }
        private void iconButton30_Click(object sender, EventArgs e)
        {
            hideUserControls();
            profile1.Visible=true;
            panel11.BringToFront();
            showPanels(panel11);
        }
        private void iconButton27_Click(object sender, EventArgs e)
        {
            hideUserControls();
            stu_ProfileComplete1.Visible=true;
        }
        private void kryptonPalette1_PalettePaint(object sender, PaletteLayoutEventArgs e)
        {

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void dashboard1_Load(object sender, EventArgs e)
        {

        }

        private void stu_ProfileComplete1_Load(object sender, EventArgs e)
        {

        }
    }
}
