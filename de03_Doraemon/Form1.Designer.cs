namespace de03_Doraemon
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ngaymuon = new System.Windows.Forms.DateTimePicker();
            this.ngaytra = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btt_tratruyen = new System.Windows.Forms.Button();
            this.btt_muontruyen = new System.Windows.Forms.Button();
            this.tb_đongia = new System.Windows.Forms.TextBox();
            this.cb_tentruyen = new System.Windows.Forms.ComboBox();
            this.tb_sdt = new System.Windows.Forms.TextBox();
            this.tb_tenkhach = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(354, 192);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.tb_đongia);
            this.panel1.Controls.Add(this.cb_tentruyen);
            this.panel1.Controls.Add(this.tb_sdt);
            this.panel1.Controls.Add(this.tb_tenkhach);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(364, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(414, 192);
            this.panel1.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.AutoSize = true;
            this.panel4.Controls.Add(this.ngaymuon);
            this.panel4.Controls.Add(this.ngaytra);
            this.panel4.Location = new System.Drawing.Point(92, 119);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(168, 62);
            this.panel4.TabIndex = 13;
            // 
            // ngaymuon
            // 
            this.ngaymuon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ngaymuon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ngaymuon.Location = new System.Drawing.Point(7, 9);
            this.ngaymuon.Name = "ngaymuon";
            this.ngaymuon.Size = new System.Drawing.Size(158, 20);
            this.ngaymuon.TabIndex = 11;
            // 
            // ngaytra
            // 
            this.ngaytra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ngaytra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ngaytra.Location = new System.Drawing.Point(7, 35);
            this.ngaytra.Name = "ngaytra";
            this.ngaytra.Size = new System.Drawing.Size(158, 20);
            this.ngaytra.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.btt_tratruyen);
            this.panel3.Controls.Add(this.btt_muontruyen);
            this.panel3.Location = new System.Drawing.Point(226, 119);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(172, 62);
            this.panel3.TabIndex = 12;
            // 
            // btt_tratruyen
            // 
            this.btt_tratruyen.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btt_tratruyen.Location = new System.Drawing.Point(43, 33);
            this.btt_tratruyen.Name = "btt_tratruyen";
            this.btt_tratruyen.Size = new System.Drawing.Size(126, 23);
            this.btt_tratruyen.TabIndex = 13;
            this.btt_tratruyen.Text = "Trả truyện";
            this.btt_tratruyen.UseVisualStyleBackColor = true;
            this.btt_tratruyen.Click += new System.EventHandler(this.btt_tratruyen_Click);
            // 
            // btt_muontruyen
            // 
            this.btt_muontruyen.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btt_muontruyen.Location = new System.Drawing.Point(42, 6);
            this.btt_muontruyen.Name = "btt_muontruyen";
            this.btt_muontruyen.Size = new System.Drawing.Size(127, 23);
            this.btt_muontruyen.TabIndex = 12;
            this.btt_muontruyen.Text = "Mượn truyện";
            this.btt_muontruyen.UseVisualStyleBackColor = true;
            this.btt_muontruyen.Click += new System.EventHandler(this.btt_muontruyen_Click);
            // 
            // tb_đongia
            // 
            this.tb_đongia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_đongia.Enabled = false;
            this.tb_đongia.Location = new System.Drawing.Point(92, 93);
            this.tb_đongia.Name = "tb_đongia";
            this.tb_đongia.Size = new System.Drawing.Size(306, 20);
            this.tb_đongia.TabIndex = 9;
            // 
            // cb_tentruyen
            // 
            this.cb_tentruyen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_tentruyen.FormattingEnabled = true;
            this.cb_tentruyen.Location = new System.Drawing.Point(92, 66);
            this.cb_tentruyen.Name = "cb_tentruyen";
            this.cb_tentruyen.Size = new System.Drawing.Size(306, 21);
            this.cb_tentruyen.TabIndex = 8;
            this.cb_tentruyen.SelectedValueChanged += new System.EventHandler(this.cb_tentruyen_SelectedValueChanged);
            // 
            // tb_sdt
            // 
            this.tb_sdt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_sdt.Location = new System.Drawing.Point(92, 39);
            this.tb_sdt.Name = "tb_sdt";
            this.tb_sdt.Size = new System.Drawing.Size(306, 20);
            this.tb_sdt.TabIndex = 7;
            // 
            // tb_tenkhach
            // 
            this.tb_tenkhach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_tenkhach.Location = new System.Drawing.Point(92, 13);
            this.tb_tenkhach.Name = "tb_tenkhach";
            this.tb_tenkhach.Size = new System.Drawing.Size(306, 20);
            this.tb_tenkhach.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ngày trả";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày mượn";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Đơn giá/ngày";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên truyện";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số điện thoại";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Khách";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(8, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(796, 221);
            this.panel2.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 241);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(797, 252);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 511);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker ngaymuon;
        private System.Windows.Forms.DateTimePicker ngaytra;
        private System.Windows.Forms.TextBox tb_đongia;
        private System.Windows.Forms.ComboBox cb_tentruyen;
        private System.Windows.Forms.TextBox tb_sdt;
        private System.Windows.Forms.TextBox tb_tenkhach;
        private System.Windows.Forms.Button btt_tratruyen;
        private System.Windows.Forms.Button btt_muontruyen;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

