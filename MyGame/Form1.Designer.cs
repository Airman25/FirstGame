namespace MyGame
{
    partial class Game
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
            this.components = new System.ComponentModel.Container();
            this.HeroMove = new System.Windows.Forms.Timer(this.components);
            this.Hero = new System.Windows.Forms.PictureBox();
            this.NPCTUtorial = new System.Windows.Forms.PictureBox();
            this.Room1 = new System.Windows.Forms.Timer(this.components);
            this.HeroAnimate = new System.Windows.Forms.Timer(this.components);
            this.Tutorial = new System.Windows.Forms.Label();
            this.Warrior = new System.Windows.Forms.PictureBox();
            this.Cyclop = new System.Windows.Forms.PictureBox();
            this.Room2 = new System.Windows.Forms.Timer(this.components);
            this.Room3 = new System.Windows.Forms.Timer(this.components);
            this.Room4 = new System.Windows.Forms.Timer(this.components);
            this.Room5 = new System.Windows.Forms.Timer(this.components);
            this.OurHero = new System.Windows.Forms.PictureBox();
            this.WarriorFight = new System.Windows.Forms.PictureBox();
            this.Timer_Fight = new System.Windows.Forms.Timer(this.components);
            this.BasicAttack = new System.Windows.Forms.Button();
            this.Superpower = new System.Windows.Forms.Button();
            this.Magic = new System.Windows.Forms.Button();
            this.Items = new System.Windows.Forms.Button();
            this.HeroHplabel = new System.Windows.Forms.Label();
            this.EnemyHplabel = new System.Windows.Forms.Label();
            this.Startbutton = new System.Windows.Forms.Button();
            this.choose = new System.Windows.Forms.Label();
            this.first = new System.Windows.Forms.Button();
            this.second = new System.Windows.Forms.Button();
            this.third = new System.Windows.Forms.Button();
            this.magic1 = new System.Windows.Forms.Button();
            this.magic2 = new System.Windows.Forms.Button();
            this.magic3 = new System.Windows.Forms.Button();
            this.Coinslabel = new System.Windows.Forms.Label();
            this.rage = new System.Windows.Forms.Button();
            this.Cyclopfight = new System.Windows.Forms.PictureBox();
            this.Robotfriend = new System.Windows.Forms.PictureBox();
            this.Robot2 = new System.Windows.Forms.PictureBox();
            this.Robot3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Hero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NPCTUtorial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Warrior)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cyclop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OurHero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WarriorFight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cyclopfight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Robotfriend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Robot2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Robot3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // HeroMove
            // 
            this.HeroMove.Tick += new System.EventHandler(this.Heromove_Tick_1);
            // 
            // Hero
            // 
            this.Hero.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Hero.Location = new System.Drawing.Point(12, 77);
            this.Hero.Name = "Hero";
            this.Hero.Size = new System.Drawing.Size(101, 96);
            this.Hero.TabIndex = 0;
            this.Hero.TabStop = false;
            this.Hero.Click += new System.EventHandler(this.Hero_Click);
            // 
            // NPCTUtorial
            // 
            this.NPCTUtorial.BackColor = System.Drawing.SystemColors.ControlDark;
            this.NPCTUtorial.Image = global::MyGame.Properties.Resources.NPCtutorial;
            this.NPCTUtorial.Location = new System.Drawing.Point(219, 180);
            this.NPCTUtorial.Name = "NPCTUtorial";
            this.NPCTUtorial.Size = new System.Drawing.Size(103, 96);
            this.NPCTUtorial.TabIndex = 1;
            this.NPCTUtorial.TabStop = false;
            // 
            // Room1
            // 
            this.Room1.Tick += new System.EventHandler(this.Room1_Tick);
            // 
            // HeroAnimate
            // 
            this.HeroAnimate.Tick += new System.EventHandler(this.HeroAnimate_Tick);
            // 
            // Tutorial
            // 
            this.Tutorial.AutoSize = true;
            this.Tutorial.Font = new System.Drawing.Font("Bernard MT Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tutorial.Location = new System.Drawing.Point(8, 415);
            this.Tutorial.Name = "Tutorial";
            this.Tutorial.Size = new System.Drawing.Size(475, 44);
            this.Tutorial.TabIndex = 3;
            this.Tutorial.Text = "Hello I am Tutorial NPC i would tell you how the game works...\r\n(Press on the tex" +
    "t)";
            this.Tutorial.Click += new System.EventHandler(this.label2_Click);
            // 
            // Warrior
            // 
            this.Warrior.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Warrior.Image = global::MyGame.Properties.Resources.Warior;
            this.Warrior.Location = new System.Drawing.Point(444, 179);
            this.Warrior.Name = "Warrior";
            this.Warrior.Size = new System.Drawing.Size(93, 96);
            this.Warrior.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Warrior.TabIndex = 4;
            this.Warrior.TabStop = false;
            // 
            // Cyclop
            // 
            this.Cyclop.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Cyclop.Image = global::MyGame.Properties.Resources.Cyclop;
            this.Cyclop.Location = new System.Drawing.Point(357, 363);
            this.Cyclop.Name = "Cyclop";
            this.Cyclop.Size = new System.Drawing.Size(93, 96);
            this.Cyclop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Cyclop.TabIndex = 5;
            this.Cyclop.TabStop = false;
            // 
            // Room2
            // 
            this.Room2.Tick += new System.EventHandler(this.Room2_Tick);
            // 
            // Room3
            // 
            this.Room3.Tick += new System.EventHandler(this.Room3_Tick);
            // 
            // OurHero
            // 
            this.OurHero.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.OurHero.Image = global::MyGame.Properties.Resources.stickminforgame1;
            this.OurHero.Location = new System.Drawing.Point(73, 186);
            this.OurHero.Name = "OurHero";
            this.OurHero.Size = new System.Drawing.Size(94, 96);
            this.OurHero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.OurHero.TabIndex = 6;
            this.OurHero.TabStop = false;
            // 
            // WarriorFight
            // 
            this.WarriorFight.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.WarriorFight.Image = global::MyGame.Properties.Resources.Warior;
            this.WarriorFight.Location = new System.Drawing.Point(524, 186);
            this.WarriorFight.Name = "WarriorFight";
            this.WarriorFight.Size = new System.Drawing.Size(93, 96);
            this.WarriorFight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.WarriorFight.TabIndex = 7;
            this.WarriorFight.TabStop = false;
            // 
            // Timer_Fight
            // 
            this.Timer_Fight.Tick += new System.EventHandler(this.Timer_Fight_Tick);
            // 
            // BasicAttack
            // 
            this.BasicAttack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BasicAttack.Location = new System.Drawing.Point(174, 252);
            this.BasicAttack.Name = "BasicAttack";
            this.BasicAttack.Size = new System.Drawing.Size(75, 23);
            this.BasicAttack.TabIndex = 8;
            this.BasicAttack.Text = "Basic Attack";
            this.BasicAttack.UseVisualStyleBackColor = false;
            this.BasicAttack.Click += new System.EventHandler(this.BasicAttack_Click);
            // 
            // Superpower
            // 
            this.Superpower.BackColor = System.Drawing.Color.Chocolate;
            this.Superpower.ForeColor = System.Drawing.Color.DarkBlue;
            this.Superpower.Location = new System.Drawing.Point(174, 281);
            this.Superpower.Name = "Superpower";
            this.Superpower.Size = new System.Drawing.Size(75, 23);
            this.Superpower.TabIndex = 9;
            this.Superpower.Text = "Superpower";
            this.Superpower.UseVisualStyleBackColor = false;
            this.Superpower.Click += new System.EventHandler(this.Superpower_Click);
            // 
            // Magic
            // 
            this.Magic.BackColor = System.Drawing.Color.Snow;
            this.Magic.ForeColor = System.Drawing.Color.IndianRed;
            this.Magic.Location = new System.Drawing.Point(174, 310);
            this.Magic.Name = "Magic";
            this.Magic.Size = new System.Drawing.Size(75, 23);
            this.Magic.TabIndex = 10;
            this.Magic.Text = "Magic";
            this.Magic.UseVisualStyleBackColor = false;
            this.Magic.Click += new System.EventHandler(this.Magic_Click);
            // 
            // Items
            // 
            this.Items.BackColor = System.Drawing.Color.Bisque;
            this.Items.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.Items.Location = new System.Drawing.Point(174, 339);
            this.Items.Name = "Items";
            this.Items.Size = new System.Drawing.Size(75, 23);
            this.Items.TabIndex = 11;
            this.Items.Text = "Items";
            this.Items.UseVisualStyleBackColor = false;
            this.Items.Click += new System.EventHandler(this.Items_Click);
            // 
            // HeroHplabel
            // 
            this.HeroHplabel.AutoSize = true;
            this.HeroHplabel.Location = new System.Drawing.Point(21, 13);
            this.HeroHplabel.Name = "HeroHplabel";
            this.HeroHplabel.Size = new System.Drawing.Size(35, 13);
            this.HeroHplabel.TabIndex = 12;
            this.HeroHplabel.Text = "label1";
            // 
            // EnemyHplabel
            // 
            this.EnemyHplabel.AutoSize = true;
            this.EnemyHplabel.Location = new System.Drawing.Point(662, 13);
            this.EnemyHplabel.Name = "EnemyHplabel";
            this.EnemyHplabel.Size = new System.Drawing.Size(35, 13);
            this.EnemyHplabel.TabIndex = 13;
            this.EnemyHplabel.Text = "label2";
            // 
            // Startbutton
            // 
            this.Startbutton.BackColor = System.Drawing.Color.Maroon;
            this.Startbutton.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Startbutton.ForeColor = System.Drawing.Color.Lime;
            this.Startbutton.Location = new System.Drawing.Point(325, 220);
            this.Startbutton.Name = "Startbutton";
            this.Startbutton.Size = new System.Drawing.Size(150, 80);
            this.Startbutton.TabIndex = 14;
            this.Startbutton.Text = "Start";
            this.Startbutton.UseVisualStyleBackColor = false;
            this.Startbutton.Click += new System.EventHandler(this.Startbutton_Click);
            // 
            // choose
            // 
            this.choose.AutoSize = true;
            this.choose.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choose.Location = new System.Drawing.Point(316, 9);
            this.choose.Name = "choose";
            this.choose.Size = new System.Drawing.Size(167, 21);
            this.choose.TabIndex = 15;
            this.choose.Text = "Choose your chapter";
            // 
            // first
            // 
            this.first.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.first.Enabled = false;
            this.first.Font = new System.Drawing.Font("Nova Square", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.first.ForeColor = System.Drawing.Color.Gold;
            this.first.Location = new System.Drawing.Point(325, 42);
            this.first.Name = "first";
            this.first.Size = new System.Drawing.Size(150, 43);
            this.first.TabIndex = 16;
            this.first.Text = "Chapter I";
            this.first.UseVisualStyleBackColor = false;
            this.first.Click += new System.EventHandler(this.first_Click);
            // 
            // second
            // 
            this.second.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.second.Enabled = false;
            this.second.Font = new System.Drawing.Font("Nova Square", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.second.ForeColor = System.Drawing.Color.Gold;
            this.second.Location = new System.Drawing.Point(325, 91);
            this.second.Name = "second";
            this.second.Size = new System.Drawing.Size(150, 43);
            this.second.TabIndex = 17;
            this.second.Text = "Chapter II";
            this.second.UseVisualStyleBackColor = false;
            this.second.Click += new System.EventHandler(this.second_Click);
            // 
            // third
            // 
            this.third.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.third.Enabled = false;
            this.third.Font = new System.Drawing.Font("Nova Square", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.third.ForeColor = System.Drawing.Color.Gold;
            this.third.Location = new System.Drawing.Point(325, 140);
            this.third.Name = "third";
            this.third.Size = new System.Drawing.Size(150, 43);
            this.third.TabIndex = 18;
            this.third.Text = "Chapter III";
            this.third.UseVisualStyleBackColor = false;
            this.third.Click += new System.EventHandler(this.third_Click);
            // 
            // magic1
            // 
            this.magic1.BackColor = System.Drawing.Color.Firebrick;
            this.magic1.ForeColor = System.Drawing.Color.GreenYellow;
            this.magic1.Location = new System.Drawing.Point(255, 310);
            this.magic1.Name = "magic1";
            this.magic1.Size = new System.Drawing.Size(75, 23);
            this.magic1.TabIndex = 19;
            this.magic1.Text = "Fire ball";
            this.magic1.UseVisualStyleBackColor = false;
            this.magic1.Click += new System.EventHandler(this.magic1_Click);
            // 
            // magic2
            // 
            this.magic2.BackColor = System.Drawing.SystemColors.Highlight;
            this.magic2.ForeColor = System.Drawing.Color.Gold;
            this.magic2.Location = new System.Drawing.Point(336, 310);
            this.magic2.Name = "magic2";
            this.magic2.Size = new System.Drawing.Size(75, 23);
            this.magic2.TabIndex = 20;
            this.magic2.Text = "Ice shard";
            this.magic2.UseVisualStyleBackColor = false;
            this.magic2.Click += new System.EventHandler(this.magic2_Click);
            // 
            // magic3
            // 
            this.magic3.BackColor = System.Drawing.Color.Gold;
            this.magic3.ForeColor = System.Drawing.Color.DarkCyan;
            this.magic3.Location = new System.Drawing.Point(417, 310);
            this.magic3.Name = "magic3";
            this.magic3.Size = new System.Drawing.Size(75, 23);
            this.magic3.TabIndex = 21;
            this.magic3.Text = "Lighting";
            this.magic3.UseVisualStyleBackColor = false;
            this.magic3.Click += new System.EventHandler(this.magic3_Click);
            // 
            // Coinslabel
            // 
            this.Coinslabel.AutoSize = true;
            this.Coinslabel.Location = new System.Drawing.Point(24, 42);
            this.Coinslabel.Name = "Coinslabel";
            this.Coinslabel.Size = new System.Drawing.Size(35, 13);
            this.Coinslabel.TabIndex = 22;
            this.Coinslabel.Text = "label1";
            // 
            // rage
            // 
            this.rage.BackColor = System.Drawing.Color.Indigo;
            this.rage.ForeColor = System.Drawing.Color.Crimson;
            this.rage.Location = new System.Drawing.Point(255, 281);
            this.rage.Name = "rage";
            this.rage.Size = new System.Drawing.Size(75, 23);
            this.rage.TabIndex = 23;
            this.rage.Text = "Rage";
            this.rage.UseVisualStyleBackColor = false;
            this.rage.Click += new System.EventHandler(this.rage_Click);
            // 
            // Cyclopfight
            // 
            this.Cyclopfight.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Cyclopfight.Image = global::MyGame.Properties.Resources.Cyclop;
            this.Cyclopfight.Location = new System.Drawing.Point(543, 77);
            this.Cyclopfight.Name = "Cyclopfight";
            this.Cyclopfight.Size = new System.Drawing.Size(154, 240);
            this.Cyclopfight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Cyclopfight.TabIndex = 24;
            this.Cyclopfight.TabStop = false;
            // 
            // Robotfriend
            // 
            this.Robotfriend.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Robotfriend.Image = global::MyGame.Properties.Resources.robofriend;
            this.Robotfriend.Location = new System.Drawing.Point(12, 12);
            this.Robotfriend.Name = "Robotfriend";
            this.Robotfriend.Size = new System.Drawing.Size(47, 50);
            this.Robotfriend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Robotfriend.TabIndex = 25;
            this.Robotfriend.TabStop = false;
            // 
            // Robot2
            // 
            this.Robot2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Robot2.Image = global::MyGame.Properties.Resources.robot2;
            this.Robot2.Location = new System.Drawing.Point(65, 12);
            this.Robot2.Name = "Robot2";
            this.Robot2.Size = new System.Drawing.Size(47, 50);
            this.Robot2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Robot2.TabIndex = 26;
            this.Robot2.TabStop = false;
            // 
            // Robot3
            // 
            this.Robot3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Robot3.Image = global::MyGame.Properties.Resources.robot3;
            this.Robot3.Location = new System.Drawing.Point(118, 12);
            this.Robot3.Name = "Robot3";
            this.Robot3.Size = new System.Drawing.Size(47, 50);
            this.Robot3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Robot3.TabIndex = 27;
            this.Robot3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MyGame.Properties.Resources.fence;
            this.pictureBox1.Location = new System.Drawing.Point(2, 409);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(358, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MyGame.Properties.Resources.fence;
            this.pictureBox2.Location = new System.Drawing.Point(444, 409);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(342, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Robot3);
            this.Controls.Add(this.Robot2);
            this.Controls.Add(this.Robotfriend);
            this.Controls.Add(this.Cyclopfight);
            this.Controls.Add(this.rage);
            this.Controls.Add(this.Hero);
            this.Controls.Add(this.Coinslabel);
            this.Controls.Add(this.magic3);
            this.Controls.Add(this.magic2);
            this.Controls.Add(this.magic1);
            this.Controls.Add(this.third);
            this.Controls.Add(this.second);
            this.Controls.Add(this.first);
            this.Controls.Add(this.choose);
            this.Controls.Add(this.Startbutton);
            this.Controls.Add(this.EnemyHplabel);
            this.Controls.Add(this.HeroHplabel);
            this.Controls.Add(this.Items);
            this.Controls.Add(this.Magic);
            this.Controls.Add(this.Superpower);
            this.Controls.Add(this.BasicAttack);
            this.Controls.Add(this.WarriorFight);
            this.Controls.Add(this.OurHero);
            this.Controls.Add(this.Cyclop);
            this.Controls.Add(this.Warrior);
            this.Controls.Add(this.Tutorial);
            //this.Controls.Add(this.NPCTUtorial);
            this.Name = "Game";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Hero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NPCTUtorial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Warrior)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cyclop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OurHero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WarriorFight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cyclopfight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Robotfriend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Robot2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Robot3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer HeroMove;
        private System.Windows.Forms.PictureBox Hero;
        private System.Windows.Forms.PictureBox NPCTUtorial;
        private System.Windows.Forms.Timer Room1;
        private System.Windows.Forms.Timer HeroAnimate;
        private System.Windows.Forms.Label Tutorial;
        private System.Windows.Forms.PictureBox Warrior;
        private System.Windows.Forms.PictureBox Cyclop;
        private System.Windows.Forms.Timer Room2;
        private System.Windows.Forms.Timer Room3;
        private System.Windows.Forms.Timer Room4;
        private System.Windows.Forms.Timer Room5;
        private System.Windows.Forms.PictureBox OurHero;
        private System.Windows.Forms.PictureBox WarriorFight;
        private System.Windows.Forms.Timer Timer_Fight;
        private System.Windows.Forms.Button BasicAttack;
        private System.Windows.Forms.Button Superpower;
        private System.Windows.Forms.Button Magic;
        private System.Windows.Forms.Button Items;
        private System.Windows.Forms.Label HeroHplabel;
        private System.Windows.Forms.Label EnemyHplabel;
        private System.Windows.Forms.Button Startbutton;
        private System.Windows.Forms.Label choose;
        private System.Windows.Forms.Button first;
        private System.Windows.Forms.Button second;
        private System.Windows.Forms.Button third;
        private System.Windows.Forms.Button magic1;
        private System.Windows.Forms.Button magic2;
        private System.Windows.Forms.Button magic3;
        private System.Windows.Forms.Label Coinslabel;
        private System.Windows.Forms.Button rage;
        private System.Windows.Forms.PictureBox Cyclopfight;
        private System.Windows.Forms.PictureBox Robotfriend;
        private System.Windows.Forms.PictureBox Robot2;
        private System.Windows.Forms.PictureBox Robot3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

