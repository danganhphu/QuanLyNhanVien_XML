namespace QuanLyNhanVien
{
    partial class frmHopDongLaoDong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHopDongLaoDong));
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvInfor = new System.Windows.Forms.DataGridView();
            this.hdId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayKT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txthdNgayKT = new System.Windows.Forms.TextBox();
            this.txthdNgayBD = new System.Windows.Forms.TextBox();
            this.txthdName = new System.Windows.Forms.TextBox();
            this.txtEmpId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txthdID = new System.Windows.Forms.TextBox();
            this.lblhdID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(568, 162);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(92, 41);
            this.btnHuy.TabIndex = 37;
            this.btnHuy.Text = "Thoát";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(406, 162);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(91, 41);
            this.btnXoa.TabIndex = 36;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(260, 162);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(82, 41);
            this.btnSua.TabIndex = 35;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(90, 162);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(96, 41);
            this.btnThem.TabIndex = 34;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvInfor
            // 
            this.dgvInfor.AllowUserToAddRows = false;
            this.dgvInfor.AllowUserToDeleteRows = false;
            this.dgvInfor.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvInfor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hdId,
            this.empId,
            this.hdName,
            this.ngayBD,
            this.ngayKT});
            this.dgvInfor.Location = new System.Drawing.Point(33, 224);
            this.dgvInfor.Name = "dgvInfor";
            this.dgvInfor.ReadOnly = true;
            this.dgvInfor.Size = new System.Drawing.Size(713, 172);
            this.dgvInfor.TabIndex = 33;
            this.dgvInfor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInfor_CellClick);
            // 
            // hdId
            // 
            this.hdId.HeaderText = "Mã hợp đồng";
            this.hdId.Name = "hdId";
            this.hdId.ReadOnly = true;
            this.hdId.Width = 120;
            // 
            // empId
            // 
            this.empId.HeaderText = "Mã nhân viên";
            this.empId.Name = "empId";
            this.empId.ReadOnly = true;
            this.empId.Width = 150;
            // 
            // hdName
            // 
            this.hdName.HeaderText = "Tên hợp đồng";
            this.hdName.Name = "hdName";
            this.hdName.ReadOnly = true;
            // 
            // ngayBD
            // 
            this.ngayBD.HeaderText = "Ngày bắt đầu";
            this.ngayBD.Name = "ngayBD";
            this.ngayBD.ReadOnly = true;
            this.ngayBD.Width = 150;
            // 
            // ngayKT
            // 
            this.ngayKT.HeaderText = "Ngày kết thúc";
            this.ngayKT.Name = "ngayKT";
            this.ngayKT.ReadOnly = true;
            this.ngayKT.Width = 150;
            // 
            // txthdNgayKT
            // 
            this.txthdNgayKT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthdNgayKT.Location = new System.Drawing.Point(469, 68);
            this.txthdNgayKT.Name = "txthdNgayKT";
            this.txthdNgayKT.Size = new System.Drawing.Size(221, 26);
            this.txthdNgayKT.TabIndex = 29;
            // 
            // txthdNgayBD
            // 
            this.txthdNgayBD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthdNgayBD.Location = new System.Drawing.Point(469, 23);
            this.txthdNgayBD.Name = "txthdNgayBD";
            this.txthdNgayBD.Size = new System.Drawing.Size(221, 26);
            this.txthdNgayBD.TabIndex = 30;
            // 
            // txthdName
            // 
            this.txthdName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthdName.Location = new System.Drawing.Point(142, 90);
            this.txthdName.Name = "txthdName";
            this.txthdName.Size = new System.Drawing.Size(221, 26);
            this.txthdName.TabIndex = 31;
            // 
            // txtEmpId
            // 
            this.txtEmpId.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpId.Location = new System.Drawing.Point(142, 52);
            this.txtEmpId.Name = "txtEmpId";
            this.txtEmpId.Size = new System.Drawing.Size(221, 26);
            this.txtEmpId.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(393, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 21);
            this.label4.TabIndex = 24;
            this.label4.Text = "Ngày KT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 21);
            this.label3.TabIndex = 25;
            this.label3.Text = "Tên hợp đồng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(390, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 21);
            this.label2.TabIndex = 26;
            this.label2.Text = "Ngày BĐ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 21);
            this.label1.TabIndex = 27;
            this.label1.Text = "Mã NV";
            // 
            // txthdID
            // 
            this.txthdID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthdID.Location = new System.Drawing.Point(142, 12);
            this.txthdID.Name = "txthdID";
            this.txthdID.Size = new System.Drawing.Size(221, 26);
            this.txthdID.TabIndex = 39;
            // 
            // lblhdID
            // 
            this.lblhdID.AutoSize = true;
            this.lblhdID.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhdID.Location = new System.Drawing.Point(29, 17);
            this.lblhdID.Name = "lblhdID";
            this.lblhdID.Size = new System.Drawing.Size(107, 21);
            this.lblhdID.TabIndex = 38;
            this.lblhdID.Text = "Mã hợp đồng";
            // 
            // frmHopDongLaoDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(774, 411);
            this.Controls.Add(this.txthdID);
            this.Controls.Add(this.lblhdID);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvInfor);
            this.Controls.Add(this.txthdNgayKT);
            this.Controls.Add(this.txthdNgayBD);
            this.Controls.Add(this.txthdName);
            this.Controls.Add(this.txtEmpId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmHopDongLaoDong";
            this.Text = "Hợp Đồng Lao Động";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvInfor;
        private System.Windows.Forms.TextBox txthdNgayKT;
        private System.Windows.Forms.TextBox txthdNgayBD;
        private System.Windows.Forms.TextBox txthdName;
        private System.Windows.Forms.TextBox txtEmpId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txthdID;
        private System.Windows.Forms.Label lblhdID;
        private System.Windows.Forms.DataGridViewTextBoxColumn hdId;
        private System.Windows.Forms.DataGridViewTextBoxColumn empId;
        private System.Windows.Forms.DataGridViewTextBoxColumn hdName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayBD;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayKT;
    }
}