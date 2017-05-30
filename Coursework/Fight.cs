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
    public partial class Fight : Form
    {
        
        private void sync(Game.Hero Hero1, Game.Enemy Enemy1)
        {
            EnHP.Text = Convert.ToString(Enemy1.hp);
            EnDMG.Text = Convert.ToString(Enemy1.dmg);
            EnEvasion.Text = Convert.ToString(Enemy1.evasion);
            EnCritChance.Text = Convert.ToString(Enemy1.CritChance);
            Enarmordisp.Text = Convert.ToString(Enemy1.armor);

            HP.Text = Convert.ToString(Hero1.hp);
            DMG.Text = Convert.ToString(Hero1.dmg);
            Evasion.Text = Convert.ToString(Hero1.evasion);
            armordisp.Text = Convert.ToString(Hero1.armor);
            CritChance.Text = Convert.ToString(Hero1.CritChance);
        }

        Game.Hero Hero1;
        Game.Enemy Enemy1;
        Random AI = new Random();
        RadioButton[] radioAtt = new RadioButton[3];
        RadioButton[] radioDef = new RadioButton[3];

        public void Turn(int att, int def, int evasion, int crit, int Enatt, int Endef, int Enevasion, int Encrit, ref bool re)
        {
            string[] log = { "Head", "Body", "Legs" };
            bool HeroEvasion = false, HeroCrit = false, EnemyEvasion = false, EnemyCrit = false;
            if (AI.Next(0, 101) <= evasion)
            {
                HeroEvasion = true;
            }
            if (AI.Next(0, 101) <= Enevasion)
            {
                EnemyEvasion = true;
            }
            if (EnemyEvasion)
            {
                TestLog.AppendText(("The Enemy avoided attacking the Hero!\n"));
            }
            else
            {
                if (att != Endef)
                {
                    if (AI.Next(0, 101) <= crit)
                    {
                        HeroCrit = true;
                    }
                    double deflection = AI.Next(75, 115) / 100.0;
                    double realdmg = Hero1.dmg * deflection * (1 - 0.03 * Enemy1.armor / (1 + 0.06 * Math.Abs(Enemy1.armor)));
                    if (HeroCrit)
                    {
                        realdmg = realdmg * (1.5 + AI.NextDouble());
                    }
                    Enemy1.hp = (int)Math.Round((Enemy1.hp - realdmg), MidpointRounding.AwayFromZero);
                    TestLog.AppendText(("Hero attacked " + log[att] + ", when Enemy blocked " + log[Endef] + ". (" + Math.Round(realdmg, 2, MidpointRounding.AwayFromZero) + " damage)\n"));
                }
                else
                {
                    TestLog.AppendText(("Hero attacked " + log[att] + ", when Enemy blocked " + log[Endef] + ". (No damaged)\n"));
                }
            }

            if (HeroEvasion)
            {
                TestLog.AppendText(("The Hero avoided attacking the Enemy!\n"));
            }
            else
            {
                if (def != Enatt)
                {
                    if (AI.Next(0, 101) <= Encrit)
                    {
                        EnemyCrit = true;
                    }
                    double deflection = AI.Next(75, 115) / 100.0;
                    double realdmg = Enemy1.dmg * deflection * (1 - 0.04 * Hero1.armor / (1 + 0.06 * Math.Abs(Hero1.armor)));
                    if (EnemyCrit)
                    {
                        realdmg = realdmg * (1.5 + AI.NextDouble());
                    }
                    Hero1.hp = (int)Math.Round((Hero1.hp - realdmg), MidpointRounding.AwayFromZero);
                    TestLog.AppendText(("Enemy attacked " + log[Enatt] + ", when Hero blocked " + log[def] + ". (" + Math.Round(realdmg, 2, MidpointRounding.AwayFromZero) + " damage)\n"));
                }
                else
                {
                    TestLog.AppendText(("Enemy attacked " + log[Enatt] + ", when Hero blocked " + log[def] + ". (No damaged)\n"));
                }
            }

            sync(Hero1, Enemy1);
            for (int i = 0; i < 1; i++)
            {
                if (Hero1.hp <= 0)
                {
                    MessageBox.Show("You died.");
                    Hero1.alive = false;
                    Close();
                    re = false;
                    break;
                }
                if (Enemy1.hp <= 0)
                {
                    MessageBox.Show("You win.");
                    Close();
                    Hero1.score += Enemy1.score;
                    re = false;
                    break;
                }
            }
        }
            public void Turn(int att, int def, int evasion, int crit, int Enatt, int Endef, int Enevasion, int Encrit)
        {
            string[] log = { "Head", "Body", "Legs" };
            bool HeroEvasion = false, HeroCrit = false, EnemyEvasion = false, EnemyCrit = false;
            if (AI.Next(0, 101) <= evasion)
            {
                HeroEvasion = true;
            }
            if (AI.Next(0, 101) <= Enevasion)
            {
                EnemyEvasion = true;
            }
            if (EnemyEvasion)
            {
                TestLog.AppendText(("The Enemy avoided attacking the Hero!\n"));
            }
            else
            {
                if (att != Endef)
                {
                    if (AI.Next(0, 101) <= crit)
                    {
                        HeroCrit = true;
                    }
                    double deflection = AI.Next(75, 115) / 100.0;
                    double realdmg = Hero1.dmg * deflection * (1 - 0.03 * Enemy1.armor / (1 + 0.06 * Math.Abs(Enemy1.armor)));
                    if (HeroCrit)
                    {
                        realdmg = realdmg * (1.5 + AI.NextDouble());
                    }
                    Enemy1.hp = (int)Math.Round((Enemy1.hp - realdmg), MidpointRounding.AwayFromZero);
                    TestLog.AppendText(("Hero attacked " + log[att] + ", when Enemy blocked " + log[Endef] + ". (" + Math.Round(realdmg, 2, MidpointRounding.AwayFromZero) + " damage)\n"));
                }
                else
                {
                    TestLog.AppendText(("Hero attacked " + log[att] + ", when Enemy blocked " + log[Endef] + ". (No damaged)\n"));
                }
            }

            if (HeroEvasion)
            {
                TestLog.AppendText(("The Hero avoided attacking the Enemy!\n"));
            }
            else
            {
                if (def != Enatt)
                {
                    if (AI.Next(0, 101) <= Encrit)
                    {
                        EnemyCrit = true;
                    }
                    double deflection = AI.Next(75, 115) / 100.0;
                    double realdmg = Enemy1.dmg * deflection * (1 - 0.04 * Hero1.armor / (1 + 0.06 * Math.Abs(Hero1.armor)));
                    if (EnemyCrit)
                    {
                        realdmg = realdmg * (1.5 + AI.NextDouble());
                    }
                    Hero1.hp = (int)Math.Round((Hero1.hp - realdmg), MidpointRounding.AwayFromZero);
                    TestLog.AppendText(("Enemy attacked " + log[Enatt] + ", when Hero blocked " + log[def] + ". (" + Math.Round(realdmg, 2, MidpointRounding.AwayFromZero) + " damage)\n"));
                }
                else
                {
                    TestLog.AppendText(("Enemy attacked " + log[Enatt] + ", when Hero blocked " + log[def] + ". (No damaged)\n"));
                }
            }

            sync(Hero1, Enemy1);
            for (int i = 0; i < 1; i++)
            {
                if (Hero1.hp <= 0)
                {
                    MessageBox.Show("You died.");
                    Hero1.alive = false;
                    Close();
                    break;
                }
                if (Enemy1.hp <= 0)
                {
                    MessageBox.Show("You win.");
                    Close();
                    Hero1.score += Enemy1.score;
                    break;
                }
            }

        }

        Game Data;
        public Fight(Game D)
        {
            InitializeComponent();
            Data = D;
        }

        private void Fight_Load(object sender, EventArgs e)
        {
            Hero1 = Game.Player;
            Enemy1 =Data.Hostile;
            sync(Hero1, Enemy1);
            radioAtt[0] = Attack1;
            radioAtt[1] = Attack2;
            radioAtt[2] = Attack3;
            radioDef[0] = Defense1;
            radioDef[1] = Defense2;
            radioDef[2] = Defense3;
        }

        private void TestTurn_Click(object sender, EventArgs e)
        {
            int att = 0;
            int def = 0;
            int Enatt = AI.Next(0, 3);
            int Endef = AI.Next(0, 3);
            for (int i = 0; i < 3; i++)
            {
                if (radioAtt[i].Checked)
                {
                    att = i;
                }
                if (radioDef[i].Checked)
                {
                    def = i;
                }
            }
            Turn(att, def, Hero1.evasion, Hero1.CritChance, Enatt, Endef, Enemy1.evasion, Enemy1.CritChance);
        }
        private void RandTurn_Click(object sender, EventArgs e)
        {
            bool recap = true;
            while (recap)
            {
                int att = AI.Next(0, 3);
                int def = AI.Next(0, 3);
                int Enatt = AI.Next(0, 3);
                int Endef = AI.Next(0, 3);
                Turn(att, def, Hero1.evasion, Hero1.CritChance, Enatt, Endef, Enemy1.evasion, Enemy1.CritChance, ref recap);
            }
            
        }
        private void Fight_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
