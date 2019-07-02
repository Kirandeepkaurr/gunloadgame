namespace gunloadgame
{
    partial class mainrussiangame
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
            this.buttonlodebtn = new System.Windows.Forms.Button();
            this.Gunspinbtn = new System.Windows.Forms.Button();
            this.videopicture = new System.Windows.Forms.PictureBox();
            this.shootbulletebutton = new System.Windows.Forms.Button();
            this.awaybulleteshoot = new System.Windows.Forms.Button();
            this.playagaingame = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.videopicture)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonlodebtn
            // 
            this.buttonlodebtn.Font = new System.Drawing.Font("Leelawadee UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonlodebtn.Location = new System.Drawing.Point(26, 72);
            this.buttonlodebtn.Name = "buttonlodebtn";
            this.buttonlodebtn.Size = new System.Drawing.Size(151, 82);
            this.buttonlodebtn.TabIndex = 0;
            this.buttonlodebtn.Text = "Bullete Load";
            this.buttonlodebtn.UseVisualStyleBackColor = true;
            this.buttonlodebtn.Click += new System.EventHandler(this.buttonlodebtn_Click);
            // 
            // Gunspinbtn
            // 
            this.Gunspinbtn.Font = new System.Drawing.Font("Leelawadee UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gunspinbtn.Location = new System.Drawing.Point(26, 224);
            this.Gunspinbtn.Name = "Gunspinbtn";
            this.Gunspinbtn.Size = new System.Drawing.Size(151, 82);
            this.Gunspinbtn.TabIndex = 1;
            this.Gunspinbtn.Text = "Gun Spin";
            this.Gunspinbtn.UseVisualStyleBackColor = true;
            this.Gunspinbtn.Click += new System.EventHandler(this.Gunspinbtn_Click);
            // 
            // pictureBox1
            // 
            this.videopicture.Location = new System.Drawing.Point(227, 37);
            this.videopicture.Name = "pictureBox1";
            this.videopicture.Size = new System.Drawing.Size(328, 314);
            this.videopicture.TabIndex = 2;
            this.videopicture.TabStop = false;
            // 
            // shootbulletebutton
            // 
            this.shootbulletebutton.Font = new System.Drawing.Font("Leelawadee UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shootbulletebutton.Location = new System.Drawing.Point(628, 72);
            this.shootbulletebutton.Name = "shootbulletebutton";
            this.shootbulletebutton.Size = new System.Drawing.Size(151, 82);
            this.shootbulletebutton.TabIndex = 3;
            this.shootbulletebutton.Text = "Shoot Bullete";
            this.shootbulletebutton.UseVisualStyleBackColor = true;
            this.shootbulletebutton.Click += new System.EventHandler(this.shootbulletebutton_Click);
            // 
            // awaybulleteshoot
            // 
            this.awaybulleteshoot.Font = new System.Drawing.Font("Leelawadee UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.awaybulleteshoot.Location = new System.Drawing.Point(628, 224);
            this.awaybulleteshoot.Name = "awaybulleteshoot";
            this.awaybulleteshoot.Size = new System.Drawing.Size(151, 82);
            this.awaybulleteshoot.TabIndex = 4;
            this.awaybulleteshoot.Text = "Shoot Away";
            this.awaybulleteshoot.UseVisualStyleBackColor = true;
            this.awaybulleteshoot.Click += new System.EventHandler(this.awaybulleteshoot_Click);
            // 
            // playagaingame
            // 
            this.playagaingame.Font = new System.Drawing.Font("Leelawadee UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playagaingame.Location = new System.Drawing.Point(314, 380);
            this.playagaingame.Name = "playagaingame";
            this.playagaingame.Size = new System.Drawing.Size(151, 58);
            this.playagaingame.TabIndex = 5;
            this.playagaingame.Text = "Play Again";
            this.playagaingame.UseVisualStyleBackColor = true;
            this.playagaingame.Click += new System.EventHandler(this.playagaingame_Click);
            // 
            // mainrussiangame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::gunloadgame.Properties.Resources._636120275396678958_guns;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.playagaingame);
            this.Controls.Add(this.awaybulleteshoot);
            this.Controls.Add(this.shootbulletebutton);
            this.Controls.Add(this.videopicture);
            this.Controls.Add(this.Gunspinbtn);
            this.Controls.Add(this.buttonlodebtn);
            this.Name = "mainrussiangame";
            this.Text = "mainrussiangame";
            ((System.ComponentModel.ISupportInitialize)(this.videopicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonlodebtn;
        private System.Windows.Forms.Button Gunspinbtn;
        private System.Windows.Forms.PictureBox videopicture;
        private System.Windows.Forms.Button shootbulletebutton;
        private System.Windows.Forms.Button awaybulleteshoot;
        private System.Windows.Forms.Button playagaingame;
    }
}