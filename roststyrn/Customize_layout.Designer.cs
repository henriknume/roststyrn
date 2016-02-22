namespace roststyrn
{
    partial class Customize_layout
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
            this.Save = new System.Windows.Forms.Button();
            this.Default = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Name_personal = new System.Windows.Forms.TextBox();
            this.PosMonitorAngle = new System.Windows.Forms.Button();
            this.PosMonitorUp = new System.Windows.Forms.Button();
            this.PosDeskUp = new System.Windows.Forms.Button();
            this.PosCLOVUp = new System.Windows.Forms.Button();
            this.PosCLOVOut = new System.Windows.Forms.Button();
            this.PosMonitorOut = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Save
            // 
            this.Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.Location = new System.Drawing.Point(306, 400);
            this.Save.Name = "Save";
            this.Save.Padding = new System.Windows.Forms.Padding(2);
            this.Save.Size = new System.Drawing.Size(75, 29);
            this.Save.TabIndex = 9;
            this.Save.Text = "Save ";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Default
            // 
            this.Default.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Default.Location = new System.Drawing.Point(201, 400);
            this.Default.Name = "Default";
            this.Default.Size = new System.Drawing.Size(99, 29);
            this.Default.TabIndex = 10;
            this.Default.Text = "Set default";
            this.Default.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Customize your own profil settings\r\n";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::roststyrn.Properties.Resources.control_table_official;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Name_personal);
            this.panel1.Controls.Add(this.PosMonitorAngle);
            this.panel1.Controls.Add(this.PosMonitorUp);
            this.panel1.Controls.Add(this.PosDeskUp);
            this.panel1.Controls.Add(this.PosCLOVUp);
            this.panel1.Controls.Add(this.PosCLOVOut);
            this.panel1.Controls.Add(this.PosMonitorOut);
            this.panel1.Location = new System.Drawing.Point(2, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(407, 351);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Name:";
            // 
            // Name_personal
            // 
            this.Name_personal.Location = new System.Drawing.Point(134, 3);
            this.Name_personal.Name = "Name_personal";
            this.Name_personal.Size = new System.Drawing.Size(137, 20);
            this.Name_personal.TabIndex = 13;
            this.Name_personal.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // PosMonitorAngle
            // 
            this.PosMonitorAngle.BackgroundImage = global::roststyrn.Properties.Resources.dynamic_blue_right;
            this.PosMonitorAngle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PosMonitorAngle.Location = new System.Drawing.Point(134, 149);
            this.PosMonitorAngle.Name = "PosMonitorAngle";
            this.PosMonitorAngle.Size = new System.Drawing.Size(64, 32);
            this.PosMonitorAngle.TabIndex = 11;
            this.PosMonitorAngle.UseVisualStyleBackColor = true;
            this.PosMonitorAngle.Click += new System.EventHandler(this.Monitor_angle_up_Click);
            
            // PosMonitorUp
            // 
            this.PosMonitorUp.BackgroundImage = global::roststyrn.Properties.Resources.arrow_upppp;
            this.PosMonitorUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PosMonitorUp.Location = new System.Drawing.Point(148, 246);
            this.PosMonitorUp.Name = "PosMonitorUp";
            this.PosMonitorUp.Size = new System.Drawing.Size(40, 42);
            this.PosMonitorUp.TabIndex = 9;
            this.PosMonitorUp.UseVisualStyleBackColor = true;
            this.PosMonitorUp.Click += new System.EventHandler(this.Monitor_up_Click);
            // 
            // PosDeskUp
            // 
            this.PosDeskUp.BackgroundImage = global::roststyrn.Properties.Resources.arrow_upppp;
            this.PosDeskUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PosDeskUp.Location = new System.Drawing.Point(318, 196);
            this.PosDeskUp.Name = "PosDeskUp";
            this.PosDeskUp.Size = new System.Drawing.Size(40, 59);
            this.PosDeskUp.TabIndex = 7;
            this.PosDeskUp.UseVisualStyleBackColor = true;
            this.PosDeskUp.Click += new System.EventHandler(this.Table_up_Click);
            // 
            // PosCLOVUp
            // 
            this.PosCLOVUp.BackgroundImage = global::roststyrn.Properties.Resources.arrow_upppp;
            this.PosCLOVUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PosCLOVUp.Location = new System.Drawing.Point(10, 53);
            this.PosCLOVUp.Name = "PosCLOVUp";
            this.PosCLOVUp.Size = new System.Drawing.Size(41, 61);
            this.PosCLOVUp.TabIndex = 1;
            this.PosCLOVUp.UseVisualStyleBackColor = true;
            this.PosCLOVUp.Click += new System.EventHandler(this.CLOV_up_Click);
            // 
            // PosCLOVOut
            // 
            this.PosCLOVOut.BackgroundImage = global::roststyrn.Properties.Resources._007358_blue_jelly_icon_arrows_arrow_thick_left;
            this.PosCLOVOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PosCLOVOut.Location = new System.Drawing.Point(33, 261);
            this.PosCLOVOut.Name = "PosCLOVOut";
            this.PosCLOVOut.Size = new System.Drawing.Size(51, 39);
            this.PosCLOVOut.TabIndex = 5;
            this.PosCLOVOut.UseVisualStyleBackColor = true;
            this.PosCLOVOut.Click += new System.EventHandler(this.CLOV_depth_up_Click);
            // 
            // PosMonitorOut
            // 
            this.PosMonitorOut.BackgroundImage = global::roststyrn.Properties.Resources._007358_blue_jelly_icon_arrows_arrow_thick_left;
            this.PosMonitorOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PosMonitorOut.Location = new System.Drawing.Point(220, 279);
            this.PosMonitorOut.Name = "PosMonitorOut";
            this.PosMonitorOut.Size = new System.Drawing.Size(51, 37);
            this.PosMonitorOut.TabIndex = 3;
            this.PosMonitorOut.UseVisualStyleBackColor = true;
            this.PosMonitorOut.Click += new System.EventHandler(this.Monitor_depth_up_Click);
            // 
            // Customize_layout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 455);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Default);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.panel1);
            this.Name = "Customize_layout";
            this.Text = "Personal settings";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PosCLOVUp;
        private System.Windows.Forms.Button PosMonitorOut;
        private System.Windows.Forms.Button PosCLOVOut;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Default;
        private System.Windows.Forms.Button PosMonitorAngle;
        private System.Windows.Forms.Button PosMonitorUp;
        private System.Windows.Forms.Button PosDeskUp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Name_personal;
    }
}

