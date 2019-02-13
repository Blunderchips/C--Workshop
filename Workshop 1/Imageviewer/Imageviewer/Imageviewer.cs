using System;
using System.Windows.Forms;

namespace Imageviewer
{
    public partial class Imageviewer : Form
    {
        public Imageviewer()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cmbStrech.Checked)
            {
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else {
                pictureBox.SizeMode = PictureBoxSizeMode.Normal;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ColorDialog colourPicker = new ColorDialog();
            if (colourPicker.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colourPicker.Color;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Open dialogue 
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pictureBox.Load(openFileDialog.FileName);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClosePicture_Click(object sender, EventArgs e)
        {
            this.pictureBox.Image = null;
        }
    }
}
