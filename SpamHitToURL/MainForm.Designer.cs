
namespace SpamHitToURL
{
    partial class MainForm
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
            this.tbNoOfThreads = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSampleAER = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSampleCT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbURL = new System.Windows.Forms.TextBox();
            this.btnHit = new System.Windows.Forms.Button();
            this.btnAERBrowse = new System.Windows.Forms.Button();
            this.btnCTBrowse = new System.Windows.Forms.Button();
            this.ofdMain = new System.Windows.Forms.OpenFileDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.tbDuration = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbNoOfThreads
            // 
            this.tbNoOfThreads.Location = new System.Drawing.Point(142, 12);
            this.tbNoOfThreads.Name = "tbNoOfThreads";
            this.tbNoOfThreads.Size = new System.Drawing.Size(89, 20);
            this.tbNoOfThreads.TabIndex = 0;
            this.tbNoOfThreads.Text = "2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "No of Threads";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sample AER File";
            // 
            // tbSampleAER
            // 
            this.tbSampleAER.Location = new System.Drawing.Point(142, 38);
            this.tbSampleAER.Name = "tbSampleAER";
            this.tbSampleAER.Size = new System.Drawing.Size(388, 20);
            this.tbSampleAER.TabIndex = 2;
            this.tbSampleAER.Text = "D:\\Projects\\SpamHitToURL\\SpamHitToURL\\Samples\\AER.xml";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sample CT File";
            // 
            // tbSampleCT
            // 
            this.tbSampleCT.Location = new System.Drawing.Point(142, 64);
            this.tbSampleCT.Name = "tbSampleCT";
            this.tbSampleCT.Size = new System.Drawing.Size(388, 20);
            this.tbSampleCT.TabIndex = 4;
            this.tbSampleCT.Text = "D:\\Projects\\SpamHitToURL\\SpamHitToURL\\Samples\\CT.xml";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "URL to hit";
            // 
            // tbURL
            // 
            this.tbURL.Location = new System.Drawing.Point(142, 90);
            this.tbURL.Name = "tbURL";
            this.tbURL.Size = new System.Drawing.Size(481, 20);
            this.tbURL.TabIndex = 6;
            this.tbURL.Text = "http://google.com/";
            // 
            // btnHit
            // 
            this.btnHit.Location = new System.Drawing.Point(548, 116);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(75, 23);
            this.btnHit.TabIndex = 8;
            this.btnHit.Text = "Hit!";
            this.btnHit.UseVisualStyleBackColor = true;
            this.btnHit.Click += new System.EventHandler(this.btnHit_Click);
            // 
            // btnAERBrowse
            // 
            this.btnAERBrowse.Location = new System.Drawing.Point(548, 36);
            this.btnAERBrowse.Name = "btnAERBrowse";
            this.btnAERBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnAERBrowse.TabIndex = 9;
            this.btnAERBrowse.Text = "Browse";
            this.btnAERBrowse.UseVisualStyleBackColor = true;
            this.btnAERBrowse.Click += new System.EventHandler(this.btnAERBrowse_Click);
            // 
            // btnCTBrowse
            // 
            this.btnCTBrowse.Location = new System.Drawing.Point(548, 62);
            this.btnCTBrowse.Name = "btnCTBrowse";
            this.btnCTBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnCTBrowse.TabIndex = 10;
            this.btnCTBrowse.Text = "Browse";
            this.btnCTBrowse.UseVisualStyleBackColor = true;
            this.btnCTBrowse.Click += new System.EventHandler(this.btnCTBrowse_Click);
            // 
            // ofdMain
            // 
            this.ofdMain.Filter = "*.xml|*.*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(237, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Duration in Second";
            // 
            // tbDuration
            // 
            this.tbDuration.Location = new System.Drawing.Point(367, 12);
            this.tbDuration.Name = "tbDuration";
            this.tbDuration.Size = new System.Drawing.Size(89, 20);
            this.tbDuration.TabIndex = 11;
            this.tbDuration.Text = "10";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 160);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbDuration);
            this.Controls.Add(this.btnCTBrowse);
            this.Controls.Add(this.btnAERBrowse);
            this.Controls.Add(this.btnHit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbURL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbSampleCT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbSampleAER);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNoOfThreads);
            this.Name = "MainForm";
            this.Text = "Multi Thread Hitter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNoOfThreads;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSampleAER;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSampleCT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbURL;
        private System.Windows.Forms.Button btnHit;
        private System.Windows.Forms.Button btnAERBrowse;
        private System.Windows.Forms.Button btnCTBrowse;
        private System.Windows.Forms.OpenFileDialog ofdMain;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbDuration;
    }
}

