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
    public partial class Teachers : KryptonForm
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        public Teachers()
        {
            InitializeComponent();
            customizePanel();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 40);
            panel1.Controls.Add(leftBorderBtn);
            customizeUserControl();
            dashboard2.Visible = true;
        }

        private void Teachers_Load(object sender, EventArgs e)
        {
            activateBtn(iconButton1, System.Drawing.Color.Black,81);
        }
        private void activateBtn(object sender, System.Drawing.Color color, int l)
        {
            if (sender != null)
            {
                disableBtn();
                currentBtn = (IconButton)sender;
                currentBtn.BackColor = System.Drawing.Color.MediumSeaGreen ;
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
        private  void disableBtn()
        {
            if(currentBtn != null)
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
            panel11.Visible = false;
        }
        private void customizeUserControl()
        {
            dashboard2.Visible = false;
            teach_YourCourses2.Visible = false;
            teach_RequestCourse2.Visible = false;
            teach_DropCourse2.Visible = false;
            teach_YourLectures2.Visible = false;
            teach_CreateLecture1.Visible = false;
            teach_UpdateLecture1.Visible = false;
            teach_DeleteLectures1.Visible = false;
            teach_CreateAssignment1.Visible= false;
            teach_UpdateAssignment1.Visible= false;
            teach_DeleteAssignment1.Visible= false;
            teach_CourseAssignments1.Visible = false;
            teach_AssignmentSubmissions1.Visible= false;
            teach_CourseQuizes1.Visible = false;
            teach_CreateQuiz1.Visible= false;
            teach_UpdateQuiz1.Visible= false ;
            teach_DeleteQuiz1.Visible= false;
            teach_QuizSubmissions1.Visible= false;
            teach_AttendenceMark1.Visible = false;
            teach_AttendenceByLecture1.Visible=false;
            teach_YourComplaints1.Visible = false;
            teach_ComplaintFile1.Visible= false;
            teach_ResutsByAssesment1.Visible = false;
            teach_CreateResult1.Visible=false;
            teach_UpdateResult1.Visible=false;
            teach_DeleteResult1.Visible=false;
            teach_Announcements1.Visible = false;
            profile1.Visible=false;
            teach_ProfileComplete1.Visible=false;
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
            if (panel11.Visible) { panel11.Visible = false; }
        }
        private void hideUserControls()
        {
            if (teach_YourCourses2.Visible) { teach_YourCourses2.Visible = false; }
            if (dashboard2.Visible) { dashboard2.Visible = false; }
            if (teach_RequestCourse2.Visible) { teach_RequestCourse2.Visible = false; }
            if (teach_DropCourse2.Visible) { teach_DropCourse2.Visible = false; }
            if (teach_YourLectures2.Visible) { teach_YourLectures2.Visible = false; }
            if (teach_CreateLecture1.Visible) { teach_CreateLecture1.Visible = false; }
            if (teach_UpdateLecture1.Visible) { teach_UpdateLecture1.Visible = false; }
            if (teach_DeleteLectures1.Visible) { teach_DeleteLectures1.Visible = false; }
            if (teach_CreateAssignment1.Visible) { teach_CreateAssignment1.Visible = false; }
            if (teach_UpdateAssignment1.Visible) { teach_UpdateAssignment1.Visible = false; }
            if (teach_DeleteAssignment1.Visible) { teach_DeleteAssignment1.Visible = false; }
            if (teach_CourseAssignments1.Visible) { teach_CourseAssignments1.Visible = false; }
            if (teach_AssignmentSubmissions1.Visible) { teach_AssignmentSubmissions1.Visible= false; }
            if (teach_CourseQuizes1.Visible) { teach_CourseQuizes1.Visible = false; }
            if (teach_CreateQuiz1.Visible) { teach_CreateQuiz1.Visible= false; }
            if (teach_UpdateQuiz1.Visible) { teach_UpdateQuiz1.Visible= false; }
            if (teach_DeleteQuiz1.Visible) { teach_DeleteQuiz1.Visible= false; }
            if (teach_QuizSubmissions1.Visible) { teach_QuizSubmissions1.Visible= false; }
            if (teach_AttendenceMark1.Visible) { teach_AttendenceMark1.Visible = false; }
            if (teach_AttendenceByLecture1.Visible) { teach_AttendenceByLecture1.Visible=false; }
            if (teach_YourComplaints1.Visible) { teach_YourComplaints1.Visible = false; }
            if (teach_ComplaintFile1.Visible) { teach_ComplaintFile1.Visible=false; }
            if (teach_ResutsByAssesment1.Visible) { teach_ResutsByAssesment1.Visible = false; }
            if (teach_CreateResult1.Visible) { teach_CreateResult1.Visible=false; }
            if (teach_UpdateResult1.Visible) { teach_UpdateResult1.Visible=false; }
            if (teach_DeleteResult1.Visible) { teach_DeleteResult1.Visible=false; }
            if (teach_Announcements1.Visible) { teach_Announcements1.Visible = false; }
            if (profile1.Visible) { profile1.Visible=false; }
            if (teach_ProfileComplete1.Visible) { teach_ProfileComplete1.Visible=false; }
        }
        private void showPanels(Panel subMenu)
        {
            if(subMenu.Visible == false)
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
            hideUserControls();
            teach_YourComplaints1.Visible = true;
            activateBtn(sender, System.Drawing.Color.Black,321);
            showPanels(panel9);
        }

        private void iconButton29_Click(object sender, EventArgs e)
        {
            hideUserControls();
            teach_Announcements1.Visible = true;
            hidePanel();
            activateBtn(sender, System.Drawing.Color.Black, 401);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            hideUserControls();
            teach_YourCourses2.Visible=true;
            activateBtn(sender, System.Drawing.Color.Black, 121);
            showPanels(panel3);
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            hideUserControls();
            teach_YourLectures2.Visible=true;
            activateBtn(sender, System.Drawing.Color.Black,161);
            showPanels(panel4);
        }

        private void iconButton12_Click(object sender, EventArgs e)
        {
            hideUserControls();
            teach_CourseAssignments1.Visible = true;
            activateBtn(sender, System.Drawing.Color.Black,201);
            showPanels(panel5);
        }

        private void iconButton16_Click(object sender, EventArgs e)
        {
            hideUserControls();
            teach_CourseQuizes1.Visible = true;
            activateBtn(sender, System.Drawing.Color.Black,241);
            showPanels(panel6);
        }

        private void iconButton28_Click(object sender, EventArgs e)
        {
            hideUserControls();
            teach_AttendenceMark1.Visible = true;
            activateBtn(sender, System.Drawing.Color.Black,281);
            showPanels(panel8);
        }

        private void iconButton23_Click(object sender, EventArgs e)
        {
            hideUserControls();
            teach_ResutsByAssesment1.Visible = true;
            activateBtn(sender, System.Drawing.Color.Black,361);
            showPanels(panel7);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            hidePanel();
            activateBtn(sender, System.Drawing.Color.Black, 81);
            hideUserControls();
            dashboard2.Visible = true;
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            hideUserControls();
            teach_RequestCourse2.Visible=true;
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            hideUserControls();
            teach_DropCourse2.Visible=true;
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            hideUserControls();
            teach_CreateLecture1.Visible=true;
        }

        private void teach_YourLectures1_Load(object sender, EventArgs e)
        {

        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            hideUserControls();
            teach_UpdateLecture1.Visible=true;
        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            hideUserControls();
            teach_DeleteLectures1.Visible=true;
        }

        private void iconButton11_Click(object sender, EventArgs e)
        {
            hideUserControls();
            teach_CreateAssignment1.Visible=true;
        }

        private void iconButton10_Click(object sender, EventArgs e)
        {
            hideUserControls();
            teach_UpdateAssignment1.Visible=true;
        }

        private void iconButton9_Click(object sender, EventArgs e)
        {
            hideUserControls();
            teach_DeleteAssignment1.Visible=true;
        }

        private void iconButton18_Click(object sender, EventArgs e)
        {
            hideUserControls();
            teach_QuizSubmissions1.Visible=true;
        }

        private void iconButton15_Click(object sender, EventArgs e)
        {
            hideUserControls();
            teach_CreateQuiz1.Visible=true;
        }

        private void iconButton14_Click(object sender, EventArgs e)
        {
            hideUserControls();
            teach_UpdateQuiz1.Visible=true;
        }

        private void iconButton13_Click(object sender, EventArgs e)
        {
            hideUserControls();
            teach_DeleteQuiz1.Visible=true;
        }

        private void iconButton17_Click(object sender, EventArgs e)
        {
            hideUserControls();
            teach_AssignmentSubmissions1.Visible=true;
        }

        private void iconButton26_Click(object sender, EventArgs e)
        {
            hideUserControls();
            teach_AttendenceByLecture1.Visible=true;
        }

        private void iconButton25_Click(object sender, EventArgs e)
        {
            hideUserControls();
            teach_ComplaintFile1.Visible=true;
        }

        private void iconButton22_Click(object sender, EventArgs e)
        {
            hideUserControls();
            teach_CreateResult1.Visible=true;
        }

        private void iconButton21_Click(object sender, EventArgs e)
        {
            hideUserControls();
            teach_UpdateResult1.Visible=true;
        }

        private void iconButton20_Click(object sender, EventArgs e)
        {
            hideUserControls();
            teach_DeleteResult1.Visible=true;
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
            teach_ProfileComplete1.Visible=true;
           
        }
    }
}
