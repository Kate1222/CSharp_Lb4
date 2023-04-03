using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CSharp_Lb4
{
    public partial class FormRemove : Form
    {
        internal List<Executor> executorsList = new List<Executor>();
        internal List<string> listGenres = new List<string>();

        internal FormRemove(string title, List<Executor> executors, List<string> genres)
        {
            this.Text = title;
            InitializeComponent();
            if (this.Text == "Remove genre")
                comboBox.DataSource = genres;
            else
            {
                comboBox.DataSource = executors;
                comboBox.DisplayMember = "name";
            }
            comboBox.SelectedIndex = 0;

            executorsList = executors;
            listGenres = genres;
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (this.Text == "Remove genre")
            {
                for (int i = 0; i < executorsList.Count; i++)
                {
                    for (int j = 0; j < executorsList[i].albums.Count; j++)
                    {
                        string findGenreInAlbums = executorsList[i].albums[j].genres.Find(g => g.Equals(comboBox.Text));
                        if (findGenreInAlbums != null)
                        {
                            executorsList[i].albums.RemoveAt(j);
                            j--;
                        }
                    }
                }
                listGenres.RemoveAt(comboBox.SelectedIndex);
                this.Close();
            }
            else
            {
                executorsList.RemoveAt(comboBox.SelectedIndex);
                this.Close();
            }
        }
    }
}
