namespace QuanLyNhanVien
{
    partial class frmNhanVien
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhanVien));
            this.dgvInfor = new System.Windows.Forms.DataGridView();
            this.empId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deptName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deptTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDeptTel = new System.Windows.Forms.TextBox();
            this.txtDeptName = new System.Windows.Forms.TextBox();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtEmpId = new System.Windows.Forms.TextBox();
            this.lblDeptTel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfor)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInfor
            // 
            this.dgvInfor.AllowUserToAddRows = false;
            this.dgvInfor.AllowUserToDeleteRows = false;
            this.dgvInfor.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvInfor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.empId,
            this.empName,
            this.salary,
            this.deptName,
            this.deptTel});
            this.dgvInfor.Location = new System.Drawing.Point(28, 225);
            this.dgvInfor.Name = "dgvInfor";
            this.dgvInfor.ReadOnly = true;
            this.dgvInfor.Size = new System.Drawing.Size(716, 148);
            this.dgvInfor.TabIndex = 18;
            this.dgvInfor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInfor_CellClick);
            // 
            // empId
            // 
            this.empId.HeaderText = "Mã NV";
            this.empId.Name = "empId";
            this.empId.ReadOnly = true;
            this.empId.Width = 120;
            // 
            // empName
            // 
            this.empName.HeaderText = "Họ Tên";
            this.empName.Name = "empName";
            this.empName.ReadOnly = true;
            this.empName.Width = 150;
            // 
            // salary
            // 
            this.salary.HeaderText = "Lương";
            this.salary.Name = "salary";
            this.salary.ReadOnly = true;
            // 
            // deptName
            // 
            this.deptName.HeaderText = "Phòng Ban";
            this.deptName.Name = "deptName";
            this.deptName.ReadOnly = true;
            this.deptName.Width = 150;
            // 
            // deptTel
            // 
            this.deptTel.HeaderText = "Số Điện Thoại";
            this.deptTel.Name = "deptTel";
            this.deptTel.ReadOnly = true;
            this.deptTel.Width = 150;
            // 
            // txtDeptTel
            // 
            this.txtDeptTel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeptTel.Location = new System.Drawing.Point(322, 115);
            this.txtDeptTel.Name = "txtDeptTel";
            this.txtDeptTel.Size = new System.Drawing.Size(221, 26);
            this.txtDeptTel.TabIndex = 9;
            // 
            // txtDeptName
            // 
            this.txtDeptName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeptName.Location = new System.Drawing.Point(424, 69);
            this.txtDeptName.Name = "txtDeptName";
            this.txtDeptName.Size = new System.Drawing.Size(221, 26);
            this.txtDeptName.TabIndex = 10;
            // 
            // txtEmpName
            // 
            this.txtEmpName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpName.Location = new System.Drawing.Point(424, 24);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(221, 26);
            this.txtEmpName.TabIndex = 11;
            // 
            // txtSalary
            // 
            this.txtSalary.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalary.Location = new System.Drawing.Point(90, 69);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(221, 26);
            this.txtSalary.TabIndex = 12;
            // 
            // txtEmpId
            // 
            this.txtEmpId.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpId.Location = new System.Drawing.Point(90, 27);
            this.txtEmpId.Name = "txtEmpId";
            this.txtEmpId.Size = new System.Drawing.Size(221, 26);
            this.txtEmpId.TabIndex = 13;
            // 
            // lblDeptTel
            // 
            this.lblDeptTel.AutoSize = true;
            this.lblDeptTel.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeptTel.Location = new System.Drawing.Point(162, 120);
            this.lblDeptTel.Name = "lblDeptTel";
            this.lblDeptTel.Size = new System.Drawing.Size(111, 21);
            this.lblDeptTel.TabIndex = 4;
            this.lblDeptTel.Text = "Số điện thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(341, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Phòng ban";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Lương";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(341, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Họ tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mã NV";
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(75, 163);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(96, 41);
            this.btnThem.TabIndex = 19;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(245, 163);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(82, 41);
            this.btnSua.TabIndex = 20;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(391, 163);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(91, 41);
            this.btnXoa.TabIndex = 21;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(553, 163);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(92, 41);
            this.btnHuy.TabIndex = 22;
            this.btnHuy.Text = "Thoát";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CadetBlue;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(667, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 59);
            this.button1.TabIndex = 23;
            this.button1.Text = "Hợp đồng lao động";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(782, 390);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvInfor);
            this.Controls.Add(this.txtDeptTel);
            this.Controls.Add(this.txtDeptName);
            this.Controls.Add(this.txtEmpName);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtEmpId);
            this.Controls.Add(this.lblDeptTel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmNhanVien";
            this.Text = "Quản lý nhân viên_XML";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInfor;
        private System.Windows.Forms.TextBox txtDeptTel;
        private System.Windows.Forms.TextBox txtDeptName;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtEmpId;
        private System.Windows.Forms.Label lblDeptTel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn empId;
        private System.Windows.Forms.DataGridViewTextBoxColumn empName;
        private System.Windows.Forms.DataGridViewTextBoxColumn salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn deptName;
        private System.Windows.Forms.DataGridViewTextBoxColumn deptTel;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button button1;
    }
}

