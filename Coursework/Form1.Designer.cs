namespace Coursework
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.StartGame = new System.Windows.Forms.Button();
            this.DemoFight = new System.Windows.Forms.Button();
            this.Difficulty = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.leaderss = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StartGame
            // 
            this.StartGame.CausesValidation = false;
            this.StartGame.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartGame.Location = new System.Drawing.Point(12, 206);
            this.StartGame.Name = "StartGame";
            this.StartGame.Size = new System.Drawing.Size(260, 43);
            this.StartGame.TabIndex = 0;
            this.StartGame.Text = "Start New Game";
            this.StartGame.UseVisualStyleBackColor = true;
            this.StartGame.Click += new System.EventHandler(this.StartGame_Click);
            // 
            // DemoFight
            // 
            this.DemoFight.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DemoFight.Location = new System.Drawing.Point(158, 12);
            this.DemoFight.Name = "DemoFight";
            this.DemoFight.Size = new System.Drawing.Size(114, 39);
            this.DemoFight.TabIndex = 1;
            this.DemoFight.Text = "Demo Fight";
            this.DemoFight.UseVisualStyleBackColor = true;
            this.DemoFight.Click += new System.EventHandler(this.DemoFight_Click);
            // 
            // Difficulty
            // 
            this.Difficulty.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Difficulty.FormattingEnabled = true;
            this.Difficulty.Items.AddRange(new object[] {
            "Normal",
            "Hardcore"});
            this.Difficulty.Location = new System.Drawing.Point(12, 179);
            this.Difficulty.Name = "Difficulty";
            this.Difficulty.Size = new System.Drawing.Size(121, 27);
            this.Difficulty.TabIndex = 2;
            this.Difficulty.Text = "Difficulty";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 38);
            this.button1.TabIndex = 3;
            this.button1.Text = "Instructions";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // leaderss
            // 
            this.leaderss.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leaderss.Location = new System.Drawing.Point(13, 58);
            this.leaderss.Name = "leaderss";
            this.leaderss.Size = new System.Drawing.Size(107, 37);
            this.leaderss.TabIndex = 4;
            this.leaderss.Text = "Leaderboard";
            this.leaderss.UseVisualStyleBackColor = true;
            this.leaderss.Click += new System.EventHandler(this.leaderboard_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.leaderss);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Difficulty);
            this.Controls.Add(this.DemoFight);
            this.Controls.Add(this.StartGame);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Start Game";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartGame;
        private System.Windows.Forms.Button DemoFight;
        public System.Windows.Forms.ComboBox Difficulty;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button leaderss;
    }
}

