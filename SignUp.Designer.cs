namespace secret_thoughts
{
    partial class SignUp
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
            this.label2 = new System.Windows.Forms.Label();
            this.UserSignUpbx = new System.Windows.Forms.TextBox();
            this.PasswordSignUPbx = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.ConfirmPasswordBx = new System.Windows.Forms.TextBox();
            this.conandpass = new System.Windows.Forms.Label();
            this.lblpassErr = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(248, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(450, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome to Secret Thoughts";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Script MT Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(434, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sign-up";
            // 
            // UserSignUpbx
            // 
            this.UserSignUpbx.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserSignUpbx.Location = new System.Drawing.Point(339, 154);
            this.UserSignUpbx.Multiline = true;
            this.UserSignUpbx.Name = "UserSignUpbx";
            this.UserSignUpbx.Size = new System.Drawing.Size(275, 31);
            this.UserSignUpbx.TabIndex = 7;
            this.UserSignUpbx.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // PasswordSignUPbx
            // 
            this.PasswordSignUPbx.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordSignUPbx.Location = new System.Drawing.Point(339, 211);
            this.PasswordSignUPbx.Multiline = true;
            this.PasswordSignUPbx.Name = "PasswordSignUPbx";
            this.PasswordSignUPbx.PasswordChar = '•';
            this.PasswordSignUPbx.Size = new System.Drawing.Size(275, 31);
            this.PasswordSignUPbx.TabIndex = 8;
            this.PasswordSignUPbx.TextChanged += new System.EventHandler(this.passwordbx_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(297, 371);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 32);
            this.button1.TabIndex = 9;
            this.button1.Text = "Back ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(259, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Username";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(259, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "Password";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(501, 371);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 32);
            this.button2.TabIndex = 14;
            this.button2.Text = "Done";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(200, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 23);
            this.label5.TabIndex = 13;
            this.label5.Text = "Confirm Password";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // ConfirmPasswordBx
            // 
            this.ConfirmPasswordBx.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmPasswordBx.Location = new System.Drawing.Point(339, 272);
            this.ConfirmPasswordBx.Multiline = true;
            this.ConfirmPasswordBx.Name = "ConfirmPasswordBx";
            this.ConfirmPasswordBx.PasswordChar = '•';
            this.ConfirmPasswordBx.Size = new System.Drawing.Size(275, 31);
            this.ConfirmPasswordBx.TabIndex = 12;
            this.ConfirmPasswordBx.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // conandpass
            // 
            this.conandpass.AutoSize = true;
            this.conandpass.ForeColor = System.Drawing.Color.Red;
            this.conandpass.Location = new System.Drawing.Point(365, 306);
            this.conandpass.Name = "conandpass";
            this.conandpass.Size = new System.Drawing.Size(0, 13);
            this.conandpass.TabIndex = 15;
            this.conandpass.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblpassErr
            // 
            this.lblpassErr.AutoSize = true;
            this.lblpassErr.BackColor = System.Drawing.Color.Transparent;
            this.lblpassErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpassErr.ForeColor = System.Drawing.Color.Red;
            this.lblpassErr.Location = new System.Drawing.Point(365, 245);
            this.lblpassErr.Name = "lblpassErr";
            this.lblpassErr.Size = new System.Drawing.Size(264, 13);
            this.lblpassErr.TabIndex = 16;
            this.lblpassErr.Text = "*Password do not match in confirm password.";
            this.lblpassErr.Visible = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(339, 309);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(111, 25);
            this.checkBox1.TabIndex = 18;
            this.checkBox1.Text = "See password";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BackgroundImage = global::secret_thoughts.Properties.Resources._436660551_814012423592593_6757988820124130120_n;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(925, 450);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.lblpassErr);
            this.Controls.Add(this.conandpass);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ConfirmPasswordBx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PasswordSignUPbx);
            this.Controls.Add(this.UserSignUpbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SignUp";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Secret Thoughts Sign-up";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UserSignUpbx;
        private System.Windows.Forms.TextBox PasswordSignUPbx;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ConfirmPasswordBx;
        private System.Windows.Forms.Label conandpass;
        private System.Windows.Forms.Label lblpassErr;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}