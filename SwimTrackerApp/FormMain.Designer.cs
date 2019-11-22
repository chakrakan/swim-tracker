namespace SwimTrackerApp
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClubsManager = new System.Windows.Forms.Button();
            this.btnSwimmerManager = new System.Windows.Forms.Button();
            this.btnCoachManager = new System.Windows.Forms.Button();
            this.btnEventsManager = new System.Windows.Forms.Button();
            this.btnSwimMeetsManager = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(475, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(505, 677);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnClubsManager
            // 
            this.btnClubsManager.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClubsManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClubsManager.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClubsManager.Location = new System.Drawing.Point(75, 153);
            this.btnClubsManager.Name = "btnClubsManager";
            this.btnClubsManager.Size = new System.Drawing.Size(319, 57);
            this.btnClubsManager.TabIndex = 1;
            this.btnClubsManager.Text = "Manage Clubs";
            this.btnClubsManager.UseVisualStyleBackColor = true;
            this.btnClubsManager.Click += new System.EventHandler(this.btnClubsManager_Click);
            // 
            // btnSwimmerManager
            // 
            this.btnSwimmerManager.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSwimmerManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSwimmerManager.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSwimmerManager.Location = new System.Drawing.Point(75, 233);
            this.btnSwimmerManager.Name = "btnSwimmerManager";
            this.btnSwimmerManager.Size = new System.Drawing.Size(319, 57);
            this.btnSwimmerManager.TabIndex = 2;
            this.btnSwimmerManager.Text = "Manage Swimmers";
            this.btnSwimmerManager.UseVisualStyleBackColor = true;
            this.btnSwimmerManager.Click += new System.EventHandler(this.btnSwimmerManager_Click);
            // 
            // btnCoachManager
            // 
            this.btnCoachManager.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCoachManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCoachManager.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCoachManager.Location = new System.Drawing.Point(75, 315);
            this.btnCoachManager.Name = "btnCoachManager";
            this.btnCoachManager.Size = new System.Drawing.Size(319, 57);
            this.btnCoachManager.TabIndex = 3;
            this.btnCoachManager.Text = "Manage Coaches";
            this.btnCoachManager.UseVisualStyleBackColor = true;
            this.btnCoachManager.Click += new System.EventHandler(this.btnCoachManager_Click);
            // 
            // btnEventsManager
            // 
            this.btnEventsManager.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEventsManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEventsManager.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEventsManager.Location = new System.Drawing.Point(75, 393);
            this.btnEventsManager.Name = "btnEventsManager";
            this.btnEventsManager.Size = new System.Drawing.Size(319, 57);
            this.btnEventsManager.TabIndex = 4;
            this.btnEventsManager.Text = "Manage Events";
            this.btnEventsManager.UseVisualStyleBackColor = true;
            this.btnEventsManager.Click += new System.EventHandler(this.btnEventsManager_Click);
            // 
            // btnSwimMeetsManager
            // 
            this.btnSwimMeetsManager.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSwimMeetsManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSwimMeetsManager.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSwimMeetsManager.Location = new System.Drawing.Point(75, 470);
            this.btnSwimMeetsManager.Name = "btnSwimMeetsManager";
            this.btnSwimMeetsManager.Size = new System.Drawing.Size(319, 57);
            this.btnSwimMeetsManager.TabIndex = 5;
            this.btnSwimMeetsManager.Text = "Manage Swim Meets";
            this.btnSwimMeetsManager.UseVisualStyleBackColor = true;
            this.btnSwimMeetsManager.Click += new System.EventHandler(this.btnSwimMeetsManager_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(781, 652);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "© Kanisk Chakraborty - 300972577";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(980, 677);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSwimMeetsManager);
            this.Controls.Add(this.btnEventsManager);
            this.Controls.Add(this.btnCoachManager);
            this.Controls.Add(this.btnSwimmerManager);
            this.Controls.Add(this.btnClubsManager);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "SwimTracker v1.0";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnClubsManager;
        private System.Windows.Forms.Button btnSwimmerManager;
        private System.Windows.Forms.Button btnCoachManager;
        private System.Windows.Forms.Button btnEventsManager;
        private System.Windows.Forms.Button btnSwimMeetsManager;
        private System.Windows.Forms.Label label1;
    }
}

