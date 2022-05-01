namespace UnoGame
{
    partial class GameForm
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
            this.pTable = new System.Windows.Forms.Panel();
            this.pPlr1 = new System.Windows.Forms.Panel();
            this.pPlr4 = new System.Windows.Forms.Panel();
            this.pPlr3 = new System.Windows.Forms.Panel();
            this.pPlr2 = new System.Windows.Forms.Panel();
            this.pDeck = new System.Windows.Forms.Panel();
            this.bPass = new System.Windows.Forms.Button();
            this.lInfo = new System.Windows.Forms.Label();
            this.pbActiveCard = new System.Windows.Forms.PictureBox();
            this.bBluff = new System.Windows.Forms.Button();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.pTools = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbActiveCard)).BeginInit();
            this.tableLayoutPanel.SuspendLayout();
            this.pTools.SuspendLayout();
            this.SuspendLayout();
            // 
            // pTable
            // 
            this.pTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pTable.Location = new System.Drawing.Point(323, 171);
            this.pTable.Name = "pTable";
            this.pTable.Size = new System.Drawing.Size(314, 162);
            this.pTable.TabIndex = 0;
            // 
            // pPlr1
            // 
            this.pPlr1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pPlr1.Location = new System.Drawing.Point(3, 339);
            this.pPlr1.Name = "pPlr1";
            this.pPlr1.Size = new System.Drawing.Size(314, 162);
            this.pPlr1.TabIndex = 1;
            // 
            // pPlr4
            // 
            this.pPlr4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pPlr4.Location = new System.Drawing.Point(3, 3);
            this.pPlr4.Name = "pPlr4";
            this.pPlr4.Size = new System.Drawing.Size(314, 162);
            this.pPlr4.TabIndex = 2;
            // 
            // pPlr3
            // 
            this.pPlr3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pPlr3.Location = new System.Drawing.Point(643, 3);
            this.pPlr3.Name = "pPlr3";
            this.pPlr3.Size = new System.Drawing.Size(317, 162);
            this.pPlr3.TabIndex = 3;
            // 
            // pPlr2
            // 
            this.pPlr2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pPlr2.Location = new System.Drawing.Point(643, 339);
            this.pPlr2.Name = "pPlr2";
            this.pPlr2.Size = new System.Drawing.Size(317, 162);
            this.pPlr2.TabIndex = 4;
            // 
            // pDeck
            // 
            this.pDeck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pDeck.Location = new System.Drawing.Point(3, 171);
            this.pDeck.Name = "pDeck";
            this.pDeck.Size = new System.Drawing.Size(314, 162);
            this.pDeck.TabIndex = 1;
            // 
            // bPass
            // 
            this.bPass.Location = new System.Drawing.Point(121, 13);
            this.bPass.Name = "bPass";
            this.bPass.Size = new System.Drawing.Size(85, 30);
            this.bPass.TabIndex = 5;
            this.bPass.Text = "Pass";
            this.bPass.UseVisualStyleBackColor = true;
            this.bPass.Click += new System.EventHandler(this.bPass_Click);
            // 
            // lInfo
            // 
            this.lInfo.Location = new System.Drawing.Point(95, 82);
            this.lInfo.Name = "lInfo";
            this.lInfo.Size = new System.Drawing.Size(146, 70);
            this.lInfo.TabIndex = 6;
            this.lInfo.Text = "Info";
            this.lInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbActiveCard
            // 
            this.pbActiveCard.Location = new System.Drawing.Point(840, 344);
            this.pbActiveCard.Name = "pbActiveCard";
            this.pbActiveCard.Size = new System.Drawing.Size(111, 148);
            this.pbActiveCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbActiveCard.TabIndex = 7;
            this.pbActiveCard.TabStop = false;
            this.pbActiveCard.Visible = false;
            // 
            // bBluff
            // 
            this.bBluff.Location = new System.Drawing.Point(121, 49);
            this.bBluff.Name = "bBluff";
            this.bBluff.Size = new System.Drawing.Size(85, 30);
            this.bBluff.TabIndex = 8;
            this.bBluff.Text = "Bluff";
            this.bBluff.UseVisualStyleBackColor = true;
            this.bBluff.Click += new System.EventHandler(this.bBluff_Click);
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 3;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel.Controls.Add(this.pPlr4, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.pPlr3, 2, 0);
            this.tableLayoutPanel.Controls.Add(this.pDeck, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.pTable, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.pPlr1, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.pPlr2, 2, 2);
            this.tableLayoutPanel.Controls.Add(this.pTools, 2, 1);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 3;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(963, 504);
            this.tableLayoutPanel.TabIndex = 9;
            // 
            // pTools
            // 
            this.pTools.Controls.Add(this.bPass);
            this.pTools.Controls.Add(this.bBluff);
            this.pTools.Controls.Add(this.lInfo);
            this.pTools.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pTools.Location = new System.Drawing.Point(643, 171);
            this.pTools.Name = "pTools";
            this.pTools.Size = new System.Drawing.Size(317, 162);
            this.pTools.TabIndex = 5;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 504);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.pbActiveCard);
            this.Name = "GameForm";
            this.Text = "Uno Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UnoGameForm_Closing);
            ((System.ComponentModel.ISupportInitialize)(this.pbActiveCard)).EndInit();
            this.tableLayoutPanel.ResumeLayout(false);
            this.pTools.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pTable;
        private System.Windows.Forms.Panel pPlr1;
        private System.Windows.Forms.Panel pPlr4;
        private System.Windows.Forms.Panel pPlr3;
        private System.Windows.Forms.Panel pPlr2;
        private System.Windows.Forms.Panel pDeck;
        private System.Windows.Forms.Button bPass;
        private System.Windows.Forms.Label lInfo;
        private System.Windows.Forms.PictureBox pbActiveCard;
        private System.Windows.Forms.Button bBluff;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Panel pTools;
    }
}
