namespace StudentManagementSystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtFullName = new TextBox();
            txtAge = new TextBox();
            txtGender = new ComboBox();
            txtCourse = new ComboBox();
            StudentGrid = new DataGridView();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)StudentGrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(353, 131);
            label1.Name = "label1";
            label1.Size = new Size(91, 25);
            label1.TabIndex = 0;
            label1.Text = "Full Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(353, 226);
            label2.Name = "label2";
            label2.Size = new Size(69, 25);
            label2.TabIndex = 1;
            label2.Text = "Gender";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(353, 179);
            label3.Name = "label3";
            label3.Size = new Size(44, 25);
            label3.TabIndex = 2;
            label3.Text = "Age";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(353, 277);
            label4.Name = "label4";
            label4.Size = new Size(136, 25);
            label4.TabIndex = 3;
            label4.Text = "Course Enrolled";
            label4.Click += label4_Click;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(507, 125);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(182, 31);
            txtFullName.TabIndex = 4;
            txtFullName.TextChanged += textBox1_TextChanged;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(507, 173);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(182, 31);
            txtAge.TabIndex = 5;
            // 
            // txtGender
            // 
            txtGender.FormattingEnabled = true;
            txtGender.Items.AddRange(new object[] { "MALE", "FEMALE" });
            txtGender.Location = new Point(507, 218);
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(182, 33);
            txtGender.TabIndex = 6;
            // 
            // txtCourse
            // 
            txtCourse.FormattingEnabled = true;
            txtCourse.Items.AddRange(new object[] { "Introduction to Computer Science", "Data Structures and Algorithms", "Database Management Systems", "Web Development Fundamentals", "Python Programming", "Operating Systems", "Computer Networks", "Software Engineering", "Artificial Intelligence", "Mobile App Development" });
            txtCourse.Location = new Point(507, 269);
            txtCourse.Name = "txtCourse";
            txtCourse.Size = new Size(182, 33);
            txtCourse.TabIndex = 7;
            // 
            // StudentGrid
            // 
            StudentGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            StudentGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            StudentGrid.Location = new Point(196, 357);
            StudentGrid.Name = "StudentGrid";
            StudentGrid.RowHeadersWidth = 62;
            StudentGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            StudentGrid.Size = new Size(770, 189);
            StudentGrid.TabIndex = 8;
            StudentGrid.CellClick += StudentGrid_CellClick;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(365, 317);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 34);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(517, 317);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 34);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(690, 317);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1075, 558);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(StudentGrid);
            Controls.Add(txtCourse);
            Controls.Add(txtGender);
            Controls.Add(txtAge);
            Controls.Add(txtFullName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)StudentGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtFullName;
        private TextBox txtAge;
        private ComboBox txtGender;
        private ComboBox txtCourse;
        private DataGridView StudentGrid;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
    }
}
