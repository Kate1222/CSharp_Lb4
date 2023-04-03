using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CSharp_Lb4
{
    public partial class FormAddAlbum : Form
    {
        List<Executor> listExecutors = new List<Executor>();
        List<string> listGenres = new List<string>();

        internal FormAddAlbum(List<Executor> executors, List<String> genres)
        {
            InitializeComponent();
            listExecutors = executors;
            listGenres = genres;
            numericUpDownYear.Value = 2023;
            comboBoxExecutors.DataSource = executors;
            comboBoxExecutors.DisplayMember = "name";
            comboBoxExecutors.SelectedIndex = 0;
            for (int i = 0; i < listGenres.Count; i++)
            {
                CheckBox newCheckBox = new CheckBox();
                newCheckBox.Text = listGenres[i];
                newCheckBox.Location = new System.Drawing.Point(10, i * 20);
                panelGenres.Controls.Add(newCheckBox);
            }
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            bool checkSelect = false;
            foreach (CheckBox c in panelGenres.Controls.OfType<CheckBox>())
            {
                if (c.Checked)
                {
                    checkSelect = true;
                    break;
                }
            }
            if (comboBoxExecutors.Text == null || textBoxAlbumName.Text == string.Empty || listGenres.Count == 0 || !checkSelect)
                MessageBox.Show("Not enough information!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                FormAddSongs formAddSongs = new FormAddSongs();
                this.Hide();
                formAddSongs.ShowDialog();
                Album newAlbum = new Album();
                newAlbum.name = textBoxAlbumName.Text;
                newAlbum.year = Convert.ToInt32(Math.Round(numericUpDownYear.Value, 0));

                foreach (CheckBox c in panelGenres.Controls.OfType<CheckBox>())
                {
                    if (c.Checked)
                        newAlbum.genres.Add(c.Text);
                }
                newAlbum.tracks = formAddSongs.tracks;

                listExecutors[comboBoxExecutors.SelectedIndex].albums.Add(newAlbum);
                this.Close();
            }
        }
    }
}
