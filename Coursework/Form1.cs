using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void StartGame_Click(object sender, EventArgs e)
        {
            if (Difficulty.SelectedIndex == -1)
            {
                MessageBox.Show("Please, choose difficulty");
            }
            else
            {
                Game GameForm = new Game(this);
                Hide();
                GameForm.ShowDialog();
            }
        }

        private void DemoFight_Click(object sender, EventArgs e)
        {
            DemoFight Demo = new DemoFight();
            Demo.ShowDialog();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Instructions NewInt = new Instructions();
            NewInt.ShowDialog();
        }

        private void leaderboard_Click(object sender, EventArgs e)
        {
            leaderboard L = new leaderboard();
            L.ShowDialog();
        }
    }
}
