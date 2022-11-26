using AForge;
using AForge.Video;
using AForge.Video.DirectShow;

namespace CamControl
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.StartButton = new System.Windows.Forms.Button();
            this.Pic = new System.Windows.Forms.PictureBox();
            this.cbo_Cams = new System.Windows.Forms.ComboBox();
            this.SupRes = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pic)).BeginInit();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.StartButton.Location = new System.Drawing.Point(292, 541);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(218, 60);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start Capture";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // Pic
            // 
            this.Pic.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Pic.Location = new System.Drawing.Point(12, 12);
            this.Pic.Name = "Pic";
            this.Pic.Size = new System.Drawing.Size(776, 523);
            this.Pic.TabIndex = 1;
            this.Pic.TabStop = false;
            // 
            // cbo_Cams
            // 
            this.cbo_Cams.FormattingEnabled = true;
            this.cbo_Cams.Location = new System.Drawing.Point(294, 607);
            this.cbo_Cams.Name = "cbo_Cams";
            this.cbo_Cams.Size = new System.Drawing.Size(216, 23);
            this.cbo_Cams.TabIndex = 2;
            // 
            // SupRes
            // 
            this.SupRes.FormattingEnabled = true;
            this.SupRes.ItemHeight = 15;
            this.SupRes.Location = new System.Drawing.Point(529, 549);
            this.SupRes.Name = "SupRes";
            this.SupRes.Size = new System.Drawing.Size(260, 64);
            this.SupRes.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 665);
            this.Controls.Add(this.SupRes);
            this.Controls.Add(this.cbo_Cams);
            this.Controls.Add(this.Pic);
            this.Controls.Add(this.StartButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button StartButton;
        private PictureBox Pic;
        private ComboBox cbo_Cams;
        private ListBox SupRes;
    }
}