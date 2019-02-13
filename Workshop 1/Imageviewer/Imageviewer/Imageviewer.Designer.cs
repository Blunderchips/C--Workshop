namespace Imageviewer
{
    partial class Imageviewer
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
            this.cmbStrech = new System.Windows.Forms.CheckBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnBGColour = new System.Windows.Forms.Button();
            this.btnClosePicture = new System.Windows.Forms.Button();
            this.btnShowPicture = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbStrech
            // 
            this.cmbStrech.AutoSize = true;
            this.cmbStrech.Location = new System.Drawing.Point(13, 421);
            this.cmbStrech.Name = "cmbStrech";
            this.cmbStrech.Size = new System.Drawing.Size(60, 17);
            this.cmbStrech.TabIndex = 0;
            this.cmbStrech.Text = "Stretch";
            this.cmbStrech.UseVisualStyleBackColor = true;
            this.cmbStrech.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(79, 417);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnBGColour
            // 
            this.btnBGColour.Location = new System.Drawing.Point(160, 417);
            this.btnBGColour.Name = "btnBGColour";
            this.btnBGColour.Size = new System.Drawing.Size(150, 23);
            this.btnBGColour.TabIndex = 2;
            this.btnBGColour.Text = "Set the background colour";
            this.btnBGColour.UseVisualStyleBackColor = true;
            this.btnBGColour.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnClosePicture
            // 
            this.btnClosePicture.Location = new System.Drawing.Point(316, 417);
            this.btnClosePicture.Name = "btnClosePicture";
            this.btnClosePicture.Size = new System.Drawing.Size(97, 23);
            this.btnClosePicture.TabIndex = 3;
            this.btnClosePicture.Text = "Clear the picture";
            this.btnClosePicture.UseVisualStyleBackColor = true;
            this.btnClosePicture.Click += new System.EventHandler(this.btnClosePicture_Click);
            // 
            // btnShowPicture
            // 
            this.btnShowPicture.Location = new System.Drawing.Point(419, 417);
            this.btnShowPicture.Name = "btnShowPicture";
            this.btnShowPicture.Size = new System.Drawing.Size(93, 23);
            this.btnShowPicture.TabIndex = 4;
            this.btnShowPicture.Text = "Show a picture";
            this.btnShowPicture.UseVisualStyleBackColor = true;
            this.btnShowPicture.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(12, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(500, 399);
            this.pictureBox.TabIndex = 5;
            this.pictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 450);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.btnShowPicture);
            this.Controls.Add(this.btnClosePicture);
            this.Controls.Add(this.btnBGColour);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.cmbStrech);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cmbStrech;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnBGColour;
        private System.Windows.Forms.Button btnClosePicture;
        private System.Windows.Forms.Button btnShowPicture;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}

