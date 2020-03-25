namespace Shooting_Games
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.bttnPlay = new System.Windows.Forms.Button();
            this.bttnShop = new System.Windows.Forms.Button();
            this.bttnCredits = new System.Windows.Forms.Button();
            this.imageTwo = new System.Windows.Forms.PictureBox();
            this.imageThree = new System.Windows.Forms.PictureBox();
            this.imageOne = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imageTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageThree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageOne)).BeginInit();
            this.SuspendLayout();
            // 
            // bttnPlay
            // 
            this.bttnPlay.Font = new System.Drawing.Font("28 Days Later", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnPlay.Location = new System.Drawing.Point(423, 450);
            this.bttnPlay.Name = "bttnPlay";
            this.bttnPlay.Size = new System.Drawing.Size(215, 58);
            this.bttnPlay.TabIndex = 0;
            this.bttnPlay.Text = "PLAY";
            this.bttnPlay.UseVisualStyleBackColor = true;
            this.bttnPlay.Click += new System.EventHandler(this.bttnPlay_Click);
            // 
            // bttnShop
            // 
            this.bttnShop.Font = new System.Drawing.Font("28 Days Later", 27.75F);
            this.bttnShop.Location = new System.Drawing.Point(644, 450);
            this.bttnShop.Name = "bttnShop";
            this.bttnShop.Size = new System.Drawing.Size(215, 58);
            this.bttnShop.TabIndex = 0;
            this.bttnShop.Text = "SHOP";
            this.bttnShop.UseVisualStyleBackColor = true;
            this.bttnShop.Click += new System.EventHandler(this.bttnShop_Click);
            // 
            // bttnCredits
            // 
            this.bttnCredits.Font = new System.Drawing.Font("28 Days Later", 27.75F);
            this.bttnCredits.Location = new System.Drawing.Point(869, 450);
            this.bttnCredits.Name = "bttnCredits";
            this.bttnCredits.Size = new System.Drawing.Size(215, 58);
            this.bttnCredits.TabIndex = 0;
            this.bttnCredits.Text = "CREDITS";
            this.bttnCredits.UseVisualStyleBackColor = true;
            this.bttnCredits.Click += new System.EventHandler(this.bttnCredits_Click);
            // 
            // imageTwo
            // 
            this.imageTwo.BackColor = System.Drawing.Color.Transparent;
            this.imageTwo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imageTwo.Location = new System.Drawing.Point(690, 265);
            this.imageTwo.Name = "imageTwo";
            this.imageTwo.Size = new System.Drawing.Size(169, 103);
            this.imageTwo.TabIndex = 1;
            this.imageTwo.TabStop = false;
            this.imageTwo.Click += new System.EventHandler(this.imageTwo_Click);
            // 
            // imageThree
            // 
            this.imageThree.BackColor = System.Drawing.Color.Transparent;
            this.imageThree.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imageThree.Location = new System.Drawing.Point(875, 265);
            this.imageThree.Name = "imageThree";
            this.imageThree.Size = new System.Drawing.Size(169, 103);
            this.imageThree.TabIndex = 1;
            this.imageThree.TabStop = false;
            this.imageThree.Click += new System.EventHandler(this.imageThree_Click);
            // 
            // imageOne
            // 
            this.imageOne.BackColor = System.Drawing.Color.Transparent;
            this.imageOne.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imageOne.Location = new System.Drawing.Point(503, 265);
            this.imageOne.Name = "imageOne";
            this.imageOne.Size = new System.Drawing.Size(169, 103);
            this.imageOne.TabIndex = 1;
            this.imageOne.TabStop = false;
            this.imageOne.Click += new System.EventHandler(this.imageOne_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Shooting_Games.Properties.Resources.mainmenu_gui;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1099, 526);
            this.Controls.Add(this.imageThree);
            this.Controls.Add(this.imageOne);
            this.Controls.Add(this.imageTwo);
            this.Controls.Add(this.bttnCredits);
            this.Controls.Add(this.bttnShop);
            this.Controls.Add(this.bttnPlay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Survival Z Mini Game by EJC";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMenu_FormClosing);
            this.Load += new System.EventHandler(this.frmMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageThree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageOne)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttnPlay;
        private System.Windows.Forms.Button bttnShop;
        private System.Windows.Forms.Button bttnCredits;
        private System.Windows.Forms.PictureBox imageTwo;
        private System.Windows.Forms.PictureBox imageThree;
        private System.Windows.Forms.PictureBox imageOne;
    }
}