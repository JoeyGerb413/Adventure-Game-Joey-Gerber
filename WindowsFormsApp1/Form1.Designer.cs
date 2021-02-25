namespace WindowsFormsApp1
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
            this.greenButton = new System.Windows.Forms.Button();
            this.redButton = new System.Windows.Forms.Button();
            this.orangeButton = new System.Windows.Forms.Button();
            this.storyLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.storyImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.storyImage)).BeginInit();
            this.SuspendLayout();
            // 
            // greenButton
            // 
            this.greenButton.BackColor = System.Drawing.Color.Lime;
            this.greenButton.Enabled = false;
            this.greenButton.Location = new System.Drawing.Point(334, 354);
            this.greenButton.Name = "greenButton";
            this.greenButton.Size = new System.Drawing.Size(465, 23);
            this.greenButton.TabIndex = 0;
            this.greenButton.Text = "Engineer";
            this.greenButton.UseVisualStyleBackColor = false;
            this.greenButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // redButton
            // 
            this.redButton.BackColor = System.Drawing.Color.Red;
            this.redButton.Enabled = false;
            this.redButton.Location = new System.Drawing.Point(334, 383);
            this.redButton.Name = "redButton";
            this.redButton.Size = new System.Drawing.Size(465, 23);
            this.redButton.TabIndex = 1;
            this.redButton.Text = "Pilot";
            this.redButton.UseVisualStyleBackColor = false;
            // 
            // orangeButton
            // 
            this.orangeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.orangeButton.Enabled = false;
            this.orangeButton.Location = new System.Drawing.Point(334, 415);
            this.orangeButton.Name = "orangeButton";
            this.orangeButton.Size = new System.Drawing.Size(465, 23);
            this.orangeButton.TabIndex = 2;
            this.orangeButton.Text = "Scientist";
            this.orangeButton.UseVisualStyleBackColor = false;
            // 
            // storyLabel
            // 
            this.storyLabel.BackColor = System.Drawing.Color.Transparent;
            this.storyLabel.Font = new System.Drawing.Font("mono 07_66", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storyLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.storyLabel.Location = new System.Drawing.Point(331, 59);
            this.storyLabel.Name = "storyLabel";
            this.storyLabel.Size = new System.Drawing.Size(468, 279);
            this.storyLabel.TabIndex = 3;
            this.storyLabel.Text = "You are a crew member aboard the Archangel, \r\nan exploration vessel. What is your" +
    " occupation?";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("mono 07_66", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.titleLabel.Location = new System.Drawing.Point(221, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(292, 47);
            this.titleLabel.TabIndex = 4;
            this.titleLabel.Text = "OVERRIDE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(312, 359);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "M";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(312, 388);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(314, 420);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "N";
            // 
            // storyImage
            // 
            this.storyImage.Location = new System.Drawing.Point(0, 59);
            this.storyImage.Name = "storyImage";
            this.storyImage.Size = new System.Drawing.Size(308, 391);
            this.storyImage.TabIndex = 8;
            this.storyImage.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.storyLabel);
            this.Controls.Add(this.orangeButton);
            this.Controls.Add(this.redButton);
            this.Controls.Add(this.greenButton);
            this.Controls.Add(this.storyImage);
            this.Name = "Form1";
            this.Text = "OVERRIDE";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.storyImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button greenButton;
        private System.Windows.Forms.Button redButton;
        private System.Windows.Forms.Button orangeButton;
        private System.Windows.Forms.Label storyLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox storyImage;
        private System.Windows.Forms.Label label3;
    }
}

