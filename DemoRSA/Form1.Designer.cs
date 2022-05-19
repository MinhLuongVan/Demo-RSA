
namespace DemoRSA
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTuSinh = new System.Windows.Forms.Button();
            this.laben = new System.Windows.Forms.Label();
            this.labd = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtD = new System.Windows.Forms.TextBox();
            this.txtPhiN = new System.Windows.Forms.TextBox();
            this.txtN = new System.Windows.Forms.TextBox();
            this.txtE = new System.Windows.Forms.TextBox();
            this.txtQ = new System.Windows.Forms.TextBox();
            this.txtP = new System.Windows.Forms.TextBox();
            this.btnD = new System.Windows.Forms.Button();
            this.btnPhiN = new System.Windows.Forms.Button();
            this.btnN = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnMaHoa = new System.Windows.Forms.Button();
            this.txtCMa = new System.Windows.Forms.TextBox();
            this.txtMMa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnGiaiMa = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMGiai = new System.Windows.Forms.TextBox();
            this.txtCGiai = new System.Windows.Forms.TextBox();
            this.labelC = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.linkResert = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.btnTuSinh);
            this.groupBox1.Controls.Add(this.laben);
            this.groupBox1.Controls.Add(this.labd);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtD);
            this.groupBox1.Controls.Add(this.txtPhiN);
            this.groupBox1.Controls.Add(this.txtN);
            this.groupBox1.Controls.Add(this.txtE);
            this.groupBox1.Controls.Add(this.txtQ);
            this.groupBox1.Controls.Add(this.txtP);
            this.groupBox1.Controls.Add(this.btnD);
            this.groupBox1.Controls.Add(this.btnPhiN);
            this.groupBox1.Controls.Add(this.btnN);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(38, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(683, 256);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tạo khóa";
            // 
            // btnTuSinh
            // 
            this.btnTuSinh.ForeColor = System.Drawing.Color.Black;
            this.btnTuSinh.Location = new System.Drawing.Point(296, 40);
            this.btnTuSinh.Name = "btnTuSinh";
            this.btnTuSinh.Size = new System.Drawing.Size(75, 111);
            this.btnTuSinh.TabIndex = 16;
            this.btnTuSinh.Text = "Tự động";
            this.btnTuSinh.UseVisualStyleBackColor = true;
            this.btnTuSinh.Click += new System.EventHandler(this.btnTuSinh_Click);
            // 
            // laben
            // 
            this.laben.AutoSize = true;
            this.laben.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laben.ForeColor = System.Drawing.Color.Black;
            this.laben.Location = new System.Drawing.Point(425, 216);
            this.laben.Name = "laben";
            this.laben.Size = new System.Drawing.Size(68, 20);
            this.laben.TabIndex = 15;
            this.laben.Text = "( E , N )";
            // 
            // labd
            // 
            this.labd.AutoSize = true;
            this.labd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labd.ForeColor = System.Drawing.Color.Black;
            this.labd.Location = new System.Drawing.Point(278, 216);
            this.labd.Name = "labd";
            this.labd.Size = new System.Drawing.Size(30, 20);
            this.labd.TabIndex = 14;
            this.labd.Text = "(d)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(341, 216);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "Public key ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(188, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = " Private key ";
            // 
            // txtD
            // 
            this.txtD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtD.Location = new System.Drawing.Point(333, 173);
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(157, 28);
            this.txtD.TabIndex = 11;
            // 
            // txtPhiN
            // 
            this.txtPhiN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhiN.Location = new System.Drawing.Point(509, 113);
            this.txtPhiN.Name = "txtPhiN";
            this.txtPhiN.Size = new System.Drawing.Size(122, 26);
            this.txtPhiN.TabIndex = 10;
            // 
            // txtN
            // 
            this.txtN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtN.Location = new System.Drawing.Point(509, 53);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(122, 26);
            this.txtN.TabIndex = 9;
            // 
            // txtE
            // 
            this.txtE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtE.Location = new System.Drawing.Point(145, 125);
            this.txtE.Name = "txtE";
            this.txtE.Size = new System.Drawing.Size(122, 26);
            this.txtE.TabIndex = 8;
            // 
            // txtQ
            // 
            this.txtQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQ.Location = new System.Drawing.Point(145, 82);
            this.txtQ.Name = "txtQ";
            this.txtQ.Size = new System.Drawing.Size(122, 26);
            this.txtQ.TabIndex = 7;
            // 
            // txtP
            // 
            this.txtP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtP.Location = new System.Drawing.Point(145, 40);
            this.txtP.Name = "txtP";
            this.txtP.Size = new System.Drawing.Size(122, 26);
            this.txtP.TabIndex = 6;
            // 
            // btnD
            // 
            this.btnD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnD.ForeColor = System.Drawing.Color.Black;
            this.btnD.Location = new System.Drawing.Point(192, 168);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(126, 33);
            this.btnD.TabIndex = 5;
            this.btnD.Text = "Tạo khóa d = ";
            this.btnD.UseVisualStyleBackColor = true;
            this.btnD.Click += new System.EventHandler(this.btnD_Click);
            // 
            // btnPhiN
            // 
            this.btnPhiN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhiN.ForeColor = System.Drawing.Color.Black;
            this.btnPhiN.Location = new System.Drawing.Point(401, 113);
            this.btnPhiN.Name = "btnPhiN";
            this.btnPhiN.Size = new System.Drawing.Size(89, 26);
            this.btnPhiN.TabIndex = 4;
            this.btnPhiN.Text = "ΦN =";
            this.btnPhiN.UseVisualStyleBackColor = true;
            this.btnPhiN.Click += new System.EventHandler(this.btnPhiN_Click);
            // 
            // btnN
            // 
            this.btnN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnN.ForeColor = System.Drawing.Color.Black;
            this.btnN.Location = new System.Drawing.Point(401, 53);
            this.btnN.Name = "btnN";
            this.btnN.Size = new System.Drawing.Size(89, 26);
            this.btnN.TabIndex = 3;
            this.btnN.Text = "N = ";
            this.btnN.UseVisualStyleBackColor = true;
            this.btnN.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(37, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhập E = ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(40, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập Q =";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(40, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập P = ";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox2.Controls.Add(this.btnMaHoa);
            this.groupBox2.Controls.Add(this.txtCMa);
            this.groupBox2.Controls.Add(this.txtMMa);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Red;
            this.groupBox2.Location = new System.Drawing.Point(38, 358);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(308, 187);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mã Hóa";
            // 
            // btnMaHoa
            // 
            this.btnMaHoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaHoa.ForeColor = System.Drawing.Color.Blue;
            this.btnMaHoa.Location = new System.Drawing.Point(88, 129);
            this.btnMaHoa.Name = "btnMaHoa";
            this.btnMaHoa.Size = new System.Drawing.Size(124, 35);
            this.btnMaHoa.TabIndex = 4;
            this.btnMaHoa.Text = "Mã hóa";
            this.btnMaHoa.UseVisualStyleBackColor = true;
            this.btnMaHoa.Click += new System.EventHandler(this.btnMaHoa_Click);
            // 
            // txtCMa
            // 
            this.txtCMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCMa.Location = new System.Drawing.Point(136, 82);
            this.txtCMa.Name = "txtCMa";
            this.txtCMa.Size = new System.Drawing.Size(122, 26);
            this.txtCMa.TabIndex = 3;
            // 
            // txtMMa
            // 
            this.txtMMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMMa.Location = new System.Drawing.Point(136, 43);
            this.txtMMa.Name = "txtMMa";
            this.txtMMa.Size = new System.Drawing.Size(122, 26);
            this.txtMMa.TabIndex = 2;
            this.txtMMa.TextChanged += new System.EventHandler(this.txtMMa_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(32, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Result C =";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(34, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nhập M = ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox3.Controls.Add(this.btnGiaiMa);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtMGiai);
            this.groupBox3.Controls.Add(this.txtCGiai);
            this.groupBox3.Controls.Add(this.labelC);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Red;
            this.groupBox3.Location = new System.Drawing.Point(392, 358);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(329, 187);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Giải Mã";
            // 
            // btnGiaiMa
            // 
            this.btnGiaiMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiaiMa.ForeColor = System.Drawing.Color.Blue;
            this.btnGiaiMa.Location = new System.Drawing.Point(98, 129);
            this.btnGiaiMa.Name = "btnGiaiMa";
            this.btnGiaiMa.Size = new System.Drawing.Size(126, 35);
            this.btnGiaiMa.TabIndex = 6;
            this.btnGiaiMa.Text = "Giải Mã";
            this.btnGiaiMa.UseVisualStyleBackColor = true;
            this.btnGiaiMa.Click += new System.EventHandler(this.btnGiaiMa_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(33, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Result M =";
            // 
            // txtMGiai
            // 
            this.txtMGiai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMGiai.Location = new System.Drawing.Point(144, 77);
            this.txtMGiai.Name = "txtMGiai";
            this.txtMGiai.Size = new System.Drawing.Size(119, 26);
            this.txtMGiai.TabIndex = 4;
            // 
            // txtCGiai
            // 
            this.txtCGiai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCGiai.Location = new System.Drawing.Point(144, 38);
            this.txtCGiai.Name = "txtCGiai";
            this.txtCGiai.Size = new System.Drawing.Size(119, 26);
            this.txtCGiai.TabIndex = 3;
            // 
            // labelC
            // 
            this.labelC.AutoSize = true;
            this.labelC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelC.ForeColor = System.Drawing.Color.Black;
            this.labelC.Location = new System.Drawing.Point(33, 43);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(85, 20);
            this.labelC.TabIndex = 1;
            this.labelC.Text = "Nhập C = ";
            this.labelC.Click += new System.EventHandler(this.labelC_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label8.Location = new System.Drawing.Point(240, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(301, 39);
            this.label8.TabIndex = 3;
            this.label8.Text = "HỆ MÃ HÓA RSA";
            // 
            // linkResert
            // 
            this.linkResert.AutoSize = true;
            this.linkResert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkResert.Location = new System.Drawing.Point(674, 556);
            this.linkResert.Name = "linkResert";
            this.linkResert.Size = new System.Drawing.Size(59, 20);
            this.linkResert.TabIndex = 4;
            this.linkResert.TabStop = true;
            this.linkResert.Text = "Resert";
            this.linkResert.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkResert_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(745, 585);
            this.Controls.Add(this.linkResert);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ Mã RSA";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtD;
        private System.Windows.Forms.TextBox txtPhiN;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.TextBox txtE;
        private System.Windows.Forms.TextBox txtQ;
        private System.Windows.Forms.TextBox txtP;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Button btnPhiN;
        private System.Windows.Forms.Button btnN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnMaHoa;
        private System.Windows.Forms.TextBox txtCMa;
        private System.Windows.Forms.TextBox txtMMa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnGiaiMa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMGiai;
        private System.Windows.Forms.TextBox txtCGiai;
        private System.Windows.Forms.Label labelC;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.LinkLabel linkResert;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labd;
        private System.Windows.Forms.Label laben;
        private System.Windows.Forms.Button btnTuSinh;
    }
}

