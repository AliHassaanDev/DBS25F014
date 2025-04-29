using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectDB.UI.Student_UserControl
{
    public partial class Stu_SubmitAssignment : UserControl
    {
        string selectedPdfPath = "";
        public Stu_SubmitAssignment()
        {
            InitializeComponent();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "PDF Files (*.pdf)|*.pdf";
            openFileDialog1.Title = "Select a PDF";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                selectedPdfPath = openFileDialog1.FileName;
                label5.Text = selectedPdfPath;
            }
        }
    }
}
