﻿namespace VNCVSProjectWizard
{
    partial class Form1
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
            this.lblAPPLICATION = new System.Windows.Forms.Label();
            this.lblTYPE = new System.Windows.Forms.Label();
            this.lblEVENT = new System.Windows.Forms.Label();
            this.txtAPPLICATION = new System.Windows.Forms.TextBox();
            this.txtTYPE = new System.Windows.Forms.TextBox();
            this.txtEVENT = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblAppVersion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAPPLICATION
            // 
            this.lblAPPLICATION.AutoSize = true;
            this.lblAPPLICATION.Location = new System.Drawing.Point(75, 53);
            this.lblAPPLICATION.Name = "lblAPPLICATION";
            this.lblAPPLICATION.Size = new System.Drawing.Size(113, 20);
            this.lblAPPLICATION.TabIndex = 0;
            this.lblAPPLICATION.Text = "APPLICATION";
            // 
            // lblTYPE
            // 
            this.lblTYPE.AutoSize = true;
            this.lblTYPE.Location = new System.Drawing.Point(138, 87);
            this.lblTYPE.Name = "lblTYPE";
            this.lblTYPE.Size = new System.Drawing.Size(50, 20);
            this.lblTYPE.TabIndex = 1;
            this.lblTYPE.Text = "TYPE";
            // 
            // lblEVENT
            // 
            this.lblEVENT.AutoSize = true;
            this.lblEVENT.Location = new System.Drawing.Point(126, 122);
            this.lblEVENT.Name = "lblEVENT";
            this.lblEVENT.Size = new System.Drawing.Size(62, 20);
            this.lblEVENT.TabIndex = 2;
            this.lblEVENT.Text = "EVENT";
            // 
            // txtAPPLICATION
            // 
            this.txtAPPLICATION.Location = new System.Drawing.Point(202, 50);
            this.txtAPPLICATION.Name = "txtAPPLICATION";
            this.txtAPPLICATION.Size = new System.Drawing.Size(234, 26);
            this.txtAPPLICATION.TabIndex = 3;
            // 
            // txtTYPE
            // 
            this.txtTYPE.Location = new System.Drawing.Point(202, 84);
            this.txtTYPE.Name = "txtTYPE";
            this.txtTYPE.Size = new System.Drawing.Size(234, 26);
            this.txtTYPE.TabIndex = 4;
            // 
            // txtEVENT
            // 
            this.txtEVENT.Location = new System.Drawing.Point(202, 119);
            this.txtEVENT.Name = "txtEVENT";
            this.txtEVENT.Size = new System.Drawing.Size(234, 26);
            this.txtEVENT.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(175, 182);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(234, 35);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save Custom Parameters";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblAppVersion
            // 
            this.lblAppVersion.AutoSize = true;
            this.lblAppVersion.Location = new System.Drawing.Point(12, 421);
            this.lblAppVersion.Name = "lblAppVersion";
            this.lblAppVersion.Size = new System.Drawing.Size(81, 20);
            this.lblAppVersion.TabIndex = 7;
            this.lblAppVersion.Text = "<Version>";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1178, 450);
            this.Controls.Add(this.lblAppVersion);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtEVENT);
            this.Controls.Add(this.txtTYPE);
            this.Controls.Add(this.txtAPPLICATION);
            this.Controls.Add(this.lblEVENT);
            this.Controls.Add(this.lblTYPE);
            this.Controls.Add(this.lblAPPLICATION);
            this.Name = "Form1";
            this.Text = "Custom Parameters";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAPPLICATION;
        private System.Windows.Forms.Label lblTYPE;
        private System.Windows.Forms.Label lblEVENT;
        private System.Windows.Forms.TextBox txtAPPLICATION;
        private System.Windows.Forms.TextBox txtTYPE;
        private System.Windows.Forms.TextBox txtEVENT;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblAppVersion;
    }
}