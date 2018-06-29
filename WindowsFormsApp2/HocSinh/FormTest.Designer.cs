using System;

namespace WindowsFormsApp2
{
    partial class FormTest
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
            this.components = new System.ComponentModel.Container();
            this.metroLabelProgress = new MetroFramework.Controls.MetroLabel();
            this.metroLabelQuestion = new MetroFramework.Controls.MetroLabel();
            this.metroRadioButtonA = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButtonD = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButtonC = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButtonB = new MetroFramework.Controls.MetroRadioButton();
            this.metroButtonRestore = new MetroFramework.Controls.MetroButton();
            this.metroButtonNext = new MetroFramework.Controls.MetroButton();
            this.metroButtonPrevious = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroComboBoxQuestion = new MetroFramework.Controls.MetroComboBox();
            this.metroButtonFinish = new MetroFramework.Controls.MetroButton();
            this.groupBoxInterface = new System.Windows.Forms.GroupBox();
            this.metroLabelHint2 = new MetroFramework.Controls.MetroLabel();
            this.metroButtonSpoil = new MetroFramework.Controls.MetroButton();
            this.metroButtonHint = new MetroFramework.Controls.MetroButton();
            this.metroLabelHint = new MetroFramework.Controls.MetroLabel();
            this.metroButtonExit = new MetroFramework.Controls.MetroButton();
            this.metroLabelStat = new MetroFramework.Controls.MetroLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.metroLabelTimer = new MetroFramework.Controls.MetroLabel();
            this.status = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.lblTime = new MetroFramework.Controls.MetroLabel();
            this.lblDate = new MetroFramework.Controls.MetroLabel();
            this.lblTestId = new MetroFramework.Controls.MetroLabel();
            this.lblExamName = new MetroFramework.Controls.MetroLabel();
            this.groupBoxInterface.SuspendLayout();
            this.groupBoxInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabelProgress
            // 
            this.metroLabelProgress.AutoSize = true;
            this.metroLabelProgress.Location = new System.Drawing.Point(10, 221);
            this.metroLabelProgress.Name = "metroLabelProgress";
            this.metroLabelProgress.Size = new System.Drawing.Size(115, 19);
            this.metroLabelProgress.TabIndex = 11;
            this.metroLabelProgress.Text = "Đã hoàn thành _/_";
            // 
            // metroLabelQuestion
            // 
            this.metroLabelQuestion.AutoSize = true;
            this.metroLabelQuestion.Location = new System.Drawing.Point(118, 126);
            this.metroLabelQuestion.Name = "metroLabelQuestion";
            this.metroLabelQuestion.Size = new System.Drawing.Size(78, 19);
            this.metroLabelQuestion.TabIndex = 0;
            this.metroLabelQuestion.Text = "Placeholder";
            // 
            // metroRadioButtonA
            // 
            this.metroRadioButtonA.AutoSize = true;
            this.metroRadioButtonA.Location = new System.Drawing.Point(162, 207);
            this.metroRadioButtonA.Name = "metroRadioButtonA";
            this.metroRadioButtonA.Size = new System.Drawing.Size(34, 15);
            this.metroRadioButtonA.TabIndex = 1;
            this.metroRadioButtonA.TabStop = true;
            this.metroRadioButtonA.Text = "A.";
            this.metroRadioButtonA.UseSelectable = true;
            // 
            // metroRadioButtonD
            // 
            this.metroRadioButtonD.AutoSize = true;
            this.metroRadioButtonD.Location = new System.Drawing.Point(162, 270);
            this.metroRadioButtonD.Name = "metroRadioButtonD";
            this.metroRadioButtonD.Size = new System.Drawing.Size(34, 15);
            this.metroRadioButtonD.TabIndex = 2;
            this.metroRadioButtonD.TabStop = true;
            this.metroRadioButtonD.Text = "D.";
            this.metroRadioButtonD.UseSelectable = true;
            // 
            // metroRadioButtonC
            // 
            this.metroRadioButtonC.AutoSize = true;
            this.metroRadioButtonC.Location = new System.Drawing.Point(162, 249);
            this.metroRadioButtonC.Name = "metroRadioButtonC";
            this.metroRadioButtonC.Size = new System.Drawing.Size(34, 15);
            this.metroRadioButtonC.TabIndex = 3;
            this.metroRadioButtonC.TabStop = true;
            this.metroRadioButtonC.Text = "C.";
            this.metroRadioButtonC.UseSelectable = true;
            // 
            // metroRadioButtonB
            // 
            this.metroRadioButtonB.AutoSize = true;
            this.metroRadioButtonB.Location = new System.Drawing.Point(162, 228);
            this.metroRadioButtonB.Name = "metroRadioButtonB";
            this.metroRadioButtonB.Size = new System.Drawing.Size(33, 15);
            this.metroRadioButtonB.TabIndex = 4;
            this.metroRadioButtonB.TabStop = true;
            this.metroRadioButtonB.Text = "B.";
            this.metroRadioButtonB.UseSelectable = true;
            // 
            // metroButtonRestore
            // 
            this.metroButtonRestore.Location = new System.Drawing.Point(38, 427);
            this.metroButtonRestore.Name = "metroButtonRestore";
            this.metroButtonRestore.Size = new System.Drawing.Size(128, 32);
            this.metroButtonRestore.TabIndex = 5;
            this.metroButtonRestore.Text = "Khôi phục";
            this.metroButtonRestore.UseSelectable = true;
            this.metroButtonRestore.Click += new System.EventHandler(this.metroButtonRestore_Click);
            // 
            // metroButtonNext
            // 
            this.metroButtonNext.Location = new System.Drawing.Point(549, 376);
            this.metroButtonNext.Name = "metroButtonNext";
            this.metroButtonNext.Size = new System.Drawing.Size(64, 25);
            this.metroButtonNext.TabIndex = 6;
            this.metroButtonNext.Text = "Tiếp theo";
            this.metroButtonNext.UseSelectable = true;
            this.metroButtonNext.Click += new System.EventHandler(this.metroButtonNext_Click);
            // 
            // metroButtonPrevious
            // 
            this.metroButtonPrevious.Location = new System.Drawing.Point(231, 376);
            this.metroButtonPrevious.Name = "metroButtonPrevious";
            this.metroButtonPrevious.Size = new System.Drawing.Size(64, 25);
            this.metroButtonPrevious.TabIndex = 7;
            this.metroButtonPrevious.Text = "Quay lại";
            this.metroButtonPrevious.UseSelectable = true;
            this.metroButtonPrevious.Click += new System.EventHandler(this.metroButtonPrevious_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(304, 378);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(47, 19);
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "Đi đến";
            // 
            // metroComboBoxQuestion
            // 
            this.metroComboBoxQuestion.FormattingEnabled = true;
            this.metroComboBoxQuestion.ItemHeight = 23;
            this.metroComboBoxQuestion.Location = new System.Drawing.Point(354, 372);
            this.metroComboBoxQuestion.Name = "metroComboBoxQuestion";
            this.metroComboBoxQuestion.Size = new System.Drawing.Size(170, 29);
            this.metroComboBoxQuestion.TabIndex = 9;
            this.metroComboBoxQuestion.UseSelectable = true;
            this.metroComboBoxQuestion.SelectedIndexChanged += new System.EventHandler(this.metroComboBoxQuestion_SelectedIndexChanged);
            // 
            // metroButtonFinish
            // 
            this.metroButtonFinish.Location = new System.Drawing.Point(627, 427);
            this.metroButtonFinish.Name = "metroButtonFinish";
            this.metroButtonFinish.Size = new System.Drawing.Size(128, 32);
            this.metroButtonFinish.TabIndex = 10;
            this.metroButtonFinish.Text = "Hoàn thành";
            this.metroButtonFinish.UseSelectable = true;
            this.metroButtonFinish.Click += new System.EventHandler(this.metroButtonFinish_Click);
            // 
            // groupBoxInterface
            // 
            this.groupBoxInterface.Controls.Add(this.metroLabelHint2);
            this.groupBoxInterface.Controls.Add(this.metroButtonSpoil);
            this.groupBoxInterface.Controls.Add(this.metroButtonHint);
            this.groupBoxInterface.Controls.Add(this.metroLabelHint);
            this.groupBoxInterface.Controls.Add(this.metroButtonFinish);
            this.groupBoxInterface.Controls.Add(this.metroComboBoxQuestion);
            this.groupBoxInterface.Controls.Add(this.metroLabel1);
            this.groupBoxInterface.Controls.Add(this.metroButtonPrevious);
            this.groupBoxInterface.Controls.Add(this.metroButtonNext);
            this.groupBoxInterface.Controls.Add(this.metroButtonRestore);
            this.groupBoxInterface.Controls.Add(this.metroRadioButtonB);
            this.groupBoxInterface.Controls.Add(this.metroRadioButtonC);
            this.groupBoxInterface.Controls.Add(this.metroRadioButtonD);
            this.groupBoxInterface.Controls.Add(this.metroRadioButtonA);
            this.groupBoxInterface.Controls.Add(this.metroLabelQuestion);
            this.groupBoxInterface.Location = new System.Drawing.Point(395, 72);
            this.groupBoxInterface.Name = "groupBoxInterface";
            this.groupBoxInterface.Size = new System.Drawing.Size(779, 485);
            this.groupBoxInterface.TabIndex = 12;
            this.groupBoxInterface.TabStop = false;
            // 
            // metroLabelHint2
            // 
            this.metroLabelHint2.AutoSize = true;
            this.metroLabelHint2.Location = new System.Drawing.Point(162, 308);
            this.metroLabelHint2.Name = "metroLabelHint2";
            this.metroLabelHint2.Size = new System.Drawing.Size(78, 19);
            this.metroLabelHint2.TabIndex = 15;
            this.metroLabelHint2.Text = "placeholder";
            // 
            // metroButtonSpoil
            // 
            this.metroButtonSpoil.Location = new System.Drawing.Point(437, 427);
            this.metroButtonSpoil.Name = "metroButtonSpoil";
            this.metroButtonSpoil.Size = new System.Drawing.Size(128, 32);
            this.metroButtonSpoil.TabIndex = 14;
            this.metroButtonSpoil.Text = "Hiện đáp án";
            this.metroButtonSpoil.UseSelectable = true;
            this.metroButtonSpoil.Click += new System.EventHandler(this.metroButtonSpoil_Click);
            // 
            // metroButtonHint
            // 
            this.metroButtonHint.Location = new System.Drawing.Point(240, 427);
            this.metroButtonHint.Name = "metroButtonHint";
            this.metroButtonHint.Size = new System.Drawing.Size(128, 32);
            this.metroButtonHint.TabIndex = 13;
            this.metroButtonHint.Text = "Hiện gợi ý";
            this.metroButtonHint.UseSelectable = true;
            this.metroButtonHint.Click += new System.EventHandler(this.metroButtonHint_Click);
            // 
            // metroLabelHint
            // 
            this.metroLabelHint.AutoSize = true;
            this.metroLabelHint.Location = new System.Drawing.Point(118, 308);
            this.metroLabelHint.Name = "metroLabelHint";
            this.metroLabelHint.Size = new System.Drawing.Size(46, 19);
            this.metroLabelHint.TabIndex = 12;
            this.metroLabelHint.Text = "Gợi ý: ";
            // 
            // metroButtonExit
            // 
            this.metroButtonExit.Location = new System.Drawing.Point(1046, 570);
            this.metroButtonExit.Name = "metroButtonExit";
            this.metroButtonExit.Size = new System.Drawing.Size(128, 32);
            this.metroButtonExit.TabIndex = 13;
            this.metroButtonExit.Text = "Thoát";
            this.metroButtonExit.UseSelectable = true;
            this.metroButtonExit.Click += new System.EventHandler(this.metroButtonExit_Click);
            // 
            // metroLabelStat
            // 
            this.metroLabelStat.AutoSize = true;
            this.metroLabelStat.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelStat.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabelStat.Location = new System.Drawing.Point(521, 50);
            this.metroLabelStat.Name = "metroLabelStat";
            this.metroLabelStat.Size = new System.Drawing.Size(137, 25);
            this.metroLabelStat.TabIndex = 14;
            this.metroLabelStat.Text = "Bảng thống kê";
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            // 
            // metroLabelTimer
            // 
            this.metroLabelTimer.AutoSize = true;
            this.metroLabelTimer.Location = new System.Drawing.Point(164, 179);
            this.metroLabelTimer.Name = "metroLabelTimer";
            this.metroLabelTimer.Size = new System.Drawing.Size(40, 19);
            this.metroLabelTimer.TabIndex = 12;
            this.metroLabelTimer.Text = "timer";
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(363, 583);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(27, 19);
            this.status.TabIndex = 15;
            this.status.Text = "___";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(297, 583);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(69, 19);
            this.metroLabel2.TabIndex = 16;
            this.metroLabel2.Text = "Trạng thái:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(6, 175);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(158, 25);
            this.metroLabel3.TabIndex = 17;
            this.metroLabel3.Text = "Thời gian còn lại:";
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.Controls.Add(this.lblTime);
            this.groupBoxInfo.Controls.Add(this.metroLabel3);
            this.groupBoxInfo.Controls.Add(this.lblDate);
            this.groupBoxInfo.Controls.Add(this.lblTestId);
            this.groupBoxInfo.Controls.Add(this.metroLabelProgress);
            this.groupBoxInfo.Controls.Add(this.lblExamName);
            this.groupBoxInfo.Controls.Add(this.metroLabelTimer);
            this.groupBoxInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxInfo.Location = new System.Drawing.Point(23, 70);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Size = new System.Drawing.Size(366, 487);
            this.groupBoxInfo.TabIndex = 18;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "Thông tin";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(10, 147);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(83, 19);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "metroLabel8";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(10, 115);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(83, 19);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "metroLabel7";
            // 
            // lblTestId
            // 
            this.lblTestId.AutoSize = true;
            this.lblTestId.Location = new System.Drawing.Point(10, 84);
            this.lblTestId.Name = "lblTestId";
            this.lblTestId.Size = new System.Drawing.Size(83, 19);
            this.lblTestId.TabIndex = 1;
            this.lblTestId.Text = "metroLabel6";
            // 
            // lblExamName
            // 
            this.lblExamName.AutoSize = true;
            this.lblExamName.Location = new System.Drawing.Point(10, 51);
            this.lblExamName.Name = "lblExamName";
            this.lblExamName.Size = new System.Drawing.Size(83, 19);
            this.lblExamName.TabIndex = 0;
            this.lblExamName.Text = "metroLabel5";
            // 
            // FormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(1203, 611);
            this.Controls.Add(this.groupBoxInfo);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.status);
            this.Controls.Add(this.metroLabelStat);
            this.Controls.Add(this.metroButtonExit);
            this.Controls.Add(this.groupBoxInterface);
            this.Name = "FormTest";
            this.Text = "Bài thi";
            this.groupBoxInterface.ResumeLayout(false);
            this.groupBoxInterface.PerformLayout();
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion
        private MetroFramework.Controls.MetroLabel metroLabelProgress;
        private MetroFramework.Controls.MetroLabel metroLabelQuestion;
        private MetroFramework.Controls.MetroRadioButton metroRadioButtonA;
        private MetroFramework.Controls.MetroRadioButton metroRadioButtonD;
        private MetroFramework.Controls.MetroRadioButton metroRadioButtonC;
        private MetroFramework.Controls.MetroRadioButton metroRadioButtonB;
        private MetroFramework.Controls.MetroButton metroButtonRestore;
        private MetroFramework.Controls.MetroButton metroButtonNext;
        private MetroFramework.Controls.MetroButton metroButtonPrevious;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox metroComboBoxQuestion;
        private MetroFramework.Controls.MetroButton metroButtonFinish;
        private System.Windows.Forms.GroupBox groupBoxInterface;
        private MetroFramework.Controls.MetroButton metroButtonExit;
        private MetroFramework.Controls.MetroLabel metroLabelStat;
        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroLabel metroLabelTimer;
        private MetroFramework.Controls.MetroButton metroButtonSpoil;
        private MetroFramework.Controls.MetroButton metroButtonHint;
        private MetroFramework.Controls.MetroLabel metroLabelHint;
        private MetroFramework.Controls.MetroLabel metroLabelHint2;
        private MetroFramework.Controls.MetroLabel status;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.GroupBox groupBoxInfo;
        private MetroFramework.Controls.MetroLabel lblTime;
        private MetroFramework.Controls.MetroLabel lblDate;
        private MetroFramework.Controls.MetroLabel lblTestId;
        private MetroFramework.Controls.MetroLabel lblExamName;
    }
}