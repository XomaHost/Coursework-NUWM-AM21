namespace Coursework
{
    partial class Fight
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fight));
            this.Defense1 = new System.Windows.Forms.RadioButton();
            this.InfoHero = new System.Windows.Forms.GroupBox();
            this.RandTurn = new System.Windows.Forms.Button();
            this.TestTurn = new System.Windows.Forms.Button();
            this.HP = new System.Windows.Forms.Label();
            this.CritChance = new System.Windows.Forms.Label();
            this.Evasion = new System.Windows.Forms.Label();
            this.armordisp = new System.Windows.Forms.Label();
            this.DMG = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Attack3 = new System.Windows.Forms.RadioButton();
            this.Attack2 = new System.Windows.Forms.RadioButton();
            this.Attack1 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Defense3 = new System.Windows.Forms.RadioButton();
            this.Defense2 = new System.Windows.Forms.RadioButton();
            this.InfoEnemy = new System.Windows.Forms.GroupBox();
            this.EnHP = new System.Windows.Forms.Label();
            this.EnCritChance = new System.Windows.Forms.Label();
            this.EnEvasion = new System.Windows.Forms.Label();
            this.EnDMG = new System.Windows.Forms.Label();
            this.Enarmordisp = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TestLog = new System.Windows.Forms.TextBox();
            this.InfoHero.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.InfoEnemy.SuspendLayout();
            this.SuspendLayout();
            // 
            // Defense1
            // 
            this.Defense1.AutoSize = true;
            this.Defense1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Defense1.Location = new System.Drawing.Point(18, 50);
            this.Defense1.Name = "Defense1";
            this.Defense1.Size = new System.Drawing.Size(53, 19);
            this.Defense1.TabIndex = 0;
            this.Defense1.TabStop = true;
            this.Defense1.Text = "Head";
            this.Defense1.UseVisualStyleBackColor = true;
            // 
            // InfoHero
            // 
            this.InfoHero.Controls.Add(this.RandTurn);
            this.InfoHero.Controls.Add(this.TestTurn);
            this.InfoHero.Controls.Add(this.HP);
            this.InfoHero.Controls.Add(this.CritChance);
            this.InfoHero.Controls.Add(this.Evasion);
            this.InfoHero.Controls.Add(this.armordisp);
            this.InfoHero.Controls.Add(this.DMG);
            this.InfoHero.Controls.Add(this.label5);
            this.InfoHero.Controls.Add(this.label3);
            this.InfoHero.Controls.Add(this.label7);
            this.InfoHero.Controls.Add(this.label4);
            this.InfoHero.Controls.Add(this.label6);
            this.InfoHero.Controls.Add(this.panel2);
            this.InfoHero.Controls.Add(this.panel1);
            this.InfoHero.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoHero.Location = new System.Drawing.Point(10, 12);
            this.InfoHero.Name = "InfoHero";
            this.InfoHero.Size = new System.Drawing.Size(203, 486);
            this.InfoHero.TabIndex = 1;
            this.InfoHero.TabStop = false;
            this.InfoHero.Text = "Hero";
            // 
            // RandTurn
            // 
            this.RandTurn.Location = new System.Drawing.Point(6, 443);
            this.RandTurn.Name = "RandTurn";
            this.RandTurn.Size = new System.Drawing.Size(191, 31);
            this.RandTurn.TabIndex = 11;
            this.RandTurn.Text = "Random Fight";
            this.RandTurn.UseVisualStyleBackColor = true;
            this.RandTurn.Click += new System.EventHandler(this.RandTurn_Click);
            // 
            // TestTurn
            // 
            this.TestTurn.Location = new System.Drawing.Point(6, 406);
            this.TestTurn.Name = "TestTurn";
            this.TestTurn.Size = new System.Drawing.Size(191, 31);
            this.TestTurn.TabIndex = 11;
            this.TestTurn.Text = "Turn";
            this.TestTurn.UseVisualStyleBackColor = true;
            this.TestTurn.Click += new System.EventHandler(this.TestTurn_Click);
            // 
            // HP
            // 
            this.HP.AutoSize = true;
            this.HP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HP.Location = new System.Drawing.Point(114, 32);
            this.HP.Name = "HP";
            this.HP.Size = new System.Drawing.Size(17, 19);
            this.HP.TabIndex = 3;
            this.HP.Text = "0";
            // 
            // CritChance
            // 
            this.CritChance.AutoSize = true;
            this.CritChance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CritChance.Location = new System.Drawing.Point(114, 150);
            this.CritChance.Name = "CritChance";
            this.CritChance.Size = new System.Drawing.Size(17, 19);
            this.CritChance.TabIndex = 4;
            this.CritChance.Text = "0";
            // 
            // Evasion
            // 
            this.Evasion.AutoSize = true;
            this.Evasion.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Evasion.Location = new System.Drawing.Point(114, 122);
            this.Evasion.Name = "Evasion";
            this.Evasion.Size = new System.Drawing.Size(17, 19);
            this.Evasion.TabIndex = 5;
            this.Evasion.Text = "0";
            // 
            // armordisp
            // 
            this.armordisp.AutoSize = true;
            this.armordisp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.armordisp.Location = new System.Drawing.Point(114, 94);
            this.armordisp.Name = "armordisp";
            this.armordisp.Size = new System.Drawing.Size(17, 19);
            this.armordisp.TabIndex = 6;
            this.armordisp.Text = "0";
            // 
            // DMG
            // 
            this.DMG.AutoSize = true;
            this.DMG.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DMG.Location = new System.Drawing.Point(114, 61);
            this.DMG.Name = "DMG";
            this.DMG.Size = new System.Drawing.Size(17, 19);
            this.DMG.TabIndex = 6;
            this.DMG.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(6, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "Crit. chance:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Evasion:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(6, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 19);
            this.label7.TabIndex = 9;
            this.label7.Text = "Armor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Damage point:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(6, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Health point:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.Attack3);
            this.panel2.Controls.Add(this.Attack2);
            this.panel2.Controls.Add(this.Attack1);
            this.panel2.Location = new System.Drawing.Point(6, 236);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(90, 164);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(18, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Attack";
            // 
            // Attack3
            // 
            this.Attack3.AutoSize = true;
            this.Attack3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Attack3.Location = new System.Drawing.Point(17, 96);
            this.Attack3.Name = "Attack3";
            this.Attack3.Size = new System.Drawing.Size(51, 19);
            this.Attack3.TabIndex = 0;
            this.Attack3.TabStop = true;
            this.Attack3.Tag = "Attack";
            this.Attack3.Text = "Legs";
            this.Attack3.UseVisualStyleBackColor = true;
            // 
            // Attack2
            // 
            this.Attack2.AutoSize = true;
            this.Attack2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Attack2.Location = new System.Drawing.Point(17, 73);
            this.Attack2.Name = "Attack2";
            this.Attack2.Size = new System.Drawing.Size(54, 19);
            this.Attack2.TabIndex = 0;
            this.Attack2.TabStop = true;
            this.Attack2.Tag = "Attack";
            this.Attack2.Text = "Body";
            this.Attack2.UseVisualStyleBackColor = true;
            // 
            // Attack1
            // 
            this.Attack1.AutoSize = true;
            this.Attack1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Attack1.Location = new System.Drawing.Point(17, 50);
            this.Attack1.Name = "Attack1";
            this.Attack1.Size = new System.Drawing.Size(53, 19);
            this.Attack1.TabIndex = 0;
            this.Attack1.TabStop = true;
            this.Attack1.Tag = "Attack";
            this.Attack1.Text = "Head";
            this.Attack1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Defense3);
            this.panel1.Controls.Add(this.Defense2);
            this.panel1.Controls.Add(this.Defense1);
            this.panel1.Location = new System.Drawing.Point(107, 236);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(90, 164);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(15, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Defense";
            // 
            // Defense3
            // 
            this.Defense3.AutoSize = true;
            this.Defense3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Defense3.Location = new System.Drawing.Point(18, 96);
            this.Defense3.Name = "Defense3";
            this.Defense3.Size = new System.Drawing.Size(51, 19);
            this.Defense3.TabIndex = 0;
            this.Defense3.TabStop = true;
            this.Defense3.Text = "Legs";
            this.Defense3.UseVisualStyleBackColor = true;
            // 
            // Defense2
            // 
            this.Defense2.AutoSize = true;
            this.Defense2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Defense2.Location = new System.Drawing.Point(18, 73);
            this.Defense2.Name = "Defense2";
            this.Defense2.Size = new System.Drawing.Size(54, 19);
            this.Defense2.TabIndex = 0;
            this.Defense2.TabStop = true;
            this.Defense2.Text = "Body";
            this.Defense2.UseVisualStyleBackColor = true;
            // 
            // InfoEnemy
            // 
            this.InfoEnemy.Controls.Add(this.EnHP);
            this.InfoEnemy.Controls.Add(this.EnCritChance);
            this.InfoEnemy.Controls.Add(this.EnEvasion);
            this.InfoEnemy.Controls.Add(this.EnDMG);
            this.InfoEnemy.Controls.Add(this.Enarmordisp);
            this.InfoEnemy.Controls.Add(this.label11);
            this.InfoEnemy.Controls.Add(this.label12);
            this.InfoEnemy.Controls.Add(this.label13);
            this.InfoEnemy.Controls.Add(this.label14);
            this.InfoEnemy.Controls.Add(this.label8);
            this.InfoEnemy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoEnemy.Location = new System.Drawing.Point(549, 12);
            this.InfoEnemy.Name = "InfoEnemy";
            this.InfoEnemy.Size = new System.Drawing.Size(185, 486);
            this.InfoEnemy.TabIndex = 1;
            this.InfoEnemy.TabStop = false;
            this.InfoEnemy.Text = "Enemy";
            // 
            // EnHP
            // 
            this.EnHP.AutoSize = true;
            this.EnHP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnHP.Location = new System.Drawing.Point(114, 32);
            this.EnHP.Name = "EnHP";
            this.EnHP.Size = new System.Drawing.Size(17, 19);
            this.EnHP.TabIndex = 3;
            this.EnHP.Text = "0";
            // 
            // EnCritChance
            // 
            this.EnCritChance.AutoSize = true;
            this.EnCritChance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnCritChance.Location = new System.Drawing.Point(114, 150);
            this.EnCritChance.Name = "EnCritChance";
            this.EnCritChance.Size = new System.Drawing.Size(17, 19);
            this.EnCritChance.TabIndex = 4;
            this.EnCritChance.Text = "0";
            // 
            // EnEvasion
            // 
            this.EnEvasion.AutoSize = true;
            this.EnEvasion.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnEvasion.Location = new System.Drawing.Point(114, 122);
            this.EnEvasion.Name = "EnEvasion";
            this.EnEvasion.Size = new System.Drawing.Size(17, 19);
            this.EnEvasion.TabIndex = 5;
            this.EnEvasion.Text = "0";
            // 
            // EnDMG
            // 
            this.EnDMG.AutoSize = true;
            this.EnDMG.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnDMG.Location = new System.Drawing.Point(114, 61);
            this.EnDMG.Name = "EnDMG";
            this.EnDMG.Size = new System.Drawing.Size(17, 19);
            this.EnDMG.TabIndex = 6;
            this.EnDMG.Text = "0";
            // 
            // Enarmordisp
            // 
            this.Enarmordisp.AutoSize = true;
            this.Enarmordisp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Enarmordisp.Location = new System.Drawing.Point(114, 94);
            this.Enarmordisp.Name = "Enarmordisp";
            this.Enarmordisp.Size = new System.Drawing.Size(17, 19);
            this.Enarmordisp.TabIndex = 6;
            this.Enarmordisp.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(6, 150);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 19);
            this.label11.TabIndex = 7;
            this.label11.Text = "Crit. chance:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(6, 122);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 19);
            this.label12.TabIndex = 8;
            this.label12.Text = "Evasion:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(6, 61);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 19);
            this.label13.TabIndex = 9;
            this.label13.Text = "Damage point:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(6, 32);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 19);
            this.label14.TabIndex = 10;
            this.label14.Text = "Health point:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(6, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 19);
            this.label8.TabIndex = 9;
            this.label8.Text = "Armor:";
            // 
            // TestLog
            // 
            this.TestLog.Location = new System.Drawing.Point(219, 12);
            this.TestLog.Multiline = true;
            this.TestLog.Name = "TestLog";
            this.TestLog.ReadOnly = true;
            this.TestLog.Size = new System.Drawing.Size(324, 485);
            this.TestLog.TabIndex = 2;
            // 
            // Fight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 510);
            this.ControlBox = false;
            this.Controls.Add(this.TestLog);
            this.Controls.Add(this.InfoEnemy);
            this.Controls.Add(this.InfoHero);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Fight";
            this.Text = "Fight";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Fight_FormClosing);
            this.Load += new System.EventHandler(this.Fight_Load);
            this.InfoHero.ResumeLayout(false);
            this.InfoHero.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.InfoEnemy.ResumeLayout(false);
            this.InfoEnemy.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox InfoHero;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox InfoEnemy;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TestLog;
        private System.Windows.Forms.Button TestTurn;
        public System.Windows.Forms.RadioButton Defense1;
        public System.Windows.Forms.RadioButton Attack3;
        public System.Windows.Forms.RadioButton Attack2;
        public System.Windows.Forms.RadioButton Attack1;
        public System.Windows.Forms.RadioButton Defense3;
        public System.Windows.Forms.RadioButton Defense2;
        public System.Windows.Forms.Label HP;
        public System.Windows.Forms.Label CritChance;
        public System.Windows.Forms.Label Evasion;
        public System.Windows.Forms.Label DMG;
        public System.Windows.Forms.Label EnHP;
        public System.Windows.Forms.Label EnCritChance;
        public System.Windows.Forms.Label EnEvasion;
        public System.Windows.Forms.Label EnDMG;
        public System.Windows.Forms.Label armordisp;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label Enarmordisp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button RandTurn;
    }
}