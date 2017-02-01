namespace ImageClient
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
            this.sourcePictureBox = new System.Windows.Forms.PictureBox();
            this.distPictureBox = new System.Windows.Forms.PictureBox();
            this.grayScaleCheckBox = new System.Windows.Forms.CheckBox();
            this.flipImageCheckBox = new System.Windows.Forms.CheckBox();
            this.ConvertButton = new System.Windows.Forms.Button();
            this.change_image_button = new System.Windows.Forms.Button();
            this.dropImageLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sourcePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.distPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // sourcePictureBox
            // 
            this.sourcePictureBox.BackColor = System.Drawing.SystemColors.Control;
            this.sourcePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sourcePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sourcePictureBox.Location = new System.Drawing.Point(12, 12);
            this.sourcePictureBox.Name = "sourcePictureBox";
            this.sourcePictureBox.Size = new System.Drawing.Size(225, 300);
            this.sourcePictureBox.TabIndex = 0;
            this.sourcePictureBox.TabStop = false;
            this.sourcePictureBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // distPictureBox
            // 
            this.distPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.distPictureBox.Location = new System.Drawing.Point(502, 12);
            this.distPictureBox.Name = "distPictureBox";
            this.distPictureBox.Size = new System.Drawing.Size(225, 300);
            this.distPictureBox.TabIndex = 1;
            this.distPictureBox.TabStop = false;
            this.distPictureBox.Click += new System.EventHandler(this.distPictureBox_Click);
            // 
            // grayScaleCheckBox
            // 
            this.grayScaleCheckBox.AutoSize = true;
            this.grayScaleCheckBox.Checked = true;
            this.grayScaleCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.grayScaleCheckBox.Location = new System.Drawing.Point(311, 30);
            this.grayScaleCheckBox.Name = "grayScaleCheckBox";
            this.grayScaleCheckBox.Size = new System.Drawing.Size(73, 17);
            this.grayScaleCheckBox.TabIndex = 2;
            this.grayScaleCheckBox.Text = "Grayscale";
            this.grayScaleCheckBox.UseVisualStyleBackColor = true;
            this.grayScaleCheckBox.CheckedChanged += new System.EventHandler(this.grayScaleCheckBox_CheckedChanged);
            // 
            // flipImageCheckBox
            // 
            this.flipImageCheckBox.AutoSize = true;
            this.flipImageCheckBox.Checked = true;
            this.flipImageCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.flipImageCheckBox.Location = new System.Drawing.Point(311, 63);
            this.flipImageCheckBox.Name = "flipImageCheckBox";
            this.flipImageCheckBox.Size = new System.Drawing.Size(74, 17);
            this.flipImageCheckBox.TabIndex = 3;
            this.flipImageCheckBox.Text = "Flip Image";
            this.flipImageCheckBox.UseVisualStyleBackColor = true;
            // 
            // ConvertButton
            // 
            this.ConvertButton.Location = new System.Drawing.Point(268, 141);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(165, 35);
            this.ConvertButton.TabIndex = 4;
            this.ConvertButton.Text = ">> Convert >>";
            this.ConvertButton.UseVisualStyleBackColor = true;
            this.ConvertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // change_image_button
            // 
            this.change_image_button.Location = new System.Drawing.Point(268, 200);
            this.change_image_button.Name = "change_image_button";
            this.change_image_button.Size = new System.Drawing.Size(165, 35);
            this.change_image_button.TabIndex = 5;
            this.change_image_button.Text = "<< Browse Image";
            this.change_image_button.UseVisualStyleBackColor = true;
            this.change_image_button.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dropImageLabel
            // 
            this.dropImageLabel.AutoSize = true;
            this.dropImageLabel.Location = new System.Drawing.Point(82, 156);
            this.dropImageLabel.Name = "dropImageLabel";
            this.dropImageLabel.Size = new System.Drawing.Size(88, 13);
            this.dropImageLabel.TabIndex = 6;
            this.dropImageLabel.Text = "Drop Image Here";
            this.dropImageLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 348);
            this.Controls.Add(this.dropImageLabel);
            this.Controls.Add(this.change_image_button);
            this.Controls.Add(this.ConvertButton);
            this.Controls.Add(this.flipImageCheckBox);
            this.Controls.Add(this.grayScaleCheckBox);
            this.Controls.Add(this.distPictureBox);
            this.Controls.Add(this.sourcePictureBox);
            this.Name = "MainForm";
            this.Text = "Image Processing Client App";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.sourcePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.distPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox sourcePictureBox;
        private System.Windows.Forms.PictureBox distPictureBox;
        private System.Windows.Forms.CheckBox grayScaleCheckBox;
        private System.Windows.Forms.CheckBox flipImageCheckBox;
        private System.Windows.Forms.Button ConvertButton;
        private System.Windows.Forms.Button change_image_button;
        private System.Windows.Forms.Label dropImageLabel;
    }
}

