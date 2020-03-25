namespace Shooting_Games
{
    partial class frmGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGame));
            this.MovementControlsTick = new System.Windows.Forms.Timer(this.components);
            this.BulletTimer = new System.Windows.Forms.Timer(this.components);
            this.WallCollisionTick = new System.Windows.Forms.Timer(this.components);
            this.zombie1Tick = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMedkits = new System.Windows.Forms.Label();
            this.shiftButton = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rightButton = new System.Windows.Forms.Label();
            this.leftButton = new System.Windows.Forms.Label();
            this.spaceButton = new System.Windows.Forms.Label();
            this.upButton = new System.Windows.Forms.Label();
            this.downButton = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblHealth = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.rButton = new System.Windows.Forms.Label();
            this.lblAmmo = new System.Windows.Forms.Label();
            this.fButton = new System.Windows.Forms.Label();
            this.progressBarHP = new CircularProgressBar.CircularProgressBar();
            this.progressBarStamina = new CircularProgressBar.CircularProgressBar();
            this.lblZombieWave = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblZombieLeft = new System.Windows.Forms.Label();
            this.StaminaTick = new System.Windows.Forms.Timer(this.components);
            this.lblCoin = new System.Windows.Forms.Label();
            this.SpawnZombieTimer = new System.Windows.Forms.Timer(this.components);
            this.ZombieDamageTick = new System.Windows.Forms.Timer(this.components);
            this.BulletCollisionZombie = new System.Windows.Forms.Timer(this.components);
            this.battleFieldBound = new System.Windows.Forms.Panel();
            this.ZombieWaveOnStart = new System.Windows.Forms.Timer(this.components);
            this.txtGUI_ContainerWave = new System.Windows.Forms.Panel();
            this.txtGUI_NumTwo = new System.Windows.Forms.Panel();
            this.txtGUI_NumOne = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.OnDelayTextGUITimer = new System.Windows.Forms.Timer(this.components);
            this.GameHeartbeatTick = new System.Windows.Forms.Timer(this.components);
            this.gameOverGUI = new System.Windows.Forms.Panel();
            this.bttnPlayAgain = new System.Windows.Forms.Button();
            this.bttnBackToMenu = new System.Windows.Forms.Button();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.rightWall = new System.Windows.Forms.PictureBox();
            this.topWall = new System.Windows.Forms.PictureBox();
            this.bottomWall = new System.Windows.Forms.PictureBox();
            this.leftWall = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.txtGUI_WaveCleared = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.txtGUI_ContainerWave.SuspendLayout();
            this.gameOverGUI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightWall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topWall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomWall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftWall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            this.SuspendLayout();
            // 
            // MovementControlsTick
            // 
            this.MovementControlsTick.Interval = 1;
            this.MovementControlsTick.Tick += new System.EventHandler(this.MovementControlsTick_Tick);
            // 
            // BulletTimer
            // 
            this.BulletTimer.Interval = 1;
            this.BulletTimer.Tick += new System.EventHandler(this.BulletTimer_Tick);
            // 
            // WallCollisionTick
            // 
            this.WallCollisionTick.Interval = 10;
            this.WallCollisionTick.Tick += new System.EventHandler(this.WallCollisionTick_Tick);
            // 
            // zombie1Tick
            // 
            this.zombie1Tick.Interval = 1;
            this.zombie1Tick.Tick += new System.EventHandler(this.zombie1Tick_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.lblMedkits);
            this.panel1.Controls.Add(this.shiftButton);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblHealth);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox10);
            this.panel1.Controls.Add(this.rButton);
            this.panel1.Controls.Add(this.lblAmmo);
            this.panel1.Controls.Add(this.fButton);
            this.panel1.Controls.Add(this.progressBarHP);
            this.panel1.Controls.Add(this.progressBarStamina);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(187, 679);
            this.panel1.TabIndex = 4;
            // 
            // lblMedkits
            // 
            this.lblMedkits.BackColor = System.Drawing.Color.Transparent;
            this.lblMedkits.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedkits.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblMedkits.Location = new System.Drawing.Point(103, 392);
            this.lblMedkits.Name = "lblMedkits";
            this.lblMedkits.Size = new System.Drawing.Size(77, 32);
            this.lblMedkits.TabIndex = 0;
            this.lblMedkits.Text = "10 Left(s)";
            this.lblMedkits.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMedkits.UseMnemonic = false;
            // 
            // shiftButton
            // 
            this.shiftButton.BackColor = System.Drawing.Color.Tomato;
            this.shiftButton.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.shiftButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.shiftButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.shiftButton.Location = new System.Drawing.Point(9, 338);
            this.shiftButton.Name = "shiftButton";
            this.shiftButton.Size = new System.Drawing.Size(51, 37);
            this.shiftButton.TabIndex = 0;
            this.shiftButton.Text = "TAB";
            this.shiftButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(66, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 38);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.rightButton);
            this.panel2.Controls.Add(this.leftButton);
            this.panel2.Controls.Add(this.spaceButton);
            this.panel2.Controls.Add(this.upButton);
            this.panel2.Controls.Add(this.downButton);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(6, 496);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(170, 157);
            this.panel2.TabIndex = 7;
            // 
            // rightButton
            // 
            this.rightButton.BackColor = System.Drawing.Color.SeaGreen;
            this.rightButton.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.rightButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.rightButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rightButton.Location = new System.Drawing.Point(107, 60);
            this.rightButton.Name = "rightButton";
            this.rightButton.Size = new System.Drawing.Size(39, 37);
            this.rightButton.TabIndex = 0;
            this.rightButton.Text = "D";
            this.rightButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // leftButton
            // 
            this.leftButton.BackColor = System.Drawing.Color.SeaGreen;
            this.leftButton.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.leftButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.leftButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.leftButton.Location = new System.Drawing.Point(18, 60);
            this.leftButton.Name = "leftButton";
            this.leftButton.Size = new System.Drawing.Size(40, 37);
            this.leftButton.TabIndex = 0;
            this.leftButton.Text = "A";
            this.leftButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // spaceButton
            // 
            this.spaceButton.BackColor = System.Drawing.Color.Tomato;
            this.spaceButton.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.spaceButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.spaceButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.spaceButton.Location = new System.Drawing.Point(48, 115);
            this.spaceButton.Name = "spaceButton";
            this.spaceButton.Size = new System.Drawing.Size(100, 24);
            this.spaceButton.TabIndex = 0;
            this.spaceButton.Text = "Space Bar";
            this.spaceButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // upButton
            // 
            this.upButton.BackColor = System.Drawing.Color.SeaGreen;
            this.upButton.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.upButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.upButton.Location = new System.Drawing.Point(64, 20);
            this.upButton.Name = "upButton";
            this.upButton.Size = new System.Drawing.Size(39, 37);
            this.upButton.TabIndex = 0;
            this.upButton.Text = "W";
            this.upButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // downButton
            // 
            this.downButton.BackColor = System.Drawing.Color.SeaGreen;
            this.downButton.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.downButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.downButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.downButton.Location = new System.Drawing.Point(64, 60);
            this.downButton.Name = "downButton";
            this.downButton.Size = new System.Drawing.Size(38, 37);
            this.downButton.TabIndex = 0;
            this.downButton.Text = "S";
            this.downButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(9, 103);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(41, 37);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(66, 344);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "To Sprint";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.UseMnemonic = false;
            // 
            // lblHealth
            // 
            this.lblHealth.BackColor = System.Drawing.Color.Transparent;
            this.lblHealth.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHealth.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblHealth.Location = new System.Drawing.Point(58, 109);
            this.lblHealth.Name = "lblHealth";
            this.lblHealth.Size = new System.Drawing.Size(63, 22);
            this.lblHealth.TabIndex = 7;
            this.lblHealth.Text = "100.0%";
            this.lblHealth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHealth.UseMnemonic = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(64, 389);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(38, 35);
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(64, 437);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(38, 35);
            this.pictureBox5.TabIndex = 6;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox10.BackgroundImage")));
            this.pictureBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox10.Location = new System.Drawing.Point(66, 223);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(51, 44);
            this.pictureBox10.TabIndex = 6;
            this.pictureBox10.TabStop = false;
            // 
            // rButton
            // 
            this.rButton.BackColor = System.Drawing.Color.Tomato;
            this.rButton.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.rButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.rButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rButton.Location = new System.Drawing.Point(23, 438);
            this.rButton.Name = "rButton";
            this.rButton.Size = new System.Drawing.Size(40, 34);
            this.rButton.TabIndex = 0;
            this.rButton.Text = "R";
            this.rButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAmmo
            // 
            this.lblAmmo.BackColor = System.Drawing.Color.Transparent;
            this.lblAmmo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmmo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblAmmo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAmmo.Location = new System.Drawing.Point(108, 437);
            this.lblAmmo.Name = "lblAmmo";
            this.lblAmmo.Size = new System.Drawing.Size(61, 35);
            this.lblAmmo.TabIndex = 0;
            this.lblAmmo.Text = "7 / 7";
            this.lblAmmo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAmmo.UseMnemonic = false;
            // 
            // fButton
            // 
            this.fButton.BackColor = System.Drawing.Color.Tomato;
            this.fButton.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.fButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.fButton.Location = new System.Drawing.Point(23, 388);
            this.fButton.Name = "fButton";
            this.fButton.Size = new System.Drawing.Size(38, 32);
            this.fButton.TabIndex = 0;
            this.fButton.Text = "F";
            this.fButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBarHP
            // 
            this.progressBarHP.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.progressBarHP.AnimationSpeed = 500;
            this.progressBarHP.BackColor = System.Drawing.Color.Transparent;
            this.progressBarHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.progressBarHP.ForeColor = System.Drawing.Color.Black;
            this.progressBarHP.InnerColor = System.Drawing.Color.Transparent;
            this.progressBarHP.InnerMargin = 2;
            this.progressBarHP.InnerWidth = -1;
            this.progressBarHP.Location = new System.Drawing.Point(12, 20);
            this.progressBarHP.MarqueeAnimationSpeed = 2000;
            this.progressBarHP.Name = "progressBarHP";
            this.progressBarHP.OuterColor = System.Drawing.Color.WhiteSmoke;
            this.progressBarHP.OuterMargin = -25;
            this.progressBarHP.OuterWidth = 26;
            this.progressBarHP.ProgressColor = System.Drawing.Color.Maroon;
            this.progressBarHP.ProgressWidth = 25;
            this.progressBarHP.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.progressBarHP.Size = new System.Drawing.Size(156, 153);
            this.progressBarHP.StartAngle = 270;
            this.progressBarHP.SubscriptColor = System.Drawing.Color.Transparent;
            this.progressBarHP.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.progressBarHP.SubscriptText = ".23";
            this.progressBarHP.SuperscriptColor = System.Drawing.Color.Transparent;
            this.progressBarHP.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.progressBarHP.SuperscriptText = "°C";
            this.progressBarHP.TabIndex = 12;
            this.progressBarHP.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.progressBarHP.Value = 50;
            // 
            // progressBarStamina
            // 
            this.progressBarStamina.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.progressBarStamina.AnimationSpeed = 500;
            this.progressBarStamina.BackColor = System.Drawing.Color.Transparent;
            this.progressBarStamina.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.progressBarStamina.ForeColor = System.Drawing.Color.Black;
            this.progressBarStamina.InnerColor = System.Drawing.Color.Transparent;
            this.progressBarStamina.InnerMargin = 2;
            this.progressBarStamina.InnerWidth = -1;
            this.progressBarStamina.Location = new System.Drawing.Point(25, 181);
            this.progressBarStamina.MarqueeAnimationSpeed = 2000;
            this.progressBarStamina.Name = "progressBarStamina";
            this.progressBarStamina.OuterColor = System.Drawing.Color.WhiteSmoke;
            this.progressBarStamina.OuterMargin = -25;
            this.progressBarStamina.OuterWidth = 26;
            this.progressBarStamina.ProgressColor = System.Drawing.Color.Turquoise;
            this.progressBarStamina.ProgressWidth = 20;
            this.progressBarStamina.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.progressBarStamina.Size = new System.Drawing.Size(130, 121);
            this.progressBarStamina.StartAngle = 270;
            this.progressBarStamina.SubscriptColor = System.Drawing.Color.Transparent;
            this.progressBarStamina.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.progressBarStamina.SubscriptText = ".23";
            this.progressBarStamina.SuperscriptColor = System.Drawing.Color.Transparent;
            this.progressBarStamina.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.progressBarStamina.SuperscriptText = "°C";
            this.progressBarStamina.TabIndex = 13;
            this.progressBarStamina.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.progressBarStamina.Value = 50;
            // 
            // lblZombieWave
            // 
            this.lblZombieWave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.lblZombieWave.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.lblZombieWave.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblZombieWave.Location = new System.Drawing.Point(1192, 29);
            this.lblZombieWave.Name = "lblZombieWave";
            this.lblZombieWave.Size = new System.Drawing.Size(105, 32);
            this.lblZombieWave.TabIndex = 0;
            this.lblZombieWave.Text = "Wave 1";
            this.lblZombieWave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblZombieWave.UseMnemonic = false;
            // 
            // lblScore
            // 
            this.lblScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.lblScore.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.lblScore.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblScore.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblScore.Location = new System.Drawing.Point(474, 30);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(89, 32);
            this.lblScore.TabIndex = 0;
            this.lblScore.Text = "0";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblScore.UseMnemonic = false;
            // 
            // lblZombieLeft
            // 
            this.lblZombieLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.lblZombieLeft.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.lblZombieLeft.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblZombieLeft.Location = new System.Drawing.Point(982, 35);
            this.lblZombieLeft.Name = "lblZombieLeft";
            this.lblZombieLeft.Size = new System.Drawing.Size(105, 25);
            this.lblZombieLeft.TabIndex = 0;
            this.lblZombieLeft.Text = "1 Left(s)";
            this.lblZombieLeft.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblZombieLeft.UseMnemonic = false;
            // 
            // StaminaTick
            // 
            this.StaminaTick.Interval = 1000;
            this.StaminaTick.Tick += new System.EventHandler(this.StaminaTick_Tick);
            // 
            // lblCoin
            // 
            this.lblCoin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.lblCoin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCoin.Location = new System.Drawing.Point(283, 30);
            this.lblCoin.Name = "lblCoin";
            this.lblCoin.Size = new System.Drawing.Size(99, 32);
            this.lblCoin.TabIndex = 0;
            this.lblCoin.Text = "00000001";
            this.lblCoin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCoin.UseMnemonic = false;
            // 
            // SpawnZombieTimer
            // 
            this.SpawnZombieTimer.Interval = 5000;
            this.SpawnZombieTimer.Tick += new System.EventHandler(this.SpawnZombieTimer_Tick);
            // 
            // ZombieDamageTick
            // 
            this.ZombieDamageTick.Interval = 1000;
            this.ZombieDamageTick.Tick += new System.EventHandler(this.ZombieDamageTick_Tick);
            // 
            // BulletCollisionZombie
            // 
            this.BulletCollisionZombie.Interval = 50;
            this.BulletCollisionZombie.Tick += new System.EventHandler(this.BulletCollisionZombie_Tick);
            // 
            // battleFieldBound
            // 
            this.battleFieldBound.BackColor = System.Drawing.Color.Gainsboro;
            this.battleFieldBound.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.battleFieldBound.Location = new System.Drawing.Point(197, 90);
            this.battleFieldBound.Name = "battleFieldBound";
            this.battleFieldBound.Size = new System.Drawing.Size(1115, 565);
            this.battleFieldBound.TabIndex = 10;
            // 
            // ZombieWaveOnStart
            // 
            this.ZombieWaveOnStart.Interval = 1000;
            this.ZombieWaveOnStart.Tick += new System.EventHandler(this.ZombieWaveOnStart_Tick);
            // 
            // txtGUI_ContainerWave
            // 
            this.txtGUI_ContainerWave.BackColor = System.Drawing.Color.Transparent;
            this.txtGUI_ContainerWave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.txtGUI_ContainerWave.Controls.Add(this.txtGUI_NumTwo);
            this.txtGUI_ContainerWave.Controls.Add(this.txtGUI_NumOne);
            this.txtGUI_ContainerWave.Controls.Add(this.panel3);
            this.txtGUI_ContainerWave.Location = new System.Drawing.Point(432, 236);
            this.txtGUI_ContainerWave.Name = "txtGUI_ContainerWave";
            this.txtGUI_ContainerWave.Size = new System.Drawing.Size(680, 260);
            this.txtGUI_ContainerWave.TabIndex = 1;
            this.txtGUI_ContainerWave.Visible = false;
            // 
            // txtGUI_NumTwo
            // 
            this.txtGUI_NumTwo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtGUI_NumTwo.BackgroundImage")));
            this.txtGUI_NumTwo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtGUI_NumTwo.Location = new System.Drawing.Point(480, 82);
            this.txtGUI_NumTwo.Name = "txtGUI_NumTwo";
            this.txtGUI_NumTwo.Size = new System.Drawing.Size(91, 99);
            this.txtGUI_NumTwo.TabIndex = 2;
            // 
            // txtGUI_NumOne
            // 
            this.txtGUI_NumOne.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtGUI_NumOne.BackgroundImage")));
            this.txtGUI_NumOne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtGUI_NumOne.Location = new System.Drawing.Point(386, 82);
            this.txtGUI_NumOne.Name = "txtGUI_NumOne";
            this.txtGUI_NumOne.Size = new System.Drawing.Size(91, 99);
            this.txtGUI_NumOne.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(92, 72);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(308, 118);
            this.panel3.TabIndex = 0;
            // 
            // OnDelayTextGUITimer
            // 
            this.OnDelayTextGUITimer.Interval = 2000;
            this.OnDelayTextGUITimer.Tick += new System.EventHandler(this.OnDelayTextGUITimer_Tick);
            // 
            // GameHeartbeatTick
            // 
            this.GameHeartbeatTick.Interval = 1000;
            this.GameHeartbeatTick.Tick += new System.EventHandler(this.GameHeartbeatTick_Tick);
            // 
            // gameOverGUI
            // 
            this.gameOverGUI.BackColor = System.Drawing.Color.Gainsboro;
            this.gameOverGUI.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gameOverGUI.BackgroundImage")));
            this.gameOverGUI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gameOverGUI.Controls.Add(this.bttnPlayAgain);
            this.gameOverGUI.Controls.Add(this.bttnBackToMenu);
            this.gameOverGUI.Location = new System.Drawing.Point(525, 142);
            this.gameOverGUI.Name = "gameOverGUI";
            this.gameOverGUI.Size = new System.Drawing.Size(486, 458);
            this.gameOverGUI.TabIndex = 0;
            // 
            // bttnPlayAgain
            // 
            this.bttnPlayAgain.BackColor = System.Drawing.Color.Gainsboro;
            this.bttnPlayAgain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnPlayAgain.Font = new System.Drawing.Font("28 Days Later", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnPlayAgain.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bttnPlayAgain.Location = new System.Drawing.Point(135, 235);
            this.bttnPlayAgain.Name = "bttnPlayAgain";
            this.bttnPlayAgain.Size = new System.Drawing.Size(213, 63);
            this.bttnPlayAgain.TabIndex = 0;
            this.bttnPlayAgain.TabStop = false;
            this.bttnPlayAgain.Text = "PLAY AGAIN";
            this.bttnPlayAgain.UseVisualStyleBackColor = false;
            this.bttnPlayAgain.Click += new System.EventHandler(this.bttnPlayAgain_Click);
            // 
            // bttnBackToMenu
            // 
            this.bttnBackToMenu.Font = new System.Drawing.Font("28 Days Later", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnBackToMenu.Location = new System.Drawing.Point(135, 323);
            this.bttnBackToMenu.Name = "bttnBackToMenu";
            this.bttnBackToMenu.Size = new System.Drawing.Size(213, 63);
            this.bttnBackToMenu.TabIndex = 0;
            this.bttnBackToMenu.TabStop = false;
            this.bttnBackToMenu.Text = "BACK TO MENU";
            this.bttnBackToMenu.UseVisualStyleBackColor = true;
            this.bttnBackToMenu.Click += new System.EventHandler(this.bttnBackToMenu_Click);
            // 
            // pictureBox13
            // 
            this.pictureBox13.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox13.BackgroundImage")));
            this.pictureBox13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox13.Location = new System.Drawing.Point(1126, 19);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(190, 50);
            this.pictureBox13.TabIndex = 11;
            this.pictureBox13.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.BackgroundImage")));
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.Location = new System.Drawing.Point(406, 21);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(190, 50);
            this.pictureBox6.TabIndex = 11;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox11.BackgroundImage")));
            this.pictureBox11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox11.Location = new System.Drawing.Point(210, 20);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(190, 50);
            this.pictureBox11.TabIndex = 11;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(609, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(278, 61);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // rightWall
            // 
            this.rightWall.BackColor = System.Drawing.Color.Black;
            this.rightWall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rightWall.Location = new System.Drawing.Point(1311, 70);
            this.rightWall.Name = "rightWall";
            this.rightWall.Size = new System.Drawing.Size(25, 586);
            this.rightWall.TabIndex = 1;
            this.rightWall.TabStop = false;
            // 
            // topWall
            // 
            this.topWall.BackColor = System.Drawing.Color.Black;
            this.topWall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.topWall.Location = new System.Drawing.Point(193, 71);
            this.topWall.Name = "topWall";
            this.topWall.Size = new System.Drawing.Size(1125, 19);
            this.topWall.TabIndex = 1;
            this.topWall.TabStop = false;
            // 
            // bottomWall
            // 
            this.bottomWall.BackColor = System.Drawing.Color.Black;
            this.bottomWall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bottomWall.Location = new System.Drawing.Point(172, 644);
            this.bottomWall.Name = "bottomWall";
            this.bottomWall.Size = new System.Drawing.Size(1164, 22);
            this.bottomWall.TabIndex = 9;
            this.bottomWall.TabStop = false;
            // 
            // leftWall
            // 
            this.leftWall.BackColor = System.Drawing.Color.Black;
            this.leftWall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.leftWall.Location = new System.Drawing.Point(176, 71);
            this.leftWall.Name = "leftWall";
            this.leftWall.Size = new System.Drawing.Size(32, 584);
            this.leftWall.TabIndex = 1;
            this.leftWall.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox12.BackgroundImage")));
            this.pictureBox12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox12.Location = new System.Drawing.Point(918, 21);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(190, 50);
            this.pictureBox12.TabIndex = 11;
            this.pictureBox12.TabStop = false;
            // 
            // txtGUI_WaveCleared
            // 
            this.txtGUI_WaveCleared.BackColor = System.Drawing.Color.Transparent;
            this.txtGUI_WaveCleared.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtGUI_WaveCleared.BackgroundImage")));
            this.txtGUI_WaveCleared.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.txtGUI_WaveCleared.Location = new System.Drawing.Point(453, 230);
            this.txtGUI_WaveCleared.Name = "txtGUI_WaveCleared";
            this.txtGUI_WaveCleared.Size = new System.Drawing.Size(680, 260);
            this.txtGUI_WaveCleared.TabIndex = 0;
            this.txtGUI_WaveCleared.Visible = false;
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1357, 678);
            this.Controls.Add(this.lblCoin);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblZombieWave);
            this.Controls.Add(this.pictureBox13);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rightWall);
            this.Controls.Add(this.lblZombieLeft);
            this.Controls.Add(this.topWall);
            this.Controls.Add(this.bottomWall);
            this.Controls.Add(this.leftWall);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.battleFieldBound);
            this.Controls.Add(this.gameOverGUI);
            this.Controls.Add(this.txtGUI_WaveCleared);
            this.Controls.Add(this.txtGUI_ContainerWave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Survival Z Mini Game by EJC";
            this.TransparencyKey = System.Drawing.Color.White;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmGame_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.SizeChanged += new System.EventHandler(this.frmGame_SizeChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmMain_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyUp);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseClick);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.txtGUI_ContainerWave.ResumeLayout(false);
            this.gameOverGUI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightWall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topWall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomWall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftWall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer MovementControlsTick;
        private System.Windows.Forms.Timer BulletTimer;
        private System.Windows.Forms.PictureBox rightWall;
        private System.Windows.Forms.PictureBox topWall;
        private System.Windows.Forms.PictureBox leftWall;
        private System.Windows.Forms.Timer WallCollisionTick;
        private System.Windows.Forms.Timer zombie1Tick;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label rButton;
        public System.Windows.Forms.Label leftButton;
        public System.Windows.Forms.Label spaceButton;
        public System.Windows.Forms.Label rightButton;
        public System.Windows.Forms.Label upButton;
        public System.Windows.Forms.Label downButton;
        public System.Windows.Forms.Label shiftButton;
        private System.Windows.Forms.Label lblZombieWave;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblAmmo;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label lblZombieLeft;
        private System.Windows.Forms.Timer StaminaTick;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer SpawnZombieTimer;
        private System.Windows.Forms.Timer ZombieDamageTick;
        private System.Windows.Forms.Timer BulletCollisionZombie;
        private System.Windows.Forms.Label lblCoin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label fButton;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox bottomWall;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblHealth;
        private System.Windows.Forms.Label lblMedkits;
        private System.Windows.Forms.Panel battleFieldBound;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.PictureBox pictureBox4;
        private CircularProgressBar.CircularProgressBar progressBarHP;
        private CircularProgressBar.CircularProgressBar progressBarStamina;
        private System.Windows.Forms.Timer ZombieWaveOnStart;
        private System.Windows.Forms.Panel txtGUI_WaveCleared;
        private System.Windows.Forms.Panel txtGUI_ContainerWave;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel txtGUI_NumTwo;
        private System.Windows.Forms.Panel txtGUI_NumOne;
        private System.Windows.Forms.Timer OnDelayTextGUITimer;
        private System.Windows.Forms.Timer GameHeartbeatTick;
        private System.Windows.Forms.Panel gameOverGUI;
        private System.Windows.Forms.Button bttnPlayAgain;
        private System.Windows.Forms.Button bttnBackToMenu;
    }
}

