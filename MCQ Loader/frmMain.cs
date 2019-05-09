using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace MCQ_Loader
{
	public partial class frmMain : Form
	{
		DataTable questionsTable = new DataTable();
		int curr = -1;
		int correct = -1;
		int correctAnswers = 0;
		int questionsCount;
		List<int> mycorrects = new List<int>();
		public frmMain()
		{
			InitializeComponent();
			this.Icon = MCQ_Loader.Properties.Resources.MyIcon;
		}

		private void RandomizeTable()
		{
			DataView myview;
			var generator = new Random();
			questionsCount = questionsTable.Rows.Count;
			for (int i = 0; i < questionsCount; i++)
			{
				questionsTable.Rows[i]["RandomValues"] = generator.Next(questionsCount);
			}
			myview = questionsTable.DefaultView;
			myview.Sort = "RandomValues";
			questionsTable = myview.ToTable();

			myview.Dispose();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			var myconnection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Questions.dat;");
			var myadapter = new OleDbDataAdapter("Select * FROM questions", myconnection);
			try
			{
				myconnection.Open();

				
				myadapter.Fill(questionsTable);

				questionsTable.Columns.Add(new DataColumn("RandomValues", typeof(int)));
				RandomizeTable();

				fetchNextQuestion();

			}
			catch
			{
				MessageBox.Show("Couldn't establish connection with the questions database, Management MCQs is exiting...", "Connection not initialized", MessageBoxButtons.OK, MessageBoxIcon.Stop);
				Application.ExitThread();
			}
			finally
			{
				myconnection.Close();
				myconnection.Dispose();
				myadapter.Dispose();
			}
		}
		void fetchNextQuestion() 
		{
			curr++;
			if (curr >= questionsCount)
			{
				int percent = (int)(correctAnswers * 100 / (float)questionsCount);
				string message = string.Format("You have answered {0} out of {1} questions correctly.\nYour percentage score is {2}%.", correctAnswers.ToString(), questionsCount.ToString(), percent.ToString());

				for (int i = mycorrects.Count - 1; i >= 0; i--)
				{
					questionsTable.Rows.RemoveAt(mycorrects[i]);
				}
				RandomizeTable();
				mycorrects.Clear();
				questionsCount = questionsTable.Rows.Count;

				if (questionsCount <= 0) { 
					MessageBox.Show(message + "\n\nThank you for using this app! Have a nice day!","Out of questions",MessageBoxButtons.OK,MessageBoxIcon.Information);
					curr = 0;
					Application.ExitThread();
					return;
				}
				else
				{
					correctAnswers = 0;
					curr = 0;
					MessageBox.Show(message + string.Format("\n\nYou have failed to answer {0} questions, these questions will be shown again.",questionsCount), "All questions answered", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			lblQuestion.Text = questionsTable.Rows[curr][1].ToString();
			lblID.Text = string.Concat(curr + 1, " of ", questionsCount);

			var rng = new Random();
			var answers = new List<string>();
			answers.Add(questionsTable.Rows[curr][2].ToString());
			answers.Add(questionsTable.Rows[curr][3].ToString());
			answers.Add(questionsTable.Rows[curr][4].ToString());
			answers.Add(questionsTable.Rows[curr][5].ToString());

			bool set = false;
			int n = 4;
			while (n > 1)
			{
				n--;
				int k = rng.Next(n + 1);
				if (k == 0 && set==false)
				{
					correct = n;
					set = true;
				}
				string value = answers[k];
				answers[k] = answers[n];
				answers[n] = value;
			}
			if (set == false) correct = 0;
			rdbAnswerA.Text = answers[0]; rdbAnswerA.Checked=false;
			rdbAnswerB.Text = answers[1]; rdbAnswerB.Checked=false;
			rdbAnswerC.Text = answers[2]; rdbAnswerC.Checked=false;
			rdbAnswerD.Text = answers[3]; rdbAnswerD.Checked=false;


		}
		private void button1_Click(object sender, EventArgs e)
		{
			if ((rdbAnswerA.Checked && correct == 0) ||
				(rdbAnswerB.Checked && correct == 1) ||
				(rdbAnswerC.Checked && correct == 2) ||
				(rdbAnswerD.Checked && correct == 3)
				)
			{
				mycorrects.Add(curr);
				correctAnswers++;
				fetchNextQuestion();
			}
			else
			{
				MessageBox.Show("Incorrect Answer! The correct answer is: " + "abcd"[correct], "Incorrect Answer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				fetchNextQuestion();
			}

		}

		private void frmMain_Shown(object sender, EventArgs e)
		{
			rdbAnswerA.Checked = false;
		}
	
	}
}
