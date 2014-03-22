﻿namespace PluraLeecher
{
    partial class FrmMain
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
            this.browser = new System.Windows.Forms.WebBrowser();
            this.lstVideoTitle = new System.Windows.Forms.ListBox();
            this.btnLeech = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lstCategories = new System.Windows.Forms.ListBox();
            this.tvTopicsAndTitles = new System.Windows.Forms.TreeView();
            this.btnGetCategories = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // browser
            // 
            this.browser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.browser.Location = new System.Drawing.Point(686, 38);
            this.browser.MinimumSize = new System.Drawing.Size(20, 20);
            this.browser.Name = "browser";
            this.browser.Size = new System.Drawing.Size(403, 426);
            this.browser.TabIndex = 0;
            // 
            // lstVideoTitle
            // 
            this.lstVideoTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstVideoTitle.FormattingEnabled = true;
            this.lstVideoTitle.Location = new System.Drawing.Point(470, 38);
            this.lstVideoTitle.Name = "lstVideoTitle";
            this.lstVideoTitle.Size = new System.Drawing.Size(210, 420);
            this.lstVideoTitle.TabIndex = 1;
            this.lstVideoTitle.SelectedIndexChanged += new System.EventHandler(this.lstVideoTitle_SelectedIndexChanged);
            // 
            // btnLeech
            // 
            this.btnLeech.Location = new System.Drawing.Point(232, 12);
            this.btnLeech.Name = "btnLeech";
            this.btnLeech.Size = new System.Drawing.Size(75, 23);
            this.btnLeech.TabIndex = 5;
            this.btnLeech.Text = "Sömür";
            this.btnLeech.UseVisualStyleBackColor = true;
            this.btnLeech.Click += new System.EventHandler(this.LeechButtonClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(313, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Down Them All!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lstCategories
            // 
            this.lstCategories.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstCategories.FormattingEnabled = true;
            this.lstCategories.Location = new System.Drawing.Point(16, 41);
            this.lstCategories.Name = "lstCategories";
            this.lstCategories.Size = new System.Drawing.Size(210, 420);
            this.lstCategories.TabIndex = 1;
            this.lstCategories.SelectedIndexChanged += new System.EventHandler(this.lstVideoTitle_SelectedIndexChanged);
            // 
            // tvTopicsAndTitles
            // 
            this.tvTopicsAndTitles.Location = new System.Drawing.Point(232, 41);
            this.tvTopicsAndTitles.Name = "tvTopicsAndTitles";
            this.tvTopicsAndTitles.Size = new System.Drawing.Size(223, 420);
            this.tvTopicsAndTitles.TabIndex = 7;
            // 
            // btnGetCategories
            // 
            this.btnGetCategories.Location = new System.Drawing.Point(16, 12);
            this.btnGetCategories.Name = "btnGetCategories";
            this.btnGetCategories.Size = new System.Drawing.Size(210, 23);
            this.btnGetCategories.TabIndex = 8;
            this.btnGetCategories.Text = "button2";
            this.btnGetCategories.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 479);
            this.Controls.Add(this.btnGetCategories);
            this.Controls.Add(this.tvTopicsAndTitles);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLeech);
            this.Controls.Add(this.lstCategories);
            this.Controls.Add(this.lstVideoTitle);
            this.Controls.Add(this.browser);
            this.Name = "FrmMain";
            this.Text = "PluraLeech";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1Closing);
            this.Load += new System.EventHandler(this.FormLoad);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser browser;
        private System.Windows.Forms.ListBox lstVideoTitle;
        private System.Windows.Forms.Button btnLeech;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lstCategories;
        private System.Windows.Forms.TreeView tvTopicsAndTitles;
        private System.Windows.Forms.Button btnGetCategories;
    }
}

