namespace secret_thoughts
{
    partial class History
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(History));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BackToProfile = new System.Windows.Forms.Button();
            this.HistoryContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(154, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 0);
            this.panel1.TabIndex = 0;
            // 
            // BackToProfile
            // 
            this.BackToProfile.BackColor = System.Drawing.Color.Tan;
            this.BackToProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackToProfile.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackToProfile.Location = new System.Drawing.Point(519, 47);
            this.BackToProfile.Name = "BackToProfile";
            this.BackToProfile.Size = new System.Drawing.Size(123, 30);
            this.BackToProfile.TabIndex = 5;
            this.BackToProfile.Text = "Back to profile";
            this.BackToProfile.UseVisualStyleBackColor = false;
            this.BackToProfile.Click += new System.EventHandler(this.BackToProfile_Click);
            // 
            // HistoryContainer
            // 
            this.HistoryContainer.AutoScroll = true;
            this.HistoryContainer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HistoryContainer.BackgroundImage")));
            this.HistoryContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HistoryContainer.Location = new System.Drawing.Point(52, 83);
            this.HistoryContainer.Name = "HistoryContainer";
            this.HistoryContainer.Size = new System.Drawing.Size(739, 327);
            this.HistoryContainer.TabIndex = 6;
            this.HistoryContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.HistoryContainer_Paint);
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BackgroundImage = global::secret_thoughts.Properties.Resources.Screenshot_2024_05_25_152312;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(843, 450);
            this.Controls.Add(this.HistoryContainer);
            this.Controls.Add(this.BackToProfile);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "History";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Secret Thoughts";
            this.Load += new System.EventHandler(this.History_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BackToProfile;
        public System.Windows.Forms.FlowLayoutPanel HistoryContainer;
    }
}