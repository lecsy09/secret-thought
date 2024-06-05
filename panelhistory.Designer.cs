namespace secret_thoughts
{
    partial class panelhistory
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(panelhistory));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Delete = new System.Windows.Forms.Button();
            this.lblmssg = new System.Windows.Forms.Label();
            this.messageReadBox = new System.Windows.Forms.RichTextBox();
            this.lbldate = new System.Windows.Forms.Label();
            this.lbltitle = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.Tan;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.Delete);
            this.panel1.Controls.Add(this.lblmssg);
            this.panel1.Controls.Add(this.messageReadBox);
            this.panel1.Controls.Add(this.lbldate);
            this.panel1.Controls.Add(this.lbltitle);
            this.panel1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(736, 185);
            this.panel1.TabIndex = 0;
            this.panel1.TabStop = true;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.AntiqueWhite;
            this.Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.Location = new System.Drawing.Point(572, 3);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(71, 29);
            this.Delete.TabIndex = 7;
            this.Delete.Text = "Delete";
            this.Delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click_1);
            // 
            // lblmssg
            // 
            this.lblmssg.AutoSize = true;
            this.lblmssg.BackColor = System.Drawing.Color.Transparent;
            this.lblmssg.Font = new System.Drawing.Font("Script MT Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmssg.Location = new System.Drawing.Point(33, 46);
            this.lblmssg.Name = "lblmssg";
            this.lblmssg.Size = new System.Drawing.Size(68, 18);
            this.lblmssg.TabIndex = 5;
            this.lblmssg.Text = "Message: ";
            // 
            // messageReadBox
            // 
            this.messageReadBox.Location = new System.Drawing.Point(17, 67);
            this.messageReadBox.Name = "messageReadBox";
            this.messageReadBox.ReadOnly = true;
            this.messageReadBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.messageReadBox.Size = new System.Drawing.Size(703, 98);
            this.messageReadBox.TabIndex = 4;
            this.messageReadBox.Text = "";
            this.messageReadBox.ZoomFactor = 2F;
            this.messageReadBox.TextChanged += new System.EventHandler(this.messageReadBox_TextChanged);
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.BackColor = System.Drawing.Color.Transparent;
            this.lbldate.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.Location = new System.Drawing.Point(456, 40);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(64, 24);
            this.lbldate.TabIndex = 1;
            this.lbldate.Text = "Date";
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.BackColor = System.Drawing.Color.Transparent;
            this.lbltitle.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbltitle.Location = new System.Drawing.Point(31, 14);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(61, 28);
            this.lbltitle.TabIndex = 0;
            this.lbltitle.Text = "Title";
            this.lbltitle.Click += new System.EventHandler(this.title_Click);
            // 
            // panelhistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "panelhistory";
            this.Size = new System.Drawing.Size(736, 185);
            this.Load += new System.EventHandler(this.panelhistory_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.RichTextBox messageReadBox;
        private System.Windows.Forms.Label lblmssg;
        private System.Windows.Forms.Button Delete;
    }
}
