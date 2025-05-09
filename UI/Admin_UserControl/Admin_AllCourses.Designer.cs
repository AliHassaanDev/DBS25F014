namespace FinalProjectDB.UI.Admin_UserControl
{
    partial class Admin_AllCourses
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gridViewCourseIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridViewcourseNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridViewdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridViewcreditHoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridViewDeptidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBLBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(951, 614);
            this.tableLayoutPanel1.TabIndex = 7;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint_1);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 44);
            this.label1.TabIndex = 2;
            this.label1.Text = "All Courses";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightCyan;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gridViewCourseIDDataGridViewTextBoxColumn,
            this.gridViewcourseNameDataGridViewTextBoxColumn,
            this.gridViewdateDataGridViewTextBoxColumn,
            this.gridViewcreditHoursDataGridViewTextBoxColumn,
            this.gridViewDeptidDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.courseBLBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(99, 127);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(752, 419);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // gridViewCourseIDDataGridViewTextBoxColumn
            // 
            this.gridViewCourseIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.gridViewCourseIDDataGridViewTextBoxColumn.DataPropertyName = "GridViewCourseID";
            this.gridViewCourseIDDataGridViewTextBoxColumn.HeaderText = "CourseID";
            this.gridViewCourseIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.gridViewCourseIDDataGridViewTextBoxColumn.Name = "gridViewCourseIDDataGridViewTextBoxColumn";
            this.gridViewCourseIDDataGridViewTextBoxColumn.Width = 113;
            // 
            // gridViewcourseNameDataGridViewTextBoxColumn
            // 
            this.gridViewcourseNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.gridViewcourseNameDataGridViewTextBoxColumn.DataPropertyName = "GridViewcourseName";
            this.gridViewcourseNameDataGridViewTextBoxColumn.HeaderText = "Course Name";
            this.gridViewcourseNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.gridViewcourseNameDataGridViewTextBoxColumn.Name = "gridViewcourseNameDataGridViewTextBoxColumn";
            this.gridViewcourseNameDataGridViewTextBoxColumn.Width = 142;
            // 
            // gridViewdateDataGridViewTextBoxColumn
            // 
            this.gridViewdateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.gridViewdateDataGridViewTextBoxColumn.DataPropertyName = "GridViewdate";
            this.gridViewdateDataGridViewTextBoxColumn.HeaderText = "End Date";
            this.gridViewdateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.gridViewdateDataGridViewTextBoxColumn.Name = "gridViewdateDataGridViewTextBoxColumn";
            this.gridViewdateDataGridViewTextBoxColumn.Width = 113;
            // 
            // gridViewcreditHoursDataGridViewTextBoxColumn
            // 
            this.gridViewcreditHoursDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.gridViewcreditHoursDataGridViewTextBoxColumn.DataPropertyName = "GridViewcreditHours";
            this.gridViewcreditHoursDataGridViewTextBoxColumn.HeaderText = "Credit Hours";
            this.gridViewcreditHoursDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.gridViewcreditHoursDataGridViewTextBoxColumn.Name = "gridViewcreditHoursDataGridViewTextBoxColumn";
            this.gridViewcreditHoursDataGridViewTextBoxColumn.Width = 134;
            // 
            // gridViewDeptidDataGridViewTextBoxColumn
            // 
            this.gridViewDeptidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.gridViewDeptidDataGridViewTextBoxColumn.DataPropertyName = "GridViewDept_id";
            this.gridViewDeptidDataGridViewTextBoxColumn.HeaderText = "Deptartment_id";
            this.gridViewDeptidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.gridViewDeptidDataGridViewTextBoxColumn.Name = "gridViewDeptidDataGridViewTextBoxColumn";
            this.gridViewDeptidDataGridViewTextBoxColumn.Width = 156;
            // 
            // courseBLBindingSource
            // 
            this.courseBLBindingSource.DataSource = typeof(FinalProjectDB.BL.CourseBL);
            this.courseBLBindingSource.CurrentChanged += new System.EventHandler(this.courseBLBindingSource_CurrentChanged);
            // 
            // Admin_AllCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Admin_AllCourses";
            this.Size = new System.Drawing.Size(951, 614);
            this.Load += new System.EventHandler(this.Admin_AllCourses_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBLBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource courseBLBindingSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridViewCourseIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridViewcourseNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridViewdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridViewcreditHoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridViewDeptidDataGridViewTextBoxColumn;
    }
}
