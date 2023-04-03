using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CSharp_Lb4
{
    public partial class FormAdd : Form
    {
        internal List<string> listGenres = new List<string>();
        private List<Executor> executorsList = new List<Executor>();

        internal FormAdd(string title, List<Executor> executors, List<string> genres)
        {
            InitializeComponent();
            this.Text = title;

            executorsList = executors;
            listGenres = genres;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (this.Text == "Add executor")
            {
                if (textBox.Text == string.Empty)
                    MessageBox.Show("Executor name cannot be empty!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    Executor findExecutorName = executorsList.Find(ex => ex.name.Equals(textBox.Text));
                    if (findExecutorName != null)
                        MessageBox.Show("This executors's name is already recorded!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        Executor newExecutor = new Executor();
                        newExecutor.name = textBox.Text;
                        executorsList.Add(newExecutor);
                        textBox.Text = string.Empty;
                    }
                }
            }
            else
            {
                if (textBox.Text == string.Empty)
                    MessageBox.Show("The name of the genre cannot be empty!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    string findGenre = listGenres.Find(g => g.Equals(textBox.Text));
                    if (findGenre != null)
                        MessageBox.Show("This genre has already been recorded!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        listGenres.Add(textBox.Text);
                        textBox.Text = string.Empty;
                    }
                }
            }
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
