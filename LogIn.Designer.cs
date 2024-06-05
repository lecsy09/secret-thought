namespace secret_thoughts
{
    partial class Login
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
            this.UserLoginbx = new System.Windows.Forms.TextBox();
            this.PasswordLoginbx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.done = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNotExist = new System.Windows.Forms.Label();
            this.lblPassUserNot = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(196, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 55);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome to Secret Thoughts";
            // 
            // UserLoginbx
            // 
            this.UserLoginbx.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserLoginbx.Location = new System.Drawing.Point(319, 214);
            this.UserLoginbx.Multiline = true;
            this.UserLoginbx.Name = "UserLoginbx";
            this.UserLoginbx.Size = new System.Drawing.Size(275, 31);
            this.UserLoginbx.TabIndex = 8;
            this.UserLoginbx.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // PasswordLoginbx
            // 
            this.PasswordLoginbx.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLoginbx.Location = new System.Drawing.Point(319, 286);
            this.PasswordLoginbx.Multiline = true;
            this.PasswordLoginbx.Name = "PasswordLoginbx";
            this.PasswordLoginbx.PasswordChar = '•';
            this.PasswordLoginbx.Size = new System.Drawing.Size(275, 31);
            this.PasswordLoginbx.TabIndex = 10;
            this.PasswordLoginbx.TextChanged += new System.EventHandler(this.PasswordLoginbx_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Script MT Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(412, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Log-in";
            // 
            // done
            // 
            this.done.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.done.Location = new System.Drawing.Point(498, 357);
            this.done.Name = "done";
            this.done.Size = new System.Drawing.Size(96, 32);
            this.done.TabIndex = 15;
            this.done.Text = "Log In";
            this.done.UseVisualStyleBackColor = true;
            this.done.Click += new System.EventHandler(this.done_Click);
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(319, 357);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(96, 32);
            this.back.TabIndex = 16;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(233, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 23);
            this.label3.TabIndex = 17;
            this.label3.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(233, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 23);
            this.label4.TabIndex = 18;
            this.label4.Text = "Password";
            // 
            // lblNotExist
            // 
            this.lblNotExist.AutoSize = true;
            this.lblNotExist.BackColor = System.Drawing.Color.Transparent;
            this.lblNotExist.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotExist.ForeColor = System.Drawing.Color.Red;
            this.lblNotExist.Location = new System.Drawing.Point(529, 341);
            this.lblNotExist.Name = "lblNotExist";
            this.lblNotExist.Size = new System.Drawing.Size(141, 13);
            this.lblNotExist.TabIndex = 19;
            this.lblNotExist.Text = "Account does not exist.";
            this.lblNotExist.Visible = false;
            // 
            // lblPassUserNot
            // 
            this.lblPassUserNot.AutoSize = true;
            this.lblPassUserNot.BackColor = System.Drawing.Color.Transparent;
            this.lblPassUserNot.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassUserNot.ForeColor = System.Drawing.Color.Red;
            this.lblPassUserNot.Location = new System.Drawing.Point(453, 320);
            this.lblPassUserNot.Name = "lblPassUserNot";
            this.lblPassUserNot.Size = new System.Drawing.Size(228, 13);
            this.lblPassUserNot.TabIndex = 20;
            this.lblPassUserNot.Text = "Username and Password do not match.";
            this.lblPassUserNot.Visible = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(319, 320);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(111, 25);
            this.checkBox1.TabIndex = 21;
            this.checkBox1.Text = "See password";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BackgroundImage = global::secret_thoughts.Properties.Resources.Screenshot_2024_05_25_151633;
            this.ClientSize = new System.Drawing.Size(912, 458);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.lblPassUserNot);
            this.Controls.Add(this.lblNotExist);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.back);
            this.Controls.Add(this.done);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PasswordLoginbx);
            this.Controls.Add(this.UserLoginbx);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Secret Thoughts Log-In";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UserLoginbx;
        private System.Windows.Forms.TextBox PasswordLoginbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button done;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNotExist;
        private System.Windows.Forms.Label lblPassUserNot;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}