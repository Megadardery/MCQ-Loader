namespace MCQ_Loader
{
	partial class frmMain
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
            this.lblQuestion = new System.Windows.Forms.Label();
            this.rdbAnswerA = new System.Windows.Forms.RadioButton();
            this.rdbAnswerB = new System.Windows.Forms.RadioButton();
            this.rdbAnswerC = new System.Windows.Forms.RadioButton();
            this.rdbAnswerD = new System.Windows.Forms.RadioButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(45, 52);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(1052, 76);
            this.lblQuestion.TabIndex = 2;
            this.lblQuestion.Text = "lblQuestion";
            // 
            // rdbAnswerA
            // 
            this.rdbAnswerA.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAnswerA.Location = new System.Drawing.Point(96, 131);
            this.rdbAnswerA.Name = "rdbAnswerA";
            this.rdbAnswerA.Size = new System.Drawing.Size(960, 55);
            this.rdbAnswerA.TabIndex = 3;
            this.rdbAnswerA.TabStop = true;
            this.rdbAnswerA.Text = "rdbAnswerA";
            this.rdbAnswerA.UseVisualStyleBackColor = true;
            // 
            // rdbAnswerB
            // 
            this.rdbAnswerB.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAnswerB.Location = new System.Drawing.Point(96, 192);
            this.rdbAnswerB.Name = "rdbAnswerB";
            this.rdbAnswerB.Size = new System.Drawing.Size(960, 55);
            this.rdbAnswerB.TabIndex = 4;
            this.rdbAnswerB.TabStop = true;
            this.rdbAnswerB.Text = "rdbAnswerB";
            this.rdbAnswerB.UseVisualStyleBackColor = true;
            // 
            // rdbAnswerC
            // 
            this.rdbAnswerC.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAnswerC.Location = new System.Drawing.Point(96, 253);
            this.rdbAnswerC.Name = "rdbAnswerC";
            this.rdbAnswerC.Size = new System.Drawing.Size(960, 55);
            this.rdbAnswerC.TabIndex = 5;
            this.rdbAnswerC.TabStop = true;
            this.rdbAnswerC.Text = "rdbAnswerC";
            this.rdbAnswerC.UseVisualStyleBackColor = true;
            // 
            // rdbAnswerD
            // 
            this.rdbAnswerD.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAnswerD.Location = new System.Drawing.Point(96, 314);
            this.rdbAnswerD.Name = "rdbAnswerD";
            this.rdbAnswerD.Size = new System.Drawing.Size(960, 55);
            this.rdbAnswerD.TabIndex = 6;
            this.rdbAnswerD.TabStop = true;
            this.rdbAnswerD.Text = "rdbAnswerD";
            this.rdbAnswerD.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(118, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Question:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(991, 9);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(106, 31);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "## of ##";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(922, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 57);
            this.button1.TabIndex = 7;
            this.button1.Text = "Check Answer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 447);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.rdbAnswerD);
            this.Controls.Add(this.rdbAnswerC);
            this.Controls.Add(this.rdbAnswerB);
            this.Controls.Add(this.rdbAnswerA);
            this.Controls.Add(this.lblQuestion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MCQ Loader";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblQuestion;
		private System.Windows.Forms.RadioButton rdbAnswerA;
		private System.Windows.Forms.RadioButton rdbAnswerB;
		private System.Windows.Forms.RadioButton rdbAnswerC;
		private System.Windows.Forms.RadioButton rdbAnswerD;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Label lblID;
		private System.Windows.Forms.Button button1;
	}
}

