using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayerApp
{
    public partial class AddSong : Form
    {
        public Form1 form;
        public AddSong()
        {
            InitializeComponent();
            form = new Form1();
            
        }

        public String[] paths, names;
        

        private void btnAddSong_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                names = ofd.SafeFileNames; // iminja na pesnite
                paths = ofd.FileNames;     // pateki na pesnite
                // prikaz na pesni vo listbox
                for (int i = 0; i < names.Length; i++)
                {
                    listBoxSongs.Items.Add(names[i]);
                }
            }
        }

        private void btnRemoveSong_Click(object sender, EventArgs e)
        {
                if (listBoxSongs.SelectedIndex != -1)
                {
                        listBoxSongs.Items.RemoveAt(listBoxSongs.SelectedIndex);
                        proverka();
                }
        }

        private void listBoxSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            //form.axWindowsMediaPlayerMusic.URL = paths[listBoxSongs.SelectedIndex];
            btnPustiPesna.Enabled = true;
            btnRemoveSong.Enabled = true;
            
        }

        private void btnPustiPesna_Click(object sender, EventArgs e)
        {
            
            form.axWindowsMediaPlayerMusic.URL = paths[listBoxSongs.SelectedIndex];
            // form.listBox1.Text = form.axWindowsMediaPlayerMusic.URL;
            //form.axWindowsMediaPlayerMusic.Ctlcontrols.play();
            //form.pust(paths[listBoxSongs.SelectedIndex]);
            this.Close();
        }

        public void proverka()
        {
            if(listBoxSongs.Items.Count==0)
            {
                btnRemoveSong.Enabled = false;
                btnPustiPesna.Enabled = false;
            }
            else
            {
                btnRemoveSong.Enabled = true;
                btnPustiPesna.Enabled = true;
            }
        }
        
    }
}
