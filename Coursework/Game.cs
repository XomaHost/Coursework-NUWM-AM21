using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Coursework
{
    
    public partial class Game : Form
    {
        public Random AI = new Random();
        public class Dungeon
        {
            
            public int size = 7;
            public Sector[,] sector;
            public Dungeon(Random AI, Hero Player)
            {
                sector = new Sector[size, size];
                for (int i = 0; i < size; i++)
                {
                    for (int k = 0; k < size; k++)
                    {
                        sector[i, k]= new Sector(ref AI);
                    }
                }
                sector[Player.position[0], Player.position[1]].presence = true;
            }
            public Dungeon()
            {
            }
            public class Sector
            {
                public int levelBuff;
                public int levelEnemy;
                public bool presence;
                public bool bosscheck;
                public Buff Buffing;
                public Sector(ref Random AI)
                {
                    levelBuff = levelEnemy = AI.Next(1, 4);
                    presence = false;
                    bosscheck = false;
                    Buffing = new Buff(levelBuff, AI);
                }
                public void Enter(Random AI, ref Enemy Hostile, ref Hero Player, bool final)
                {

                    if (!presence)
                    {

                        if (final)
                        {
                            Hostile = new Boss(AI);
                        }
                        else
                        {
                            Hostile = new StandartEnemy(AI, levelEnemy);
                        }
                        presence = true;
                    }
                }
                
                public class Buff
                {
                    public int hp = 0;
                    public double dmg = 0;
                    public int evasion = 0;
                    public int CritChance = 0;
                    public int armor = 0;
                    public Buff(int a, Random AI)
                    {
                        double r = AI.NextDouble();
                        
                            hp = (int)Math.Round( ((r + 1+AI.NextDouble()) *(a) * 11), MidpointRounding.AwayFromZero);
                            dmg = (int)Math.Round( ((r + 1+AI.NextDouble()) * (a) * 5), MidpointRounding.AwayFromZero);
                            evasion = (int)Math.Round( ((r + 1+AI.NextDouble()) * (a) * 4), MidpointRounding.AwayFromZero);
                            armor = (int)Math.Round(((r + 1+AI.NextDouble()) * (a) * 2.5), MidpointRounding.AwayFromZero);
                            CritChance = (int)Math.Round(((r + 1+AI.NextDouble()) * (a) * 2),MidpointRounding.AwayFromZero);
                            
                    }
                }
            }
        }

        public class Hero
        {
            public string name;
            public int hp = 100;
            public double dmg = 15;
            public int evasion = 7;
            public int armor = 2;
            public int CritChance = 5;
            public int[] position = { 2, 2 };
            public bool alive = true;
            public int score = 0;
            public Hero (Random AI, Dungeon D)
            {
                hp = (int)Math.Round(hp *(1 + AI.NextDouble()), MidpointRounding.AwayFromZero);
                dmg = (int)Math.Round(dmg * (1 + AI.NextDouble()), MidpointRounding.AwayFromZero);
                evasion = (int)Math.Round(evasion * (1 + AI.NextDouble()), MidpointRounding.AwayFromZero);
                armor = (int)Math.Round(armor * (1 + AI.NextDouble()), MidpointRounding.AwayFromZero);
                CritChance = (int)Math.Round(CritChance * (1 + AI.NextDouble()), MidpointRounding.AwayFromZero);
                position[0] = AI.Next(0, D.size);
                position[1] = AI.Next(0, D.size);
            }
            
            public void move(int a)
            {
                switch (a)
                {
                    case 0:
                        position[0]--;
                        break;
                    case 1:
                        position[0]++;
                        break;
                    case 2:
                        position[1]--;
                        break;
                    case 3:
                        position[1]++;
                        break;
                }
            }
        }

        public abstract class Enemy
        {
            static public double K;
            public string name;
            public int hp = 16;
            public double dmg = 6;
            public int evasion = 4;
            public int armor = 3;
            public int CritChance = 3;
            public int score = (int)Math.Round(6*K, MidpointRounding.AwayFromZero);
            public bool finalboss = false;
            public abstract string namelog();
        }
        public class StandartEnemy : Enemy
        {

            public StandartEnemy(Random AI, int a)
            {
                hp = (a+1)*(int)Math.Round((hp * (K + AI.NextDouble())));
                dmg = a*(int)Math.Round((dmg * (K + AI.NextDouble())));
                evasion = a*(int)Math.Round((evasion * (K + AI.NextDouble())));
                armor = a * (int)Math.Round((armor * (K + AI.NextDouble())));
                CritChance = a*(int)Math.Round((CritChance * (K + AI.NextDouble())));
                score = a * (int)Math.Round((CritChance * (K + AI.NextDouble())));
                if (evasion >= 70)
                {
                    evasion = 70;
                }
                if (CritChance >= 55)
                {
                    CritChance = 55;
                }
                switch (a)
                { 
                    case 1:
                        name = "Light Enemy";
                        break;
                    case 2:
                        name = "Medium Enemy";
                        break;
                    case 3:
                        name = "Large Enemy";
                        break;
                }
            }
            public override string namelog()
            {
                return name;
            }
        }
        
        public class Boss : Enemy
        {
            
            public Boss(Random AI)
            {
                finalboss = true;
                K += 3;
                name = "Boss";
                hp = 250 + (int)Math.Round((hp * (K + AI.NextDouble() + AI.NextDouble())));
                dmg = AI.Next(15, 35)+(int)Math.Round((dmg * (K + AI.NextDouble() + AI.NextDouble())));
                evasion = AI.Next(5, 20)+(int)Math.Round((evasion * (K + AI.NextDouble() + AI.NextDouble())));
                armor = AI.Next(5, 20)+(int)Math.Round((armor * (K + AI.NextDouble() + AI.NextDouble())));
                CritChance = AI.Next(0, 15)+(int)Math.Round((CritChance * (K+ AI.NextDouble() + AI.NextDouble())));
                score = (int)(Math.Round((CritChance * (K + AI.NextDouble() + AI.NextDouble()))));
                if (evasion >= 80)
                {
                    evasion = 80;
                }
                if (CritChance >= 65)
                {
                    CritChance = 65;
                }
                K -= 3;
            }
            public override string namelog()
            {
                return name;
            }
        }

        public void buff(Dungeon.Sector.Buff B)
        {
            buff_form wind = new buff_form(B, Player);
            wind.ShowDialog();
            switch (wind.choice)
            {
                case -1:
                    break;
                case 0:
                    TextLog.AppendText("You pick up buff: +" + B.hp + " HP (" + Player.position[0] + "," + Player.position[1] + ")\n");
                    break;
                case 1:
                    TextLog.AppendText("You pick up buff: +" + B.dmg + " DMG (" + Player.position[0] + "," + Player.position[1] + ")\n");
                    break;
                case 2:
                    TextLog.AppendText("You pick up buff: +" + B.armor + " Armor (" + Player.position[0] + "," + Player.position[1] + ")\n");
                    break;
                case 3:
                    TextLog.AppendText("You pick up buff: +" + B.evasion + " Evasion (" + Player.position[0] + "," + Player.position[1] + ")\n");
                    break;
                case 4:
                    TextLog.AppendText("You pick up buff: +" + B.CritChance + " Crit.Chance (" + Player.position[0] + "," + Player.position[1] + ")\n");
                    break;
                default:
                    break;
            }
        }
        public void sync(Hero Player, Dungeon FD)
        {
            if (Player.evasion > 66)
            {
                Player.evasion = 66;
            }
            if (Player.CritChance > 33)
            {
                Player.CritChance = 33;
            }
            HP.Text = Convert.ToString(Player.hp);
            DMG.Text = Convert.ToString(Player.dmg);
            Evasion.Text = Convert.ToString(Player.evasion);
            armordisp.Text = Convert.ToString(Player.armor);
            CritChance.Text = Convert.ToString(Player.CritChance);
            LocX.Text = Convert.ToString(1+Player.position[0]);
            LocY.Text = Convert.ToString(1+Player.position[1]);
            scoredisp.Text = Convert.ToString(Player.score);

            map.Clear();
            string[,] Minimap = new string[FD.size, FD.size];
            for (int i = 0; i < FD.size; i++)
            {
                for (int k = 0; k < FD.size; k++)
                {
                    if (FD.sector[i,k].presence == true)
                    {
                        Minimap[i, k] = " [+] ";
                    }
                    else
                    {
                        Minimap[i, k] = " [-] ";
                    }
                }
            }
            Minimap[Player.position[0], Player.position[1]] = " [I] ";
            for (int i = 0; i < FD.size; i++)
            {
                for (int k = 0; k < FD.size; k++)
                {
                        map.AppendText(Minimap[i, k]);
                    
                }
                map.AppendText("\n");
            }

            if (Player.position[0] == 0)
            {
                go_ahead.Visible = false;
            }
            else
            {
                go_ahead.Visible = true;
            }
            if (Player.position[0] == FD.size-1)
            {
                go_back.Visible = false;
            }
            else
            {
                go_back.Visible = true;
            }
            if (Player.position[1] == 0)
            {
                go_left.Visible = false;
            }
            else
            {
                go_left.Visible = true;
            }
            if (Player.position[1] == FD.size-1)
            {
                go_right.Visible = false;
            }
            else
            {
                go_right.Visible = true;
            }
            if (Hostile != null)
            {
                EnName.Text = Hostile.namelog();
                go_ahead.Visible = false;
                go_back.Visible = false;
                go_left.Visible = false;
                go_right.Visible = false;
                to_battle.Visible = true;
            }
            else
            {
                EnName.Text = "-";
                to_battle.Visible = false;
            }
            if (FD.sector[Player.position[0], Player.position[1]].Buffing != null)
            {
                get_buff.Visible = true;
                EnBuff.Text = ("Level: " + FD.sector[Player.position[0], Player.position[1]].levelBuff);
            }
            else
            {
                get_buff.Visible = false;
                EnBuff.Text = ("-");
            }
        }

        
        public Enemy Hostile;
        public static Hero Player;
        public Dungeon FD = new Dungeon();
        public Form1 Back;

        public Game(Form1 B)
        {
            InitializeComponent();
            Back = B;
            Enemy.K = (Back.Difficulty.SelectedIndex*0.5)+1;
            Player = new Hero(AI, FD);
            FD = new Dungeon(AI, Player);
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {   //right
            Player.move(3);
            TextLog.AppendText("You go right. ("+ (Player.position[0]+1) +"," + (Player.position[1]+1) + ")\n");
            if (Player.position[0] == Player.position[1])
            {
                FD.sector[Player.position[0], Player.position[1]].Enter(AI, ref Hostile, ref Player, true);
            }
            else
            {
                FD.sector[Player.position[0], Player.position[1]].Enter(AI, ref Hostile, ref Player, false);
            }

            sync(Player, FD);
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {   //left
            Player.move(2);
            TextLog.AppendText("You go left. (" + (Player.position[0]+1) + "," + (Player.position[1]+1) + ")\n");
            if (Player.position[0] == Player.position[1])
            {
                FD.sector[Player.position[0], Player.position[1]].Enter(AI, ref Hostile, ref Player, true);
            }
            else
            {
                FD.sector[Player.position[0], Player.position[1]].Enter(AI, ref Hostile, ref Player, false);
            }
            
            sync(Player, FD);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {   //back
            Player.move(1);
            TextLog.AppendText("You go back. (" + (Player.position[0] + 1) + "," + (Player.position[1] + 1) + ")\n");
            if (Player.position[0] == Player.position[1])
            {
                FD.sector[Player.position[0], Player.position[1]].Enter(AI, ref Hostile, ref Player, true);
            }
            else
            {
                FD.sector[Player.position[0], Player.position[1]].Enter(AI, ref Hostile, ref Player, false);
            }

            sync(Player, FD);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {   //ahead
            Player.move(0);
            TextLog.AppendText("You go ahead. (" + (Player.position[0] + 1) + "," + (Player.position[1] + 1) + ")\n");
            if (Player.position[0] == Player.position[1])
            {
                FD.sector[Player.position[0], Player.position[1]].Enter(AI, ref Hostile, ref Player, true);
            }
            else
            {
                FD.sector[Player.position[0], Player.position[1]].Enter(AI, ref Hostile, ref Player, false);
            }

            sync(Player, FD);
        }

        private void Game_Load(object sender, EventArgs e)
        {
            TextLog.AppendText("You positions: (" + (Player.position[0] + 1) + "," + (Player.position[1] + 1) + ")\n");
            if (Player.position[0] == Player.position[1])
            {
                FD.sector[Player.position[0], Player.position[1]].Enter(AI, ref Hostile, ref Player, true);
            }
            else
            {
                FD.sector[Player.position[0], Player.position[1]].Enter(AI, ref Hostile, ref Player, false);
            }

            sync(Player, FD);
        }

        private void to_battle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            for (int i = 0; i < 1; i++)
            {
                Fight Battle = new Fight(this);
                Battle.ShowDialog();
                sync(Player, FD);
                if (!Player.alive)
                {
                    MessageBox.Show("Game over.");
                    this.Close();
                    Back.Show();
                    break;
                }
                if (Hostile.finalboss)
                {
                    Enemy.K+=0.9;
                    MessageBox.Show("Congratulations! You have destroyed the final boss. Now, you can finish the game and bring the bill. Or you can continue the journey into the dungeon to gain more points.");
                    end_game.Visible = true;
                }
                TextLog.AppendText("You defeated " + Hostile.namelog() + " (" + Player.position[0] + "," + Player.position[1] + ")\n");
                Hostile = null;

                sync(Player, FD);
            }
        }
        private void get_buff_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            buff(FD.sector[Player.position[0], Player.position[1]].Buffing);
            FD.sector[Player.position[0], Player.position[1]].Buffing = null;
            sync(Player, FD);
        }
        private void Game_FormClosed(object sender, FormClosedEventArgs e)
        {
            Back.Show();
        }
        private void surrender_Click(object sender, EventArgs e)
        {
            this.Close();
            Back.Show();
        }
        private void end_game_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You score: " + Player.score);
            leader L = new leader(Player);
            L.ShowDialog();
            WorkWithXML.WriteXml();
            Player = null;
            this.Close();
            Back.Show();
        }
    }
}
