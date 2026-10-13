namespace code
{
    partial class FormStudents
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
            lblStudentId = new Label();
            lblFullName = new Label();
            lblAge = new Label();
            lblGender = new Label();
            txtStudentId = new TextBox();
            txtFullName = new TextBox();
            txtAge = new TextBox();
            cboGender = new ComboBox();
            picAvatar = new PictureBox();
            btnChooseAvatar = new Button();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnExportCsv = new Button();
            dgvStudents = new DataGridView();
            btnLoadData = new Button();
            progressBar1 = new ProgressBar();
            lblPercent = new Label();
            ((System.ComponentModel.ISupportInitialize)picAvatar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            SuspendLayout();
            // 
            // lblStudentId
            // 
            lblStudentId.AutoSize = true;
            lblStudentId.Font = new Font("Segoe UI", 12F);
            lblStudentId.Location = new Point(110, 38);
            lblStudentId.Name = "lblStudentId";
            lblStudentId.Size = new Size(121, 28);
            lblStudentId.TabIndex = 0;
            lblStudentId.Text = "Mã sinh viên";
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Segoe UI", 12F);
            lblFullName.Location = new Point(357, 38);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(96, 28);
            lblFullName.TabIndex = 1;
            lblFullName.Text = "Họ và tên";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Font = new Font("Segoe UI", 12F);
            lblAge.Location = new Point(110, 134);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(50, 28);
            lblAge.TabIndex = 2;
            lblAge.Text = "Tuổi";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Segoe UI", 12F);
            lblGender.Location = new Point(366, 134);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(87, 28);
            lblGender.TabIndex = 3;
            lblGender.Text = "Giới tính";
            // 
            // txtStudentId
            // 
            txtStudentId.BorderStyle = BorderStyle.FixedSingle;
            txtStudentId.Font = new Font("Segoe UI", 12F);
            txtStudentId.Location = new Point(110, 69);
            txtStudentId.Name = "txtStudentId";
            txtStudentId.Size = new Size(206, 34);
            txtStudentId.TabIndex = 4;
            // 
            // txtFullName
            // 
            txtFullName.BorderStyle = BorderStyle.FixedSingle;
            txtFullName.Font = new Font("Segoe UI", 12F);
            txtFullName.Location = new Point(357, 69);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(206, 34);
            txtFullName.TabIndex = 5;
            // 
            // txtAge
            // 
            txtAge.BorderStyle = BorderStyle.FixedSingle;
            txtAge.Font = new Font("Segoe UI", 12F);
            txtAge.Location = new Point(110, 165);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(206, 34);
            txtAge.TabIndex = 6;
            // 
            // cboGender
            // 
            cboGender.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboGender.FormattingEnabled = true;
            cboGender.Location = new Point(357, 165);
            cboGender.Name = "cboGender";
            cboGender.Size = new Size(206, 36);
            cboGender.TabIndex = 7;
            // 
            // picAvatar
            // 
            picAvatar.BorderStyle = BorderStyle.FixedSingle;
            picAvatar.Location = new Point(110, 231);
            picAvatar.Name = "picAvatar";
            picAvatar.Size = new Size(184, 124);
            picAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            picAvatar.TabIndex = 8;
            picAvatar.TabStop = false;
            // 
            // btnChooseAvatar
            // 
            btnChooseAvatar.Font = new Font("Segoe UI", 12F);
            btnChooseAvatar.Location = new Point(329, 222);
            btnChooseAvatar.Name = "btnChooseAvatar";
            btnChooseAvatar.Size = new Size(234, 35);
            btnChooseAvatar.TabIndex = 9;
            btnChooseAvatar.Text = "Chọn ảnh";
            btnChooseAvatar.UseVisualStyleBackColor = true;
            btnChooseAvatar.Click += btnChooseAvatar_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 12F);
            btnAdd.Location = new Point(329, 272);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(102, 37);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 12F);
            btnUpdate.Location = new Point(461, 274);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(102, 33);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Sửa";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 12F);
            btnDelete.Location = new Point(329, 323);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(102, 37);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnExportCsv
            // 
            btnExportCsv.Font = new Font("Segoe UI", 12F);
            btnExportCsv.Location = new Point(461, 323);
            btnExportCsv.Name = "btnExportCsv";
            btnExportCsv.Size = new Size(102, 37);
            btnExportCsv.TabIndex = 13;
            btnExportCsv.Text = "Xuất CSV";
            btnExportCsv.UseVisualStyleBackColor = true;
            btnExportCsv.Click += btnExportCsv_Click;
            // 
            // dgvStudents
            // 
            dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Location = new Point(82, 444);
            dgvStudents.MultiSelect = false;
            dgvStudents.Name = "dgvStudents";
            dgvStudents.ReadOnly = true;
            dgvStudents.RowHeadersWidth = 51;
            dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudents.Size = new Size(499, 188);
            dgvStudents.TabIndex = 14;
            // 
            // btnLoadData
            // 
            btnLoadData.Location = new Point(82, 670);
            btnLoadData.Name = "btnLoadData";
            btnLoadData.Size = new Size(183, 71);
            btnLoadData.TabIndex = 15;
            btnLoadData.Text = "Nạp dữ liệu";
            btnLoadData.UseVisualStyleBackColor = true;
            
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(283, 694);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(298, 29);
            progressBar1.TabIndex = 16;
            // 
            // lblPercent
            // 
            lblPercent.AutoSize = true;
            lblPercent.Location = new Point(599, 703);
            lblPercent.Name = "lblPercent";
            lblPercent.Size = new Size(29, 20);
            lblPercent.TabIndex = 17;
            lblPercent.Text = "0%";
            // 
            // FormStudents
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 788);
            Controls.Add(lblPercent);
            Controls.Add(progressBar1);
            Controls.Add(btnLoadData);
            Controls.Add(dgvStudents);
            Controls.Add(btnExportCsv);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(btnChooseAvatar);
            Controls.Add(picAvatar);
            Controls.Add(cboGender);
            Controls.Add(txtAge);
            Controls.Add(txtFullName);
            Controls.Add(txtStudentId);
            Controls.Add(lblGender);
            Controls.Add(lblAge);
            Controls.Add(lblFullName);
            Controls.Add(lblStudentId);
            Name = "FormStudents";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)picAvatar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStudentId;
        private Label lblFullName;
        private Label lblAge;
        private Label lblGender;
        private TextBox txtStudentId;
        private TextBox txtFullName;
        private TextBox txtAge;
        private ComboBox cboGender;
        private PictureBox picAvatar;
        private Button btnChooseAvatar;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnExportCsv;
        private DataGridView dgvStudents;
        private Button btnLoadData;
        private ProgressBar progressBar1;
        private Label lblPercent;
    }
}
