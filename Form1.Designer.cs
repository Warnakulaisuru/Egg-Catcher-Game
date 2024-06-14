namespace egg_catcher_game
{
    partial class gameBoard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            eggBasket1 = new PictureBox();
            eggBasket2 = new PictureBox();
            eggBasket3 = new PictureBox();
            egg = new PictureBox();
            timer_basket1 = new System.Windows.Forms.Timer(components);
            timer_basket2 = new System.Windows.Forms.Timer(components);
            timer_basket3 = new System.Windows.Forms.Timer(components);
            timer_eggFall = new System.Windows.Forms.Timer(components);
            timer_eggBasketMove = new System.Windows.Forms.Timer(components);
            lblScore = new Label();
            lblEggsLeft = new Label();
            cover = new PictureBox();
            cloud = new PictureBox();
            cloud2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)eggBasket1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)eggBasket2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)eggBasket3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)egg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cover).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cloud).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cloud2).BeginInit();
            SuspendLayout();
            // 
            // eggBasket1
            // 
            eggBasket1.BackColor = Color.Transparent;
            eggBasket1.Image = Properties.Resources.egg_basket;
            eggBasket1.Location = new Point(0, 236);
            eggBasket1.Margin = new Padding(0);
            eggBasket1.Name = "eggBasket1";
            eggBasket1.Size = new Size(70, 36);
            eggBasket1.SizeMode = PictureBoxSizeMode.StretchImage;
            eggBasket1.TabIndex = 0;
            eggBasket1.TabStop = false;
            // 
            // eggBasket2
            // 
            eggBasket2.BackColor = Color.Transparent;
            eggBasket2.Image = Properties.Resources.egg_basket;
            eggBasket2.Location = new Point(0, 139);
            eggBasket2.Margin = new Padding(0);
            eggBasket2.Name = "eggBasket2";
            eggBasket2.Size = new Size(70, 36);
            eggBasket2.SizeMode = PictureBoxSizeMode.StretchImage;
            eggBasket2.TabIndex = 1;
            eggBasket2.TabStop = false;
            // 
            // eggBasket3
            // 
            eggBasket3.BackColor = Color.Transparent;
            eggBasket3.Image = Properties.Resources.egg_basket;
            eggBasket3.Location = new Point(0, 41);
            eggBasket3.Margin = new Padding(0);
            eggBasket3.Name = "eggBasket3";
            eggBasket3.Size = new Size(70, 36);
            eggBasket3.SizeMode = PictureBoxSizeMode.StretchImage;
            eggBasket3.TabIndex = 2;
            eggBasket3.TabStop = false;
            // 
            // egg
            // 
            egg.BackColor = Color.Transparent;
            egg.Image = Properties.Resources.egg_cropped;
            egg.Location = new Point(137, 334);
            egg.Name = "egg";
            egg.Size = new Size(35, 34);
            egg.SizeMode = PictureBoxSizeMode.StretchImage;
            egg.TabIndex = 3;
            egg.TabStop = false;
            // 
            // timer_basket1
            // 
            timer_basket1.Enabled = true;
            timer_basket1.Interval = 10;
            timer_basket1.Tick += timer_basket1_Tick;
            // 
            // timer_basket2
            // 
            timer_basket2.Enabled = true;
            timer_basket2.Interval = 10;
            timer_basket2.Tick += timer_basket2_Tick;
            // 
            // timer_basket3
            // 
            timer_basket3.Enabled = true;
            timer_basket3.Interval = 10;
            timer_basket3.Tick += timer_basket3_Tick;
            // 
            // timer_eggFall
            // 
            timer_eggFall.Interval = 10;
            timer_eggFall.Tick += timer_eggFall_Tick;
            // 
            // timer_eggBasketMove
            // 
            timer_eggBasketMove.Interval = 10;
            timer_eggBasketMove.Tick += timer_eggBasketMove_Tick;
            // 
            // lblScore
            // 
            lblScore.BackColor = Color.Transparent;
            lblScore.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblScore.ForeColor = Color.Green;
            lblScore.Location = new Point(192, 7);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(123, 21);
            lblScore.TabIndex = 4;
            lblScore.Text = "SCORE : 00";
            // 
            // lblEggsLeft
            // 
            lblEggsLeft.BackColor = Color.Transparent;
            lblEggsLeft.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblEggsLeft.ForeColor = Color.Red;
            lblEggsLeft.Location = new Point(10, 9);
            lblEggsLeft.Name = "lblEggsLeft";
            lblEggsLeft.Size = new Size(163, 21);
            lblEggsLeft.TabIndex = 5;
            lblEggsLeft.Text = "EGGS LEFT : 00";
            // 
            // cover
            // 
            cover.BackColor = Color.Transparent;
            cover.Image = Properties.Resources.win2;
            cover.Location = new Point(0, -2);
            cover.Name = "cover";
            cover.Size = new Size(316, 369);
            cover.SizeMode = PictureBoxSizeMode.StretchImage;
            cover.TabIndex = 6;
            cover.TabStop = false;
            cover.Visible = false;
            // 
            // cloud
            // 
            cloud.BackColor = Color.Transparent;
            cloud.Image = Properties.Resources.cloud1;
            cloud.Location = new Point(179, 80);
            cloud.Name = "cloud";
            cloud.Size = new Size(273, 55);
            cloud.SizeMode = PictureBoxSizeMode.StretchImage;
            cloud.TabIndex = 7;
            cloud.TabStop = false;
            // 
            // cloud2
            // 
            cloud2.BackColor = Color.Transparent;
            cloud2.Image = Properties.Resources.cloud1;
            cloud2.Location = new Point(-134, 178);
            cloud2.Name = "cloud2";
            cloud2.Size = new Size(273, 55);
            cloud2.SizeMode = PictureBoxSizeMode.StretchImage;
            cloud2.TabIndex = 8;
            cloud2.TabStop = false;
            // 
            // gameBoard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(312, 370);
            Controls.Add(cloud2);
            Controls.Add(cloud);
            Controls.Add(cover);
            Controls.Add(lblEggsLeft);
            Controls.Add(lblScore);
            Controls.Add(egg);
            Controls.Add(eggBasket3);
            Controls.Add(eggBasket2);
            Controls.Add(eggBasket1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "gameBoard";
            Text = "Egg Catcher";
            Load += Form1_Load;
            KeyDown += gameBoard_KeyDown;
            ((System.ComponentModel.ISupportInitialize)eggBasket1).EndInit();
            ((System.ComponentModel.ISupportInitialize)eggBasket2).EndInit();
            ((System.ComponentModel.ISupportInitialize)eggBasket3).EndInit();
            ((System.ComponentModel.ISupportInitialize)egg).EndInit();
            ((System.ComponentModel.ISupportInitialize)cover).EndInit();
            ((System.ComponentModel.ISupportInitialize)cloud).EndInit();
            ((System.ComponentModel.ISupportInitialize)cloud2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox eggBasket1;
        private PictureBox eggBasket2;
        private PictureBox eggBasket3;
        private PictureBox egg;
        private System.Windows.Forms.Timer timer_basket1;
        private System.Windows.Forms.Timer timer_basket2;
        private System.Windows.Forms.Timer timer_basket3;
        private System.Windows.Forms.Timer timer_eggFall;
        private System.Windows.Forms.Timer timer_eggBasketMove;
        private Label lblScore;
        private Label lblEggsLeft;
        private PictureBox cover;
        private PictureBox cloud;
        private PictureBox cloud2;
    }
}