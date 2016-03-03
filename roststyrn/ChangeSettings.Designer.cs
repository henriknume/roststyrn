namespace roststyrn
{
    partial class ChangeSetting
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
            this.newPos = new System.Windows.Forms.TextBox();
            this.Change = new System.Windows.Forms.Button();
            this.Set_default = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // newPos
            // 
            this.newPos.Location = new System.Drawing.Point(81, 59);
            this.newPos.Name = "newPos";
            this.newPos.Size = new System.Drawing.Size(154, 20);
            this.newPos.TabIndex = 0;
            this.newPos.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Change
            // 
            this.Change.Location = new System.Drawing.Point(160, 132);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(75, 23);
            this.Change.TabIndex = 1;
            this.Change.Text = "Change";
            this.Change.UseVisualStyleBackColor = true;
            this.Change.Click += new System.EventHandler(this.Change_Click);
            // 
            // Set_default
            // 
            this.Set_default.Location = new System.Drawing.Point(81, 132);
            this.Set_default.Name = "Set_default";
            this.Set_default.Size = new System.Drawing.Size(75, 23);
            this.Set_default.TabIndex = 2;
            this.Set_default.Text = "Default";
            this.Set_default.UseVisualStyleBackColor = true;
            this.Set_default.Click += new System.EventHandler(this.Set_default_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pos:\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Change_Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 197);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Set_default);
            this.Controls.Add(this.Change);
            this.Controls.Add(this.newPos);
            this.Name = "Change_Setting";
            this.Text = "Change_Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox newPos;
        private System.Windows.Forms.Button Change;
        private System.Windows.Forms.Button Set_default;
        private System.Windows.Forms.Label label1;
    }
}