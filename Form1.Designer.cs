
namespace Mail_o_bot
{
    partial class MailBot
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
            this.StartStop = new System.Windows.Forms.Button();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.DstName = new System.Windows.Forms.TextBox();
            this.SrcName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BodyPatterns = new System.Windows.Forms.TextBox();
            this.ChangeLogs = new System.Windows.Forms.TextBox();
            this.Appeal = new System.Windows.Forms.ComboBox();
            this.AppealLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Introduce = new System.Windows.Forms.ComboBox();
            this.Body = new System.Windows.Forms.TextBox();
            this.Generate = new System.Windows.Forms.Button();
            this.Send = new System.Windows.Forms.Button();
            this.AllowEditBodyPatterns = new System.Windows.Forms.CheckBox();
            this.AllowEditResult = new System.Windows.Forms.CheckBox();
            this.AllowEditChangelogs = new System.Windows.Forms.CheckBox();
            this.DestinationAddressLabel = new System.Windows.Forms.Label();
            this.DstAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SrcAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SrcPswd = new System.Windows.Forms.TextBox();
            this.Subject = new System.Windows.Forms.TextBox();
            this.AllowEditSubject = new System.Windows.Forms.CheckBox();
            this.NextEmailTime = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SubjectPatterns = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // StartStop
            // 
            this.StartStop.Location = new System.Drawing.Point(271, 115);
            this.StartStop.Name = "StartStop";
            this.StartStop.Size = new System.Drawing.Size(82, 23);
            this.StartStop.TabIndex = 0;
            this.StartStop.Text = "Start service";
            this.StartStop.UseVisualStyleBackColor = true;
            this.StartStop.Click += new System.EventHandler(this.StartStop_Click);
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(498, 447);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(0, 15);
            this.StatusLabel.TabIndex = 1;
            // 
            // DstName
            // 
            this.DstName.Location = new System.Drawing.Point(131, 71);
            this.DstName.Name = "DstName";
            this.DstName.Size = new System.Drawing.Size(113, 23);
            this.DstName.TabIndex = 4;
            // 
            // SrcName
            // 
            this.SrcName.Location = new System.Drawing.Point(12, 115);
            this.SrcName.Name = "SrcName";
            this.SrcName.Size = new System.Drawing.Size(113, 23);
            this.SrcName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Destination name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Source name:";
            // 
            // BodyPatterns
            // 
            this.BodyPatterns.Location = new System.Drawing.Point(12, 257);
            this.BodyPatterns.Multiline = true;
            this.BodyPatterns.Name = "BodyPatterns";
            this.BodyPatterns.Size = new System.Drawing.Size(776, 128);
            this.BodyPatterns.TabIndex = 8;
            // 
            // ChangeLogs
            // 
            this.ChangeLogs.Location = new System.Drawing.Point(12, 416);
            this.ChangeLogs.Multiline = true;
            this.ChangeLogs.Name = "ChangeLogs";
            this.ChangeLogs.Size = new System.Drawing.Size(776, 128);
            this.ChangeLogs.TabIndex = 10;
            // 
            // Appeal
            // 
            this.Appeal.FormattingEnabled = true;
            this.Appeal.Location = new System.Drawing.Point(250, 27);
            this.Appeal.Name = "Appeal";
            this.Appeal.Size = new System.Drawing.Size(103, 23);
            this.Appeal.TabIndex = 13;
            // 
            // AppealLabel
            // 
            this.AppealLabel.AutoSize = true;
            this.AppealLabel.Location = new System.Drawing.Point(250, 9);
            this.AppealLabel.Name = "AppealLabel";
            this.AppealLabel.Size = new System.Drawing.Size(49, 15);
            this.AppealLabel.TabIndex = 14;
            this.AppealLabel.Text = "Appeal?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(250, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "Introduce?";
            // 
            // Introduce
            // 
            this.Introduce.FormattingEnabled = true;
            this.Introduce.Location = new System.Drawing.Point(250, 71);
            this.Introduce.Name = "Introduce";
            this.Introduce.Size = new System.Drawing.Size(103, 23);
            this.Introduce.TabIndex = 15;
            // 
            // Body
            // 
            this.Body.Location = new System.Drawing.Point(12, 629);
            this.Body.Multiline = true;
            this.Body.Name = "Body";
            this.Body.Size = new System.Drawing.Size(776, 128);
            this.Body.TabIndex = 17;
            // 
            // Generate
            // 
            this.Generate.Location = new System.Drawing.Point(131, 115);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(68, 23);
            this.Generate.TabIndex = 19;
            this.Generate.Text = "Generate";
            this.Generate.UseVisualStyleBackColor = true;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(205, 115);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(60, 23);
            this.Send.TabIndex = 20;
            this.Send.Text = "Send";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // AllowEditBodyPatterns
            // 
            this.AllowEditBodyPatterns.AutoSize = true;
            this.AllowEditBodyPatterns.Location = new System.Drawing.Point(12, 232);
            this.AllowEditBodyPatterns.Name = "AllowEditBodyPatterns";
            this.AllowEditBodyPatterns.Size = new System.Drawing.Size(122, 19);
            this.AllowEditBodyPatterns.TabIndex = 21;
            this.AllowEditBodyPatterns.Text = "Edit body patterns";
            this.AllowEditBodyPatterns.UseVisualStyleBackColor = true;
            this.AllowEditBodyPatterns.CheckStateChanged += new System.EventHandler(this.AllowEditPatterns_CheckStateChanged);
            // 
            // AllowEditResult
            // 
            this.AllowEditResult.AutoSize = true;
            this.AllowEditResult.Location = new System.Drawing.Point(12, 604);
            this.AllowEditResult.Name = "AllowEditResult";
            this.AllowEditResult.Size = new System.Drawing.Size(76, 19);
            this.AllowEditResult.TabIndex = 22;
            this.AllowEditResult.Text = "Edit body";
            this.AllowEditResult.UseVisualStyleBackColor = true;
            this.AllowEditResult.CheckStateChanged += new System.EventHandler(this.AllowEditResult_CheckStateChanged);
            // 
            // AllowEditChangelogs
            // 
            this.AllowEditChangelogs.AutoSize = true;
            this.AllowEditChangelogs.Location = new System.Drawing.Point(12, 391);
            this.AllowEditChangelogs.Name = "AllowEditChangelogs";
            this.AllowEditChangelogs.Size = new System.Drawing.Size(110, 19);
            this.AllowEditChangelogs.TabIndex = 23;
            this.AllowEditChangelogs.Text = "Edit changelogs";
            this.AllowEditChangelogs.UseVisualStyleBackColor = true;
            this.AllowEditChangelogs.CheckStateChanged += new System.EventHandler(this.AllowEditChangelogs_CheckStateChanged);
            // 
            // DestinationAddressLabel
            // 
            this.DestinationAddressLabel.AutoSize = true;
            this.DestinationAddressLabel.Location = new System.Drawing.Point(131, 9);
            this.DestinationAddressLabel.Name = "DestinationAddressLabel";
            this.DestinationAddressLabel.Size = new System.Drawing.Size(113, 15);
            this.DestinationAddressLabel.TabIndex = 25;
            this.DestinationAddressLabel.Text = "Destination address:";
            // 
            // DstAddress
            // 
            this.DstAddress.Location = new System.Drawing.Point(131, 27);
            this.DstAddress.Name = "DstAddress";
            this.DstAddress.Size = new System.Drawing.Size(113, 23);
            this.DstAddress.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 15);
            this.label3.TabIndex = 27;
            this.label3.Text = "Source address:";
            // 
            // SrcAddress
            // 
            this.SrcAddress.Location = new System.Drawing.Point(12, 27);
            this.SrcAddress.Name = "SrcAddress";
            this.SrcAddress.Size = new System.Drawing.Size(113, 23);
            this.SrcAddress.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 15);
            this.label4.TabIndex = 29;
            this.label4.Text = "Source password:";
            // 
            // SrcPswd
            // 
            this.SrcPswd.Location = new System.Drawing.Point(12, 71);
            this.SrcPswd.Name = "SrcPswd";
            this.SrcPswd.Size = new System.Drawing.Size(113, 23);
            this.SrcPswd.TabIndex = 28;
            // 
            // Subject
            // 
            this.Subject.Location = new System.Drawing.Point(12, 575);
            this.Subject.Name = "Subject";
            this.Subject.Size = new System.Drawing.Size(776, 23);
            this.Subject.TabIndex = 33;
            // 
            // AllowEditSubject
            // 
            this.AllowEditSubject.AutoSize = true;
            this.AllowEditSubject.Location = new System.Drawing.Point(12, 550);
            this.AllowEditSubject.Name = "AllowEditSubject";
            this.AllowEditSubject.Size = new System.Drawing.Size(87, 19);
            this.AllowEditSubject.TabIndex = 32;
            this.AllowEditSubject.Text = "Edit subject";
            this.AllowEditSubject.UseVisualStyleBackColor = true;
            this.AllowEditSubject.CheckStateChanged += new System.EventHandler(this.AllowEditSubject_CheckStateChanged);
            // 
            // NextEmailTime
            // 
            this.NextEmailTime.AutoSize = true;
            this.NextEmailTime.Location = new System.Drawing.Point(182, 145);
            this.NextEmailTime.Name = "NextEmailTime";
            this.NextEmailTime.Size = new System.Drawing.Size(93, 15);
            this.NextEmailTime.TabIndex = 34;
            this.NextEmailTime.Text = "Next E-mail at ...";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 144);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(133, 19);
            this.checkBox1.TabIndex = 36;
            this.checkBox1.Text = "Edit subject patterns";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // SubjectPatterns
            // 
            this.SubjectPatterns.Location = new System.Drawing.Point(12, 169);
            this.SubjectPatterns.Multiline = true;
            this.SubjectPatterns.Name = "SubjectPatterns";
            this.SubjectPatterns.Size = new System.Drawing.Size(776, 57);
            this.SubjectPatterns.TabIndex = 35;
            // 
            // MailBot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 769);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.SubjectPatterns);
            this.Controls.Add(this.NextEmailTime);
            this.Controls.Add(this.Subject);
            this.Controls.Add(this.AllowEditSubject);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SrcPswd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SrcAddress);
            this.Controls.Add(this.DestinationAddressLabel);
            this.Controls.Add(this.DstAddress);
            this.Controls.Add(this.AllowEditChangelogs);
            this.Controls.Add(this.AllowEditResult);
            this.Controls.Add(this.AllowEditBodyPatterns);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.Generate);
            this.Controls.Add(this.Body);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Introduce);
            this.Controls.Add(this.AppealLabel);
            this.Controls.Add(this.Appeal);
            this.Controls.Add(this.ChangeLogs);
            this.Controls.Add(this.BodyPatterns);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SrcName);
            this.Controls.Add(this.DstName);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.StartStop);
            this.Name = "MailBot";
            this.Text = "Mail\'o\'bot";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MailBot_FormClosing);
            this.Shown += new System.EventHandler(this.MailBot_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartStop;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.TextBox DstName;
        private System.Windows.Forms.TextBox SrcName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox BodyPatterns;
        private System.Windows.Forms.TextBox ChangeLogs;
        private System.Windows.Forms.ComboBox Appeal;
        private System.Windows.Forms.Label AppealLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Introduce;
        private System.Windows.Forms.TextBox Body;
        private System.Windows.Forms.Button Generate;
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.CheckBox AllowEditBodyPatterns;
        private System.Windows.Forms.CheckBox AllowEditResult;
        private System.Windows.Forms.CheckBox AllowEditChangelogs;
        private System.Windows.Forms.Label DestinationAddressLabel;
        private System.Windows.Forms.TextBox DstAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SrcAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SrcPswd;
        private System.Windows.Forms.TextBox Subject;
        private System.Windows.Forms.CheckBox AllowEditSubject;
        private System.Windows.Forms.Label NextEmailTime;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox SubjectPatterns;
    }
}

