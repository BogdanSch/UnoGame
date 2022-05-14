namespace UnoGame
{
    partial class ChooseColorForm
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
            this.pRed = new System.Windows.Forms.PictureBox();
            this.pGreen = new System.Windows.Forms.PictureBox();
            this.pYellow = new System.Windows.Forms.PictureBox();
            this.pBlue = new System.Windows.Forms.PictureBox();
            this.lHint = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pYellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBlue)).BeginInit();
            this.SuspendLayout();
            // 
            // pRed
            // 
            this.pRed.BackColor = System.Drawing.Color.Red;
            this.pRed.Location = new System.Drawing.Point(12, 12);
            this.pRed.Name = "pRed";
            this.pRed.Size = new System.Drawing.Size(103, 98);
            this.pRed.TabIndex = 0;
            this.pRed.TabStop = false;
            this.pRed.Click += new System.EventHandler(this.ColorPictureClick);
            // 
            // pGreen
            // 
            this.pGreen.BackColor = System.Drawing.Color.Green;
            this.pGreen.Location = new System.Drawing.Point(12, 224);
            this.pGreen.Name = "pGreen";
            this.pGreen.Size = new System.Drawing.Size(103, 98);
            this.pGreen.TabIndex = 1;
            this.pGreen.TabStop = false;
            this.pGreen.Click += new System.EventHandler(this.ColorPictureClick);
            // 
            // pYellow
            // 
            this.pYellow.BackColor = System.Drawing.Color.Yellow;
            this.pYellow.Location = new System.Drawing.Point(254, 224);
            this.pYellow.Name = "pYellow";
            this.pYellow.Size = new System.Drawing.Size(103, 98);
            this.pYellow.TabIndex = 2;
            this.pYellow.TabStop = false;
            this.pYellow.Click += new System.EventHandler(this.ColorPictureClick);
            // 
            // pBlue
            // 
            this.pBlue.BackColor = System.Drawing.Color.Blue;
            this.pBlue.Location = new System.Drawing.Point(254, 12);
            this.pBlue.Name = "pBlue";
            this.pBlue.Size = new System.Drawing.Size(103, 98);
            this.pBlue.TabIndex = 3;
            this.pBlue.TabStop = false;
            this.pBlue.Click += new System.EventHandler(this.ColorPictureClick);
            // 
            // lHint
            // 
            this.lHint.Location = new System.Drawing.Point(119, 117);
            this.lHint.Name = "lHint";
            this.lHint.Size = new System.Drawing.Size(131, 91);
            this.lHint.TabIndex = 4;
            this.lHint.Text = "Choose color which you want to switch on";
            this.lHint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ChooseColorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 334);
            this.Controls.Add(this.lHint);
            this.Controls.Add(this.pBlue);
            this.Controls.Add(this.pYellow);
            this.Controls.Add(this.pGreen);
            this.Controls.Add(this.pRed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChooseColorForm";
            this.ShowIcon = false;
            this.Text = "Choose Color";
            ((System.ComponentModel.ISupportInitialize)(this.pRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pYellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBlue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pRed;
        private System.Windows.Forms.PictureBox pGreen;
        private System.Windows.Forms.PictureBox pYellow;
        private System.Windows.Forms.PictureBox pBlue;
        private System.Windows.Forms.Label lHint;
    }
}