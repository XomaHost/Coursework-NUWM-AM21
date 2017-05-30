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
    public partial class buff_form : Form
    {
        Game.Dungeon.Sector.Buff Main;
        Game.Hero Player;
        public int choice = -1;
        public buff_form(Game.Dungeon.Sector.Buff B, Game.Hero Player)
        {
            InitializeComponent();
            Main = B;
            this.Player = Player;
            button1.Text = Convert.ToString(B.hp);
            button2.Text = Convert.ToString(B.dmg);
            button3.Text = Convert.ToString(B.armor);
            button4.Text = Convert.ToString(B.evasion);
            button5.Text = Convert.ToString(B.CritChance);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Player.hp += Main.hp;
            Close();
            choice = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Player.dmg += Main.dmg;
            Close();
            choice = 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Player.armor += Main.armor;
            Close();
            choice = 2;
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Player.evasion += Main.evasion;
            Close();
            choice = 3;
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Player.CritChance += Main.CritChance;
            Close();
            choice = 4;
        }
    }
}
