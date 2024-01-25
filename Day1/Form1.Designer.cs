namespace Day1
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
            this.lblHoVaTen = new System.Windows.Forms.Label();
            this.lblDiachi = new System.Windows.Forms.Label();
            this.lblCMND = new System.Windows.Forms.Label();
            this.datNgayThang = new System.Windows.Forms.DateTimePicker();
            this.lblNgayThang = new System.Windows.Forms.Label();
            this.gvHocSinh = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.txtHoVaTen = new System.Windows.Forms.TextBox();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvHocSinh)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHoVaTen
            // 
            this.lblHoVaTen.AutoSize = true;
            this.lblHoVaTen.Location = new System.Drawing.Point(40, 51);
            this.lblHoVaTen.Name = "lblHoVaTen";
            this.lblHoVaTen.Size = new System.Drawing.Size(58, 13);
            this.lblHoVaTen.TabIndex = 0;
            this.lblHoVaTen.Text = "Ho va Ten";
            // 
            // lblDiachi
            // 
            this.lblDiachi.AutoSize = true;
            this.lblDiachi.Location = new System.Drawing.Point(40, 95);
            this.lblDiachi.Name = "lblDiachi";
            this.lblDiachi.Size = new System.Drawing.Size(40, 13);
            this.lblDiachi.TabIndex = 1;
            this.lblDiachi.Text = "Dia chi";
            // 
            // lblCMND
            // 
            this.lblCMND.AutoSize = true;
            this.lblCMND.Location = new System.Drawing.Point(40, 146);
            this.lblCMND.Name = "lblCMND";
            this.lblCMND.Size = new System.Drawing.Size(39, 13);
            this.lblCMND.TabIndex = 1;
            this.lblCMND.Text = "CMND";
            // 
            // datNgayThang
            // 
            this.datNgayThang.Location = new System.Drawing.Point(193, 195);
            this.datNgayThang.Name = "datNgayThang";
            this.datNgayThang.Size = new System.Drawing.Size(200, 20);
            this.datNgayThang.TabIndex = 2;
            // 
            // lblNgayThang
            // 
            this.lblNgayThang.AutoSize = true;
            this.lblNgayThang.Location = new System.Drawing.Point(40, 201);
            this.lblNgayThang.Name = "lblNgayThang";
            this.lblNgayThang.Size = new System.Drawing.Size(107, 13);
            this.lblNgayThang.TabIndex = 1;
            this.lblNgayThang.Text = "Ngay thang nam sinh";
            // 
            // gvHocSinh
            // 
            this.gvHocSinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvHocSinh.Location = new System.Drawing.Point(415, 51);
            this.gvHocSinh.Name = "gvHocSinh";
            this.gvHocSinh.Size = new System.Drawing.Size(373, 255);
            this.gvHocSinh.TabIndex = 3;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(13, 297);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Them";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(134, 297);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xoa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(259, 297);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sua";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // txtHoVaTen
            // 
            this.txtHoVaTen.Location = new System.Drawing.Point(193, 51);
            this.txtHoVaTen.Name = "txtHoVaTen";
            this.txtHoVaTen.Size = new System.Drawing.Size(200, 20);
            this.txtHoVaTen.TabIndex = 5;
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(193, 92);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(200, 20);
            this.txtDiachi.TabIndex = 5;
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(193, 143);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(200, 20);
            this.txtCMND.TabIndex = 5;
            // 
            // FHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "FHocSinh";
            this.Text = "HocSinh";
            this.Load += new System.EventHandler(this.FHocSinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvHocSinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHoVaTen;
        private System.Windows.Forms.Label lblDiachi;
        private System.Windows.Forms.Label lblCMND;
        private System.Windows.Forms.DateTimePicker datNgayThang;
        private System.Windows.Forms.Label lblNgayThang;
        private System.Windows.Forms.DataGridView gvHocSinh;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.TextBox txtHoVaTen;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.TextBox txtCMND;
    }
}

