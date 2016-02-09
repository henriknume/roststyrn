﻿namespace roststyrn
{
    partial class Simulator
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
            this.buttonUp = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.label1AxlePos = new System.Windows.Forms.Label();
            this.label2AxlePos = new System.Windows.Forms.Label();
            this.buttonStop2 = new System.Windows.Forms.Button();
            this.buttonDown2 = new System.Windows.Forms.Button();
            this.buttonUp2 = new System.Windows.Forms.Button();
            this.LightOn = new System.Windows.Forms.Button();
            this.LightOff = new System.Windows.Forms.Button();
            this.WarmLight = new System.Windows.Forms.Button();
            this.ColdLight = new System.Windows.Forms.Button();
            this.LightCheckOn = new System.Windows.Forms.CheckBox();
            this.LightCheckOff = new System.Windows.Forms.CheckBox();
            this.WarmCheck = new System.Windows.Forms.CheckBox();
            this.ColdCheck = new System.Windows.Forms.CheckBox();
            this.mVDC_Output = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelaxles = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonUp
            // 
            this.buttonUp.Location = new System.Drawing.Point(10, 95);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(75, 23);
            this.buttonUp.TabIndex = 0;
            this.buttonUp.Text = "Up";
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonUp_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(10, 65);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(237, 24);
            this.progressBar1.TabIndex = 1;
            this.progressBar1.Value = 1;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(10, 151);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(237, 23);
            this.progressBar2.TabIndex = 2;
            this.progressBar2.Value = 1;
            // 
            // buttonDown
            // 
            this.buttonDown.Location = new System.Drawing.Point(91, 95);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(75, 23);
            this.buttonDown.TabIndex = 3;
            this.buttonDown.Text = "Down";
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonDown_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(172, 95);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 4;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // label1AxlePos
            // 
            this.label1AxlePos.AutoSize = true;
            this.label1AxlePos.Location = new System.Drawing.Point(7, 49);
            this.label1AxlePos.Name = "label1AxlePos";
            this.label1AxlePos.Size = new System.Drawing.Size(84, 13);
            this.label1AxlePos.TabIndex = 5;
            this.label1AxlePos.Text = "Axle ID #1  Pos:";
            // 
            // label2AxlePos
            // 
            this.label2AxlePos.AutoSize = true;
            this.label2AxlePos.Location = new System.Drawing.Point(7, 135);
            this.label2AxlePos.Name = "label2AxlePos";
            this.label2AxlePos.Size = new System.Drawing.Size(84, 13);
            this.label2AxlePos.TabIndex = 6;
            this.label2AxlePos.Text = "Axle ID #2  Pos:";
            // 
            // buttonStop2
            // 
            this.buttonStop2.Location = new System.Drawing.Point(172, 180);
            this.buttonStop2.Name = "buttonStop2";
            this.buttonStop2.Size = new System.Drawing.Size(75, 23);
            this.buttonStop2.TabIndex = 9;
            this.buttonStop2.Text = "Stop2";
            this.buttonStop2.UseVisualStyleBackColor = true;
            this.buttonStop2.Click += new System.EventHandler(this.buttonStop2_Click);
            // 
            // buttonDown2
            // 
            this.buttonDown2.Location = new System.Drawing.Point(91, 180);
            this.buttonDown2.Name = "buttonDown2";
            this.buttonDown2.Size = new System.Drawing.Size(75, 23);
            this.buttonDown2.TabIndex = 8;
            this.buttonDown2.Text = "Down2";
            this.buttonDown2.UseVisualStyleBackColor = true;
            this.buttonDown2.Click += new System.EventHandler(this.buttonDown2_Click);
            // 
            // buttonUp2
            // 
            this.buttonUp2.Location = new System.Drawing.Point(10, 180);
            this.buttonUp2.Name = "buttonUp2";
            this.buttonUp2.Size = new System.Drawing.Size(75, 23);
            this.buttonUp2.TabIndex = 7;
            this.buttonUp2.Text = "Up2";
            this.buttonUp2.UseVisualStyleBackColor = true;
            this.buttonUp2.Click += new System.EventHandler(this.buttonUp2_Click);
            // 
            // LightOn
            // 
            this.LightOn.Location = new System.Drawing.Point(6, 57);
            this.LightOn.Name = "LightOn";
            this.LightOn.Size = new System.Drawing.Size(75, 23);
            this.LightOn.TabIndex = 10;
            this.LightOn.Text = "On";
            this.LightOn.UseVisualStyleBackColor = true;
            this.LightOn.Click += new System.EventHandler(this.LightOn_Click);
            // 
            // LightOff
            // 
            this.LightOff.Location = new System.Drawing.Point(91, 57);
            this.LightOff.Name = "LightOff";
            this.LightOff.Size = new System.Drawing.Size(75, 23);
            this.LightOff.TabIndex = 11;
            this.LightOff.Text = "Off";
            this.LightOff.UseVisualStyleBackColor = true;
            this.LightOff.Click += new System.EventHandler(this.LightOff_Click);
            // 
            // WarmLight
            // 
            this.WarmLight.Location = new System.Drawing.Point(6, 100);
            this.WarmLight.Name = "WarmLight";
            this.WarmLight.Size = new System.Drawing.Size(75, 23);
            this.WarmLight.TabIndex = 12;
            this.WarmLight.Text = "Warm";
            this.WarmLight.UseVisualStyleBackColor = true;
            this.WarmLight.Click += new System.EventHandler(this.WarmLight_Click);
            // 
            // ColdLight
            // 
            this.ColdLight.Location = new System.Drawing.Point(91, 99);
            this.ColdLight.Name = "ColdLight";
            this.ColdLight.Size = new System.Drawing.Size(75, 23);
            this.ColdLight.TabIndex = 13;
            this.ColdLight.Text = "Cold";
            this.ColdLight.UseVisualStyleBackColor = true;
            this.ColdLight.Click += new System.EventHandler(this.ColdLight_Click);
            // 
            // LightCheckOn
            // 
            this.LightCheckOn.AutoSize = true;
            this.LightCheckOn.Location = new System.Drawing.Point(183, 61);
            this.LightCheckOn.Name = "LightCheckOn";
            this.LightCheckOn.Size = new System.Drawing.Size(64, 17);
            this.LightCheckOn.TabIndex = 14;
            this.LightCheckOn.Text = "Light on";
            this.LightCheckOn.UseVisualStyleBackColor = true;
            // 
            // LightCheckOff
            // 
            this.LightCheckOff.AutoSize = true;
            this.LightCheckOff.Location = new System.Drawing.Point(258, 61);
            this.LightCheckOff.Name = "LightCheckOff";
            this.LightCheckOff.Size = new System.Drawing.Size(64, 17);
            this.LightCheckOff.TabIndex = 15;
            this.LightCheckOff.Text = "Light off";
            this.LightCheckOff.UseVisualStyleBackColor = true;
            // 
            // WarmCheck
            // 
            this.WarmCheck.AutoSize = true;
            this.WarmCheck.Location = new System.Drawing.Point(183, 100);
            this.WarmCheck.Name = "WarmCheck";
            this.WarmCheck.Size = new System.Drawing.Size(76, 17);
            this.WarmCheck.TabIndex = 16;
            this.WarmCheck.Text = "Warm light";
            this.WarmCheck.UseVisualStyleBackColor = true;
            // 
            // ColdCheck
            // 
            this.ColdCheck.AutoSize = true;
            this.ColdCheck.Location = new System.Drawing.Point(258, 100);
            this.ColdCheck.Name = "ColdCheck";
            this.ColdCheck.Size = new System.Drawing.Size(69, 17);
            this.ColdCheck.TabIndex = 17;
            this.ColdCheck.Text = "Cold light";
            this.ColdCheck.UseVisualStyleBackColor = true;
            // 
            // mVDC_Output
            // 
            this.mVDC_Output.Location = new System.Drawing.Point(333, 97);
            this.mVDC_Output.Name = "mVDC_Output";
            this.mVDC_Output.Size = new System.Drawing.Size(100, 20);
            this.mVDC_Output.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 24);
            this.label1.TabIndex = 19;
            this.label1.Text = "Light properties";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(340, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Current mVDC";
            // 
            // labelaxles
            // 
            this.labelaxles.AutoSize = true;
            this.labelaxles.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelaxles.Location = new System.Drawing.Point(6, 16);
            this.labelaxles.Name = "labelaxles";
            this.labelaxles.Size = new System.Drawing.Size(57, 24);
            this.labelaxles.TabIndex = 21;
            this.labelaxles.Text = "Axles";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.LightOn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.LightOff);
            this.groupBox1.Controls.Add(this.WarmLight);
            this.groupBox1.Controls.Add(this.mVDC_Output);
            this.groupBox1.Controls.Add(this.ColdLight);
            this.groupBox1.Controls.Add(this.ColdCheck);
            this.groupBox1.Controls.Add(this.LightCheckOn);
            this.groupBox1.Controls.Add(this.WarmCheck);
            this.groupBox1.Controls.Add(this.LightCheckOff);
            this.groupBox1.Location = new System.Drawing.Point(17, 289);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 131);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonUp);
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(this.labelaxles);
            this.groupBox2.Controls.Add(this.progressBar2);
            this.groupBox2.Controls.Add(this.buttonStop2);
            this.groupBox2.Controls.Add(this.buttonDown);
            this.groupBox2.Controls.Add(this.buttonDown2);
            this.groupBox2.Controls.Add(this.buttonStop);
            this.groupBox2.Controls.Add(this.buttonUp2);
            this.groupBox2.Controls.Add(this.label1AxlePos);
            this.groupBox2.Controls.Add(this.label2AxlePos);
            this.groupBox2.Location = new System.Drawing.Point(17, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(450, 218);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft PhagsPa", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(411, 53);
            this.label3.TabIndex = 24;
            this.label3.Text = "EOWTable Simulator";
            // 
            // Simulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 436);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Simulator";
            this.Text = "Simulator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Label label1AxlePos;
        private System.Windows.Forms.Label label2AxlePos;
        private System.Windows.Forms.Button buttonStop2;
        private System.Windows.Forms.Button buttonDown2;
        private System.Windows.Forms.Button buttonUp2;
        private System.Windows.Forms.Button LightOn;
        private System.Windows.Forms.Button LightOff;
        private System.Windows.Forms.Button WarmLight;
        private System.Windows.Forms.Button ColdLight;
        private System.Windows.Forms.CheckBox LightCheckOn;
        private System.Windows.Forms.CheckBox LightCheckOff;
        private System.Windows.Forms.CheckBox WarmCheck;
        private System.Windows.Forms.CheckBox ColdCheck;
        private System.Windows.Forms.TextBox mVDC_Output;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelaxles;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
    }
}