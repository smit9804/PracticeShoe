using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeShoe
{
    public partial class Form1 : Form
    {
        public class ScoreRow
        {
            public string Ringer { get; set; }
            public string Points { get; set; }
            public int Score { get; set; }
            public int Shoes { get; set; }
        }

        public class PlayerTotals
        {
            public double RingerPct { get; set; }
            public int TotalRingers { get; set; }
            public int TotalShoes { get; set; }
            public int TotalPoints { get; set; }
        }

        public class PracticeGame
        {
            public List<ScoreRow> PlayerScoreRows { get; set; }
            public PlayerTotals PlayerStats { get; set; }
        }
        public static PracticeGame ThePracticeGame { get; set; }

        public Form1()
        {
            InitializeComponent();
        }



        //No Score
        private void button1_Click(object sender, EventArgs e)
        {
            var innerlist = ThePracticeGame.PlayerScoreRows;
            
            ScoreRow sr = new ScoreRow();
            if(innerlist.Count > 0)
            {
                sr = ProcessScore("NS", innerlist);
            }
            else
            {
                sr.Ringer = "-";
                sr.Points = "-";
                sr.Score = 0;
                sr.Shoes = 2;
            }
            innerlist.Add(sr);
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Add(sr.Ringer, sr.Points, sr.Score, sr.Shoes);
            ThePracticeGame.PlayerScoreRows = innerlist;
            ProcessTotals(innerlist);
        }

        //One Point
        private void button2_Click(object sender, EventArgs e)
        {
            var innerlist = ThePracticeGame.PlayerScoreRows;

            ScoreRow sr = new ScoreRow();
            if (innerlist.Count > 0)
            {
                sr = ProcessScore("1P", innerlist);
            }
            else
            {
                sr.Ringer = "-";
                sr.Points = "1";
                sr.Score = 1;
                sr.Shoes = 2;
            }
            innerlist.Add(sr);
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Add(sr.Ringer, sr.Points, sr.Score, sr.Shoes);
            ThePracticeGame.PlayerScoreRows = innerlist;
            ProcessTotals(innerlist);
        }

        //Two Points
        private void button3_Click(object sender, EventArgs e)
        {
            var innerlist = ThePracticeGame.PlayerScoreRows;

            ScoreRow sr = new ScoreRow();
            if (innerlist.Count > 0)
            {
                sr = ProcessScore("2P", innerlist);
            }
            else
            {
                sr.Ringer = "-";
                sr.Points = "2";
                sr.Score = 2;
                sr.Shoes = 2;
            }
            innerlist.Add(sr);
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Add(sr.Ringer, sr.Points, sr.Score, sr.Shoes);
            ThePracticeGame.PlayerScoreRows = innerlist;
            ProcessTotals(innerlist);
        }

        //Ringer 3
        private void button4_Click(object sender, EventArgs e)
        {
            var innerlist = ThePracticeGame.PlayerScoreRows;

            ScoreRow sr = new ScoreRow();
            if (innerlist.Count > 0)
            {
                sr = ProcessScore("R3", innerlist);
            }
            else
            {
                sr.Ringer = "O";
                sr.Points = "3";
                sr.Score = 3;
                sr.Shoes = 2;
            }
            innerlist.Add(sr);
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Add(sr.Ringer, sr.Points, sr.Score, sr.Shoes);
            ThePracticeGame.PlayerScoreRows = innerlist;
            ProcessTotals(innerlist);
        }

        //Ringer 4
        private void button5_Click(object sender, EventArgs e)
        {
            var innerlist = ThePracticeGame.PlayerScoreRows;

            ScoreRow sr = new ScoreRow();
            if (innerlist.Count > 0)
            {
                sr = ProcessScore("R4", innerlist);
            }
            else
            {
                sr.Ringer = "O'";
                sr.Points = "4";
                sr.Score = 4;
                sr.Shoes = 2;
            }
            innerlist.Add(sr);
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Add(sr.Ringer, sr.Points, sr.Score, sr.Shoes);
            ThePracticeGame.PlayerScoreRows = innerlist;
            ProcessTotals(innerlist);
        }

        //2 Ringer 6
        private void button6_Click(object sender, EventArgs e)
        {
            var innerlist = ThePracticeGame.PlayerScoreRows;

            ScoreRow sr = new ScoreRow();
            if (innerlist.Count > 0)
            {
                sr = ProcessScore("2R", innerlist);
            }
            else
            {
                sr.Ringer = "OO";
                sr.Points = "6";
                sr.Score = 6;
                sr.Shoes = 2;
            }
            innerlist.Add(sr);
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Add(sr.Ringer, sr.Points, sr.Score, sr.Shoes);
            ThePracticeGame.PlayerScoreRows = innerlist;
            ProcessTotals(innerlist);
        }

        public ScoreRow ProcessScore(string scoretype, List<ScoreRow> scoreRows)
        {
            ScoreRow sr = new ScoreRow();
            switch (scoretype)
            {
                case "NS":
                    sr.Ringer = "-";
                    sr.Points = "-";
                    sr.Score = scoreRows[scoreRows.Count - 1].Score;
                    //sr.Score = int.Parse(scoreRows[scoreRows.Count - 1].Cells["Score"].Value.ToString());
                    break;
                case "1P":
                    sr.Ringer = "-";
                    sr.Points = "1";
                    sr.Score = scoreRows[scoreRows.Count - 1].Score + 1;
                    //sr.Score = int.Parse(scoreRows[scoreRows.Count - 1].Cells["Score"].Value.ToString()) + 1;
                    break;
                case "2P":
                    sr.Ringer = "-";
                    sr.Points = "2";
                    sr.Score = scoreRows[scoreRows.Count - 1].Score + 2;
                    //sr.Score = int.Parse(scoreRows[scoreRows.Count - 1].Cells["Score"].Value.ToString()) + 2;
                    break;
                case "R3":
                    sr.Ringer = "O";
                    sr.Points = "3";
                    sr.Score = scoreRows[scoreRows.Count - 1].Score + 3;
                    //sr.Score = int.Parse(scoreRows[scoreRows.Count - 1].Cells["Score"].Value.ToString()) + 3;
                    break;
                case "R4":
                    sr.Ringer = "O'";
                    sr.Points = "4";
                    sr.Score = scoreRows[scoreRows.Count - 1].Score + 4;
                    //sr.Score = int.Parse(scoreRows[scoreRows.Count - 1].Cells["Score"].Value.ToString()) + 4;
                    break;
                case "2R":
                    sr.Ringer = "OO";
                    sr.Points = "6";
                    sr.Score = scoreRows[scoreRows.Count - 1].Score + 6;
                    //sr.Score = int.Parse(scoreRows[scoreRows.Count - 1].Cells["Score"].Value.ToString()) + 6;
                    break;
                default:
                    break;
            }
            sr.Shoes = scoreRows[scoreRows.Count - 1].Shoes + 2;
            //sr.Shoes = int.Parse(scoreRows[scoreRows.Count - 1].Cells["Shoes"].Value.ToString()) + 2;
            return sr;
        }

        public void ProcessTotals(List<ScoreRow> scoreRows)
        {
            List<ScoreRow> innerlist = scoreRows;
            double ringerpct = 0;
            int totalringers = 0;
            int totalpoints = 0;
            int totalshoes = 0;
            for(int i = 0; i < innerlist.Count; i++)
            {
                if (innerlist[i].Ringer == "OO")
                {
                    totalringers += 2;
                }
                else if (innerlist[i].Ringer == "O'" || innerlist[i].Ringer == "O")
                {
                    totalringers++;
                }

                if (innerlist[i].Points != "-")
                {
                    totalpoints += int.Parse(innerlist[i].Points);
                }
                totalshoes += 2;
            }
            ringerpct = Math.Round(Convert.ToDouble(totalringers) / Convert.ToDouble(totalshoes), 2) * 100;

            textBox1.Text = ringerpct.ToString() + "%";
            textBox2.Text = totalringers.ToString();
            textBox3.Text = totalpoints.ToString();
            textBox4.Text = totalshoes.ToString();
        }

        //Start New Game
        private void button7_Click(object sender, EventArgs e)
        {
            if(button7.Text == "Paused")
            {
                panel2.BackColor = Color.Red;
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Text = "Undo";
            }
            else
            {
                ThePracticeGame = new PracticeGame();
                
                ThePracticeGame.PlayerScoreRows = new List<ScoreRow>();

                PlayerTotals pt = new PlayerTotals();
                pt.RingerPct = 0.0;
                pt.TotalRingers = 0;
                pt.TotalShoes = 0;
                pt.TotalPoints = 0;
                ThePracticeGame.PlayerStats = pt;

                textBox1.Text = ThePracticeGame.PlayerStats.RingerPct.ToString() + "%";
                textBox2.Text = ThePracticeGame.PlayerStats.TotalRingers.ToString();
                textBox3.Text = ThePracticeGame.PlayerStats.TotalPoints.ToString();
                textBox4.Text = ThePracticeGame.PlayerStats.TotalShoes.ToString();
            }
            panel2.BackColor = Color.LightGreen;
            button7.Text = "Started";
            button7.BackColor = Color.Gainsboro;
            button7.ForeColor = Color.DarkGray;
            dataGridView1.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            //button8.Enabled = false;
            //button8.BackColor = Color.Gainsboro;
            //button8.ForeColor = Color.DarkGray;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = true;
            dataGridView1.AllowUserToOrderColumns = false;
        }
        //Undo Activated
        private void button8_Click(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Goldenrod;
            button7.Text = "Paused";
            button7.BackColor = Color.ForestGreen;
            button7.ForeColor = Color.White;

            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            //button7.Enabled = false;
            //button18.Enabled = false;
            //button19.Enabled = false;
            //button20.Enabled = false;
            //button21.Enabled = false;
            //button22.Enabled = false;
            //button23.Enabled = false;
            //button24.Enabled = false;

            List<ScoreRow> innerlist = ThePracticeGame.PlayerScoreRows;
            if(dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                ScoreRow scorerow = innerlist.Where(
                    x => (x.Shoes.ToString() == row.Cells["Shoes"].Value.ToString() &&
                    x.Score.ToString() == row.Cells["Score"].Value.ToString())
                    ).FirstOrDefault();

                dataGridView1.Rows.Remove(row);
                innerlist.Remove(scorerow);
            }
            ThePracticeGame.PlayerScoreRows = innerlist;
            ProcessTotals(innerlist);
        }
    }
}
