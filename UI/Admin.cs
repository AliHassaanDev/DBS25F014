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
using FinalProjectDB.UI.Admin_UserControl;

namespace FinalProjectDB.UI
{
    public partial class Admin : KryptonForm
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        public Admin()
        {
            InitializeComponent();
            customizePanel();
            customizeUserControl();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 40);
            panel1.Controls.Add(leftBorderBtn);
            dashboard1.Visible = true;
        }

        private void Admin_Load(object sender, EventArgs e)
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
            panel11.Visible = false;
            panel12.Visible = false;
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
            if (panel12.Visible) { panel12.Visible = false; }
        }
        private void customizeUserControl()
        {
            dashboard1.Visible = false;
            profile1.Visible= false;
            admin_AllCourses1.Visible = false;
            admin_CreateCourse1.Visible = false;
            admin_UpdateCourse1.Visible = false;
            admin_DeleteCourse1.Visible = false;
            admin_AssignCourse1.Visible = false;
            admin_TeachRequests1.Visible = false;
            admin_AddUser1.Visible = false;
            admin_UpdateUser1.Visible = false;
            admin_DeleteUser1.Visible = false;
            admin_AllUsers1.Visible = false;
            admin_AllDepartments1.Visible = false;
            admin_CreateDepartment1.Visible = false;
            admin_UpdateDepartment1.Visible = false;
            admin_DeleteDepartment1.Visible = false;
            teach_Announcements1.Visible = false;
            admin_CreateAnnouncement1.Visible = false;
            admin_UpdateAnnouncement1.Visible = false;
            admin_DeleteAnnouncement1.Visible = false;
            teach_AttendanceByLecture1.Visible = false;
            admin_AttendenceByStudent1.Visible = false;
            admin_AllComplaints1.Visible = false;
            admin_ComplaintResolve1.Visible = false;
            teach_ResutsByAssesment1.Visible = false;
            admin_ResultByStudent1.Visible = false;
            admin_AllStudents1.Visible = false;
            admin_AllTeachers1.Visible = false;
            admin_EnrolledStudents1.Visible = false;
            admin_AssignedTeachers1.Visible = false;
        }
        
        private void hideUserControls()
        {
            if (dashboard1.Visible) { dashboard1.Visible = false; }
            if (profile1.Visible) { profile1.Visible= false; }
            if (admin_AllCourses1.Visible) { admin_AllCourses1.Visible = false; }
            if (admin_CreateCourse1.Visible) { admin_CreateCourse1.Visible = false; }
            if(admin_UpdateCourse1.Visible) { admin_UpdateCourse1.Visible = false; }
            if(admin_DeleteCourse1.Visible) { admin_DeleteCourse1.Visible = false; }
            if(admin_AssignCourse1.Visible) { admin_AssignCourse1.Visible = false; }
            if (admin_TeachRequests1.Visible) { admin_TeachRequests1.Visible = false; }
            if(admin_AddUser1.Visible) { admin_AddUser1.Visible = false; }
            if (admin_UpdateUser1.Visible) { admin_UpdateUser1.Visible = false; }
            if(admin_DeleteUser1.Visible) { admin_DeleteUser1.Visible = false; }
            if (admin_AllUsers1.Visible) { admin_AllUsers1.Visible = false; }
            if(admin_AllDepartments1.Visible) { admin_AllDepartments1.Visible = false; }
            if(admin_CreateDepartment1.Visible) { admin_CreateDepartment1.Visible = false; }
            if (admin_UpdateDepartment1.Visible) { admin_UpdateDepartment1.Visible = false; }
            if (admin_DeleteDepartment1.Visible) { admin_DeleteDepartment1.Visible = false; }
            if(teach_Announcements1.Visible) { teach_Announcements1.Visible = false; }
            if(admin_CreateAnnouncement1.Visible) { admin_CreateAnnouncement1.Visible = false; }
            if (admin_UpdateAnnouncement1.Visible) { admin_UpdateAnnouncement1.Visible = false; }
            if (admin_DeleteAnnouncement1.Visible) { admin_DeleteAnnouncement1.Visible = false; }
            if(teach_AttendanceByLecture1.Visible) { teach_AttendanceByLecture1.Visible = false; }
            if (admin_AttendenceByStudent1.Visible) { admin_AttendenceByStudent1.Visible = false; }        
            if(admin_AllComplaints1.Visible) { admin_AllComplaints1.Visible = false; }
            if (admin_ComplaintResolve1.Visible) { admin_ComplaintResolve1.Visible = false; }
            if(teach_ResutsByAssesment1.Visible) { teach_ResutsByAssesment1.Visible = false; }
            if(admin_ResultByStudent1.Visible) { admin_ResultByStudent1.Visible = false; }
            if(admin_AllStudents1.Visible) { admin_AllStudents1.Visible = false; }
            if(admin_AllTeachers1.Visible) { admin_AllTeachers1.Visible = false; }
            if (admin_EnrolledStudents1.Visible) { admin_EnrolledStudents1.Visible = false; }
            if (admin_AssignedTeachers1.Visible) { admin_AssignedTeachers1.Visible = false; }
        
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton30_Click(object sender, EventArgs e)
        {
            hideUserControls();
            profile1.Visible=true;
        }

        private void iconButton31_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //-----------Dashboard Btn---------------------//
        private void iconButton1_Click(object sender, EventArgs e)
        {
            hidePanel();
            activateBtn(sender, System.Drawing.Color.Black, 81);
            hideUserControls();
            dashboard1.Visible = true;
        }

        //-----------Course Btns-----------------------//
        private void iconButton2_Click(object sender, EventArgs e)
        {
            hideUserControls();
            admin_AllCourses1.Visible = true;
            activateBtn(sender, System.Drawing.Color.Black, 121);
            showPanels(panel3);
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            hideUserControls();
            admin_CreateCourse1.Visible = true;
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            hideUserControls();
            admin_UpdateCourse1.Visible = true;
        }

        private void iconButton32_Click(object sender, EventArgs e)
        {
            hideUserControls();
            admin_DeleteCourse1.Visible = true;

        }

        private void iconButton33_Click(object sender, EventArgs e)
        {
            hideUserControls();
            admin_AssignCourse1.Visible = true;
        }

        private void iconButton34_Click(object sender, EventArgs e)
        {
            hideUserControls();
            admin_TeachRequests1.Visible = true;
        }

        //-----------User Control Btns-----------------//
        private void iconButton5_Click(object sender, EventArgs e)
        {
            hideUserControls();
            admin_AllUsers1.Visible = true;
            activateBtn(sender, System.Drawing.Color.Black, 161);
            showPanels(panel4);
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            hideUserControls();
            admin_AddUser1.Visible = true;
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            hideUserControls();
            admin_UpdateUser1.Visible = true;
        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            hideUserControls();
            admin_DeleteUser1.Visible = true;
        }

        //-----------Department Btns-------------------//
        private void iconButton12_Click(object sender, EventArgs e)
        {
            hideUserControls();
            admin_AllDepartments1.Visible = true;
            activateBtn(sender, System.Drawing.Color.Black, 201);
            showPanels(panel5);
        }

        private void iconButton11_Click(object sender, EventArgs e)
        {
            hideUserControls();
            admin_CreateDepartment1.Visible = true;
        }

        private void iconButton10_Click(object sender, EventArgs e)
        {
            hideUserControls();
            admin_UpdateDepartment1.Visible = true;
        }

        private void iconButton9_Click(object sender, EventArgs e)
        {
            hideUserControls();
            admin_DeleteDepartment1.Visible = true;
        }

        //-----------Announcement Btns-----------------//
        private void iconButton16_Click(object sender, EventArgs e)
        {
            hideUserControls();
            teach_Announcements1.Visible = true;
            activateBtn(sender, System.Drawing.Color.Black, 241);
            showPanels(panel6);
        }

        private void iconButton15_Click(object sender, EventArgs e)
        {
            hideUserControls();
            admin_CreateAnnouncement1.Visible = true;
        }

        private void iconButton14_Click(object sender, EventArgs e)
        {
            hideUserControls();
            admin_UpdateAnnouncement1.Visible = true;
        }

        private void iconButton13_Click(object sender, EventArgs e)
        {
            hideUserControls();
            admin_DeleteAnnouncement1.Visible = true;
        }

        //-----------Attendance Btns-------------------//
        private void iconButton28_Click(object sender, EventArgs e)
        {
            hideUserControls();
            teach_AttendanceByLecture1.Visible = true;
            activateBtn(sender, System.Drawing.Color.Black, 281);
            showPanels(panel8);
        }

        private void iconButton27_Click(object sender, EventArgs e)
        {
            hideUserControls();
            admin_AttendenceByStudent1.Visible = true;
        }


        //-----------Complaints Btns-------------------//
        private void iconButton24_Click(object sender, EventArgs e)
        {
            hideUserControls();
            admin_AllComplaints1.Visible =true;
            activateBtn(sender, System.Drawing.Color.Black, 321);
            showPanels(panel9);
        }

        private void iconButton25_Click(object sender, EventArgs e)
        {
            hideUserControls();
            admin_ComplaintResolve1.Visible = true;
        }

        //-----------Results Reports Btns--------------//
        private void iconButton23_Click(object sender, EventArgs e)
        {
            hideUserControls();
            teach_ResutsByAssesment1.Visible = true;
            activateBtn(sender, System.Drawing.Color.Black, 361);
            showPanels(panel7);
        }

        private void iconButton22_Click(object sender, EventArgs e)
        {
            hideUserControls();
            admin_ResultByStudent1.Visible = true;
        }

        //-----------Student Reports Btns--------------//
        private void iconButton29_Click(object sender, EventArgs e)
        {
            hideUserControls();
            admin_AllStudents1.Visible = true;
            activateBtn(sender, System.Drawing.Color.Black, 401);
            showPanels(panel12);
        }

        private void iconButton18_Click(object sender, EventArgs e)
        {
            hideUserControls();
            admin_EnrolledStudents1.Visible = true;
        }

        //-----------Teacher Report Btns---------------//
        private void iconButton17_Click_1(object sender, EventArgs e)
        {
            hideUserControls();
            admin_AllTeachers1.Visible = true;
            activateBtn(sender, System.Drawing.Color.Black, 401);
            showPanels(panel11);
        }

        private void iconButton36_Click(object sender, EventArgs e)
        {
            hideUserControls();
            admin_AssignedTeachers1.Visible = true;
        }

    }
}
