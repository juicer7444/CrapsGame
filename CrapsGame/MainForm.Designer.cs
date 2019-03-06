namespace CrapsGame
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.historyListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.playerNameLabel = new System.Windows.Forms.Label();
            this.rollButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.die1Label = new System.Windows.Forms.Label();
            this.die2Label = new System.Windows.Forms.Label();
            this.totalSumLabel = new System.Windows.Forms.Label();
            this.pointLabel = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.createPlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletePlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.editPlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearPlayerHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // historyListBox
            // 
            this.historyListBox.FormattingEnabled = true;
            this.historyListBox.ItemHeight = 31;
            this.historyListBox.Location = new System.Drawing.Point(786, 223);
            this.historyListBox.Name = "historyListBox";
            this.historyListBox.Size = new System.Drawing.Size(396, 500);
            this.historyListBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Current Player:";
            // 
            // playerNameLabel
            // 
            this.playerNameLabel.AutoSize = true;
            this.playerNameLabel.Location = new System.Drawing.Point(223, 70);
            this.playerNameLabel.Name = "playerNameLabel";
            this.playerNameLabel.Size = new System.Drawing.Size(194, 32);
            this.playerNameLabel.TabIndex = 2;
            this.playerNameLabel.Text = "Default Player";
            // 
            // rollButton
            // 
            this.rollButton.Location = new System.Drawing.Point(120, 550);
            this.rollButton.Name = "rollButton";
            this.rollButton.Size = new System.Drawing.Size(199, 110);
            this.rollButton.TabIndex = 3;
            this.rollButton.Text = "Roll";
            this.rollButton.UseVisualStyleBackColor = true;
            this.rollButton.Click += new System.EventHandler(this.rollButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Die 1: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Die 2: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 372);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "Total: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(424, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 32);
            this.label5.TabIndex = 7;
            this.label5.Text = "Point: ";
            // 
            // die1Label
            // 
            this.die1Label.AutoSize = true;
            this.die1Label.Location = new System.Drawing.Point(141, 233);
            this.die1Label.Name = "die1Label";
            this.die1Label.Size = new System.Drawing.Size(0, 32);
            this.die1Label.TabIndex = 8;
            // 
            // die2Label
            // 
            this.die2Label.AutoSize = true;
            this.die2Label.Location = new System.Drawing.Point(141, 305);
            this.die2Label.Name = "die2Label";
            this.die2Label.Size = new System.Drawing.Size(0, 32);
            this.die2Label.TabIndex = 9;
            // 
            // totalSumLabel
            // 
            this.totalSumLabel.AutoSize = true;
            this.totalSumLabel.Location = new System.Drawing.Point(141, 372);
            this.totalSumLabel.Name = "totalSumLabel";
            this.totalSumLabel.Size = new System.Drawing.Size(0, 32);
            this.totalSumLabel.TabIndex = 10;
            // 
            // pointLabel
            // 
            this.pointLabel.AutoSize = true;
            this.pointLabel.Location = new System.Drawing.Point(526, 243);
            this.pointLabel.Name = "pointLabel";
            this.pointLabel.Size = new System.Drawing.Size(0, 32);
            this.pointLabel.TabIndex = 11;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1217, 48);
            this.toolStrip1.TabIndex = 12;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createPlayerToolStripMenuItem,
            this.deletePlayerToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(89, 45);
            this.toolStripDropDownButton1.Text = "File";
            // 
            // createPlayerToolStripMenuItem
            // 
            this.createPlayerToolStripMenuItem.Name = "createPlayerToolStripMenuItem";
            this.createPlayerToolStripMenuItem.Size = new System.Drawing.Size(396, 46);
            this.createPlayerToolStripMenuItem.Text = "Create Player";
            this.createPlayerToolStripMenuItem.Click += new System.EventHandler(this.createPlayerToolStripMenuItem_Click);
            // 
            // deletePlayerToolStripMenuItem
            // 
            this.deletePlayerToolStripMenuItem.Name = "deletePlayerToolStripMenuItem";
            this.deletePlayerToolStripMenuItem.Size = new System.Drawing.Size(396, 46);
            this.deletePlayerToolStripMenuItem.Text = "Delete Player";
            this.deletePlayerToolStripMenuItem.Click += new System.EventHandler(this.deletePlayerToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(396, 46);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editPlayerToolStripMenuItem,
            this.clearPlayerHistoryToolStripMenuItem});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(94, 45);
            this.toolStripDropDownButton2.Text = "Edit";
            this.toolStripDropDownButton2.ToolTipText = "Edit";
            // 
            // editPlayerToolStripMenuItem
            // 
            this.editPlayerToolStripMenuItem.Name = "editPlayerToolStripMenuItem";
            this.editPlayerToolStripMenuItem.Size = new System.Drawing.Size(396, 46);
            this.editPlayerToolStripMenuItem.Text = "Edit Player";
            this.editPlayerToolStripMenuItem.Click += new System.EventHandler(this.editPlayerToolStripMenuItem_Click);
            // 
            // clearPlayerHistoryToolStripMenuItem
            // 
            this.clearPlayerHistoryToolStripMenuItem.Name = "clearPlayerHistoryToolStripMenuItem";
            this.clearPlayerHistoryToolStripMenuItem.Size = new System.Drawing.Size(396, 46);
            this.clearPlayerHistoryToolStripMenuItem.Text = "Clear Player History";
            this.clearPlayerHistoryToolStripMenuItem.Click += new System.EventHandler(this.clearPlayerHistoryToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 759);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pointLabel);
            this.Controls.Add(this.totalSumLabel);
            this.Controls.Add(this.die2Label);
            this.Controls.Add(this.die1Label);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rollButton);
            this.Controls.Add(this.playerNameLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.historyListBox);
            this.Name = "MainForm";
            this.Text = "Craps!";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox historyListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label playerNameLabel;
        private System.Windows.Forms.Button rollButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label die1Label;
        private System.Windows.Forms.Label die2Label;
        private System.Windows.Forms.Label totalSumLabel;
        private System.Windows.Forms.Label pointLabel;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem createPlayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deletePlayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem editPlayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearPlayerHistoryToolStripMenuItem;
    }
}