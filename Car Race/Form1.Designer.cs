namespace Car_Race
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
            this.lblscore = new System.Windows.Forms.Label();
            this.mytimer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.car2 = new System.Windows.Forms.PictureBox();
            this.lblgameover = new System.Windows.Forms.Label();
            this.player = new System.Windows.Forms.PictureBox();
            this.car1 = new System.Windows.Forms.PictureBox();
            this.L3 = new System.Windows.Forms.PictureBox();
            this.L6 = new System.Windows.Forms.PictureBox();
            this.L2 = new System.Windows.Forms.PictureBox();
            this.L5 = new System.Windows.Forms.PictureBox();
            this.L4 = new System.Windows.Forms.PictureBox();
            this.L1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.car2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.L3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.L6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.L2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.L5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.L4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.L1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblscore
            // 
            this.lblscore.AutoSize = true;
            this.lblscore.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblscore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblscore.Location = new System.Drawing.Point(245, 9);
            this.lblscore.Name = "lblscore";
            this.lblscore.Size = new System.Drawing.Size(85, 29);
            this.lblscore.TabIndex = 1;
            this.lblscore.Text = "score :";
            // 
            // mytimer
            // 
            this.mytimer.Enabled = true;
            this.mytimer.Interval = 10;
            this.mytimer.Tick += new System.EventHandler(this.mytimer_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.player);
            this.panel1.Controls.Add(this.car2);
            this.panel1.Controls.Add(this.lblgameover);
            this.panel1.Controls.Add(this.car1);
            this.panel1.Controls.Add(this.L3);
            this.panel1.Controls.Add(this.L6);
            this.panel1.Controls.Add(this.L2);
            this.panel1.Controls.Add(this.L5);
            this.panel1.Controls.Add(this.L4);
            this.panel1.Controls.Add(this.L1);
            this.panel1.Location = new System.Drawing.Point(12, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(609, 594);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // car2
            // 
            this.car2.BackColor = System.Drawing.Color.Yellow;
            this.car2.Location = new System.Drawing.Point(128, 167);
            this.car2.Name = "car2";
            this.car2.Size = new System.Drawing.Size(46, 99);
            this.car2.TabIndex = 5;
            this.car2.TabStop = false;
            // 
            // lblgameover
            // 
            this.lblgameover.AutoSize = true;
            this.lblgameover.BackColor = System.Drawing.SystemColors.Info;
            this.lblgameover.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblgameover.Font = new System.Drawing.Font("Cambria", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgameover.Location = new System.Drawing.Point(181, 91);
            this.lblgameover.Name = "lblgameover";
            this.lblgameover.Padding = new System.Windows.Forms.Padding(10);
            this.lblgameover.Size = new System.Drawing.Size(230, 66);
            this.lblgameover.TabIndex = 6;
            this.lblgameover.Text = "Game Over";
            this.lblgameover.Visible = false;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Black;
            this.player.Location = new System.Drawing.Point(257, 463);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(59, 124);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 3;
            this.player.TabStop = false;
            this.player.Click += new System.EventHandler(this.player_Click);
            // 
            // car1
            // 
            this.car1.BackColor = System.Drawing.Color.Cyan;
            this.car1.Location = new System.Drawing.Point(448, 267);
            this.car1.Name = "car1";
            this.car1.Size = new System.Drawing.Size(46, 99);
            this.car1.TabIndex = 4;
            this.car1.TabStop = false;
            // 
            // L3
            // 
            this.L3.BackColor = System.Drawing.Color.White;
            this.L3.Location = new System.Drawing.Point(448, 3);
            this.L3.Name = "L3";
            this.L3.Size = new System.Drawing.Size(16, 219);
            this.L3.TabIndex = 2;
            this.L3.TabStop = false;
            // 
            // L6
            // 
            this.L6.BackColor = System.Drawing.Color.White;
            this.L6.Location = new System.Drawing.Point(448, 372);
            this.L6.Name = "L6";
            this.L6.Size = new System.Drawing.Size(16, 219);
            this.L6.TabIndex = 1;
            this.L6.TabStop = false;
            // 
            // L2
            // 
            this.L2.BackColor = System.Drawing.Color.White;
            this.L2.Location = new System.Drawing.Point(287, 3);
            this.L2.Name = "L2";
            this.L2.Size = new System.Drawing.Size(16, 219);
            this.L2.TabIndex = 0;
            this.L2.TabStop = false;
            this.L2.Click += new System.EventHandler(this.L2_Click);
            // 
            // L5
            // 
            this.L5.BackColor = System.Drawing.Color.White;
            this.L5.Location = new System.Drawing.Point(287, 372);
            this.L5.Name = "L5";
            this.L5.Size = new System.Drawing.Size(16, 219);
            this.L5.TabIndex = 0;
            this.L5.TabStop = false;
            this.L5.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // L4
            // 
            this.L4.BackColor = System.Drawing.Color.White;
            this.L4.Location = new System.Drawing.Point(145, 372);
            this.L4.Name = "L4";
            this.L4.Size = new System.Drawing.Size(16, 219);
            this.L4.TabIndex = 0;
            this.L4.TabStop = false;
            this.L4.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // L1
            // 
            this.L1.BackColor = System.Drawing.Color.White;
            this.L1.Location = new System.Drawing.Point(145, 3);
            this.L1.Name = "L1";
            this.L1.Size = new System.Drawing.Size(16, 219);
            this.L1.TabIndex = 0;
            this.L1.TabStop = false;
            this.L1.Click += new System.EventHandler(this.L1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 647);
            this.Controls.Add(this.lblscore);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Car Race";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.car2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.L3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.L6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.L2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.L5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.L4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.L1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox L3;
        private System.Windows.Forms.PictureBox L6;
        private System.Windows.Forms.PictureBox L1;
        private System.Windows.Forms.PictureBox L4;
        private System.Windows.Forms.Label lblscore;
        private System.Windows.Forms.PictureBox L2;
        private System.Windows.Forms.PictureBox L5;
        private System.Windows.Forms.Timer mytimer;
        private System.Windows.Forms.PictureBox car2;
        private System.Windows.Forms.PictureBox car1;
        private System.Windows.Forms.Label lblgameover;
        private System.Windows.Forms.PictureBox player;
    }
}

