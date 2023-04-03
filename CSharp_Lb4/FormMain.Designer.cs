namespace CSharp_Lb4
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonShowAllList = new System.Windows.Forms.Button();
            this.buttonAddExecutor = new System.Windows.Forms.Button();
            this.buttonAddGenres = new System.Windows.Forms.Button();
            this.buttonRemoveTrack = new System.Windows.Forms.Button();
            this.buttonChangeInfoAboutTrack = new System.Windows.Forms.Button();
            this.buttonAddAlbum = new System.Windows.Forms.Button();
            this.buttonRemoveGenre = new System.Windows.Forms.Button();
            this.buttonRemoveExecutor = new System.Windows.Forms.Button();
            this.buttonRemoveAlbum = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonShowAllList
            // 
            this.buttonShowAllList.Enabled = false;
            this.buttonShowAllList.Location = new System.Drawing.Point(340, 225);
            this.buttonShowAllList.Name = "buttonShowAllList";
            this.buttonShowAllList.Size = new System.Drawing.Size(130, 62);
            this.buttonShowAllList.TabIndex = 0;
            this.buttonShowAllList.Text = "Show all list";
            this.buttonShowAllList.UseVisualStyleBackColor = true;
            this.buttonShowAllList.Click += new System.EventHandler(this.buttonShowAllList_Click);
            // 
            // buttonAddExecutor
            // 
            this.buttonAddExecutor.Location = new System.Drawing.Point(68, 89);
            this.buttonAddExecutor.Name = "buttonAddExecutor";
            this.buttonAddExecutor.Size = new System.Drawing.Size(130, 62);
            this.buttonAddExecutor.TabIndex = 1;
            this.buttonAddExecutor.Text = "Add executors";
            this.buttonAddExecutor.UseVisualStyleBackColor = true;
            this.buttonAddExecutor.Click += new System.EventHandler(this.buttonAddExecutor_Click);
            // 
            // buttonAddGenres
            // 
            this.buttonAddGenres.Location = new System.Drawing.Point(204, 89);
            this.buttonAddGenres.Name = "buttonAddGenres";
            this.buttonAddGenres.Size = new System.Drawing.Size(130, 62);
            this.buttonAddGenres.TabIndex = 2;
            this.buttonAddGenres.Text = "Add genres";
            this.buttonAddGenres.UseVisualStyleBackColor = true;
            this.buttonAddGenres.Click += new System.EventHandler(this.buttonAddGenres_Click);
            // 
            // buttonRemoveTrack
            // 
            this.buttonRemoveTrack.Enabled = false;
            this.buttonRemoveTrack.Location = new System.Drawing.Point(340, 157);
            this.buttonRemoveTrack.Name = "buttonRemoveTrack";
            this.buttonRemoveTrack.Size = new System.Drawing.Size(130, 62);
            this.buttonRemoveTrack.TabIndex = 5;
            this.buttonRemoveTrack.Text = "Remove track";
            this.buttonRemoveTrack.UseVisualStyleBackColor = true;
            this.buttonRemoveTrack.Click += new System.EventHandler(this.buttonRemoveTrack_Click);
            // 
            // buttonChangeInfoAboutTrack
            // 
            this.buttonChangeInfoAboutTrack.Enabled = false;
            this.buttonChangeInfoAboutTrack.Location = new System.Drawing.Point(204, 224);
            this.buttonChangeInfoAboutTrack.Name = "buttonChangeInfoAboutTrack";
            this.buttonChangeInfoAboutTrack.Size = new System.Drawing.Size(130, 62);
            this.buttonChangeInfoAboutTrack.TabIndex = 4;
            this.buttonChangeInfoAboutTrack.Text = "Change info about track";
            this.buttonChangeInfoAboutTrack.UseVisualStyleBackColor = true;
            this.buttonChangeInfoAboutTrack.Click += new System.EventHandler(this.buttonChangeInfoAboutTrack_Click);
            // 
            // buttonAddAlbum
            // 
            this.buttonAddAlbum.Enabled = false;
            this.buttonAddAlbum.Location = new System.Drawing.Point(340, 89);
            this.buttonAddAlbum.Name = "buttonAddAlbum";
            this.buttonAddAlbum.Size = new System.Drawing.Size(130, 62);
            this.buttonAddAlbum.TabIndex = 3;
            this.buttonAddAlbum.Text = "Add album";
            this.buttonAddAlbum.UseVisualStyleBackColor = true;
            this.buttonAddAlbum.Click += new System.EventHandler(this.buttonAddAlbum_Click);
            // 
            // buttonRemoveGenre
            // 
            this.buttonRemoveGenre.Enabled = false;
            this.buttonRemoveGenre.Location = new System.Drawing.Point(204, 157);
            this.buttonRemoveGenre.Name = "buttonRemoveGenre";
            this.buttonRemoveGenre.Size = new System.Drawing.Size(130, 62);
            this.buttonRemoveGenre.TabIndex = 8;
            this.buttonRemoveGenre.Text = "Remove genre";
            this.buttonRemoveGenre.UseVisualStyleBackColor = true;
            this.buttonRemoveGenre.Click += new System.EventHandler(this.buttonRemoveGenre_Click);
            // 
            // buttonRemoveExecutor
            // 
            this.buttonRemoveExecutor.Enabled = false;
            this.buttonRemoveExecutor.Location = new System.Drawing.Point(68, 157);
            this.buttonRemoveExecutor.Name = "buttonRemoveExecutor";
            this.buttonRemoveExecutor.Size = new System.Drawing.Size(130, 62);
            this.buttonRemoveExecutor.TabIndex = 7;
            this.buttonRemoveExecutor.Text = "Remove executor";
            this.buttonRemoveExecutor.UseVisualStyleBackColor = true;
            this.buttonRemoveExecutor.Click += new System.EventHandler(this.buttonRemoveExecutor_Click);
            // 
            // buttonRemoveAlbum
            // 
            this.buttonRemoveAlbum.Enabled = false;
            this.buttonRemoveAlbum.Location = new System.Drawing.Point(68, 224);
            this.buttonRemoveAlbum.Name = "buttonRemoveAlbum";
            this.buttonRemoveAlbum.Size = new System.Drawing.Size(130, 62);
            this.buttonRemoveAlbum.TabIndex = 6;
            this.buttonRemoveAlbum.Text = "Remove album";
            this.buttonRemoveAlbum.UseVisualStyleBackColor = true;
            this.buttonRemoveAlbum.Click += new System.EventHandler(this.buttonRemoveAlbum_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(365, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 26);
            this.label1.TabIndex = 9;
            this.label1.Text = "Audio-library";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "label2";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 368);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRemoveGenre);
            this.Controls.Add(this.buttonRemoveExecutor);
            this.Controls.Add(this.buttonRemoveAlbum);
            this.Controls.Add(this.buttonRemoveTrack);
            this.Controls.Add(this.buttonChangeInfoAboutTrack);
            this.Controls.Add(this.buttonAddAlbum);
            this.Controls.Add(this.buttonAddGenres);
            this.Controls.Add(this.buttonAddExecutor);
            this.Controls.Add(this.buttonShowAllList);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(548, 407);
            this.MinimumSize = new System.Drawing.Size(548, 407);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonShowAllList;
        private System.Windows.Forms.Button buttonAddExecutor;
        private System.Windows.Forms.Button buttonAddGenres;
        private System.Windows.Forms.Button buttonRemoveTrack;
        private System.Windows.Forms.Button buttonChangeInfoAboutTrack;
        private System.Windows.Forms.Button buttonAddAlbum;
        private System.Windows.Forms.Button buttonRemoveGenre;
        private System.Windows.Forms.Button buttonRemoveExecutor;
        private System.Windows.Forms.Button buttonRemoveAlbum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

