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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.startSimBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.langBox = new System.Windows.Forms.ComboBox();
            this.Customize_profile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Input: NO_COMMAND";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Status: OFF";
            // 
            // startSimBtn
            // 
            this.startSimBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startSimBtn.Location = new System.Drawing.Point(12, 182);
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
            this.label3.Location = new System.Drawing.Point(77, 9);
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
            "Engelska"});
            this.langBox.Location = new System.Drawing.Point(12, 144);
            this.langBox.Name = "langBox";
            this.langBox.Size = new System.Drawing.Size(121, 21);
            this.langBox.TabIndex = 6;
            this.langBox.SelectedIndexChanged += new System.EventHandler(this.langBox_SelectedIndexChanged);
            // 
            // Customize_profile
            // 
            this.Customize_profile.Location = new System.Drawing.Point(172, 109);
            this.Customize_profile.Name = "Customize_profile";
            this.Customize_profile.Size = new System.Drawing.Size(100, 23);
            this.Customize_profile.TabIndex = 7;
            this.Customize_profile.Text = "Customize_profile";
            this.Customize_profile.UseVisualStyleBackColor = true;
            this.Customize_profile.Click += new System.EventHandler(this.Customize_profile_Click);
            // 
            // VoiceControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 245);
            this.Controls.Add(this.Customize_profile);
            this.Controls.Add(this.langBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.startSimBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "VoiceControl";
            this.Text = "VoiceControl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button startSimBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox langBox;
        private System.Windows.Forms.Button Customize_profile;
    }
}

