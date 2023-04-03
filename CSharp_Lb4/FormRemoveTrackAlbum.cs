using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CSharp_Lb4
{
    public partial class FormRemoveTrackAlbum : Form
    {
        private List<Executor> executorsList = new List<Executor>();

        internal FormRemoveTrackAlbum(string title, List<Executor> executors)
        {
            InitializeComponent();
            executorsList = executors;
            this.Text = title;
            comboBoxExecutor.DataSource = executorsList;
            comboBoxExecutor.DisplayMember = "name";
            comboBoxAlbum.DataSource = executorsList[comboBoxExecutor.SelectedIndex].albums;
            comboBoxAlbum.DisplayMember = "name";

            if (title == "Remove album")
            {
                label3.Visible = false;
                comboBoxSongs.Visible = false;
            }
            else
            {
                comboBoxSongs.DataSource = executorsList[comboBoxExecutor.SelectedIndex].albums[comboBoxAlbum.SelectedIndex].tracks;
                comboBoxSongs.DisplayMember = "name";
            }
        }

        private void comboBoxExecutor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (executorsList[comboBoxExecutor.SelectedIndex].albums.Count != 0)
            {
                comboBoxAlbum.DataSource = executorsList[comboBoxExecutor.SelectedIndex].albums;
                comboBoxAlbum.DisplayMember = "name";
                if (this.Text == "Remove song")
                {
                    comboBoxSongs.DataSource = executorsList[comboBoxExecutor.SelectedIndex].albums[comboBoxAlbum.SelectedIndex].tracks;
                    comboBoxSongs.DisplayMember = "name";
                }
            }
            else
            {
                comboBoxAlbum.DataSource = null;
                comboBoxSongs.DataSource = null;
            }
        }

        private void comboBoxAlbum_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxAlbum.DataSource = executorsList[comboBoxExecutor.SelectedIndex].albums;
            comboBoxAlbum.DisplayMember = "name";
            if (executorsList[comboBoxExecutor.SelectedIndex].albums.Count > 0)
            {
                if (this.Text == "Remove song")
                {
                    comboBoxSongs.DataSource = executorsList[comboBoxExecutor.SelectedIndex].albums[comboBoxAlbum.SelectedIndex].tracks;
                    comboBoxSongs.DisplayMember = "name";
                }
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (comboBoxAlbum.Text == string.Empty)
                MessageBox.Show("This executor has no albums!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (this.Text == "Remove album")
                    executorsList[comboBoxExecutor.SelectedIndex].albums.RemoveAt(comboBoxAlbum.SelectedIndex);
                else
                {
                    if (executorsList[comboBoxExecutor.SelectedIndex].albums[comboBoxAlbum.SelectedIndex].tracks.Count == 1)
                        executorsList[comboBoxExecutor.SelectedIndex].albums.RemoveAt(comboBoxAlbum.SelectedIndex);
                    else
                        executorsList[comboBoxExecutor.SelectedIndex].albums[comboBoxAlbum.SelectedIndex].tracks.RemoveAt(comboBoxSongs.SelectedIndex);
                }
                this.Close();
            }
        }
    }
}
