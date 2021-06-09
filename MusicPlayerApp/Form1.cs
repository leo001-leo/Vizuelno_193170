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
    public partial class Form1 : Form
    {
        //public AddSong song;
       // public String[] songs;
        public String[] paths, names;
        public Form1()
        {
            InitializeComponent();
            
        }
        
        
        

        private void btnSelectSongs_Click(object sender, EventArgs e)
        {
            
            /*AddSong add = new AddSong();
            add.Show();*/
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                names = ofd.SafeFileNames; // iminja na pesnite
                paths = ofd.FileNames;     // pateki na pesnite
                // prikaz na pesni vo listbox
                for (int i = 0; i < names.Length; i++)
                {
                    listBox1.Items.Add(names[i]);
                }
            }
        }

        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayerMusic.Ctlcontrols.pause();
        }
        public void pust(string urll)
        {
            axWindowsMediaPlayerMusic.URL = urll;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex!=-1)
            {
                btnPustiPesna.Enabled = true;
                btnRemoveSong.Enabled = true;
            }
            else
            {
                btnPustiPesna.Enabled = false;
                btnRemoveSong.Enabled = false;
            }
        }

        private void btnPustiPesna_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                axWindowsMediaPlayerMusic.URL = paths[listBox1.SelectedIndex];
            }
        }

        private void btnRemoveSong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Дали сакате да ја избришете песната?", "Бришење песна", MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                if (listBox1.SelectedIndex != -1)
                {
                    listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                    //proverka();
                }
            }
        }

    }

}
