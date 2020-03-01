using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
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
        private const int APPCOMMAND_MIC_ON_OFF_TOGGLE = 44 * 65536;

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
                 (IntPtr)APPCOMMAND_VOLUME_MUTE);
        }

        private void BtnDown_Click(object sender, EventArgs e)
        {
            SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle,
                (IntPtr)APPCOMMAND_VOLUME_DOWN);
        }

        private void BtnUp_Click(object sender, EventArgs e)
        {
            SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle,
                (IntPtr)APPCOMMAND_VOLUME_UP);
        }

        private void BtnBassUp_Click(object sender, EventArgs e)
        {
            SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle,
                 (IntPtr)APPCOMMAND_MICROPHONE_VOLUME_MUTE);
        }

        private void BtnBassDown_Click(object sender, EventArgs e)
        {
            SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle,
                (IntPtr)APPCOMMAND_MICROPHONE_VOLUME_DOWN);
        }

        private void BunifuThinButton21_Click(object sender, EventArgs e)
        {
            SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle,
                (IntPtr)APPCOMMAND_MICROPHONE_VOLUME_UP);
        }

        private void Teste_Click(object sender, EventArgs e)
        {
            SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle,
                  (IntPtr)APPCOMMAND_MIC_ON_OFF_TOGGLE);
        }

        private void Audio_Load(object sender, EventArgs e)
        {
            ManagementObjectSearcher mos = new ManagementObjectSearcher("select * from Win32_SoundDevice");
            String head = "";
            foreach (ManagementObject soundDevice in mos.Get())
            {
                String sDeviceName = soundDevice.GetPropertyValue("Name").ToString();
                
                Console.WriteLine("Device Name = {0}", sDeviceName);
                if (sDeviceName.Equals("Dispositivo de áudio USB") || sDeviceName.Equals("Realtek High Definition Audio"))
                {
                    head = sDeviceName;
                }
              
            }
            if (head.Equals(""))
            {
                Console.WriteLine("DESCONECTADO");
            }
            else
            {
                Console.WriteLine("CONECTADO");
            }
        }
    }
}
