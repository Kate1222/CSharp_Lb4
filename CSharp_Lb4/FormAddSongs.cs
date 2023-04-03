using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CSharp_Lb4
{
    public partial class FormAddSongs : Form
    {
        internal List <Track> tracks = new List <Track> ();

        public FormAddSongs()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxTrackName.Text == string.Empty)
                MessageBox.Show("Song name cannot be empty!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (numericUpDownMinutes.Value == 0 && numericUpDownSeconds.Value == 0)
                MessageBox.Show("Song time cannot be zero!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                Track newTrack = new Track();
                newTrack.name = textBoxTrackName.Text;
                newTrack.minutes = Convert.ToInt32(Math.Round(numericUpDownMinutes.Value, 0));
                newTrack.seconds = Convert.ToInt32(Math.Round(numericUpDownSeconds.Value, 0));
                tracks.Add(newTrack);
                dataGridView1.Rows.Add(tracks.Count, newTrack.name, newTrack.minutes + ":" + newTrack.seconds);
                textBoxTrackName.Text = string.Empty;
                numericUpDownMinutes.Value = 0;
                numericUpDownSeconds.Value = 0;
            }
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            if (tracks.Count == 0) 
                MessageBox.Show("There must be at least one song in the album!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                this.Close();
        }
    }
}
