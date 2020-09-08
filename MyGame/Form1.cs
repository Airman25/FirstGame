using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGame
{
    public partial class Game : Form
    {
        int heroStep = 10;
        int heroImage = 1;
        string heroDirection = "right";
        int RoomLeft = 0;
        int RoomUp = 0;
        int NPCtutorial = 0;
        int HeroHP = 1;
        int EnemyHP = 1;
        int HeroDamage = 5;
        int HeroMagicDamage = 10;
        int armor = 0;
        int EnemyDamage = 10;
        int coins = 0;
        String enemyname = "";
        int warriorwin = 0;
        int cyclopwin = 0;
        int magicon = 1;
        int superpoweron = 1;
        int itemson = 1;
        int raged = 0;
        int robotfriended = 0;
        public Game()
        {
            InitializeComponent();
            SetupGame();

        }

        private void SetupGame()
        {
            this.BackColor = Color.White;
            Hero.BackColor = Color.Transparent;
            NPCTUtorial.BackColor = Color.Transparent;
            Warrior.BackColor = Color.Transparent;
            Cyclop.BackColor = Color.Transparent;
            Robotfriend.BackColor = Color.Transparent;
            Robot2.BackColor = Color.Transparent;
            Robot3.BackColor = Color.Transparent;
            OurHero.BackColor = Color.Transparent;
            WarriorFight.BackColor = Color.Transparent;
            Cyclopfight.BackColor = Color.Transparent;
            Hero.SizeMode = PictureBoxSizeMode.StretchImage;
            NPCTUtorial.BackColor = Color.Transparent;
            NPCTUtorial.SizeMode = PictureBoxSizeMode.StretchImage;
            Hero.Width = 50;
            Hero.Height = 50;
            Robotfriend.Width = 50;
            Robotfriend.Height = 50;
            Robot2.Width = 50;
            Robot2.Height = 50;
            Robot3.Width = 50;
            Robot3.Height = 50;
            NPCTUtorial.Width = 50;
            NPCTUtorial.Height = 50;
            Warrior.Width = 50;
            Warrior.Height = 50;
            Cyclop.Width = 75;
            Cyclop.Height = 75;
            Invisibility();
        }
        private void Invisibility()
        {
            Coinslabel.Visible = false;
            OurHero.Visible = false;
            WarriorFight.Visible = false;
            BasicAttack.Visible = false;
            Superpower.Visible = false;
            Magic.Visible = false;
            magic1.Visible = false;
            magic2.Visible = false;
            magic3.Visible = false;
            Items.Visible = false;
            HeroHplabel.Visible = false;
            EnemyHplabel.Visible = false;
            Warrior.Visible = false;
            Cyclop.Visible = false;
            Hero.Visible = false;
            NPCTUtorial.Visible = false;
            Tutorial.Visible = false;
            first.Visible = false;
            second.Visible = false;
            third.Visible = false;
            choose.Visible = false;
            rage.Visible = false;
            Cyclopfight.Visible = false;
            Robotfriend.Visible = false;
            Robot2.Visible = false;
            Robot3.Visible = false;
        }
        private void HeroBorderCollision()
        {
            if (Hero.Top + Hero.Height < 0)
            {
                Hero.Top = ClientRectangle.Height;
                RoomUp += 1;
            }
            if (Hero.Top > ClientRectangle.Height)
            {
                Hero.Top = 0 - Hero.Height;
                RoomUp -= 1;
            }
            if (Hero.Left + Hero.Width < 0)
            {
                Hero.Left = ClientRectangle.Width;
                RoomLeft += 1;
            }
            if (Hero.Left > ClientRectangle.Width)
            {
                Hero.Left = 0 - Hero.Width;
                RoomLeft -= 1;
            }
        }

        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W | e.KeyCode == Keys.Up)
            {
                Hero.Top -= heroStep;
                heroDirection = "up";
            }
            else if (e.KeyCode == Keys.S | e.KeyCode == Keys.Down)
            {
                Hero.Top += heroStep;
                heroDirection = "down";
            }
            else if (e.KeyCode == Keys.A | e.KeyCode == Keys.Left)
            {
                Hero.Left -= heroStep;
                heroDirection = "left";
            }
            else if (e.KeyCode == Keys.D | e.KeyCode == Keys.Right)
            {
                Hero.Left += heroStep;
                heroDirection = "right";
            }
        }

        private void Heromove_Tick_1(object sender, EventArgs e)
        {
            HeroBorderCollision();
        }

        private void HeroNPCCollision()
        {
            if (Hero.Bounds.IntersectsWith(NPCTUtorial.Bounds))
            {
                Tutorial.Visible = true;
            }
        }
        private void HeroWarriorCollision()
        {
            if (Hero.Bounds.IntersectsWith(Warrior.Bounds))
            {
                enemyname = "Warrior";
                WarriorFight.Visible = true;
                EnemyHP = 150;
                HeroBattle();

            }
        }
        private void HeroBattle()
        {
            magic1.Enabled = true;
            magic2.Enabled = true;
            magic3.Enabled = true;
            RoomUp = 999;
            RoomLeft = 999;
            Hero.Visible = false;
            OurHero.Visible = true;
            HeroHP = 100 + armor;
            BasicAttack.Visible = true;
            Superpower.Visible = true;
            Magic.Visible = true;
            Items.Visible = true;
            HeroHplabel.Visible = true;
            EnemyHplabel.Visible = true;
        }
        private void HeroCyclopCollision()
        {
            if (Hero.Bounds.IntersectsWith(Cyclop.Bounds))
            {
                enemyname = "Cyclop";
                Cyclopfight.Visible = true;
                EnemyHP = 300;
                HeroBattle();
            }
        }
        private void Room1_Tick(object sender, EventArgs e)
        {
            if (RoomUp != 0 | RoomLeft != 0)
            {
                NPCTUtorial.Visible = false;
            }
            if (RoomUp == 0 && RoomLeft == 0)
            {
                NPCTUtorial.Visible = true;
                HeroNPCCollision();
            }
            Coinslabel.Text = "Coins:" + coins;
        }

        private void HeroAnimate_Tick(object sender, EventArgs e)
        {
            string heroImageName;
            heroImageName = "stickminforgame" + heroImage;
            Hero.Image = (Image)Properties.Resources.ResourceManager.GetObject(heroImageName);
            heroImage += 1; //heroImage++
            if (heroImage > 2)
            {
                heroImage = 1;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (NPCtutorial == 5)
            {
                Tutorial.Visible = false;
                NPCtutorial = -1;
            }
            if (NPCtutorial == 4)
            {
                Tutorial.Text = " Thats all click one more time to close";
                NPCtutorial += 1;
            }
            if (NPCtutorial == 3)
            {
                Tutorial.Text = " Press I to interact with Furnace(maybe other machienes later)...";
                NPCtutorial += 1;
            }
            if (NPCtutorial == 2)
            {
                Tutorial.Text = " You also could trade with some NPC's by pressing Y...";
                NPCtutorial += 1;
            }

            if (NPCtutorial == 1)
            {
                Tutorial.Text = " So you need to use WASD to move and E to open inventory, Space to start fight...";
                NPCtutorial += 1;
            }
            if (NPCtutorial == 0)
            {
                Tutorial.Text = " Hello I am Tutorial NPC i would tell you how the game works...";
                NPCtutorial += 1;
            }
        }

        private void Room2_Tick(object sender, EventArgs e)
        {
            if (RoomUp != -1 | RoomLeft != 0)
            {
                Warrior.Visible = false;
                Cyclop.Visible = false;
            }
            if (RoomUp == -1 && RoomLeft == 0)
            {
                if (warriorwin == 0)
                {
                    Warrior.Visible = true;
                    HeroWarriorCollision();
                }
                if (cyclopwin == 0)
                {
                    Cyclop.Visible = true;
                    HeroCyclopCollision();
                }

            }

        }

        private void Timer_Fight_Tick(object sender, EventArgs e)
        {
            BasicAttack.Enabled = true;
            Superpower.Enabled = true;
            Magic.Enabled = true;
            Items.Enabled = true;
            HeroHplabel.Text = "Hero HP" + HeroHP;
            EnemyHplabel.Text = "Enemy HP" + EnemyHP;
            if (HeroHP <= 0)
            {
                HeroHP = 1;
                HeroAnimate.Stop();
                Invisibility();
                Startbutton.Enabled = true;
                Startbutton.Visible = true;
            }
            if (EnemyHP <= 0)
            {
                BasicAttack.Enabled = false;
                Superpower.Enabled = false;
                Magic.Enabled = false;
                magic1.Enabled = false;
                magic2.Enabled = false;
                magic3.Enabled = false;
                Items.Enabled = false;
                rage.Enabled = false;
                EnemyHP = 1;
                Invisibility();
                HeroAnimate.Start();
                Hero.Visible = true;
                youwin();
            }
        }
        private void youwin()
        {
            if (enemyname == "Warrior")
            {
                WarriorFight.Visible = false;
                coins += 10;
                warriorwin = 1;
                RoomUp = -1;
                RoomLeft = 0;
                HeroDamage += 15;
                armor += 50;
            }
            if (enemyname == "Cyclop")
            {
                Cyclopfight.Visible = false;
                coins += 100;
                cyclopwin = 1;
                RoomUp = -1;
                RoomLeft = 0;
                HeroDamage += 50;
            }
        }
        private void BasicAttack_Click(object sender, EventArgs e)
        {
            EnemyHP -= HeroDamage;
            Enemyturn();
        }
        private void Enemyturn()
        {
            if (enemyname == "Warrior")
            {
                HeroHP -= EnemyDamage * 2;
            }
            if (enemyname == "Cyclop")
            {
                HeroHP -= EnemyDamage * 10;
            }
            if (enemyname == "")
            {
                HeroHP -= EnemyDamage;
            }
        }

        private void Superpower_Click(object sender, EventArgs e)
        {

            if (superpoweron == 1)
            {
                superpoweron = 0;
                magic1.Visible = false;
                magic2.Visible = false;
                magic3.Visible = false;
                if (raged == 0)
                {
                    rage.Visible = true;
                }
            }
            else
            {
                superpoweron = 1;
                rage.Visible = false;
            }
        }

        private void Magic_Click(object sender, EventArgs e)
        {
            if (magicon == 1)
            {
                magicon = 0;
                rage.Visible = false;
                magic1.Visible = true;
                magic2.Visible = true;
                magic3.Visible = true;
            }
            else
            {
                magicon = 1;
                magic1.Visible = false;
                magic2.Visible = false;
                magic3.Visible = false;
            }


        }

        private void Items_Click(object sender, EventArgs e)
        {
            if (itemson == 1)
            {
                itemson = 0;
                rage.Visible = false;
                magic1.Visible = false;
                magic2.Visible = false;
                magic3.Visible = false;
            }
            else
            {
                itemson = 1;

            }

        }

        private void Startbutton_Click(object sender, EventArgs e)
        {
            Startbutton.Visible = false;
            Startbutton.Enabled = false;
            first.Visible = true;
            second.Visible = true;
            third.Visible = true;
            choose.Visible = true;
            Hero.Visible = true;
            first.Enabled = true;
            second.Enabled = true;
            third.Enabled = true;
            BasicAttack.Enabled = false;
            Superpower.Enabled = false;
            Magic.Enabled = false;
            magic1.Enabled = false;
            magic2.Enabled = false;
            magic3.Enabled = false;
            Items.Enabled = false;
        }

        private void first_Click(object sender, EventArgs e)
        {
            first.Visible = false;
            second.Visible = false;
            third.Visible = false;
            choose.Visible = false;
            first.Enabled = false;
            second.Enabled = false;
            third.Enabled = false;
            Hero.Visible = true;
            HeroMove.Start();
            HeroAnimate.Start();
            Timer_Fight.Start();
            Room1.Start();
            Room2.Start();
            Room3.Start();
            RoomUp = 0;
            RoomLeft = 0;
        }

        private void second_Click(object sender, EventArgs e)
        {
            first.Visible = false;
            second.Visible = false;
            third.Visible = false;
            choose.Visible = false;
            Startbutton.Enabled = true;
            Startbutton.Visible = true;
            first.Enabled = false;
            second.Enabled = false;
            third.Enabled = false;
        }

        private void third_Click(object sender, EventArgs e)
        {
            first.Visible = false;
            second.Visible = false;
            third.Visible = false;
            choose.Visible = false;
            Startbutton.Enabled = true;
            Startbutton.Visible = true;
            first.Enabled = false;
            second.Enabled = false;
            third.Enabled = false;
        }

        private void Hero_Click(object sender, EventArgs e)
        {
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game_KeyDown);
        }

        private void magic1_Click(object sender, EventArgs e)
        {
            EnemyHP -= HeroMagicDamage * 5;
            Enemyturn();
            magic1.Enabled = false;
            magic1.Visible = false;
            magic2.Visible = false;
            magic3.Visible = false;
        }

        private void magic2_Click(object sender, EventArgs e)
        {
            EnemyHP -= HeroMagicDamage * 2;
            EnemyDamage -= 2;
            Enemyturn();
            magic2.Enabled = false;
            magic1.Visible = false;
            magic2.Visible = false;
            magic3.Visible = false;
        }

        private void magic3_Click(object sender, EventArgs e)
        {
            EnemyHP -= HeroMagicDamage;
            magic3.Enabled = false;
            magic1.Visible = false;
            magic2.Visible = false;
            magic3.Visible = false;
        }

        private void rage_Click(object sender, EventArgs e)
        {
            raged = 1;
            HeroDamage = HeroDamage * 10;
            rage.Visible = false;
            rage.Enabled = false;
        }

        private void Room3_Tick(object sender, EventArgs e)
        {
            if (RoomUp != 0 | RoomLeft != 1)
            {
                Robotfriend.Visible = false;
                Robot2.Visible = false;
                Robot3.Visible = false;
            }
            if (RoomUp == 0 && RoomLeft == 1)
            {
                if (robotfriended == 0)
                {
                    Robotfriend.Visible = true;
                    HeroRobotCollision();
                }
                Robot2.Visible = true;
                Robot3.Visible = true;
            }
        }

        private void HeroRobotCollision()
        {
            if (Hero.Bounds.IntersectsWith(Robotfriend.Bounds))
            {
                Tutorial.Visible = true;
            }
        }
    }
}
