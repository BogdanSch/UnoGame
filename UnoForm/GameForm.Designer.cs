using System.Windows.Forms;

namespace UnoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
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
            this.pColor = new System.Windows.Forms.Panel();
            this.lHintColor = new System.Windows.Forms.Label();
            this.picColor = new System.Windows.Forms.PictureBox();
            this.ToolsLayout = new System.Windows.Forms.TableLayoutPanel();
            this.pnlPass = new System.Windows.Forms.Panel();
            this.pnlBluff = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbActiveCard)).BeginInit();
            this.tableLayoutPanel.SuspendLayout();
            this.pColor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picColor)).BeginInit();
            this.ToolsLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // pTable
            // 
            this.pTable.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pTable.Location = new System.Drawing.Point(318, 159);
            this.pTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pTable.Name = "pTable";
            this.pTable.Size = new System.Drawing.Size(227, 153);
            this.pTable.TabIndex = 0;
            // 
            // pPlr1
            // 
            this.pPlr1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pPlr1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pPlr1.Location = new System.Drawing.Point(3, 317);
            this.pPlr1.Name = "pPlr1";
            this.pPlr1.Size = new System.Drawing.Size(309, 152);
            this.pPlr1.TabIndex = 1;
            // 
            // pPlr4
            // 
            this.pPlr4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pPlr4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pPlr4.Location = new System.Drawing.Point(3, 3);
            this.pPlr4.Name = "pPlr4";
            this.pPlr4.Size = new System.Drawing.Size(309, 151);
            this.pPlr4.TabIndex = 2;
            // 
            // pPlr3
            // 
            this.pPlr3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pPlr3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pPlr3.Location = new System.Drawing.Point(551, 2);
            this.pPlr3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pPlr3.Name = "pPlr3";
            this.pPlr3.Size = new System.Drawing.Size(311, 153);
            this.pPlr3.TabIndex = 3;
            // 
            // pPlr2
            // 
            this.pPlr2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pPlr2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pPlr2.Location = new System.Drawing.Point(551, 316);
            this.pPlr2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pPlr2.Name = "pPlr2";
            this.pPlr2.Size = new System.Drawing.Size(311, 154);
            this.pPlr2.TabIndex = 4;
            // 
            // pDeck
            // 
            this.pDeck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pDeck.Location = new System.Drawing.Point(3, 160);
            this.pDeck.Name = "pDeck";
            this.pDeck.Size = new System.Drawing.Size(309, 151);
            this.pDeck.TabIndex = 1;
            // 
            // bPass
            // 
            this.bPass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bPass.Location = new System.Drawing.Point(96, 2);
            this.bPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bPass.Name = "bPass";
            this.bPass.Size = new System.Drawing.Size(118, 46);
            this.bPass.TabIndex = 5;
            this.bPass.Text = "Pass";
            this.bPass.UseVisualStyleBackColor = true;
            this.bPass.Click += new System.EventHandler(this.bPass_Click);
            // 
            // lInfo
            // 
            this.lInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lInfo.Location = new System.Drawing.Point(96, 100);
            this.lInfo.Name = "lInfo";
            this.lInfo.Size = new System.Drawing.Size(118, 53);
            this.lInfo.TabIndex = 6;
            this.lInfo.Text = "Info";
            this.lInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbActiveCard
            // 
            this.pbActiveCard.Location = new System.Drawing.Point(647, 245);
            this.pbActiveCard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbActiveCard.Name = "pbActiveCard";
            this.pbActiveCard.Size = new System.Drawing.Size(97, 110);
            this.pbActiveCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbActiveCard.TabIndex = 7;
            this.pbActiveCard.TabStop = false;
            this.pbActiveCard.Visible = false;
            // 
            // bBluff
            // 
            this.bBluff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bBluff.Location = new System.Drawing.Point(96, 52);
            this.bBluff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bBluff.Name = "bBluff";
            this.bBluff.Size = new System.Drawing.Size(118, 46);
            this.bBluff.TabIndex = 8;
            this.bBluff.Text = "Bluff";
            this.bBluff.UseVisualStyleBackColor = true;
            this.bBluff.Click += new System.EventHandler(this.bBluff_Click);
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.BackgroundImage = global::UnoForm.Properties.Resources.Background;
            this.tableLayoutPanel.ColumnCount = 3;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.5F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.5F));
            this.tableLayoutPanel.Controls.Add(this.pPlr4, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.pPlr3, 2, 0);
            this.tableLayoutPanel.Controls.Add(this.pDeck, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.pTable, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.pPlr1, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.pPlr2, 2, 2);
            this.tableLayoutPanel.Controls.Add(this.pColor, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.ToolsLayout, 2, 1);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 3;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(865, 472);
            this.tableLayoutPanel.TabIndex = 9;
            // 
            // pColor
            // 
            this.pColor.Controls.Add(this.lHintColor);
            this.pColor.Controls.Add(this.picColor);
            this.pColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pColor.Location = new System.Drawing.Point(318, 2);
            this.pColor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pColor.Name = "pColor";
            this.pColor.Size = new System.Drawing.Size(227, 153);
            this.pColor.TabIndex = 6;
            // 
            // lHintColor
            // 
            this.lHintColor.AutoSize = true;
            this.lHintColor.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lHintColor.Location = new System.Drawing.Point(50, 4);
            this.lHintColor.Name = "lHintColor";
            this.lHintColor.Size = new System.Drawing.Size(117, 20);
            this.lHintColor.TabIndex = 1;
            this.lHintColor.Text = "Chosed color is :";
            // 
            // picColor
            // 
            this.picColor.BackColor = System.Drawing.SystemColors.Control;
            this.picColor.Location = new System.Drawing.Point(55, 26);
            this.picColor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picColor.Name = "picColor";
            this.picColor.Size = new System.Drawing.Size(112, 103);
            this.picColor.TabIndex = 0;
            this.picColor.TabStop = false;
            // 
            // ToolsLayout
            // 
            this.ToolsLayout.ColumnCount = 3;
            this.ToolsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.ToolsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.ToolsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.ToolsLayout.Controls.Add(this.bBluff, 1, 1);
            this.ToolsLayout.Controls.Add(this.bPass, 1, 0);
            this.ToolsLayout.Controls.Add(this.pnlPass, 0, 0);
            this.ToolsLayout.Controls.Add(this.pnlBluff, 0, 1);
            this.ToolsLayout.Controls.Add(this.lInfo, 1, 2);
            this.ToolsLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ToolsLayout.Location = new System.Drawing.Point(551, 159);
            this.ToolsLayout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ToolsLayout.Name = "ToolsLayout";
            this.ToolsLayout.RowCount = 3;
            this.ToolsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ToolsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ToolsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ToolsLayout.Size = new System.Drawing.Size(311, 153);
            this.ToolsLayout.TabIndex = 7;
            // 
            // pnlPass
            // 
            this.pnlPass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPass.Location = new System.Drawing.Point(3, 2);
            this.pnlPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlPass.Name = "pnlPass";
            this.pnlPass.Size = new System.Drawing.Size(87, 46);
            this.pnlPass.TabIndex = 9;
            // 
            // pnlBluff
            // 
            this.pnlBluff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBluff.Location = new System.Drawing.Point(3, 52);
            this.pnlBluff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlBluff.Name = "pnlBluff";
            this.pnlBluff.Size = new System.Drawing.Size(87, 46);
            this.pnlBluff.TabIndex = 10;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(865, 472);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.pbActiveCard);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "GameForm";
            this.Text = "Uno Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UnoGameForm_Closing);
            this.ClientSizeChanged += new System.EventHandler(this.GameForm_ClientSizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pbActiveCard)).EndInit();
            this.tableLayoutPanel.ResumeLayout(false);
            this.pColor.ResumeLayout(false);
            this.pColor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picColor)).EndInit();
            this.ToolsLayout.ResumeLayout(false);
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
        private System.Windows.Forms.Panel pColor;
        private System.Windows.Forms.PictureBox picColor;
        private System.Windows.Forms.Label lHintColor;
        private TableLayoutPanel ToolsLayout;
        private Panel pnlPass;
        private Panel pnlBluff;
    }
}
