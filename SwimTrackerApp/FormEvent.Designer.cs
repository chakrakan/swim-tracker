namespace SwimTrackerApp
{
    partial class FormEvent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEvent));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lsbDistance = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lsbStroke = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lsbEvents = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lsbSwimmers = new System.Windows.Forms.ListBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblEventInfo = new System.Windows.Forms.Label();
            this.btnAddEvent = new System.Windows.Forms.Button();
            this.btnAssignSwimmer = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtMiliSeconds = new System.Windows.Forms.TextBox();
            this.txtSeconds = new System.Windows.Forms.TextBox();
            this.txtMinutes = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddTime = new System.Windows.Forms.Button();
            this.lblErrorTime = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Events Manager";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lsbDistance);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 188);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Distance";
            // 
            // lsbDistance
            // 
            this.lsbDistance.FormattingEnabled = true;
            this.lsbDistance.ItemHeight = 17;
            this.lsbDistance.Items.AddRange(new object[] {
            "50 m",
            "100 m",
            "200 m",
            "400 m",
            "800 m",
            "1500 m"});
            this.lsbDistance.Location = new System.Drawing.Point(6, 42);
            this.lsbDistance.Name = "lsbDistance";
            this.lsbDistance.Size = new System.Drawing.Size(241, 140);
            this.lsbDistance.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lsbStroke);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 308);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(254, 186);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stroke Style";
            // 
            // lsbStroke
            // 
            this.lsbStroke.FormattingEnabled = true;
            this.lsbStroke.ItemHeight = 17;
            this.lsbStroke.Items.AddRange(new object[] {
            "Butterfly",
            "Backstroke",
            "Breaststroke",
            "Freestyle",
            "Individual medley"});
            this.lsbStroke.Location = new System.Drawing.Point(7, 42);
            this.lsbStroke.Name = "lsbStroke";
            this.lsbStroke.Size = new System.Drawing.Size(241, 140);
            this.lsbStroke.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lsbEvents);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(288, 114);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 380);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Events";
            // 
            // lsbEvents
            // 
            this.lsbEvents.FormattingEnabled = true;
            this.lsbEvents.ItemHeight = 17;
            this.lsbEvents.Location = new System.Drawing.Point(7, 33);
            this.lsbEvents.Name = "lsbEvents";
            this.lsbEvents.Size = new System.Drawing.Size(187, 327);
            this.lsbEvents.TabIndex = 0;
            this.lsbEvents.SelectedIndexChanged += new System.EventHandler(this.lsbEvents_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lsbSwimmers);
            this.groupBox4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(513, 114);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 376);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Assign Swimmer";
            // 
            // lsbSwimmers
            // 
            this.lsbSwimmers.FormattingEnabled = true;
            this.lsbSwimmers.ItemHeight = 17;
            this.lsbSwimmers.Location = new System.Drawing.Point(7, 33);
            this.lsbSwimmers.Name = "lsbSwimmers";
            this.lsbSwimmers.Size = new System.Drawing.Size(187, 327);
            this.lsbSwimmers.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblEventInfo);
            this.groupBox5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(725, 114);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(247, 281);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Event Info";
            // 
            // lblEventInfo
            // 
            this.lblEventInfo.AutoSize = true;
            this.lblEventInfo.Location = new System.Drawing.Point(7, 33);
            this.lblEventInfo.Name = "lblEventInfo";
            this.lblEventInfo.Size = new System.Drawing.Size(0, 17);
            this.lblEventInfo.TabIndex = 0;
            // 
            // btnAddEvent
            // 
            this.btnAddEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEvent.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEvent.Location = new System.Drawing.Point(55, 556);
            this.btnAddEvent.Name = "btnAddEvent";
            this.btnAddEvent.Size = new System.Drawing.Size(178, 44);
            this.btnAddEvent.TabIndex = 8;
            this.btnAddEvent.Text = "Add Event";
            this.btnAddEvent.UseVisualStyleBackColor = true;
            this.btnAddEvent.Click += new System.EventHandler(this.btnAddEvent_Click);
            // 
            // btnAssignSwimmer
            // 
            this.btnAssignSwimmer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssignSwimmer.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssignSwimmer.Location = new System.Drawing.Point(531, 556);
            this.btnAssignSwimmer.Name = "btnAssignSwimmer";
            this.btnAssignSwimmer.Size = new System.Drawing.Size(163, 47);
            this.btnAssignSwimmer.TabIndex = 9;
            this.btnAssignSwimmer.Text = "Assign Swimmer";
            this.btnAssignSwimmer.UseVisualStyleBackColor = true;
            this.btnAssignSwimmer.Click += new System.EventHandler(this.btnAssignSwimmer_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtMiliSeconds);
            this.groupBox6.Controls.Add(this.txtSeconds);
            this.groupBox6.Controls.Add(this.txtMinutes);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(719, 413);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(253, 77);
            this.groupBox6.TabIndex = 10;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Swimmer Time";
            // 
            // txtMiliSeconds
            // 
            this.txtMiliSeconds.Location = new System.Drawing.Point(170, 39);
            this.txtMiliSeconds.Name = "txtMiliSeconds";
            this.txtMiliSeconds.Size = new System.Drawing.Size(44, 23);
            this.txtMiliSeconds.TabIndex = 5;
            // 
            // txtSeconds
            // 
            this.txtSeconds.Location = new System.Drawing.Point(96, 39);
            this.txtSeconds.Name = "txtSeconds";
            this.txtSeconds.Size = new System.Drawing.Size(44, 23);
            this.txtSeconds.TabIndex = 4;
            // 
            // txtMinutes
            // 
            this.txtMinutes.Location = new System.Drawing.Point(6, 39);
            this.txtMinutes.Name = "txtMinutes";
            this.txtMinutes.Size = new System.Drawing.Size(44, 23);
            this.txtMinutes.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(220, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "ms";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(146, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "ss";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "mm";
            // 
            // btnAddTime
            // 
            this.btnAddTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTime.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTime.Location = new System.Drawing.Point(764, 556);
            this.btnAddTime.Name = "btnAddTime";
            this.btnAddTime.Size = new System.Drawing.Size(163, 47);
            this.btnAddTime.TabIndex = 11;
            this.btnAddTime.Text = "Add Time";
            this.btnAddTime.UseVisualStyleBackColor = true;
            this.btnAddTime.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblErrorTime
            // 
            this.lblErrorTime.AutoSize = true;
            this.lblErrorTime.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorTime.Location = new System.Drawing.Point(761, 512);
            this.lblErrorTime.Name = "lblErrorTime";
            this.lblErrorTime.Size = new System.Drawing.Size(0, 17);
            this.lblErrorTime.TabIndex = 12;
            // 
            // FormEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(984, 681);
            this.Controls.Add(this.lblErrorTime);
            this.Controls.Add(this.btnAddTime);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.btnAssignSwimmer);
            this.Controls.Add(this.btnAddEvent);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEvent";
            this.Text = "Events Manager";
            this.Load += new System.EventHandler(this.FormEvent_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lsbDistance;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lsbStroke;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lsbEvents;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox lsbSwimmers;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblEventInfo;
        private System.Windows.Forms.Button btnAddEvent;
        private System.Windows.Forms.Button btnAssignSwimmer;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMiliSeconds;
        private System.Windows.Forms.TextBox txtSeconds;
        private System.Windows.Forms.TextBox txtMinutes;
        private System.Windows.Forms.Button btnAddTime;
        private System.Windows.Forms.Label lblErrorTime;
    }
}