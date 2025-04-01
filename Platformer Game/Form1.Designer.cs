namespace Platformer_Game
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
            this.groundPictureBox = new System.Windows.Forms.PictureBox();
            this.hero = new System.Windows.Forms.PictureBox();
            this.gravityTimer = new System.Windows.Forms.Timer(this.components);
            this.upTimer = new System.Windows.Forms.Timer(this.components);
            this.rightTimer = new System.Windows.Forms.Timer(this.components);
            this.leftTimer = new System.Windows.Forms.Timer(this.components);
            this.scoreLabel = new System.Windows.Forms.Label();
            this.gameLoopTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groundPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hero)).BeginInit();
            this.SuspendLayout();
            // 
            // groundPictureBox
            // 
            this.groundPictureBox.BackColor = System.Drawing.Color.LimeGreen;
            this.groundPictureBox.Location = new System.Drawing.Point(0, 429);
            this.groundPictureBox.Name = "groundPictureBox";
            this.groundPictureBox.Size = new System.Drawing.Size(464, 46);
            this.groundPictureBox.TabIndex = 0;
            this.groundPictureBox.TabStop = false;
            // 
            // hero
            // 
            this.hero.BackColor = System.Drawing.Color.Black;
            this.hero.Location = new System.Drawing.Point(214, 232);
            this.hero.Name = "hero";
            this.hero.Size = new System.Drawing.Size(40, 40);
            this.hero.TabIndex = 1;
            this.hero.TabStop = false;
            // 
            // gravityTimer
            // 
            this.gravityTimer.Enabled = true;
            this.gravityTimer.Interval = 10;
            this.gravityTimer.Tick += new System.EventHandler(this.gravityTimer_Tick);
            // 
            // upTimer
            // 
            this.upTimer.Interval = 10;
            this.upTimer.Tick += new System.EventHandler(this.upTimer_Tick);
            // 
            // rightTimer
            // 
            this.rightTimer.Interval = 10;
            this.rightTimer.Tick += new System.EventHandler(this.rightTimer_Tick);
            // 
            // leftTimer
            // 
            this.leftTimer.Interval = 10;
            this.leftTimer.Tick += new System.EventHandler(this.leftTimer_Tick);
            // 
            // scoreLabel
            // 
            this.scoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.scoreLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.Location = new System.Drawing.Point(12, 9);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(100, 23);
            this.scoreLabel.TabIndex = 2;
            this.scoreLabel.Text = "Score: 0";
            // 
            // gameLoopTimer
            // 
            this.gameLoopTimer.Enabled = true;
            this.gameLoopTimer.Interval = 10;
            this.gameLoopTimer.Tick += new System.EventHandler(this.gameLoopTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(463, 476);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.hero);
            this.Controls.Add(this.groundPictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Plaformer Game";
            this.Load += new System.EventHandler(this.PlatformerGame_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PlatformerGame_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PlatformerGame_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.groundPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hero)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox groundPictureBox;
        private System.Windows.Forms.PictureBox hero;
        private System.Windows.Forms.Timer gravityTimer;
        private System.Windows.Forms.Timer upTimer;
        private System.Windows.Forms.Timer rightTimer;
        private System.Windows.Forms.Timer leftTimer;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Timer gameLoopTimer;
    }
}

