namespace CrapsGame
{
    partial class StartForm
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
            this.playerListComboBox = new System.Windows.Forms.ComboBox();
            this.playersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.mainPlayButton = new System.Windows.Forms.Button();
            this.mainCreatePlayerButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // playerListComboBox
            // 
            this.playerListComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.playerListComboBox.FormattingEnabled = true;
            this.playerListComboBox.Location = new System.Drawing.Point(270, 312);
            this.playerListComboBox.Name = "playerListComboBox";
            this.playerListComboBox.Size = new System.Drawing.Size(246, 39);
            this.playerListComboBox.TabIndex = 0;
            // 
            // playersBindingSource
            // 
            this.playersBindingSource.DataMember = "Players";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label1.Location = new System.Drawing.Point(254, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 91);
            this.label1.TabIndex = 1;
            this.label1.Text = "Craps!";
            // 
            // mainPlayButton
            // 
            this.mainPlayButton.Location = new System.Drawing.Point(116, 415);
            this.mainPlayButton.Name = "mainPlayButton";
            this.mainPlayButton.Size = new System.Drawing.Size(205, 96);
            this.mainPlayButton.TabIndex = 2;
            this.mainPlayButton.Text = "Play";
            this.mainPlayButton.UseVisualStyleBackColor = true;
            this.mainPlayButton.Click += new System.EventHandler(this.mainPlayButton_Click);
            // 
            // mainCreatePlayerButton
            // 
            this.mainCreatePlayerButton.Location = new System.Drawing.Point(441, 415);
            this.mainCreatePlayerButton.Name = "mainCreatePlayerButton";
            this.mainCreatePlayerButton.Size = new System.Drawing.Size(203, 96);
            this.mainCreatePlayerButton.TabIndex = 3;
            this.mainCreatePlayerButton.Text = "Create Player";
            this.mainCreatePlayerButton.UseVisualStyleBackColor = true;
            this.mainCreatePlayerButton.Click += new System.EventHandler(this.mainCreatePlayerButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Choose your player!";
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 632);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mainCreatePlayerButton);
            this.Controls.Add(this.mainPlayButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.playerListComboBox);
            this.Name = "StartForm";
            this.Text = "Craps!";
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox playerListComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button mainPlayButton;
        private System.Windows.Forms.Button mainCreatePlayerButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource playersBindingSource;
    }
}

