namespace FireGame_Master_April
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
            this.gamest1 = new System.Windows.Forms.Button();
            this.gameld = new System.Windows.Forms.Button();
            this.spin_gun = new System.Windows.Forms.Button();
            this.shot_btn = new System.Windows.Forms.Button();
            this.shot_away = new System.Windows.Forms.Button();
            this.reloadbtn = new System.Windows.Forms.Button();
            this.picBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // gamest1
            // 
            this.gamest1.BackColor = System.Drawing.Color.White;
            this.gamest1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gamest1.Location = new System.Drawing.Point(29, 12);
            this.gamest1.Name = "gamest1";
            this.gamest1.Size = new System.Drawing.Size(109, 41);
            this.gamest1.TabIndex = 0;
            this.gamest1.Text = "Start Game";
            this.gamest1.UseVisualStyleBackColor = false;
            this.gamest1.Click += new System.EventHandler(this.gamest1_Click);
            // 
            // gameld
            // 
            this.gameld.BackColor = System.Drawing.Color.White;
            this.gameld.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameld.Location = new System.Drawing.Point(156, 12);
            this.gameld.Name = "gameld";
            this.gameld.Size = new System.Drawing.Size(109, 41);
            this.gameld.TabIndex = 1;
            this.gameld.Text = "Load Game";
            this.gameld.UseVisualStyleBackColor = false;
            this.gameld.Click += new System.EventHandler(this.gameld_Click);
            // 
            // spin_gun
            // 
            this.spin_gun.BackColor = System.Drawing.Color.White;
            this.spin_gun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spin_gun.Location = new System.Drawing.Point(284, 12);
            this.spin_gun.Name = "spin_gun";
            this.spin_gun.Size = new System.Drawing.Size(109, 41);
            this.spin_gun.TabIndex = 2;
            this.spin_gun.Text = "Spin_Gun";
            this.spin_gun.UseVisualStyleBackColor = false;
            this.spin_gun.Click += new System.EventHandler(this.spin_gun_Click);
            // 
            // shot_btn
            // 
            this.shot_btn.BackColor = System.Drawing.Color.White;
            this.shot_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shot_btn.Location = new System.Drawing.Point(416, 12);
            this.shot_btn.Name = "shot_btn";
            this.shot_btn.Size = new System.Drawing.Size(109, 41);
            this.shot_btn.TabIndex = 3;
            this.shot_btn.Text = "Shoot";
            this.shot_btn.UseVisualStyleBackColor = false;
            this.shot_btn.Click += new System.EventHandler(this.shot_btn_Click);
            // 
            // shot_away
            // 
            this.shot_away.BackColor = System.Drawing.Color.White;
            this.shot_away.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shot_away.Location = new System.Drawing.Point(545, 12);
            this.shot_away.Name = "shot_away";
            this.shot_away.Size = new System.Drawing.Size(109, 41);
            this.shot_away.TabIndex = 4;
            this.shot_away.Text = "Shoot_Away";
            this.shot_away.UseVisualStyleBackColor = false;
            this.shot_away.Click += new System.EventHandler(this.shot_away_Click);
            // 
            // reloadbtn
            // 
            this.reloadbtn.BackColor = System.Drawing.Color.White;
            this.reloadbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reloadbtn.Location = new System.Drawing.Point(675, 12);
            this.reloadbtn.Name = "reloadbtn";
            this.reloadbtn.Size = new System.Drawing.Size(109, 41);
            this.reloadbtn.TabIndex = 5;
            this.reloadbtn.Text = "Reload";
            this.reloadbtn.UseVisualStyleBackColor = false;
            this.reloadbtn.Click += new System.EventHandler(this.reloadbtn_Click);
            // 
            // picBox
            // 
            this.picBox.Location = new System.Drawing.Point(29, 85);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(755, 318);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox.TabIndex = 6;
            this.picBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(838, 415);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.reloadbtn);
            this.Controls.Add(this.shot_away);
            this.Controls.Add(this.shot_btn);
            this.Controls.Add(this.spin_gun);
            this.Controls.Add(this.gameld);
            this.Controls.Add(this.gamest1);
            this.Name = "Form1";
            this.Text = " vbnh juk,9omkinjfrcedxwza";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button gamest1;
        private System.Windows.Forms.Button gameld;
        private System.Windows.Forms.Button spin_gun;
        private System.Windows.Forms.Button shot_btn;
        private System.Windows.Forms.Button shot_away;
        private System.Windows.Forms.Button reloadbtn;
        private System.Windows.Forms.PictureBox picBox;
    }
}

