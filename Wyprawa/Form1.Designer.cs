namespace Wyprawa
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Player = new System.Windows.Forms.PictureBox();
            this.bat = new System.Windows.Forms.PictureBox();
            this.ghost = new System.Windows.Forms.PictureBox();
            this.ghoul = new System.Windows.Forms.PictureBox();
            this.redPotion = new System.Windows.Forms.PictureBox();
            this.sword = new System.Windows.Forms.PictureBox();
            this.bluePotion = new System.Windows.Forms.PictureBox();
            this.bow = new System.Windows.Forms.PictureBox();
            this.mace = new System.Windows.Forms.PictureBox();
            this.pictureSword = new System.Windows.Forms.PictureBox();
            this.pictureBluePotion = new System.Windows.Forms.PictureBox();
            this.pictureMace = new System.Windows.Forms.PictureBox();
            this.pictureBow = new System.Windows.Forms.PictureBox();
            this.pictureRedPotion = new System.Windows.Forms.PictureBox();
            this.moveLeft = new System.Windows.Forms.Button();
            this.moveUp = new System.Windows.Forms.Button();
            this.moveDown = new System.Windows.Forms.Button();
            this.moveRight = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.attackRight = new System.Windows.Forms.Button();
            this.attackDown = new System.Windows.Forms.Button();
            this.attackLeft = new System.Windows.Forms.Button();
            this.attackUp = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.playerHitPoints = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.batHitPoints = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ghostHitPoints = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ghoulHitPoints = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghoul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redPotion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluePotion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBluePotion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRedPotion)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.Transparent;
            this.Player.Image = ((System.Drawing.Image)(resources.GetObject("Player.Image")));
            this.Player.Location = new System.Drawing.Point(110, 77);
            this.Player.Margin = new System.Windows.Forms.Padding(4);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(40, 37);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player.TabIndex = 0;
            this.Player.TabStop = false;
            // 
            // bat
            // 
            this.bat.BackColor = System.Drawing.Color.Transparent;
            this.bat.Image = ((System.Drawing.Image)(resources.GetObject("bat.Image")));
            this.bat.Location = new System.Drawing.Point(158, 77);
            this.bat.Margin = new System.Windows.Forms.Padding(4);
            this.bat.Name = "bat";
            this.bat.Size = new System.Drawing.Size(40, 37);
            this.bat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bat.TabIndex = 2;
            this.bat.TabStop = false;
            // 
            // ghost
            // 
            this.ghost.BackColor = System.Drawing.Color.Transparent;
            this.ghost.Image = ((System.Drawing.Image)(resources.GetObject("ghost.Image")));
            this.ghost.Location = new System.Drawing.Point(206, 77);
            this.ghost.Margin = new System.Windows.Forms.Padding(4);
            this.ghost.Name = "ghost";
            this.ghost.Size = new System.Drawing.Size(40, 37);
            this.ghost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ghost.TabIndex = 3;
            this.ghost.TabStop = false;
            // 
            // ghoul
            // 
            this.ghoul.BackColor = System.Drawing.Color.Transparent;
            this.ghoul.Image = ((System.Drawing.Image)(resources.GetObject("ghoul.Image")));
            this.ghoul.Location = new System.Drawing.Point(254, 77);
            this.ghoul.Margin = new System.Windows.Forms.Padding(4);
            this.ghoul.Name = "ghoul";
            this.ghoul.Size = new System.Drawing.Size(40, 37);
            this.ghoul.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ghoul.TabIndex = 4;
            this.ghoul.TabStop = false;
            // 
            // redPotion
            // 
            this.redPotion.BackColor = System.Drawing.Color.Transparent;
            this.redPotion.Image = ((System.Drawing.Image)(resources.GetObject("redPotion.Image")));
            this.redPotion.Location = new System.Drawing.Point(302, 77);
            this.redPotion.Margin = new System.Windows.Forms.Padding(4);
            this.redPotion.Name = "redPotion";
            this.redPotion.Size = new System.Drawing.Size(40, 37);
            this.redPotion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.redPotion.TabIndex = 5;
            this.redPotion.TabStop = false;
            // 
            // sword
            // 
            this.sword.BackColor = System.Drawing.Color.Transparent;
            this.sword.Image = ((System.Drawing.Image)(resources.GetObject("sword.Image")));
            this.sword.Location = new System.Drawing.Point(398, 77);
            this.sword.Margin = new System.Windows.Forms.Padding(4);
            this.sword.Name = "sword";
            this.sword.Size = new System.Drawing.Size(40, 37);
            this.sword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sword.TabIndex = 6;
            this.sword.TabStop = false;
            // 
            // bluePotion
            // 
            this.bluePotion.BackColor = System.Drawing.Color.Transparent;
            this.bluePotion.Image = ((System.Drawing.Image)(resources.GetObject("bluePotion.Image")));
            this.bluePotion.Location = new System.Drawing.Point(350, 77);
            this.bluePotion.Margin = new System.Windows.Forms.Padding(4);
            this.bluePotion.Name = "bluePotion";
            this.bluePotion.Size = new System.Drawing.Size(40, 37);
            this.bluePotion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bluePotion.TabIndex = 7;
            this.bluePotion.TabStop = false;
            // 
            // bow
            // 
            this.bow.BackColor = System.Drawing.Color.Transparent;
            this.bow.Image = ((System.Drawing.Image)(resources.GetObject("bow.Image")));
            this.bow.Location = new System.Drawing.Point(446, 77);
            this.bow.Margin = new System.Windows.Forms.Padding(4);
            this.bow.Name = "bow";
            this.bow.Size = new System.Drawing.Size(40, 37);
            this.bow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bow.TabIndex = 8;
            this.bow.TabStop = false;
            // 
            // mace
            // 
            this.mace.BackColor = System.Drawing.Color.Transparent;
            this.mace.Image = ((System.Drawing.Image)(resources.GetObject("mace.Image")));
            this.mace.Location = new System.Drawing.Point(494, 77);
            this.mace.Margin = new System.Windows.Forms.Padding(4);
            this.mace.Name = "mace";
            this.mace.Size = new System.Drawing.Size(40, 37);
            this.mace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mace.TabIndex = 9;
            this.mace.TabStop = false;
            // 
            // pictureSword
            // 
            this.pictureSword.BackColor = System.Drawing.Color.Transparent;
            this.pictureSword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureSword.BackgroundImage")));
            this.pictureSword.Location = new System.Drawing.Point(98, 432);
            this.pictureSword.Margin = new System.Windows.Forms.Padding(4);
            this.pictureSword.Name = "pictureSword";
            this.pictureSword.Size = new System.Drawing.Size(67, 62);
            this.pictureSword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureSword.TabIndex = 10;
            this.pictureSword.TabStop = false;
            this.pictureSword.Click += new System.EventHandler(this.pictureBox10_Click);
            // 
            // pictureBluePotion
            // 
            this.pictureBluePotion.BackColor = System.Drawing.Color.Transparent;
            this.pictureBluePotion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBluePotion.BackgroundImage")));
            this.pictureBluePotion.Location = new System.Drawing.Point(374, 432);
            this.pictureBluePotion.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBluePotion.Name = "pictureBluePotion";
            this.pictureBluePotion.Size = new System.Drawing.Size(67, 62);
            this.pictureBluePotion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBluePotion.TabIndex = 11;
            this.pictureBluePotion.TabStop = false;
            this.pictureBluePotion.Click += new System.EventHandler(this.pictureBluePotion_Click);
            // 
            // pictureMace
            // 
            this.pictureMace.BackColor = System.Drawing.Color.Transparent;
            this.pictureMace.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureMace.BackgroundImage")));
            this.pictureMace.Location = new System.Drawing.Point(237, 432);
            this.pictureMace.Margin = new System.Windows.Forms.Padding(4);
            this.pictureMace.Name = "pictureMace";
            this.pictureMace.Size = new System.Drawing.Size(67, 62);
            this.pictureMace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureMace.TabIndex = 12;
            this.pictureMace.TabStop = false;
            this.pictureMace.Click += new System.EventHandler(this.pictureMace_Click);
            // 
            // pictureBow
            // 
            this.pictureBow.BackColor = System.Drawing.Color.Transparent;
            this.pictureBow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBow.BackgroundImage")));
            this.pictureBow.Location = new System.Drawing.Point(168, 432);
            this.pictureBow.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBow.Name = "pictureBow";
            this.pictureBow.Size = new System.Drawing.Size(67, 62);
            this.pictureBow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBow.TabIndex = 13;
            this.pictureBow.TabStop = false;
            this.pictureBow.Click += new System.EventHandler(this.pictureBox13_Click);
            // 
            // pictureRedPotion
            // 
            this.pictureRedPotion.BackColor = System.Drawing.Color.Transparent;
            this.pictureRedPotion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureRedPotion.BackgroundImage")));
            this.pictureRedPotion.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureRedPotion.Location = new System.Drawing.Point(312, 432);
            this.pictureRedPotion.Margin = new System.Windows.Forms.Padding(4);
            this.pictureRedPotion.Name = "pictureRedPotion";
            this.pictureRedPotion.Size = new System.Drawing.Size(67, 62);
            this.pictureRedPotion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureRedPotion.TabIndex = 14;
            this.pictureRedPotion.TabStop = false;
            this.pictureRedPotion.Click += new System.EventHandler(this.pictureRedPotion_Click);
            // 
            // moveLeft
            // 
            this.moveLeft.Location = new System.Drawing.Point(8, 37);
            this.moveLeft.Margin = new System.Windows.Forms.Padding(4);
            this.moveLeft.Name = "moveLeft";
            this.moveLeft.Size = new System.Drawing.Size(33, 31);
            this.moveLeft.TabIndex = 0;
            this.moveLeft.Text = "←";
            this.moveLeft.UseVisualStyleBackColor = true;
            this.moveLeft.Visible = false;
            this.moveLeft.Click += new System.EventHandler(this.moveLeft_Click);
            // 
            // moveUp
            // 
            this.moveUp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.moveUp.Location = new System.Drawing.Point(44, 22);
            this.moveUp.Margin = new System.Windows.Forms.Padding(4);
            this.moveUp.Name = "moveUp";
            this.moveUp.Size = new System.Drawing.Size(33, 31);
            this.moveUp.TabIndex = 1;
            this.moveUp.Text = "↑";
            this.moveUp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.moveUp.UseVisualStyleBackColor = true;
            this.moveUp.Visible = false;
            this.moveUp.Click += new System.EventHandler(this.button2_Click);
            // 
            // moveDown
            // 
            this.moveDown.Location = new System.Drawing.Point(44, 57);
            this.moveDown.Margin = new System.Windows.Forms.Padding(4);
            this.moveDown.Name = "moveDown";
            this.moveDown.Size = new System.Drawing.Size(33, 31);
            this.moveDown.TabIndex = 2;
            this.moveDown.Text = "↓";
            this.moveDown.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.moveDown.UseVisualStyleBackColor = true;
            this.moveDown.Visible = false;
            this.moveDown.Click += new System.EventHandler(this.button3_Click);
            // 
            // moveRight
            // 
            this.moveRight.Location = new System.Drawing.Point(80, 37);
            this.moveRight.Margin = new System.Windows.Forms.Padding(4);
            this.moveRight.Name = "moveRight";
            this.moveRight.Size = new System.Drawing.Size(33, 31);
            this.moveRight.TabIndex = 3;
            this.moveRight.Text = "→";
            this.moveRight.UseVisualStyleBackColor = true;
            this.moveRight.Visible = false;
            this.moveRight.Click += new System.EventHandler(this.moveRight_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.moveRight);
            this.groupBox1.Controls.Add(this.moveDown);
            this.groupBox1.Controls.Add(this.moveLeft);
            this.groupBox1.Controls.Add(this.moveUp);
            this.groupBox1.Location = new System.Drawing.Point(514, 412);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(120, 92);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ruch";
            this.groupBox1.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.attackRight);
            this.groupBox2.Controls.Add(this.attackDown);
            this.groupBox2.Controls.Add(this.attackLeft);
            this.groupBox2.Controls.Add(this.attackUp);
            this.groupBox2.Location = new System.Drawing.Point(642, 412);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(120, 92);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Atak";
            // 
            // attackRight
            // 
            this.attackRight.Location = new System.Drawing.Point(80, 37);
            this.attackRight.Margin = new System.Windows.Forms.Padding(4);
            this.attackRight.Name = "attackRight";
            this.attackRight.Size = new System.Drawing.Size(33, 31);
            this.attackRight.TabIndex = 3;
            this.attackRight.Text = "→";
            this.attackRight.UseVisualStyleBackColor = true;
            this.attackRight.Click += new System.EventHandler(this.attackRight_Click);
            // 
            // attackDown
            // 
            this.attackDown.Location = new System.Drawing.Point(44, 57);
            this.attackDown.Margin = new System.Windows.Forms.Padding(4);
            this.attackDown.Name = "attackDown";
            this.attackDown.Size = new System.Drawing.Size(33, 31);
            this.attackDown.TabIndex = 2;
            this.attackDown.Text = "↓";
            this.attackDown.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.attackDown.UseVisualStyleBackColor = true;
            this.attackDown.Click += new System.EventHandler(this.attackDown_Click);
            // 
            // attackLeft
            // 
            this.attackLeft.Location = new System.Drawing.Point(8, 37);
            this.attackLeft.Margin = new System.Windows.Forms.Padding(4);
            this.attackLeft.Name = "attackLeft";
            this.attackLeft.Size = new System.Drawing.Size(33, 31);
            this.attackLeft.TabIndex = 0;
            this.attackLeft.Text = "←";
            this.attackLeft.UseVisualStyleBackColor = true;
            this.attackLeft.Click += new System.EventHandler(this.attackLeft_Click);
            // 
            // attackUp
            // 
            this.attackUp.Location = new System.Drawing.Point(44, 22);
            this.attackUp.Margin = new System.Windows.Forms.Padding(4);
            this.attackUp.Name = "attackUp";
            this.attackUp.Size = new System.Drawing.Size(33, 31);
            this.attackUp.TabIndex = 1;
            this.attackUp.Text = "↑";
            this.attackUp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.attackUp.UseVisualStyleBackColor = true;
            this.attackUp.Click += new System.EventHandler(this.attackUp_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel2.Controls.Add(this.playerHitPoints, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.batHitPoints, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.ghostHitPoints, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.ghoulHitPoints, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(543, 332);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 72);
            this.tableLayoutPanel2.TabIndex = 18;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // playerHitPoints
            // 
            this.playerHitPoints.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.playerHitPoints.AutoSize = true;
            this.playerHitPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.playerHitPoints.Location = new System.Drawing.Point(91, 0);
            this.playerHitPoints.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.playerHitPoints.Name = "playerHitPoints";
            this.playerHitPoints.Size = new System.Drawing.Size(105, 16);
            this.playerHitPoints.TabIndex = 1;
            this.playerHitPoints.Text = "playerHitPoints";
            this.playerHitPoints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(4, 17);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nietoperz";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // batHitPoints
            // 
            this.batHitPoints.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.batHitPoints.AutoSize = true;
            this.batHitPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.batHitPoints.Location = new System.Drawing.Point(91, 17);
            this.batHitPoints.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.batHitPoints.Name = "batHitPoints";
            this.batHitPoints.Size = new System.Drawing.Size(105, 16);
            this.batHitPoints.TabIndex = 3;
            this.batHitPoints.Text = "batHitPoints";
            this.batHitPoints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(4, 36);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Duch";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ghostHitPoints
            // 
            this.ghostHitPoints.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ghostHitPoints.AutoSize = true;
            this.ghostHitPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ghostHitPoints.Location = new System.Drawing.Point(91, 36);
            this.ghostHitPoints.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ghostHitPoints.Name = "ghostHitPoints";
            this.ghostHitPoints.Size = new System.Drawing.Size(105, 16);
            this.ghostHitPoints.TabIndex = 5;
            this.ghostHitPoints.Text = "ghostHitPoints";
            this.ghostHitPoints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(4, 54);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Upiór";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ghoulHitPoints
            // 
            this.ghoulHitPoints.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ghoulHitPoints.AutoSize = true;
            this.ghoulHitPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ghoulHitPoints.Location = new System.Drawing.Point(91, 54);
            this.ghoulHitPoints.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ghoulHitPoints.Name = "ghoulHitPoints";
            this.ghoulHitPoints.Size = new System.Drawing.Size(105, 16);
            this.ghoulHitPoints.TabIndex = 7;
            this.ghoulHitPoints.Text = "ghoulHitPoints";
            this.ghoulHitPoints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gracz";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.UseCompatibleTextRendering = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(846, 536);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.pictureRedPotion);
            this.Controls.Add(this.pictureBow);
            this.Controls.Add(this.pictureMace);
            this.Controls.Add(this.pictureBluePotion);
            this.Controls.Add(this.pictureSword);
            this.Controls.Add(this.ghoul);
            this.Controls.Add(this.ghost);
            this.Controls.Add(this.bat);
            this.Controls.Add(this.redPotion);
            this.Controls.Add(this.bluePotion);
            this.Controls.Add(this.sword);
            this.Controls.Add(this.bow);
            this.Controls.Add(this.mace);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Wyprawa";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghoul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redPotion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluePotion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBluePotion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRedPotion)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.PictureBox bat;
        private System.Windows.Forms.PictureBox ghost;
        private System.Windows.Forms.PictureBox ghoul;
        private System.Windows.Forms.PictureBox redPotion;
        private System.Windows.Forms.PictureBox sword;
        private System.Windows.Forms.PictureBox bluePotion;
        private System.Windows.Forms.PictureBox bow;
        private System.Windows.Forms.PictureBox mace;
        private System.Windows.Forms.PictureBox pictureSword;
        private System.Windows.Forms.PictureBox pictureBluePotion;
        private System.Windows.Forms.PictureBox pictureMace;
        private System.Windows.Forms.PictureBox pictureBow;
        private System.Windows.Forms.PictureBox pictureRedPotion;
        private System.Windows.Forms.Button moveLeft;
        private System.Windows.Forms.Button moveUp;
        private System.Windows.Forms.Button moveDown;
        private System.Windows.Forms.Button moveRight;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button attackRight;
        private System.Windows.Forms.Button attackDown;
        private System.Windows.Forms.Button attackLeft;
        private System.Windows.Forms.Button attackUp;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label playerHitPoints;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label batHitPoints;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label ghostHitPoints;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label ghoulHitPoints;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}

