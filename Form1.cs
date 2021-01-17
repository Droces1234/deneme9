using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace medya_player_kullanımı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "C:\\Users\\Windows10\\AppData\\Local\\Microsoft\\Windows\\INetCache\\IE\\J0L7D1MO\\Gazapizm_-_Unutulacak_Dünler[1].mp3";
            pictureBox1.ImageLocation = "C:\\Users\\Windows10\\AppData\\Local\\Microsoft\\Windows\\INetCache\\IE\\0E8B9DBG\\IMG_20201231_172235_767[1].jpg";

        }
    }
}
