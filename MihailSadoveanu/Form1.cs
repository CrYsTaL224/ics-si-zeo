/*
 * Created by SharpDevelop.
 * Developer:Anoop Kumar Sharma
 * Date: 9/3/2013
 * Time: 12:37 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MihailSadoveanu
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class Form1 : Form
	{
		public Form1()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();

			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		int turn = 1;
		int click1 = 0, click2 = 0, click3 = 0, click4 = 0, click5 = 0, click6 = 0, click7 = 0, click8 = 0, click9 = 0;
		int player1 = 0, player2 = 0;

		void Button1Click(object sender, EventArgs e)
		{ }

		void Button2Click(object sender, EventArgs e)
		{ }

		void Button3_Click(object sender, EventArgs e)
		{
			
		}

		void Button4Click(object sender, EventArgs e)
		{
			
		}

		void Button5Click(object sender, EventArgs e)
		{
			
		}

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
		{
			if (click1 == 0)
			{
				if (turn % 2 != 0)
				{
					Button1.Text = "X";
					click1++;
				}
				else
				{
					Button1.Text = "O";
					click1++;
				}
				turn++;
			}
			else
			{
				Button1.Text = Button1.Text;
			}
			display();
			checkit();

		}

		private void Button3_Click_1(object sender, EventArgs e)
        {
			if (click3 == 0)
			{
				if (turn % 2 != 0)
				{
					Button3.Text = "X";
					click3++;
				}
				else
				{
					Button3.Text = "O";
					click3++;
				}
				turn++;
			}
			else
			{
				Button3.Text = Button3.Text;
			}
			display();
			checkit();
		}

        private void Button2_Click(object sender, EventArgs e)
        {
			{
				if (click2 == 0)
				{
					if (turn % 2 != 0)
					{
						Button2.Text = "X";
						click2++;
					}
					else
					{
						Button2.Text = "O";
						click2++;
					}
					turn++;
				}
				else
				{
					Button2.Text = Button2.Text;
				}
				display();
				checkit();
			}
		}

        private void Button4_Click(object sender, EventArgs e)
        {
			if (click4 == 0)
			{
				if (turn % 2 != 0)
				{
					Button4.Text = "X";
					click4++;
				}
				else
				{
					Button4.Text = "O";
					click4++;
				}
				turn++;
			}
			else
			{
				Button4.Text = Button4.Text;
			}
			display();
			checkit();
		}

        private void Button5_Click(object sender, EventArgs e)
        {
			if (click5 == 0)
			{
				if (turn % 2 != 0)
				{
					Button5.Text = "X";
					click5++;
				}
				else
				{
					Button5.Text = "O";
					click5++;
				}
				turn++;
			}
			else
			{
				Button5.Text = Button5.Text;
			}
			display();
			checkit();
		}

        private void Button6_Click(object sender, EventArgs e)
        {
			if (click6 == 0)
			{
				if (turn % 2 != 0)
				{
					Button6.Text = "X";
					click6++;
				}
				else
				{
					Button6.Text = "O";
					click6++;
				}
				turn++;
			}
			else
			{
				Button6.Text = Button6.Text;
			}
			display();
			checkit();
		}

        private void Button7_Click(object sender, EventArgs e)
        {
			if (click7 == 0)
			{
				if (turn % 2 != 0)
				{
					Button7.Text = "X";
					click7++;
				}
				else
				{
					Button7.Text = "O";
					click7++;
				}
				turn++;
			}
			else
			{
				Button7.Text = Button7.Text;
			}
			display();
			checkit();
		}

        private void Button8_Click(object sender, EventArgs e)
        {
			if (click8 == 0)
			{
				if (turn % 2 != 0)
				{
					Button8.Text = "X";
					click8++;
				}
				else
				{
					Button8.Text = "O";
					click8++;
				}
				turn++;
			}
			else
			{
				Button8.Text = Button8.Text;
			}
			display();
			checkit();
		}

        private void Button9_Click(object sender, EventArgs e)
        {
			if (click9 == 0)
			{
				if (turn % 2 != 0)
				{
					Button9.Text = "X";
					click9++;
				}
				else
				{
					Button9.Text = "O";
					click9++;
				}
				turn++;
			}
			else
			{
				Button9.Text = Button9.Text;
			}
			display();
			checkit();
		}



        void Button6Click(object sender, EventArgs e)
		{
			
		}



        void Button7Click(object sender, EventArgs e)
		{
			
		}

		void Button8Click(object sender, EventArgs e)
		{
			
		}

        private void Form1_Load(object sender, EventArgs e)
        {
			
        }

        void Button9Click(object sender, EventArgs e)
		{
			
		}
		public void display()
		{
			if (turn % 2 != 0)
			{
				displayturn.Text = "Primul Jucător";
			}
			else
			{
				displayturn.Text = "Al Doi-lea Jucător";
			}
		}
		public void checkit()
		{
			if (Button1.Text != "" && Button2.Text != "" && Button3.Text != "")
			{
				if (Button1.Text == Button2.Text && Button1.Text == Button3.Text)
				{
					Button1.BackColor = Color.Green;
					Button1.ForeColor = Color.White;
					Button2.BackColor = Color.Green;
					Button2.ForeColor = Color.White;
					Button3.BackColor = Color.Green;
					Button3.ForeColor = Color.White;
					if (Button1.Text == "X")
					{
						MessageBox.Show("Player 1 Wins!");
						player1++;
						player1score.Text = player1.ToString();
					}
					else
					{
						MessageBox.Show("Player 2 Wins!");
						player2++;
						player2score.Text = player2.ToString();
					}
					cleargame();

				}
			}
			if (Button4.Text != "" && Button5.Text != "" && Button6.Text != "")
			{
				if (Button4.Text == Button5.Text && Button4.Text == Button6.Text)
				{
					Button4.BackColor = Color.Green;
					Button4.ForeColor = Color.White;
					Button5.BackColor = Color.Green;
					Button5.ForeColor = Color.White;
					Button6.BackColor = Color.Green;
					Button6.ForeColor = Color.White;
					if (Button4.Text == "X")
					{
						MessageBox.Show("Player 1 Wins!");
						player1++;
						player1score.Text = player1.ToString();

					}
					else
					{
						MessageBox.Show("Player 2 Wins!");
						player2++;
						player2score.Text = player2.ToString();

					}
					cleargame();
				}
			}
			if (Button7.Text != "" && Button8.Text != "" && Button9.Text != "")
			{
				if (Button7.Text == Button8.Text && Button7.Text == Button9.Text)
				{
					Button7.BackColor = Color.Green;
					Button7.ForeColor = Color.White;
					Button8.BackColor = Color.Green;
					Button8.ForeColor = Color.White;
					Button9.BackColor = Color.Green;
					Button9.ForeColor = Color.White;
					if (Button7.Text == "X")
					{
						MessageBox.Show("Player 1 Wins!");
						player1++;
						player1score.Text = player1.ToString();

					}
					else
					{
						MessageBox.Show("Player 2 Wins!");
						player2++;
						player2score.Text = player2.ToString();

					}
					cleargame();
				}
			}
			if (Button1.Text != "" && Button4.Text != "" && Button7.Text != "")
			{
				if (Button1.Text == Button4.Text && Button1.Text == Button7.Text)
				{
					Button1.BackColor = Color.Green;
					Button1.ForeColor = Color.White;
					Button4.BackColor = Color.Green;
					Button4.ForeColor = Color.White;
					Button7.BackColor = Color.Green;
					Button7.ForeColor = Color.White;
					if (Button1.Text == "X")
					{
						MessageBox.Show("Player 1 Wins!");
						player1++;
						player1score.Text = player1.ToString();

					}
					else
					{
						MessageBox.Show("Player 2 Wins!");
						player2++;
						player2score.Text = player2.ToString();

					}
					cleargame();
				}
			}
			if (Button2.Text != "" && Button5.Text != "" && Button8.Text != "")
			{
				if (Button2.Text == Button5.Text && Button2.Text == Button8.Text)
				{
					Button2.BackColor = Color.Green;
					Button2.ForeColor = Color.White;
					Button5.BackColor = Color.Green;
					Button5.ForeColor = Color.White;
					Button8.BackColor = Color.Green;
					Button8.ForeColor = Color.White;
					if (Button2.Text == "X")
					{
						MessageBox.Show("Player 1 Wins!");
						player1++;
						player1score.Text = player1.ToString();

					}
					else
					{
						MessageBox.Show("Player 2 Wins!");
						player2++;
						player2score.Text = player2.ToString();

					}
					cleargame();
				}
			}
			if (Button3.Text != "" && Button6.Text != "" && Button9.Text != "")
			{
				if (Button3.Text == Button6.Text && Button3.Text == Button9.Text)
				{
					Button3.BackColor = Color.Green;
					Button3.ForeColor = Color.White;
					Button6.BackColor = Color.Green;
					Button6.ForeColor = Color.White;
					Button9.BackColor = Color.Green;
					Button9.ForeColor = Color.White;
					if (Button3.Text == "X")
					{
						MessageBox.Show("Player 1 Wins!");
						player1++;
						player1score.Text = player1.ToString();

					}
					else
					{
						MessageBox.Show("Player 2 Wins!");
						player2++;
						player2score.Text = player2.ToString();

					}
					cleargame();
				}
			}
			if (Button1.Text != "" && Button5.Text != "" && Button9.Text != "")
			{
				if (Button1.Text == Button5.Text && Button1.Text == Button9.Text)
				{
					Button1.BackColor = Color.Green;
					Button1.ForeColor = Color.White;
					Button5.BackColor = Color.Green;
					Button5.ForeColor = Color.White;
					Button9.BackColor = Color.Green;
					Button9.ForeColor = Color.White;
					if (Button1.Text == "X")
					{
						MessageBox.Show("Player 1 Wins!");
						player1++;
						player1score.Text = player1.ToString();

					}
					else
					{
						MessageBox.Show("Player 2 Wins!");
						player2++;
						player2score.Text = player2.ToString();

					}
					cleargame();
				}
			}
			if (Button3.Text != "" && Button5.Text != "" && Button7.Text != "")
			{
				if (Button3.Text == Button5.Text && Button3.Text == Button7.Text)
				{
					Button3.BackColor = Color.Green;
					Button3.ForeColor = Color.White;
					Button5.BackColor = Color.Green;
					Button5.ForeColor = Color.White;
					Button7.BackColor = Color.Green;
					Button7.ForeColor = Color.White;
					if (Button3.Text == "X")
					{
						MessageBox.Show("Player 1 Wins!");
						player1++;
						player1score.Text = player1.ToString();

					}
					else
					{
						MessageBox.Show("Player 2 Wins!");
						player2++;
						player2score.Text = player2.ToString();

					}
					cleargame();
				}
			}
		}
		public void cleargame()
		{
			displayturn.Text = "Primul Jucător";
			turn = 1;
			click1 = 0; click2 = 0; click3 = 0; click4 = 0; click5 = 0; click6 = 0; click7 = 0; click8 = 0; click9 = 0;
			Button1.Text = "";
			Button2.Text = "";
			Button3.Text = "";
			Button4.Text = "";
			Button5.Text = "";
			Button6.Text = "";
			Button7.Text = "";
			Button8.Text = "";
			Button9.Text = "";
			Button1.BackColor = Color.White;
			Button1.ForeColor = Color.Black;
			Button2.BackColor = Color.White;
			Button2.ForeColor = Color.Black;
			Button3.BackColor = Color.White;
			Button3.ForeColor = Color.Black;
			Button4.BackColor = Color.White;
			Button4.ForeColor = Color.Black;
			Button5.BackColor = Color.White;
			Button5.ForeColor = Color.Black;
			Button6.BackColor = Color.White;
			Button6.ForeColor = Color.Black;
			Button7.BackColor = Color.White;
			Button7.ForeColor = Color.Black;
			Button8.BackColor = Color.White;
			Button8.ForeColor = Color.Black;
			Button9.BackColor = Color.White;
			Button9.ForeColor = Color.Black;
		}

		void PlayagainClick(object sender, EventArgs e)
		{
		}
		private void Playagain_Click(object sender, EventArgs e)
		{
			cleargame();
		}
		private void Reset_Click(object sender, EventArgs e)
		{
			player1score.Text = "";
			player2score.Text = "";
			player1 = 0;
			player2 = 0;
			cleargame();
		}


		void ResetClick(object sender, EventArgs e)
		{

		}
		private void Reset_Click_1(object sender, EventArgs e)
		{
			player1score.Text = "0";
			player2score.Text = "0";
			player1 = 0;
			player2 = 0;
			cleargame();
			
		}

	}
}