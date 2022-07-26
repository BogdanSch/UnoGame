namespace UnoForm
{
    partial class StartUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartUpForm));
            this.lHint = new System.Windows.Forms.Label();
            this.bPlay = new System.Windows.Forms.Button();
            this.tPlayer1 = new System.Windows.Forms.TextBox();
            this.tPlayer2 = new System.Windows.Forms.TextBox();
            this.tPlayer3 = new System.Windows.Forms.TextBox();
            this.tPlayer4 = new System.Windows.Forms.TextBox();
            this.lHint1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lHint
            // 
            this.lHint.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lHint.Location = new System.Drawing.Point(63, 9);
            this.lHint.Name = "lHint";
            this.lHint.Size = new System.Drawing.Size(198, 56);
            this.lHint.TabIndex = 0;
            this.lHint.Text = "Max count of players is 4. Have fun!";
            this.lHint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bPlay
            // 
            this.bPlay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bPlay.Location = new System.Drawing.Point(119, 328);
            this.bPlay.Name = "bPlay";
            this.bPlay.Size = new System.Drawing.Size(93, 32);
            this.bPlay.TabIndex = 1;
            this.bPlay.Text = "Start";
            this.bPlay.UseVisualStyleBackColor = true;
            this.bPlay.Click += new System.EventHandler(this.bPlay_Click);
            // 
            // tPlayer1
            // 
            this.tPlayer1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tPlayer1.Location = new System.Drawing.Point(30, 99);
            this.tPlayer1.Name = "tPlayer1";
            this.tPlayer1.Size = new System.Drawing.Size(274, 33);
            this.tPlayer1.TabIndex = 2;
            // 
            // tPlayer2
            // 
            this.tPlayer2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tPlayer2.Location = new System.Drawing.Point(30, 156);
            this.tPlayer2.Name = "tPlayer2";
            this.tPlayer2.Size = new System.Drawing.Size(274, 33);
            this.tPlayer2.TabIndex = 3;
            // 
            // tPlayer3
            // 
            this.tPlayer3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tPlayer3.Location = new System.Drawing.Point(30, 208);
            this.tPlayer3.Name = "tPlayer3";
            this.tPlayer3.Size = new System.Drawing.Size(274, 33);
            this.tPlayer3.TabIndex = 4;
            // 
            // tPlayer4
            // 
            this.tPlayer4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tPlayer4.Location = new System.Drawing.Point(30, 266);
            this.tPlayer4.Name = "tPlayer4";
            this.tPlayer4.Size = new System.Drawing.Size(274, 33);
            this.tPlayer4.TabIndex = 5;
            // 
            // lHint1
            // 
            this.lHint1.AutoSize = true;
            this.lHint1.Location = new System.Drawing.Point(30, 81);
            this.lHint1.Name = "lHint1";
            this.lHint1.Size = new System.Drawing.Size(48, 15);
            this.lHint1.TabIndex = 6;
            this.lHint1.Text = "Player 1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Player2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Player 4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Player3";
            // 
            // StartUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(331, 373);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lHint1);
            this.Controls.Add(this.tPlayer4);
            this.Controls.Add(this.tPlayer3);
            this.Controls.Add(this.tPlayer2);
            this.Controls.Add(this.tPlayer1);
            this.Controls.Add(this.bPlay);
            this.Controls.Add(this.lHint);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StartUpForm";
            this.Text = "Start";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lHint;
        private System.Windows.Forms.Button bPlay;
        private System.Windows.Forms.TextBox tPlayer1;
        private System.Windows.Forms.TextBox tPlayer2;
        private System.Windows.Forms.TextBox tPlayer3;
        private System.Windows.Forms.TextBox tPlayer4;
        private System.Windows.Forms.Label lHint1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}