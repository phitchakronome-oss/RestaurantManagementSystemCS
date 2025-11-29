namespace final
{
    partial class FormCustomer
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
            this.DTGV_CT = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TBName = new System.Windows.Forms.TextBox();
            this.TBSname = new System.Windows.Forms.TextBox();
            this.TBTel = new System.Windows.Forms.TextBox();
            this.TBAdd = new System.Windows.Forms.TextBox();
            this.TBEmail = new System.Windows.Forms.TextBox();
            this.DTP_BP = new System.Windows.Forms.DateTimePicker();
            this.CBSex = new System.Windows.Forms.ComboBox();
            this.CBMember = new System.Windows.Forms.ComboBox();
            this.LBID = new System.Windows.Forms.Label();
            this.BTGen = new System.Windows.Forms.Button();
            this.BTAdd = new System.Windows.Forms.Button();
            this.BTDel = new System.Windows.Forms.Button();
            this.BTEdit = new System.Windows.Forms.Button();
            this.BTSave = new System.Windows.Forms.Button();
            this.BTSR = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.TBSR = new System.Windows.Forms.TextBox();
            this.BTCL = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DTGV_CT)).BeginInit();
            this.SuspendLayout();
            // 
            // DTGV_CT
            // 
            this.DTGV_CT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGV_CT.Location = new System.Drawing.Point(59, 90);
            this.DTGV_CT.Name = "DTGV_CT";
            this.DTGV_CT.Size = new System.Drawing.Size(950, 367);
            this.DTGV_CT.TabIndex = 0;
            this.DTGV_CT.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DTGV_CT_CellContentClick);
            this.DTGV_CT.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DTGV_CT_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 487);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "เลขสมาชิค";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 549);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "ชื่อ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(323, 550);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "นามสกุล";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(665, 552);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "เบอร์โทร";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(56, 632);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "เพศ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(323, 633);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "ว/ด/ป เกิด";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(642, 633);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "ระดับสมาชิค";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(54, 714);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "ที่อยู่";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(676, 716);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "E-mail";
            // 
            // TBName
            // 
            this.TBName.Location = new System.Drawing.Point(99, 549);
            this.TBName.MaxLength = 20;
            this.TBName.Name = "TBName";
            this.TBName.Size = new System.Drawing.Size(197, 20);
            this.TBName.TabIndex = 10;
            // 
            // TBSname
            // 
            this.TBSname.Location = new System.Drawing.Point(395, 549);
            this.TBSname.MaxLength = 50;
            this.TBSname.Name = "TBSname";
            this.TBSname.Size = new System.Drawing.Size(207, 20);
            this.TBSname.TabIndex = 11;
            // 
            // TBTel
            // 
            this.TBTel.Location = new System.Drawing.Point(741, 552);
            this.TBTel.MaxLength = 10;
            this.TBTel.Name = "TBTel";
            this.TBTel.Size = new System.Drawing.Size(184, 20);
            this.TBTel.TabIndex = 12;
            // 
            // TBAdd
            // 
            this.TBAdd.Location = new System.Drawing.Point(99, 716);
            this.TBAdd.MaxLength = 100;
            this.TBAdd.Name = "TBAdd";
            this.TBAdd.Size = new System.Drawing.Size(197, 20);
            this.TBAdd.TabIndex = 13;
            // 
            // TBEmail
            // 
            this.TBEmail.Location = new System.Drawing.Point(741, 716);
            this.TBEmail.MaxLength = 20;
            this.TBEmail.Name = "TBEmail";
            this.TBEmail.Size = new System.Drawing.Size(184, 20);
            this.TBEmail.TabIndex = 14;
            // 
            // DTP_BP
            // 
            this.DTP_BP.CustomFormat = "dd/mm/yyyy";
            this.DTP_BP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTP_BP.Location = new System.Drawing.Point(402, 632);
            this.DTP_BP.Name = "DTP_BP";
            this.DTP_BP.Size = new System.Drawing.Size(200, 20);
            this.DTP_BP.TabIndex = 15;
            // 
            // CBSex
            // 
            this.CBSex.FormattingEnabled = true;
            this.CBSex.Location = new System.Drawing.Point(99, 631);
            this.CBSex.Name = "CBSex";
            this.CBSex.Size = new System.Drawing.Size(197, 21);
            this.CBSex.TabIndex = 16;
            // 
            // CBMember
            // 
            this.CBMember.FormattingEnabled = true;
            this.CBMember.Location = new System.Drawing.Point(741, 635);
            this.CBMember.Name = "CBMember";
            this.CBMember.Size = new System.Drawing.Size(184, 21);
            this.CBMember.TabIndex = 17;
            // 
            // LBID
            // 
            this.LBID.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LBID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBID.Location = new System.Drawing.Point(163, 487);
            this.LBID.Name = "LBID";
            this.LBID.Size = new System.Drawing.Size(98, 20);
            this.LBID.TabIndex = 18;
            this.LBID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BTGen
            // 
            this.BTGen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTGen.Location = new System.Drawing.Point(314, 479);
            this.BTGen.Name = "BTGen";
            this.BTGen.Size = new System.Drawing.Size(107, 38);
            this.BTGen.TabIndex = 19;
            this.BTGen.Text = "สร้่างเลขสมาชิค";
            this.BTGen.UseVisualStyleBackColor = true;
            this.BTGen.Click += new System.EventHandler(this.BTGen_Click);
            // 
            // BTAdd
            // 
            this.BTAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTAdd.Location = new System.Drawing.Point(1081, 90);
            this.BTAdd.Name = "BTAdd";
            this.BTAdd.Size = new System.Drawing.Size(107, 38);
            this.BTAdd.TabIndex = 20;
            this.BTAdd.Text = "เพิ่มข้อมูล";
            this.BTAdd.UseVisualStyleBackColor = true;
            this.BTAdd.Click += new System.EventHandler(this.BTAdd_Click);
            // 
            // BTDel
            // 
            this.BTDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTDel.Location = new System.Drawing.Point(1081, 177);
            this.BTDel.Name = "BTDel";
            this.BTDel.Size = new System.Drawing.Size(107, 38);
            this.BTDel.TabIndex = 21;
            this.BTDel.Text = "ลบข้อมูล";
            this.BTDel.UseVisualStyleBackColor = true;
            this.BTDel.Click += new System.EventHandler(this.BTDel_Click);
            // 
            // BTEdit
            // 
            this.BTEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTEdit.Location = new System.Drawing.Point(1081, 262);
            this.BTEdit.Name = "BTEdit";
            this.BTEdit.Size = new System.Drawing.Size(107, 38);
            this.BTEdit.TabIndex = 22;
            this.BTEdit.Text = "แก้ไขช้อมูล";
            this.BTEdit.UseVisualStyleBackColor = true;
            this.BTEdit.Click += new System.EventHandler(this.BTEdit_Click);
            // 
            // BTSave
            // 
            this.BTSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTSave.Location = new System.Drawing.Point(1081, 345);
            this.BTSave.Name = "BTSave";
            this.BTSave.Size = new System.Drawing.Size(107, 38);
            this.BTSave.TabIndex = 23;
            this.BTSave.Text = "บันทึกข้อมูล";
            this.BTSave.UseVisualStyleBackColor = true;
            // 
            // BTSR
            // 
            this.BTSR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTSR.Location = new System.Drawing.Point(563, 24);
            this.BTSR.Name = "BTSR";
            this.BTSR.Size = new System.Drawing.Size(107, 38);
            this.BTSR.TabIndex = 24;
            this.BTSR.Text = "ค้นหา";
            this.BTSR.UseVisualStyleBackColor = true;
            this.BTSR.Click += new System.EventHandler(this.BTSR_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(56, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 20);
            this.label10.TabIndex = 25;
            this.label10.Text = "ค้นหา";
            // 
            // TBSR
            // 
            this.TBSR.Location = new System.Drawing.Point(119, 34);
            this.TBSR.MaxLength = 20;
            this.TBSR.Name = "TBSR";
            this.TBSR.Size = new System.Drawing.Size(429, 20);
            this.TBSR.TabIndex = 26;
            // 
            // BTCL
            // 
            this.BTCL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTCL.Location = new System.Drawing.Point(495, 479);
            this.BTCL.Name = "BTCL";
            this.BTCL.Size = new System.Drawing.Size(107, 38);
            this.BTCL.TabIndex = 27;
            this.BTCL.Text = "ล้างข้อมูล";
            this.BTCL.UseVisualStyleBackColor = true;
            this.BTCL.Click += new System.EventHandler(this.BTCL_Click);
            // 
            // FormCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 783);
            this.Controls.Add(this.BTCL);
            this.Controls.Add(this.TBSR);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.BTSR);
            this.Controls.Add(this.BTSave);
            this.Controls.Add(this.BTEdit);
            this.Controls.Add(this.BTDel);
            this.Controls.Add(this.BTAdd);
            this.Controls.Add(this.BTGen);
            this.Controls.Add(this.LBID);
            this.Controls.Add(this.CBMember);
            this.Controls.Add(this.CBSex);
            this.Controls.Add(this.DTP_BP);
            this.Controls.Add(this.TBEmail);
            this.Controls.Add(this.TBAdd);
            this.Controls.Add(this.TBTel);
            this.Controls.Add(this.TBSname);
            this.Controls.Add(this.TBName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DTGV_CT);
            this.Name = "FormCustomer";
            this.Text = "ฐานข้อมูลลูกค้า";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DTGV_CT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DTGV_CT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TBName;
        private System.Windows.Forms.TextBox TBSname;
        private System.Windows.Forms.TextBox TBTel;
        private System.Windows.Forms.TextBox TBAdd;
        private System.Windows.Forms.TextBox TBEmail;
        private System.Windows.Forms.DateTimePicker DTP_BP;
        private System.Windows.Forms.ComboBox CBSex;
        private System.Windows.Forms.ComboBox CBMember;
        private System.Windows.Forms.Label LBID;
        private System.Windows.Forms.Button BTGen;
        private System.Windows.Forms.Button BTAdd;
        private System.Windows.Forms.Button BTDel;
        private System.Windows.Forms.Button BTEdit;
        private System.Windows.Forms.Button BTSave;
        private System.Windows.Forms.Button BTSR;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TBSR;
        private System.Windows.Forms.Button BTCL;
    }
}

