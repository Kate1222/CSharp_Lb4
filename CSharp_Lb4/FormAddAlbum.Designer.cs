namespace CSharp_Lb4
{
    partial class FormAddAlbum
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAlbumName = new System.Windows.Forms.TextBox();
            this.numericUpDownYear = new System.Windows.Forms.NumericUpDown();
            this.comboBoxExecutors = new System.Windows.Forms.ComboBox();
            this.buttonDone = new System.Windows.Forms.Button();
            this.groupBoxGenres = new System.Windows.Forms.GroupBox();
            this.panelGenres = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear)).BeginInit();
            this.groupBoxGenres.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Executor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Album name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 121);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Released";
            // 
            // textBoxAlbumName
            // 
            this.textBoxAlbumName.Location = new System.Drawing.Point(168, 87);
            this.textBoxAlbumName.Name = "textBoxAlbumName";
            this.textBoxAlbumName.Size = new System.Drawing.Size(183, 26);
            this.textBoxAlbumName.TabIndex = 2;
            // 
            // numericUpDownYear
            // 
            this.numericUpDownYear.Location = new System.Drawing.Point(168, 119);
            this.numericUpDownYear.Maximum = new decimal(new int[] {
            2023,
            0,
            0,
            0});
            this.numericUpDownYear.Minimum = new decimal(new int[] {
            1700,
            0,
            0,
            0});
            this.numericUpDownYear.Name = "numericUpDownYear";
            this.numericUpDownYear.Size = new System.Drawing.Size(183, 26);
            this.numericUpDownYear.TabIndex = 3;
            this.numericUpDownYear.Value = new decimal(new int[] {
            1700,
            0,
            0,
            0});
            // 
            // comboBoxExecutors
            // 
            this.comboBoxExecutors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxExecutors.FormattingEnabled = true;
            this.comboBoxExecutors.Location = new System.Drawing.Point(168, 54);
            this.comboBoxExecutors.Name = "comboBoxExecutors";
            this.comboBoxExecutors.Size = new System.Drawing.Size(183, 27);
            this.comboBoxExecutors.TabIndex = 1;
            // 
            // buttonDone
            // 
            this.buttonDone.Location = new System.Drawing.Point(197, 349);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(126, 54);
            this.buttonDone.TabIndex = 5;
            this.buttonDone.Text = "Add songs to album";
            this.buttonDone.UseVisualStyleBackColor = true;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // groupBoxGenres
            // 
            this.groupBoxGenres.Controls.Add(this.panelGenres);
            this.groupBoxGenres.Location = new System.Drawing.Point(168, 151);
            this.groupBoxGenres.Name = "groupBoxGenres";
            this.groupBoxGenres.Size = new System.Drawing.Size(183, 192);
            this.groupBoxGenres.TabIndex = 4;
            this.groupBoxGenres.TabStop = false;
            this.groupBoxGenres.Text = "Genres";
            // 
            // panelGenres
            // 
            this.panelGenres.AutoScroll = true;
            this.panelGenres.Location = new System.Drawing.Point(6, 21);
            this.panelGenres.Name = "panelGenres";
            this.panelGenres.Size = new System.Drawing.Size(171, 165);
            this.panelGenres.TabIndex = 0;
            // 
            // FormAddAlbum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 462);
            this.Controls.Add(this.groupBoxGenres);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.comboBoxExecutors);
            this.Controls.Add(this.numericUpDownYear);
            this.Controls.Add(this.textBoxAlbumName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(504, 501);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(504, 501);
            this.Name = "FormAddAlbum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add album";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear)).EndInit();
            this.groupBoxGenres.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxAlbumName;
        private System.Windows.Forms.NumericUpDown numericUpDownYear;
        private System.Windows.Forms.ComboBox comboBoxExecutors;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.GroupBox groupBoxGenres;
        private System.Windows.Forms.Panel panelGenres;
    }
}