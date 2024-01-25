namespace Day1_2
{
    partial class FHocSinh
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
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.txtHoVaTen = new System.Windows.Forms.TextBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.gvHocSinh = new System.Windows.Forms.DataGridView();
            this.datNgayThang = new System.Windows.Forms.DateTimePicker();
            this.lblNgayThang = new System.Windows.Forms.Label();
            this.lblCMND = new System.Windows.Forms.Label();
            this.lblDiachi = new System.Windows.Forms.Label();
            this.lblHoVaTen = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvHocSinh)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCMND
            // 
            this.txtCMND.Font = new System.Drawing.Font("UTM Seagull", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCMND.Location = new System.Drawing.Point(126, 241);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(200, 26);
            this.txtCMND.TabIndex = 15;
            this.txtCMND.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDiachi
            // 
            this.txtDiachi.Font = new System.Drawing.Font("UTM Seagull", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiachi.Location = new System.Drawing.Point(126, 173);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(200, 26);
            this.txtDiachi.TabIndex = 16;
            this.txtDiachi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtHoVaTen
            // 
            this.txtHoVaTen.Font = new System.Drawing.Font("UTM Seagull", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoVaTen.Location = new System.Drawing.Point(126, 110);
            this.txtHoVaTen.Name = "txtHoVaTen";
            this.txtHoVaTen.Size = new System.Drawing.Size(200, 26);
            this.txtHoVaTen.TabIndex = 17;
            this.txtHoVaTen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("UTM Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(388, 140);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(82, 29);
            this.btnSua.TabIndex = 12;
            this.btnSua.Text = "Sua";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("UTM Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(388, 274);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(82, 29);
            this.btnXoa.TabIndex = 13;
            this.btnXoa.Text = "Xoa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("UTM Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(388, 206);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(82, 29);
            this.btnThem.TabIndex = 14;
            this.btnThem.Text = "Them";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // gvHocSinh
            // 
            this.gvHocSinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvHocSinh.Location = new System.Drawing.Point(511, 100);
            this.gvHocSinh.Name = "gvHocSinh";
            this.gvHocSinh.Size = new System.Drawing.Size(443, 255);
            this.gvHocSinh.TabIndex = 11;
            this.gvHocSinh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvHocSinh_CellClick);
            // 
            // datNgayThang
            // 
            this.datNgayThang.CustomFormat = "dd/MM/yyyy";
            this.datNgayThang.Font = new System.Drawing.Font("UTM Seagull", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datNgayThang.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datNgayThang.Location = new System.Drawing.Point(126, 318);
            this.datNgayThang.Name = "datNgayThang";
            this.datNgayThang.Size = new System.Drawing.Size(200, 26);
            this.datNgayThang.TabIndex = 10;
            // 
            // lblNgayThang
            // 
            this.lblNgayThang.AutoSize = true;
            this.lblNgayThang.Font = new System.Drawing.Font("UTM Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayThang.Location = new System.Drawing.Point(128, 287);
            this.lblNgayThang.Name = "lblNgayThang";
            this.lblNgayThang.Size = new System.Drawing.Size(125, 19);
            this.lblNgayThang.TabIndex = 7;
            this.lblNgayThang.Text = "Ngay thang nam sinh";
            // 
            // lblCMND
            // 
            this.lblCMND.AutoSize = true;
            this.lblCMND.Font = new System.Drawing.Font("UTM Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCMND.Location = new System.Drawing.Point(127, 211);
            this.lblCMND.Name = "lblCMND";
            this.lblCMND.Size = new System.Drawing.Size(39, 19);
            this.lblCMND.TabIndex = 8;
            this.lblCMND.Text = "CMND";
            // 
            // lblDiachi
            // 
            this.lblDiachi.AutoSize = true;
            this.lblDiachi.Font = new System.Drawing.Font("UTM Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiachi.Location = new System.Drawing.Point(127, 145);
            this.lblDiachi.Name = "lblDiachi";
            this.lblDiachi.Size = new System.Drawing.Size(47, 19);
            this.lblDiachi.TabIndex = 9;
            this.lblDiachi.Text = "Dia chi";
            // 
            // lblHoVaTen
            // 
            this.lblHoVaTen.AutoSize = true;
            this.lblHoVaTen.Font = new System.Drawing.Font("UTM Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoVaTen.Location = new System.Drawing.Point(126, 78);
            this.lblHoVaTen.Name = "lblHoVaTen";
            this.lblHoVaTen.Size = new System.Drawing.Size(62, 19);
            this.lblHoVaTen.TabIndex = 6;
            this.lblHoVaTen.Text = "Ho va Ten";
            // 
            // FHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 433);
            this.Controls.Add(this.txtCMND);
            this.Controls.Add(this.txtDiachi);
            this.Controls.Add(this.txtHoVaTen);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.gvHocSinh);
            this.Controls.Add(this.datNgayThang);
            this.Controls.Add(this.lblNgayThang);
            this.Controls.Add(this.lblCMND);
            this.Controls.Add(this.lblDiachi);
            this.Controls.Add(this.lblHoVaTen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FHocSinh";
            this.Text = "HocSinh";
            this.Load += new System.EventHandler(this.FHocSinh_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.gvHocSinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.TextBox txtHoVaTen;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView gvHocSinh;
        private System.Windows.Forms.DateTimePicker datNgayThang;
        private System.Windows.Forms.Label lblNgayThang;
        private System.Windows.Forms.Label lblCMND;
        private System.Windows.Forms.Label lblDiachi;
        private System.Windows.Forms.Label lblHoVaTen;
    }
}

