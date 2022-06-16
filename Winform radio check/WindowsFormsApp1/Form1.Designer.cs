namespace WindowsFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoChuNhat = new System.Windows.Forms.RadioButton();
            this.rdoTron = new System.Windows.Forms.RadioButton();
            this.rdoTamGiac = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkDienTich = new System.Windows.Forms.CheckBox();
            this.chkChuVi = new System.Windows.Forms.CheckBox();
            this.lblR = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.txtR = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(178, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "TÍNH CHU VI, DIỆN TÍCH";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoChuNhat);
            this.groupBox1.Controls.Add(this.rdoTron);
            this.groupBox1.Controls.Add(this.rdoTamGiac);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(30, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 145);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hình";
            // 
            // rdoChuNhat
            // 
            this.rdoChuNhat.AutoSize = true;
            this.rdoChuNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoChuNhat.Location = new System.Drawing.Point(7, 115);
            this.rdoChuNhat.Name = "rdoChuNhat";
            this.rdoChuNhat.Size = new System.Drawing.Size(140, 24);
            this.rdoChuNhat.TabIndex = 2;
            this.rdoChuNhat.Text = "Hình Chữ Nhật";
            this.rdoChuNhat.UseVisualStyleBackColor = true;
            this.rdoChuNhat.CheckedChanged += new System.EventHandler(this.rdoChuNhat_CheckedChanged);
            // 
            // rdoTron
            // 
            this.rdoTron.AutoSize = true;
            this.rdoTron.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoTron.Location = new System.Drawing.Point(7, 75);
            this.rdoTron.Name = "rdoTron";
            this.rdoTron.Size = new System.Drawing.Size(104, 24);
            this.rdoTron.TabIndex = 1;
            this.rdoTron.Text = "Hình Tròn";
            this.rdoTron.UseVisualStyleBackColor = true;
            this.rdoTron.CheckedChanged += new System.EventHandler(this.rdoTron_CheckedChanged);
            // 
            // rdoTamGiac
            // 
            this.rdoTamGiac.AutoSize = true;
            this.rdoTamGiac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoTamGiac.Location = new System.Drawing.Point(7, 34);
            this.rdoTamGiac.Name = "rdoTamGiac";
            this.rdoTamGiac.Size = new System.Drawing.Size(103, 24);
            this.rdoTamGiac.TabIndex = 0;
            this.rdoTamGiac.Text = "Tam Giác";
            this.rdoTamGiac.UseVisualStyleBackColor = true;
            this.rdoTamGiac.CheckedChanged += new System.EventHandler(this.rdoTamGiac_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkDienTich);
            this.groupBox2.Controls.Add(this.chkChuVi);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(477, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(221, 145);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tính";
            // 
            // chkDienTich
            // 
            this.chkDienTich.AutoSize = true;
            this.chkDienTich.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDienTich.Location = new System.Drawing.Point(29, 91);
            this.chkDienTich.Name = "chkDienTich";
            this.chkDienTich.Size = new System.Drawing.Size(98, 24);
            this.chkDienTich.TabIndex = 1;
            this.chkDienTich.Text = "Diện tích";
            this.chkDienTich.UseVisualStyleBackColor = true;
            // 
            // chkChuVi
            // 
            this.chkChuVi.AutoSize = true;
            this.chkChuVi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkChuVi.Location = new System.Drawing.Point(29, 35);
            this.chkChuVi.Name = "chkChuVi";
            this.chkChuVi.Size = new System.Drawing.Size(78, 24);
            this.chkChuVi.TabIndex = 0;
            this.chkChuVi.Text = "Chu vi";
            this.chkChuVi.UseVisualStyleBackColor = true;
            // 
            // lblR
            // 
            this.lblR.AutoSize = true;
            this.lblR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblR.Location = new System.Drawing.Point(65, 248);
            this.lblR.Name = "lblR";
            this.lblR.Size = new System.Drawing.Size(15, 20);
            this.lblR.TabIndex = 3;
            this.lblR.Text = "r";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA.Location = new System.Drawing.Point(65, 296);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(18, 20);
            this.lblA.TabIndex = 4;
            this.lblA.Text = "a";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblB.Location = new System.Drawing.Point(65, 346);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(18, 20);
            this.lblB.TabIndex = 5;
            this.lblB.Text = "b";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblC.Location = new System.Drawing.Point(65, 395);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(18, 20);
            this.lblC.TabIndex = 6;
            this.lblC.Text = "c";
            // 
            // txtR
            // 
            this.txtR.Location = new System.Drawing.Point(105, 248);
            this.txtR.Name = "txtR";
            this.txtR.Size = new System.Drawing.Size(112, 22);
            this.txtR.TabIndex = 7;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(105, 296);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(112, 22);
            this.txtA.TabIndex = 8;
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(105, 393);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(112, 22);
            this.txtC.TabIndex = 8;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(105, 346);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(112, 22);
            this.txtB.TabIndex = 9;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(506, 257);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(165, 61);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(506, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 61);
            this.button1.TabIndex = 11;
            this.button1.Text = "TÍNH";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.txtR);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.lblR);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoChuNhat;
        private System.Windows.Forms.RadioButton rdoTron;
        private System.Windows.Forms.RadioButton rdoTamGiac;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkDienTich;
        private System.Windows.Forms.CheckBox chkChuVi;
        private System.Windows.Forms.Label lblR;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.TextBox txtR;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button button1;
    }
}

