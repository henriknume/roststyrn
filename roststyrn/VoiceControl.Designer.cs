namespace roststyrn
{
    partial class VoiceControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VoiceControl));
            this.label2 = new System.Windows.Forms.Label();
            this.startSimBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.langBox = new System.Windows.Forms.ComboBox();
            this.Customize_profile = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.viewCommandsButtons = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Status: Not listening";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // startSimBtn
            // 
            this.startSimBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startSimBtn.Location = new System.Drawing.Point(12, 186);
            this.startSimBtn.Name = "startSimBtn";
            this.startSimBtn.Size = new System.Drawing.Size(260, 40);
            this.startSimBtn.TabIndex = 4;
            this.startSimBtn.Text = "Start simulator";
            this.startSimBtn.UseVisualStyleBackColor = true;
            this.startSimBtn.Click += new System.EventHandler(this.startSimBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(83, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Control";
            // 
            // langBox
            // 
            this.langBox.FormattingEnabled = true;
            this.langBox.Items.AddRange(new object[] {
            "Svenska",
            "English"});
            this.langBox.Location = new System.Drawing.Point(12, 108);
            this.langBox.Name = "langBox";
            this.langBox.Size = new System.Drawing.Size(121, 21);
            this.langBox.TabIndex = 6;
            this.langBox.SelectedIndexChanged += new System.EventHandler(this.langBox_SelectedIndexChanged);
            // 
            // Customize_profile
            // 
            this.Customize_profile.Location = new System.Drawing.Point(151, 150);
            this.Customize_profile.Name = "Customize_profile";
            this.Customize_profile.Size = new System.Drawing.Size(121, 30);
            this.Customize_profile.TabIndex = 7;
            this.Customize_profile.Text = "Custom Command";
            this.Customize_profile.UseVisualStyleBackColor = true;
            this.Customize_profile.Click += new System.EventHandler(this.Customize_profile_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(216, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 62);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(216, 53);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(56, 76);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // viewCommandsButtons
            // 
            this.viewCommandsButtons.Location = new System.Drawing.Point(12, 150);
            this.viewCommandsButtons.Name = "viewCommandsButtons";
            this.viewCommandsButtons.Size = new System.Drawing.Size(133, 30);
            this.viewCommandsButtons.TabIndex = 10;
            this.viewCommandsButtons.Text = "View Commands";
            this.viewCommandsButtons.UseVisualStyleBackColor = true;
            this.viewCommandsButtons.Click += new System.EventHandler(this.viewCommandsButtons_Click);
            // 
            // VoiceControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 239);
            this.Controls.Add(this.viewCommandsButtons);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Customize_profile);
            this.Controls.Add(this.langBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.startSimBtn);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "VoiceControl";
            this.Text = "VoiceControl";
            this.Deactivate += new System.EventHandler(this.VoiceControl_Deactivate);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button startSimBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox langBox;
        private System.Windows.Forms.Button Customize_profile;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button viewCommandsButtons;
    }
}

