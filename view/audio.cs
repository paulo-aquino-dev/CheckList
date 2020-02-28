using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CheckList.view
{
    public partial class Audio : Form
    {


        private const int WM_APPCOMMAND = 0x319;

        //MICROFONE 
        private const int APPCOMMAND_MICROPHONE_VOLUME_MUTE = 24 * 65536;
        private const int APPCOMMAND_MICROPHONE_VOLUME_DOWN = 25 * 65536;
        private const int APPCOMMAND_MICROPHONE_VOLUME_UP = 26 * 65536;

        //HEAD
        private const int APPCOMMAND_VOLUME_MUTE = 8 * 65536;
        private const int APPCOMMAND_VOLUME_DOWN = 9 * 65536;
        private const int APPCOMMAND_VOLUME_UP = 10 * 65536;

        //TESTE
        private const int APPCOMMAND_MEDIA_PLAY_PAUSE = 14 * 65536;

        [DllImport("user32.dll")]
        public static extern IntPtr SendMessageW(IntPtr hWnd, int Msg, 
            IntPtr wParam, IntPtr lParam);
        public Audio()
        {
            InitializeComponent();
        }

        private void BtnMute_Click(object sender, EventArgs e)
        {
            SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle,
                 (IntPtr)APPCOMMAND_VOLUME_MUTE);//or _DOWN
        }

        private void BtnDown_Click(object sender, EventArgs e)
        {
            SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle,
                (IntPtr)APPCOMMAND_VOLUME_DOWN);//or _DOWN
        }

        private void BtnUp_Click(object sender, EventArgs e)
        {
            SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle,
                (IntPtr)APPCOMMAND_VOLUME_UP);//or _DOWN
        }

        private void BtnBassUp_Click(object sender, EventArgs e)
        {
            SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle,
                 (IntPtr)APPCOMMAND_MICROPHONE_VOLUME_MUTE);//or _DOWN
        }

        private void BtnBassDown_Click(object sender, EventArgs e)
        {
            SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle,
                (IntPtr)APPCOMMAND_MICROPHONE_VOLUME_DOWN);//or _DOWN
        }

        private void BunifuThinButton21_Click(object sender, EventArgs e)
        {
            SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle,
                (IntPtr)APPCOMMAND_MICROPHONE_VOLUME_UP);//or _DOWN
        }

        private void Teste_Click(object sender, EventArgs e)
        {
          
        }
    }
}
