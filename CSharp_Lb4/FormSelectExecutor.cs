using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CSharp_Lb4
{
    public partial class FormSelectExecutor : Form
    {
        public int selectIndex = 0;
        internal FormSelectExecutor(List<Executor> executors)
        {
            InitializeComponent();
            comboBoxExecutors.DataSource = executors;
            comboBoxExecutors.DisplayMember = "name";
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            selectIndex = comboBoxExecutors.SelectedIndex;
            this.Close();
        }
    }
}
