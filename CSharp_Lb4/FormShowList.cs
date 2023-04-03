using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CSharp_Lb4
{
    public partial class FormShowList : Form
    {
        private List<Executor> listExecutors = new List<Executor>();

        private void updateDataGridView() 
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < listExecutors.Count; i++)
            {
                for (int j = 0; j < listExecutors[i].albums.Count; j++)
                {
                    string genres = listExecutors[i].albums[j].genres.Aggregate((current, next) => current + " " + next);
                    for (int k = 0; k < listExecutors[i].albums[j].tracks.Count; k++)
                        dataGridView1.Rows.Add(j + 1, listExecutors[i].albums[j].tracks[k].name,
                            listExecutors[i].name, genres, listExecutors[i].albums[j].name,
                            listExecutors[i].albums[j].tracks[k].minutes + ":" + listExecutors[i].albums[j].tracks[k].seconds);
                    dataGridView1.Rows.Add();
                }
            }
        }

        internal FormShowList(List<Executor> executors)
        {
            InitializeComponent();
            listExecutors = executors;
            updateDataGridView();
        }

        private void showAllListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updateDataGridView();
        }

        private void chooseExecutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSelectExecutor formSelectExecutor = new FormSelectExecutor(listExecutors);
            formSelectExecutor.ShowDialog();
            dataGridView1.Rows.Clear();
            for (int j = 0; j < listExecutors[formSelectExecutor.selectIndex].albums.Count; j++)
            {
                string genres = listExecutors[formSelectExecutor.selectIndex].albums[j].genres.Aggregate((current, next) => current + " " + next);
                for (int k = 0; k < listExecutors[formSelectExecutor.selectIndex].albums[j].tracks.Count; k++)
                    dataGridView1.Rows.Add(j + 1, listExecutors[formSelectExecutor.selectIndex].albums[j].tracks[k].name,
                        listExecutors[formSelectExecutor.selectIndex].name, genres, listExecutors[formSelectExecutor.selectIndex].albums[j].name,
                        listExecutors[formSelectExecutor.selectIndex].albums[j].tracks[k].minutes + ":" + listExecutors[formSelectExecutor.selectIndex].albums[j].tracks[k].seconds);
                dataGridView1.Rows.Add();
            }
        }
    }
}
