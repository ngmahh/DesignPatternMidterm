namespace DesignPatternMidterm.View
{
    partial class Register
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
            btnDangKy = new Button();
            button2 = new Button();
            txtEmail = new TextBox();
            txtUsername = new TextBox();
            txtPWD = new TextBox();
            txtConfirmPWD = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label1 = new Label();
            chkAgree = new CheckBox();
            SuspendLayout();
            // 
            // btnDangKy
            // 
            btnDangKy.Location = new Point(334, 591);
            btnDangKy.Margin = new Padding(4, 4, 4, 4);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(118, 36);
            btnDangKy.TabIndex = 1;
            btnDangKy.Text = "Đăng ký";
            btnDangKy.UseVisualStyleBackColor = true;
            btnDangKy.Click += btnDangKy_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(598, 591);
            button2.Margin = new Padding(4, 4, 4, 4);
            button2.Name = "button2";
            button2.Size = new Size(118, 36);
            button2.TabIndex = 2;
            button2.Text = "Thoát";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(334, 198);
            txtEmail.Margin = new Padding(4, 4, 4, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(394, 31);
            txtEmail.TabIndex = 3;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(336, 280);
            txtUsername.Margin = new Padding(4, 4, 4, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(392, 31);
            txtUsername.TabIndex = 4;
            // 
            // txtPWD
            // 
            txtPWD.Location = new Point(334, 359);
            txtPWD.Margin = new Padding(4, 4, 4, 4);
            txtPWD.Name = "txtPWD";
            txtPWD.Size = new Size(392, 31);
            txtPWD.TabIndex = 5;
            txtPWD.UseSystemPasswordChar = true;
            // 
            // txtConfirmPWD
            // 
            txtConfirmPWD.Location = new Point(334, 450);
            txtConfirmPWD.Margin = new Padding(4, 4, 4, 4);
            txtConfirmPWD.Name = "txtConfirmPWD";
            txtConfirmPWD.Size = new Size(392, 31);
            txtConfirmPWD.TabIndex = 6;
            txtConfirmPWD.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(130, 206);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(58, 25);
            label2.TabIndex = 7;
            label2.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(130, 284);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(94, 25);
            label3.TabIndex = 8;
            label3.Text = "Họ và Tên:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(130, 359);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(90, 25);
            label4.TabIndex = 9;
            label4.Text = "Mật khẩu:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(130, 450);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(167, 25);
            label5.TabIndex = 10;
            label5.Text = "Xác nhận mật khẩu:";
            label5.Click += label5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(99, 66);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(573, 76);
            label1.TabIndex = 11;
            label1.Text = "Quản lý quán gà rán";
            // 
            // chkAgree
            // 
            chkAgree.AutoSize = true;
            chkAgree.Location = new Point(231, 518);
            chkAgree.Margin = new Padding(4, 4, 4, 4);
            chkAgree.Name = "chkAgree";
            chkAgree.Size = new Size(360, 29);
            chkAgree.TabIndex = 12;
            chkAgree.Text = "Tôi đồng ý với điều khoản của ứng dụng";
            chkAgree.UseVisualStyleBackColor = true;
            chkAgree.CheckedChanged += chkAgree_CheckedChanged;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(909, 664);
            Controls.Add(chkAgree);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtConfirmPWD);
            Controls.Add(txtPWD);
            Controls.Add(txtUsername);
            Controls.Add(txtEmail);
            Controls.Add(button2);
            Controls.Add(btnDangKy);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Register";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnDangKy;
        private Button button2;
        private TextBox txtEmail;
        private TextBox txtUsername;
        private TextBox txtPWD;
        private TextBox txtConfirmPWD;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label1;
        private CheckBox chkAgree;
    }
}