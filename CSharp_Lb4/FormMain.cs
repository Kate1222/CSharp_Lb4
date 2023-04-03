using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Text.Json;
using System.CodeDom.Compiler;

namespace CSharp_Lb4
{
    public partial class FormMain : Form
    {
        private List<Executor> executors = new List<Executor>();
        private List<string> genres = new List<string>();

        private bool findAlbum()
        {
            bool result = false;

            foreach (var executor in executors)
            {
                if (executor.albums.Count > 0)
                {
                    result = true;
                    break;
                }
            }

            return result;
        }

        public FormMain()
        {
            InitializeComponent();
            if (Directory.Exists("data"))
            {
                string readExecutorsJsonFile = File.ReadAllText("data//executors.json");
                executors = JsonSerializer.Deserialize<List<Executor>>(readExecutorsJsonFile);
                string readGenresJsonFile = File.ReadAllText("data//genres.json");
                genres = JsonSerializer.Deserialize<List<string>>(readGenresJsonFile);

                bool buttonEnabled = false;
                if (executors != null )
                {
                    if (findAlbum())
                    {
                        buttonEnabled = true;
                        buttonShowAllList.Enabled = true;
                        buttonAddAlbum.Enabled = true;
                        buttonChangeInfoAboutTrack.Enabled = true;
                        buttonRemoveTrack.Enabled = true;
                        buttonRemoveAlbum.Enabled = true;
                        buttonRemoveExecutor.Enabled = true;
                        buttonRemoveGenre.Enabled = true;
                    }
                    if (!buttonEnabled)
                    {
                        buttonRemoveExecutor.Enabled = true;
                        if (genres.Count > 0)
                        {
                            buttonAddAlbum.Enabled = true;
                            buttonRemoveGenre.Enabled = true;
                        }
                    }
                }
                label2.Text = "In program write: \nExecutors: " + executors.Count + "\nGenres: " + genres.Count;
            }
        }

        private void buttonShowAllList_Click(object sender, EventArgs e)
        {
            FormShowList formShowList = new FormShowList(executors);
            this.Hide();
            formShowList.ShowDialog();
            this.Show();
        }

        private void buttonAddExecutor_Click(object sender, EventArgs e)
        {
            FormAdd formAddExecutor = new FormAdd("Add executor", executors, genres);
            this.Hide();
            formAddExecutor.ShowDialog();
            this.Show();
            if (executors.Count > 0)
            {
                buttonRemoveExecutor.Enabled = true;
                if (genres.Count > 0)
                    buttonAddAlbum.Enabled = true;
            }
            label2.Text = "In program write: \nExecutors: " + executors.Count + "\nGenres: " + genres.Count;
        }

        private void buttonAddGenres_Click(object sender, EventArgs e)
        {
            FormAdd formAddGenres = new FormAdd("Add genre", executors, genres);
            this.Hide();
            formAddGenres.ShowDialog();
            this.Show();
            if (genres.Count > 0)
            {
                buttonRemoveGenre.Enabled = true;
                if (executors.Count > 0)
                    buttonAddAlbum.Enabled = true;
            }
            label2.Text = "In program write: \nExecutors: " + executors.Count + "\nGenres: " + genres.Count;
        }

        private void buttonAddAlbum_Click(object sender, EventArgs e)
        {
            FormAddAlbum formAddAlbum = new FormAddAlbum(executors, genres);
            this.Hide();
            formAddAlbum.ShowDialog();
            this.Show();
            bool savedAlbums = false;
            for (int i = 0; i < executors.Count; i++)
            {
                if (executors[i].albums.Count > 0)
                {
                    savedAlbums = true;
                    break;
                }
            }
            if (savedAlbums)
            {
                buttonShowAllList.Enabled = true;
                buttonChangeInfoAboutTrack.Enabled = true;
                buttonRemoveTrack.Enabled = true;
                buttonRemoveAlbum.Enabled = true;
            }
            label2.Text = "In program write: \nExecutors: " + executors.Count + "\nGenres: " + genres.Count;
        }

        private void buttonChangeInfoAboutTrack_Click(object sender, EventArgs e)
        {
            FormChangeInfoAboutSong formChangeInfoAboutSong = new FormChangeInfoAboutSong(executors);
            this.Hide();
            formChangeInfoAboutSong.ShowDialog();
            this.Show();
            label2.Text = "In program write: \nExecutors: " + executors.Count + "\nGenres: " + genres.Count;
        }

        private void buttonRemoveTrack_Click(object sender, EventArgs e)
        {
            FormRemoveTrackAlbum removeTrack = new FormRemoveTrackAlbum("Remove song", executors);
            this.Hide();
            removeTrack.ShowDialog();
            this.Show();
            if (!findAlbum())
            {
                buttonRemoveAlbum.Enabled = false;
                buttonRemoveTrack.Enabled = false;
                buttonChangeInfoAboutTrack.Enabled = false;
                buttonShowAllList.Enabled = false;
            }
            label2.Text = "In program write: \nExecutors: " + executors.Count + "\nGenres: " + genres.Count;
        }

        private void buttonRemoveAlbum_Click(object sender, EventArgs e)
        {
            FormRemoveTrackAlbum removeAlbum = new FormRemoveTrackAlbum("Remove album", executors);
            this.Hide();
            removeAlbum.ShowDialog();
            this.Show();
            if (!findAlbum())
            {
                buttonRemoveAlbum.Enabled = false;
                buttonRemoveTrack.Enabled = false;
                buttonChangeInfoAboutTrack.Enabled = false;
                buttonShowAllList.Enabled = false;
            }
            label2.Text = "In program write: \nExecutors: " + executors.Count + "\nGenres: " + genres.Count;
        }

        private void buttonRemoveExecutor_Click(object sender, EventArgs e)
        {
            FormRemove formRemoveExecutor = new FormRemove("Remove executor", executors, genres);
            this.Hide();
            formRemoveExecutor.ShowDialog();
            this.Show();
            if (executors.Count == 0)
            {
                buttonRemoveExecutor.Enabled = false;
                buttonAddAlbum.Enabled = false;
            }
            if (!findAlbum())
            {
                buttonRemoveAlbum.Enabled = false;
                buttonRemoveTrack.Enabled = false;
                buttonChangeInfoAboutTrack.Enabled = false;
                buttonShowAllList.Enabled = false;
            }
            label2.Text = "In program write: \nExecutors: " + executors.Count + "\nGenres: " + genres.Count;
        }

        private void buttonRemoveGenre_Click(object sender, EventArgs e)
        {
            FormRemove formRemoveGenre = new FormRemove("Remove genre", executors, genres);
            this.Hide();
            formRemoveGenre.ShowDialog();
            this.Show();
            if (genres.Count == 0)
            {
                buttonRemoveGenre.Enabled = false;
                buttonAddAlbum.Enabled = false;
            }
            if (!findAlbum())
            {
                buttonRemoveAlbum.Enabled = false;
                buttonRemoveTrack.Enabled = false;
                buttonChangeInfoAboutTrack.Enabled = false;
                buttonShowAllList.Enabled = false;
            }
            label2.Text = "In program write: \nExecutors: " + executors.Count + "\nGenres: " + genres.Count;
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure you want to finish the work?", "Question!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                if (executors.Count > 0 || genres.Count > 0)
                {
                    if (!Directory.Exists("data"))
                        Directory.CreateDirectory("data");
                    string saveExecutorsJson = JsonSerializer.Serialize(executors);
                    File.WriteAllText("data//executors.json", saveExecutorsJson);
                    string saveGenresJson = JsonSerializer.Serialize(genres);
                    File.WriteAllText("data//genres.json", saveGenresJson);
                }
                e.Cancel = false;
            }
            else
                e.Cancel = true;
        }
    }
}
