namespace CSharp_Lb4
{
    partial class FormChangeInfoAboutSong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelExecutor = new System.Windows.Forms.Label();
            this.labelAlbum = new System.Windows.Forms.Label();
            this.labelSong1 = new System.Windows.Forms.Label();
            this.comboBoxExecutors = new System.Windows.Forms.ComboBox();
            this.comboBoxAlbums = new System.Windows.Forms.ComboBox();
            this.comboBoxSongs = new System.Windows.Forms.ComboBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.textBoxSongName = new System.Windows.Forms.TextBox();
            this.labelSong2 = new System.Windows.Forms.Label();
            this.labelMinutes = new System.Windows.Forms.Label();
            this.labelSeconds = new System.Windows.Forms.Label();
            this.numericUpDownMinutes = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSeconds = new System.Windows.Forms.NumericUpDown();
            this.buttonDone = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSeconds)).BeginInit();
            this.SuspendLayout();
            // 
            // labelExecutor
            // 
            this.labelExecutor.AutoSize = true;
            this.labelExecutor.Location = new System.Drawing.Point(136, 76);
            this.labelExecutor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelExecutor.Name = "labelExecutor";
            this.labelExecutor.Size = new System.Drawing.Size(63, 19);
            this.labelExecutor.TabIndex = 0;
            this.labelExecutor.Text = "Executor";
            // 
            // labelAlbum
            // 
            this.labelAlbum.AutoSize = true;
            this.labelAlbum.Location = new System.Drawing.Point(150, 110);
            this.labelAlbum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAlbum.Name = "labelAlbum";
            this.labelAlbum.Size = new System.Drawing.Size(49, 19);
            this.labelAlbum.TabIndex = 1;
            this.labelAlbum.Text = "Album";
            // 
            // labelSong1
            // 
            this.labelSong1.AutoSize = true;
            this.labelSong1.Location = new System.Drawing.Point(159, 143);
            this.labelSong1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSong1.Name = "labelSong1";
            this.labelSong1.Size = new System.Drawing.Size(40, 19);
            this.labelSong1.TabIndex = 2;
            this.labelSong1.Text = "Song";
            // 
            // comboBoxExecutors
            // 
            this.comboBoxExecutors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxExecutors.FormattingEnabled = true;
            this.comboBoxExecutors.Location = new System.Drawing.Point(206, 74);
            this.comboBoxExecutors.Name = "comboBoxExecutors";
            this.comboBoxExecutors.Size = new System.Drawing.Size(188, 27);
            this.comboBoxExecutors.TabIndex = 1;
            this.comboBoxExecutors.SelectedIndexChanged += new System.EventHandler(this.comboBoxExecutors_SelectedIndexChanged);
            // 
            // comboBoxAlbums
            // 
            this.comboBoxAlbums.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAlbums.FormattingEnabled = true;
            this.comboBoxAlbums.Location = new System.Drawing.Point(206, 107);
            this.comboBoxAlbums.Name = "comboBoxAlbums";
            this.comboBoxAlbums.Size = new System.Drawing.Size(188, 27);
            this.comboBoxAlbums.TabIndex = 2;
            this.comboBoxAlbums.SelectedIndexChanged += new System.EventHandler(this.comboBoxAlbums_SelectedIndexChanged);
            // 
            // comboBoxSongs
            // 
            this.comboBoxSongs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSongs.FormattingEnabled = true;
            this.comboBoxSongs.Location = new System.Drawing.Point(206, 140);
            this.comboBoxSongs.Name = "comboBoxSongs";
            this.comboBoxSongs.Size = new System.Drawing.Size(188, 27);
            this.comboBoxSongs.TabIndex = 3;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(238, 173);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(105, 32);
            this.buttonEdit.TabIndex = 4;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // textBoxSongName
            // 
            this.textBoxSongName.Location = new System.Drawing.Point(206, 92);
            this.textBoxSongName.Name = "textBoxSongName";
            this.textBoxSongName.Size = new System.Drawing.Size(188, 26);
            this.textBoxSongName.TabIndex = 5;
            // 
            // labelSong2
            // 
            this.labelSong2.AutoSize = true;
            this.labelSong2.Location = new System.Drawing.Point(159, 95);
            this.labelSong2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSong2.Name = "labelSong2";
            this.labelSong2.Size = new System.Drawing.Size(40, 19);
            this.labelSong2.TabIndex = 6;
            this.labelSong2.Text = "Song";
            // 
            // labelMinutes
            // 
            this.labelMinutes.AutoSize = true;
            this.labelMinutes.Location = new System.Drawing.Point(165, 126);
            this.labelMinutes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMinutes.Name = "labelMinutes";
            this.labelMinutes.Size = new System.Drawing.Size(37, 19);
            this.labelMinutes.TabIndex = 7;
            this.labelMinutes.Text = "Min.";
            // 
            // labelSeconds
            // 
            this.labelSeconds.AutoSize = true;
            this.labelSeconds.Location = new System.Drawing.Point(285, 126);
            this.labelSeconds.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSeconds.Name = "labelSeconds";
            this.labelSeconds.Size = new System.Drawing.Size(36, 19);
            this.labelSeconds.TabIndex = 8;
            this.labelSeconds.Text = "Sec.";
            // 
            // numericUpDownMinutes
            // 
            this.numericUpDownMinutes.Location = new System.Drawing.Point(209, 124);
            this.numericUpDownMinutes.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownMinutes.Name = "numericUpDownMinutes";
            this.numericUpDownMinutes.Size = new System.Drawing.Size(64, 26);
            this.numericUpDownMinutes.TabIndex = 9;
            // 
            // numericUpDownSeconds
            // 
            this.numericUpDownSeconds.Location = new System.Drawing.Point(330, 124);
            this.numericUpDownSeconds.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDownSeconds.Name = "numericUpDownSeconds";
            this.numericUpDownSeconds.Size = new System.Drawing.Size(64, 26);
            this.numericUpDownSeconds.TabIndex = 10;
            // 
            // buttonDone
            // 
            this.buttonDone.Location = new System.Drawing.Point(247, 156);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(105, 32);
            this.buttonDone.TabIndex = 11;
            this.buttonDone.Text = "Save";
            this.buttonDone.UseVisualStyleBackColor = true;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // FormChangeInfoAboutSong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 278);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.numericUpDownSeconds);
            this.Controls.Add(this.numericUpDownMinutes);
            this.Controls.Add(this.labelSeconds);
            this.Controls.Add(this.labelMinutes);
            this.Controls.Add(this.labelSong2);
            this.Controls.Add(this.textBoxSongName);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.comboBoxSongs);
            this.Controls.Add(this.comboBoxAlbums);
            this.Controls.Add(this.comboBoxExecutors);
            this.Controls.Add(this.labelSong1);
            this.Controls.Add(this.labelAlbum);
            this.Controls.Add(this.labelExecutor);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(561, 317);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(561, 317);
            this.Name = "FormChangeInfoAboutSong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Change info about song";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSeconds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelExecutor;
        private System.Windows.Forms.Label labelAlbum;
        private System.Windows.Forms.Label labelSong1;
        private System.Windows.Forms.ComboBox comboBoxExecutors;
        private System.Windows.Forms.ComboBox comboBoxAlbums;
        private System.Windows.Forms.ComboBox comboBoxSongs;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.TextBox textBoxSongName;
        private System.Windows.Forms.Label labelSong2;
        private System.Windows.Forms.Label labelMinutes;
        private System.Windows.Forms.Label labelSeconds;
        private System.Windows.Forms.NumericUpDown numericUpDownMinutes;
        private System.Windows.Forms.NumericUpDown numericUpDownSeconds;
        private System.Windows.Forms.Button buttonDone;
    }
}