﻿
namespace WindowsFormsApp1
{
    partial class LogInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInForm));
            this.box_UserName = new System.Windows.Forms.TextBox();
            this.box_Password = new System.Windows.Forms.TextBox();
            this.label_UserName = new System.Windows.Forms.Label();
            this.label_Password = new System.Windows.Forms.Label();
            this.btn_LogIn = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_register = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // box_UserName
            // 
            this.box_UserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.box_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_UserName.Location = new System.Drawing.Point(168, 47);
            this.box_UserName.Margin = new System.Windows.Forms.Padding(2);
            this.box_UserName.Name = "box_UserName";
            this.box_UserName.Size = new System.Drawing.Size(125, 21);
            this.box_UserName.TabIndex = 0;
            this.box_UserName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.box_UserName_KeyDown);
            // 
            // box_Password
            // 
            this.box_Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.box_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_Password.Location = new System.Drawing.Point(168, 78);
            this.box_Password.Margin = new System.Windows.Forms.Padding(2);
            this.box_Password.Name = "box_Password";
            this.box_Password.Size = new System.Drawing.Size(125, 21);
            this.box_Password.TabIndex = 2;
            this.box_Password.UseSystemPasswordChar = true;
            this.box_Password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.box_Password_KeyDown);
            // 
            // label_UserName
            // 
            this.label_UserName.AutoSize = true;
            this.label_UserName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_UserName.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label_UserName.Font = new System.Drawing.Font("Britannic Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_UserName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_UserName.Location = new System.Drawing.Point(42, 52);
            this.label_UserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_UserName.Name = "label_UserName";
            this.label_UserName.Size = new System.Drawing.Size(77, 16);
            this.label_UserName.TabIndex = 3;
            this.label_UserName.Text = "User Name";
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_Password.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label_Password.Font = new System.Drawing.Font("Britannic Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Password.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_Password.Location = new System.Drawing.Point(42, 80);
            this.label_Password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(71, 16);
            this.label_Password.TabIndex = 4;
            this.label_Password.Text = "Password";
            // 
            // btn_LogIn
            // 
            this.btn_LogIn.BackColor = System.Drawing.Color.BlueViolet;
            this.btn_LogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LogIn.Font = new System.Drawing.Font("Unispace", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LogIn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_LogIn.Location = new System.Drawing.Point(129, 133);
            this.btn_LogIn.Margin = new System.Windows.Forms.Padding(2);
            this.btn_LogIn.Name = "btn_LogIn";
            this.btn_LogIn.Size = new System.Drawing.Size(74, 39);
            this.btn_LogIn.TabIndex = 5;
            this.btn_LogIn.Text = "Log In";
            this.btn_LogIn.UseVisualStyleBackColor = false;
            this.btn_LogIn.Click += new System.EventHandler(this.btn_LogIn_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.BlueViolet;
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Font = new System.Drawing.Font("Unispace", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Cancel.Location = new System.Drawing.Point(219, 133);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(74, 39);
            this.btn_Cancel.TabIndex = 6;
            this.btn_Cancel.Text = "Exit";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_register
            // 
            this.btn_register.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_register.BackColor = System.Drawing.Color.BlueViolet;
            this.btn_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_register.Font = new System.Drawing.Font("Unispace", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_register.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_register.Location = new System.Drawing.Point(39, 133);
            this.btn_register.Margin = new System.Windows.Forms.Padding(2);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(74, 39);
            this.btn_register.TabIndex = 7;
            this.btn_register.Text = "Register";
            this.btn_register.UseVisualStyleBackColor = false;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(334, 211);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.box_UserName);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_LogIn);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.label_UserName);
            this.Controls.Add(this.box_Password);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LogInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account Login";
            this.Load += new System.EventHandler(this.LogInForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox box_UserName;
        private System.Windows.Forms.TextBox box_Password;
        private System.Windows.Forms.Label label_UserName;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.Button btn_LogIn;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_register;
    }
}

