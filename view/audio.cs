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

        private const int APPCOMMAND_VOLUME_MUTE = 0x80000;
        private const int WM_APPCOMMAND = 0x319;
        private const int APPCOMMAND_MICROPHONE_VOLUME_UP = 26 * 65536;
        private const int APPCOMMAND_MICROPHONE_VOLUME_DOWN = 25 * 65536;
        private const int APPCOMMAND_MIC_ON_OFF_TOGGLE = 44 * 65536;
        private const int APPCOMMAND_BASS_BOOST = 44 * 65536;

        [DllImport("user32.dll")]
        public static extern IntPtr SendMessageW(IntPtr hWnd, int Msg, 
            IntPtr wParam, IntPtr lParam);
        public Audio()
        {
            InitializeComponent();
        }

        private void BtnMute_Click(object sender, EventArgs e)
        {
            //SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle,
            //    (IntPtr)APPCOMMAND_VOLUME_MUTE);
        }

        private void BtnDown_Click(object sender, EventArgs e)
        {

        }

        private void BtnUp_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnBassUp_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnBassDown_Click(object sender, EventArgs e)
        {
            SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle,
                 (IntPtr)APPCOMMAND_BASS_BOOST);//or _DOWN
        }
    }
}
