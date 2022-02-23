using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Wyprawa
{
    public partial class Form1 : Form
    {
        private Game game;
        private Random random = new Random();
        private List<System.Windows.Forms.PictureBox> menuPictures;
        private List<System.Windows.Forms.Button> attackButtons;
       

        public Form1()
        {
            InitializeComponent();
            KeyPreview = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            menuPictures = new List<PictureBox>() { pictureSword, pictureBow, pictureMace, pictureRedPotion, pictureBluePotion };
            attackButtons = new List<Button>() { attackDown, attackLeft, attackRight, attackUp };            
            game = new Game(new System.Drawing.Rectangle(78, 57, 450, 185));
            game.NewLevel(random);
            timer1.Start();
            UpdateCharacters();            
        }

        public void UpdateCharacters()
        {
            Player.Location = game.PlayerLocation;
            playerHitPoints.Text = game.PlayerHitPoints.ToString();
            bool showBat = false;
            bool showGhost = false;
            bool showGhoul = false;
            bool levelChanged = false;
            int enemiesShown = 0;
            foreach (Enemy enemy in game.Enemies)
            {
                if (enemy is Bat)
                {
                    bat.Location = enemy.Location;
                    batHitPoints.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints>0)
                    {
                        bat.Visible = true;
                        showBat = true;
                        enemiesShown++;
                    }
                }
            }
            foreach (Enemy enemy in game.Enemies)
            {
                if (enemy is Ghost)
                {
                    ghost.Location = enemy.Location;
                    ghostHitPoints.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        ghost.Visible = true;
                        showGhost = true;
                        enemiesShown++;
                    }
                }
            }
            foreach (Enemy enemy in game.Enemies)
            {
                if (enemy is Ghoul)
                {
                    ghoul.Location = enemy.Location;
                    ghoulHitPoints.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        ghoul.Visible = true;

                        showGhoul = true;
                        enemiesShown++;
                    }
                }
            }
            if (!showBat)
            {
                bat.Visible = false;
                batHitPoints.Text = "";
            }
            if (!showGhost)
            {
                ghost.Visible = false;
                ghostHitPoints.Text = "";
            }
            if (!showGhoul)
            {
                ghoul.Visible = false;
                ghoulHitPoints.Text = "";
            }

            sword.Visible = false;
            bow.Visible = false;
            mace.Visible = false;
            redPotion.Visible = false;
            bluePotion.Visible = false;
            Control weaponContol = null;
            switch (game.WeaponInRoom.Name)
            {
                case "Miecz":
                    weaponContol = sword; break;
                case "Łuk":
                    weaponContol = bow; break;
                case "Buława":
                    weaponContol = mace; break;
                case "Czerwona mikstura":
                    weaponContol = redPotion; break;
                case "Niebieska mikstura":
                    weaponContol = bluePotion; break;
                default:
                    break;
            }
            weaponContol.Visible = true;
            pictureSword.Visible = false;
            pictureMace.Visible = false;
            pictureBow.Visible = false;
            pictureBluePotion.Visible = false;
            pictureRedPotion.Visible = false;
            if (game.CheckPlayerInventory("Miecz"))
            {
                pictureSword.Visible = true;
            }
            if (game.CheckPlayerInventory("Łuk"))
            {
                pictureBow.Visible = true;
            }
            if (game.CheckPlayerInventory("Buława"))
            {
                pictureMace.Visible = true;
            }
            if (game.CheckPlayerInventory("Niebieska mikstura"))
            {
                pictureBluePotion.Visible = true;
            }
            if (game.CheckPlayerInventory("Czerwona mikstura"))
            {
                pictureRedPotion.Visible = true;
            }

            weaponContol.Location = game.WeaponInRoom.Location;
            if (game.WeaponInRoom.PickedUp)
            {
                weaponContol.Visible = false;
            }
            else
            {
                weaponContol.Visible = true;
            }

            if (game.PlayerHitPoints <= 0)
            {
                MessageBox.Show("Zostałeś zabity ");
                Application.Exit();
            }
            if (levelChanged = true && timer1.Enabled==false)
            {
                timer1.Start();
                levelChanged = false;
            }
            if (enemiesShown<1)
            {
                timer1.Stop();
                MessageBox.Show("Pokonałeś przeciwników na tym poziomie");                
                game.NewLevel(random);
                levelChanged = true;
                UpdateCharacters();
            }

            if (game.Level == 8)
            {
                timer1.Stop();
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Down, random);
            UpdateCharacters();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {
            
        }
        //miecz
        private void pictureBox10_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("Miecz"))
            {
                game.Equip("Miecz");
                foreach (PictureBox picture in menuPictures)
                {
                    if (picture.Name==pictureSword.Name)
                    {
                        picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                    }
                    else
                    {
                        picture.BorderStyle = System.Windows.Forms.BorderStyle.None;
                    }
                }
                foreach (Button button in attackButtons)
                {
                    if (button.Name == attackUp.Name)
                    {
                        button.Text = "↑";
                    }
                    else
                    {
                        button.Visible = true;
                    }
                }

            }
        }
        //Łuk
        private void pictureBox13_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("Łuk"))
            {
                game.Equip("Łuk");
                foreach (PictureBox picture in menuPictures)
                {
                    if (picture.Name == pictureBow.Name)
                    {
                        picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                    }
                    else
                    {
                        picture.BorderStyle = System.Windows.Forms.BorderStyle.None;
                    }
                }
                foreach (Button button in attackButtons)
                {
                    if (button.Name == attackUp.Name)
                    {
                        button.Text = "↑";
                    }
                    else
                    {
                        button.Visible = true;
                    }
                }

            }
        }

        private void pictureMace_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("Buława"))
            {
                game.Equip("Buława");
                foreach (PictureBox picture in menuPictures)
                {
                    if (picture.Name == pictureMace.Name)
                    {
                        picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                    }
                    else
                    {
                        picture.BorderStyle = System.Windows.Forms.BorderStyle.None;
                    }
                }
                foreach (Button button in attackButtons)
                {
                    if (button.Name == attackUp.Name)
                    {
                        button.Text = "↑";
                    }
                    else
                    {
                        button.Visible = true;
                    }
                }

            }
        }

        private void pictureRedPotion_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("Czerwona mikstura"))
            {
                game.Equip("Czerwona mikstura");
                foreach (PictureBox picture in menuPictures)
                {
                    if (picture.Name == pictureRedPotion.Name)
                    {
                        picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                    }
                    else
                    {
                        picture.BorderStyle = System.Windows.Forms.BorderStyle.None;
                    }
                }
                foreach (Button button in attackButtons)
                {
                    if (button.Name == attackUp.Name)
                    {
                        button.Text = "Wypij";
                    }
                    else
                    {
                        button.Visible = false;
                    }
                }
            }
        }

        private void pictureBluePotion_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("Niebieska mikstura"))
            {
                game.Equip("Niebieska mikstura");
                foreach (PictureBox picture in menuPictures)
                {
                    if (picture.Name == pictureBluePotion.Name)
                    {
                        picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                    }
                    else
                    {
                        picture.BorderStyle = System.Windows.Forms.BorderStyle.None;
                    }
                }
                foreach (Button button in attackButtons)
                {
                    if (button.Name == attackUp.Name)
                    {
                        button.Text = "Wypij";
                    }
                    else
                    {
                        button.Visible = false;
                    }
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Up,random);
            UpdateCharacters();
        }

        private void moveLeft_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Left, random);
            UpdateCharacters();
        }

        private void moveRight_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Right, random);
            UpdateCharacters();
        }

        private void attackUp_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Up, random);
            
        }

        private void attackDown_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Down, random);
            
        }

        private void attackRight_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Right, random);
           
        }

        private void attackLeft_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Left, random);
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            game.Move(random);
            if (game.PlayerHitPoints <= 0)
            {
                timer1.Stop();
            }
            else if (game.Level==8)
            {
                timer1.Stop();
            }
            UpdateCharacters();
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.W)
            {
                game.Move(Direction.Up);
                UpdateCharacters();
            }
            else if (e.KeyCode == Keys.A)
            {
                game.Move(Direction.Left);
                UpdateCharacters();
            }
            else if(e.KeyCode == Keys.D)
            {
                game.Move(Direction.Right);
                UpdateCharacters();
            }
            else if (e.KeyCode == Keys.S)
            {
                game.Move(Direction.Down);
                UpdateCharacters();
            }
            
        }

        
    }
}
