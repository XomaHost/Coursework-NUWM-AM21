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
    public partial class DemoFight : Form
    {

        class TestHero
        {
            public int hp = 100;
            public double dmg = 15;
            public int evasion = 15;
            public int CritChance = 5;



        }
        class TestEnemy
        {
            public int hp = 100;
            public double dmg = 15;
            public int evasion = 15;
            public int CritChance = 5;


        }
        private void sync(TestHero Hero1, TestEnemy Enemy1)
        {
            EnHP.Text = Convert.ToString(Enemy1.hp);
            EnDMG.Text = Convert.ToString(Enemy1.dmg);
            EnEvasion.Text = Convert.ToString(Enemy1.evasion);
            EnCritChance.Text = Convert.ToString(Enemy1.CritChance);

            HP.Text = Convert.ToString(Hero1.hp);
            DMG.Text = Convert.ToString(Hero1.dmg);
            Evasion.Text = Convert.ToString(Hero1.evasion);
            CritChance.Text = Convert.ToString(Hero1.CritChance);
        }

        TestHero Hero1 = new TestHero();
        TestEnemy Enemy1 = new TestEnemy();
        Random AI = new Random();
        RadioButton[] radioAtt = new RadioButton[3];
        RadioButton[] radioDef = new RadioButton[3];

        public void Fight(int att, int def, int evasion, int crit, int Enatt, int Endef, int Enevasion, int Encrit)
        {
            string[] log = { "Head", "Body", "Legs" };
            bool HeroEvasion=false, HeroCrit=false, EnemyEvasion=false, EnemyCrit=false;
            if (AI.Next(0, 101) <= evasion)
            {
                HeroEvasion = true;
            }
            if (AI.Next(0, 101) <= crit)
            {
                HeroCrit = true;
            }
            if (AI.Next(0, 101) <= Enevasion)
            {
                EnemyEvasion = true;
            }
            if (AI.Next(0, 101) <= Encrit)
            {
                EnemyCrit = true;
            }

            
            if (EnemyEvasion)
            {
                TestLog.AppendText(("The Enemy avoided attacking the Hero!\n"));
            }
            else
            {
                if (att != Endef)
                {
                    double deflection = AI.Next(75, 115) / 100.0;
                    double realdmg = Hero1.dmg * deflection;
                    if (HeroCrit)
                    {
                        realdmg = realdmg * 2.0;
                    }
                    Enemy1.hp = (int)Math.Round((Enemy1.hp - realdmg), MidpointRounding.AwayFromZero);
                    TestLog.AppendText(("Hero attacked " + log[att] + ", when Enemy blocked " + log[Endef] + ". (" + realdmg + " damage)\n"));
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
                    double deflection = AI.Next(75, 115) / 100.0;
                    double realdmg = Enemy1.dmg * deflection;
                    if (EnemyCrit)
                    {
                        realdmg = realdmg * 2.0;
                    }
                    Hero1.hp = (int)Math.Round((Hero1.hp - realdmg), MidpointRounding.AwayFromZero);
                    TestLog.AppendText(("Enemy attacked " + log[Enatt] + ", when Hero blocked " + log[def] + ". (" + realdmg + " damage)\n"));
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
                    Close();
                    break;
                }
                if (Enemy1.hp <= 0)
                {
                    MessageBox.Show("You win.");
                    Close();
                    break;
                }
            }
        }

        public DemoFight()
        {
            InitializeComponent();
        }

        private void DemoFight_Load(object sender, EventArgs e)
        {
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
            Fight(att, def, Hero1.evasion, Hero1.CritChance, Enatt, Endef, Enemy1.evasion, Enemy1.CritChance);
        }

        private void refreshToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Hero1 = new TestHero();
            Enemy1 = new TestEnemy();
            sync(Hero1, Enemy1);
            TestLog.Clear();
        }

        private void DemoFight_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.Exit();
        }
    }
}
