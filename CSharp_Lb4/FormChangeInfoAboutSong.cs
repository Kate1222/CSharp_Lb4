using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_Lb4
{
    public partial class FormChangeInfoAboutSong : Form
    {
        private List<Executor> executorsList = new List<Executor>();

        internal FormChangeInfoAboutSong(List<Executor> executors)
        {
            executorsList = executors;
            InitializeComponent();
            labelSong2.Visible = false;
            labelMinutes.Visible = false;
            labelSeconds.Visible = false;
            textBoxSongName.Visible = false;
            numericUpDownMinutes.Visible = false;
            numericUpDownSeconds.Visible = false;
            buttonDone.Visible = false;

            comboBoxExecutors.DataSource = executorsList;
            comboBoxExecutors.DisplayMember = "name";
            
        }

        private void comboBoxExecutors_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxAlbums.DataSource = executorsList[comboBoxExecutors.SelectedIndex].albums;
            comboBoxAlbums.DisplayMember = "name";
            if (executorsList[comboBoxExecutors.SelectedIndex].albums.Count > 0)
            {
                comboBoxSongs.DataSource = executorsList[comboBoxExecutors.SelectedIndex].albums[comboBoxAlbums.SelectedIndex].tracks;
                comboBoxSongs.DisplayMember = "name";
            }
            else
                comboBoxSongs.DataSource = null;
        }

        private void comboBoxAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxSongs.DataSource = executorsList[comboBoxExecutors.SelectedIndex].albums[comboBoxAlbums.SelectedIndex].tracks;
            comboBoxSongs.DisplayMember = "name";
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (comboBoxAlbums.Text == string.Empty)
                MessageBox.Show("You have not selected a song!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                labelExecutor.Visible = false;
                labelAlbum.Visible = false;
                labelSong1.Visible = false;
                comboBoxExecutors.Visible = false;
                comboBoxAlbums.Visible = false;
                comboBoxSongs.Visible = false;
                buttonEdit.Visible = false;

                labelSong2.Visible = true;
                labelMinutes.Visible = true;
                labelSeconds.Visible = true;
                textBoxSongName.Visible = true;
                numericUpDownMinutes.Visible = true;
                numericUpDownSeconds.Visible = true;
                buttonDone.Visible = true;
                
                textBoxSongName.Text = comboBoxSongs.Text;
                numericUpDownMinutes.Value = executorsList[comboBoxExecutors.SelectedIndex].albums[comboBoxAlbums.SelectedIndex].tracks[comboBoxSongs.SelectedIndex].minutes;
                numericUpDownSeconds.Value = executorsList[comboBoxExecutors.SelectedIndex].albums[comboBoxAlbums.SelectedIndex].tracks[comboBoxSongs.SelectedIndex].seconds;
            }
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            if (textBoxSongName.Text == string.Empty)
            {
                DialogResult mb = MessageBox.Show("Are you sure you want to delete this song?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (mb == DialogResult.Yes)
                {
                    if (executorsList[comboBoxExecutors.SelectedIndex].albums[comboBoxAlbums.SelectedIndex].tracks.Count == 1)
                        executorsList[comboBoxExecutors.SelectedIndex].albums.RemoveAt(comboBoxAlbums.SelectedIndex);
                    else
                        executorsList[comboBoxExecutors.SelectedIndex].albums[comboBoxAlbums.SelectedIndex].tracks.RemoveAt(comboBoxSongs.SelectedIndex);
                    this.Close();
                }
                else
                    this.Close();
            }
            else
            {
                executorsList[comboBoxExecutors.SelectedIndex].albums[comboBoxAlbums.SelectedIndex].tracks[comboBoxSongs.SelectedIndex].name = textBoxSongName.Text;
                executorsList[comboBoxExecutors.SelectedIndex].albums[comboBoxAlbums.SelectedIndex].tracks[comboBoxSongs.SelectedIndex].minutes = Convert.ToInt32(Math.Round(numericUpDownMinutes.Value, 0));
                executorsList[comboBoxExecutors.SelectedIndex].albums[comboBoxAlbums.SelectedIndex].tracks[comboBoxSongs.SelectedIndex].seconds = Convert.ToInt32(Math.Round(numericUpDownSeconds.Value, 0));
                this.Close();
            }
        }
    }
}
