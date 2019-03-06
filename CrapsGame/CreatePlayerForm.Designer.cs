namespace CrapsGame
{
    partial class CreatePlayerForm
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
            this.createPlayerLabel = new System.Windows.Forms.Label();
            this.createPlayerTextBox = new System.Windows.Forms.TextBox();
            this.CreatePlayerButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createPlayerLabel
            // 
            this.createPlayerLabel.AutoSize = true;
            this.createPlayerLabel.Location = new System.Drawing.Point(124, 93);
            this.createPlayerLabel.Name = "createPlayerLabel";
            this.createPlayerLabel.Size = new System.Drawing.Size(316, 32);
            this.createPlayerLabel.TabIndex = 0;
            this.createPlayerLabel.Text = "Enter New Player Name";
            // 
            // createPlayerTextBox
            // 
            this.createPlayerTextBox.Location = new System.Drawing.Point(121, 156);
            this.createPlayerTextBox.Name = "createPlayerTextBox";
            this.createPlayerTextBox.Size = new System.Drawing.Size(330, 38);
            this.createPlayerTextBox.TabIndex = 1;
            // 
            // CreatePlayerButton
            // 
            this.CreatePlayerButton.Location = new System.Drawing.Point(89, 285);
            this.CreatePlayerButton.Name = "CreatePlayerButton";
            this.CreatePlayerButton.Size = new System.Drawing.Size(148, 76);
            this.CreatePlayerButton.TabIndex = 2;
            this.CreatePlayerButton.Text = "Create";
            this.CreatePlayerButton.UseVisualStyleBackColor = true;
            this.CreatePlayerButton.Click += new System.EventHandler(this.CreatePlayerButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(319, 285);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(148, 76);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // CreatePlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 396);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.CreatePlayerButton);
            this.Controls.Add(this.createPlayerTextBox);
            this.Controls.Add(this.createPlayerLabel);
            this.Name = "CreatePlayerForm";
            this.Text = "Create Player";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label createPlayerLabel;
        private System.Windows.Forms.TextBox createPlayerTextBox;
        private System.Windows.Forms.Button CreatePlayerButton;
        private System.Windows.Forms.Button cancelButton;
    }
}