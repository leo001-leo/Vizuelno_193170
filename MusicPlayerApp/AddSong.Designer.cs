namespace MusicPlayerApp
{
    partial class AddSong
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
            this.listBoxSongs = new System.Windows.Forms.ListBox();
            this.btnAddSong = new System.Windows.Forms.Button();
            this.btnRemoveSong = new System.Windows.Forms.Button();
            this.btnPustiPesna = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxSongs
            // 
            this.listBoxSongs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxSongs.FormattingEnabled = true;
            this.listBoxSongs.ItemHeight = 20;
            this.listBoxSongs.Location = new System.Drawing.Point(106, 12);
            this.listBoxSongs.Name = "listBoxSongs";
            this.listBoxSongs.Size = new System.Drawing.Size(322, 324);
            this.listBoxSongs.TabIndex = 2;
            this.listBoxSongs.SelectedIndexChanged += new System.EventHandler(this.listBoxSongs_SelectedIndexChanged);
            // 
            // btnAddSong
            // 
            this.btnAddSong.BackColor = System.Drawing.Color.Khaki;
            this.btnAddSong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddSong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSong.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSong.ForeColor = System.Drawing.Color.Black;
            this.btnAddSong.Location = new System.Drawing.Point(106, 370);
            this.btnAddSong.Name = "btnAddSong";
            this.btnAddSong.Size = new System.Drawing.Size(322, 58);
            this.btnAddSong.TabIndex = 3;
            this.btnAddSong.Text = "Додади песни";
            this.btnAddSong.UseVisualStyleBackColor = false;
            this.btnAddSong.Click += new System.EventHandler(this.btnAddSong_Click);
            // 
            // btnRemoveSong
            // 
            this.btnRemoveSong.BackColor = System.Drawing.Color.Firebrick;
            this.btnRemoveSong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveSong.Enabled = false;
            this.btnRemoveSong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveSong.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveSong.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRemoveSong.Location = new System.Drawing.Point(475, 193);
            this.btnRemoveSong.Name = "btnRemoveSong";
            this.btnRemoveSong.Size = new System.Drawing.Size(228, 58);
            this.btnRemoveSong.TabIndex = 4;
            this.btnRemoveSong.Text = "Избриши песна";
            this.btnRemoveSong.UseVisualStyleBackColor = false;
            this.btnRemoveSong.Click += new System.EventHandler(this.btnRemoveSong_Click);
            // 
            // btnPustiPesna
            // 
            this.btnPustiPesna.BackColor = System.Drawing.Color.ForestGreen;
            this.btnPustiPesna.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPustiPesna.Enabled = false;
            this.btnPustiPesna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPustiPesna.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPustiPesna.ForeColor = System.Drawing.Color.White;
            this.btnPustiPesna.Location = new System.Drawing.Point(475, 105);
            this.btnPustiPesna.Name = "btnPustiPesna";
            this.btnPustiPesna.Size = new System.Drawing.Size(228, 58);
            this.btnPustiPesna.TabIndex = 5;
            this.btnPustiPesna.Text = "Пушти песна";
            this.btnPustiPesna.UseVisualStyleBackColor = false;
            this.btnPustiPesna.Click += new System.EventHandler(this.btnPustiPesna_Click);
            // 
            // AddSong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPustiPesna);
            this.Controls.Add(this.btnRemoveSong);
            this.Controls.Add(this.btnAddSong);
            this.Controls.Add(this.listBoxSongs);
            this.Name = "AddSong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Додади песна";
            //this.ResumeLayout(true);

        }

        #endregion
        private System.Windows.Forms.Button btnAddSong;
        private System.Windows.Forms.Button btnRemoveSong;
        private System.Windows.Forms.Button btnPustiPesna;
        public System.Windows.Forms.ListBox listBoxSongs;
    }
}