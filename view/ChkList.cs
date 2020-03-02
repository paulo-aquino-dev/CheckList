using Bunifu.Framework.UI;
using CheckList.view.utils;
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
using Message = CheckList.view.utils.Message;

namespace CheckList.view
{
    public partial class ChkList : Form
    {
        public ChkList()
        {
            InitializeComponent();
        }
        private const int WM_APPCOMMAND = 0x319;

        //MICROFONE 
        private const int APPCOMMAND_MICROPHONE_VOLUME_MUTE = 24 * 65536;
        private const int APPCOMMAND_MICROPHONE_VOLUME_DOWN = 25 * 65536;
        private const int APPCOMMAND_MICROPHONE_VOLUME_UP = 26 * 65536;

        //HEAD
        private const int APPCOMMAND_VOLUME_MUTE = 8 * 65536;
        private const int APPCOMMAND_VOLUME_DOWN = 9 * 65536;
        private const int APPCOMMAND_VOLUME_UP = 10 * 65536;

        [DllImport("user32.dll")]
        public static extern IntPtr SendMessageW(IntPtr hWnd, int Msg,
            IntPtr wParam, IntPtr lParam);

        private void ajustaAudio()
        {
            for (int i = 0; i < 30; i++)
            {
                SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle,
                (IntPtr)APPCOMMAND_VOLUME_UP);

                SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle,
                (IntPtr)APPCOMMAND_MICROPHONE_VOLUME_UP);
            }
            
        }

        private void ChkList_Load(object sender, EventArgs e)
        {
            ManagementObjectSearcher mos = new ManagementObjectSearcher("select * from Win32_SoundDevice");
            String head = "";
            foreach (ManagementObject soundDevice in mos.Get())
            {
                String sDeviceName = soundDevice.GetPropertyValue("Name").ToString();

                Console.WriteLine("Device Name = {0}", sDeviceName);
                if (sDeviceName.Equals("Dispositivo de áudio USB"))
                {
                    head = sDeviceName;
                }

            }
            if (head.Equals(""))
            {
                Msg formMsg = new Msg();
                Message.Msg = "HEADSET DESCONECTADO, FAVOR INFORMAR O SEU SUPERVISOR!";
                Message.Icone = "ERRO";
                formMsg.ShowDialog();
            }
            else
            {
                ajustaAudio();
                Msg formMsg2 = new Msg();
                Message.Msg = "AUDIO AUTOMATICAMENTE AJUSTADO!!!";
                Message.Icone = "OK";
                formMsg2.ShowDialog();
            }
        }

        string headStatus = "";
        string mouseStatus = "";
        string tecladoStatus= "";
        string monitorStatus = "";
       

        private void BtnHead_Click(object sender, EventArgs e)
        {
            string backColor = btnHead.BackColor.Name;

            var btn = btnHead;

            var lbl = lblHead;

            var cmb = cmbHead;

            if (backColor.Equals("Green"))
            {
                btn.BackColor = Color.Red;
                lbl.Text = "DANIFICADO";
                cmb.Enabled = true;
                lbl.ForeColor = Color.Red;
                headStatus = "DANIFICADO";
            }
            else
            {
                btn.BackColor = Color.Green;
                lbl.Text = "OK";
                cmb.Text = "INFORME O PROBLEMA...";
                cmb.Enabled = false;
                lbl.ForeColor = Color.Green;
                headStatus = "OK";
            }
        }

        private void BtnTeclado_Click(object sender, EventArgs e)
        {
            string backColor = btnTeclado.BackColor.Name;

            var btn = btnTeclado;

            var lbl = lblTeclado;

            var cmb = cmbTeclado;

            if (backColor.Equals("Green"))
            {
                btn.BackColor = Color.Red;
                lbl.Text = "DANIFICADO";
                cmb.Enabled = true;
                lbl.ForeColor = Color.Red;
                tecladoStatus = "DANIFICADO";
            }
            else
            {
                btn.BackColor = Color.Green;
                lbl.Text = "OK";
                cmb.Text = "INFORME O PROBLEMA...";
                cmb.Enabled = false;
                lbl.ForeColor = Color.Green;
                tecladoStatus = "OK";
            }
        }

        private void BtnMouse_Click(object sender, EventArgs e)
        {
            string backColor = btnMouse.BackColor.Name;

            var btn = btnMouse;

            var lbl = lblMouse;

            var cmb = cmbMouse;

            if (backColor.Equals("Green"))
            {
                btn.BackColor = Color.Red;
                lbl.Text = "DANIFICADO";
                cmb.Enabled = true;
                lbl.ForeColor = Color.Red;
                monitorStatus = "DANIFICADO";
            }
            else
            {
                btn.BackColor = Color.Green;
                lbl.Text = "OK";
                cmb.Text = "INFORME O PROBLEMA...";
                cmb.Enabled = false;
                lbl.ForeColor = Color.Green;
                mouseStatus = "OK";
            }
        }

        private void BtnMonitor_Click(object sender, EventArgs e)
        {
            string backColor = btnMonitor.BackColor.Name;

            var btn = btnMonitor;

            var lbl = lblMonitor;

            var cmb = cmbMonitor;

            if (backColor.Equals("Green"))
            {
                btn.BackColor = Color.Red;
                lbl.Text = "DANIFICADO";
                cmb.Enabled = true;
                lbl.ForeColor = Color.Red;
                monitorStatus = "DANIFICADO";
            }
            else
            {
                btn.BackColor = Color.Green;
                lbl.Text = "OK";
                cmb.Text = "INFORME O PROBLEMA...";
                cmb.Enabled = false;
                lbl.ForeColor = Color.Green;
                monitorStatus = "OK";
            }
        }

        private void BtnEnviar_Click(object sender, EventArgs e)
        {
            if (headStatus.Equals("") || monitorStatus.Equals("") || tecladoStatus.Equals("") || monitorStatus.Equals(""))
            {
                Msg formMsg = new Msg();
                Message.Msg = "FAVOR SELECIONAR TODOS OS CAMPOS";
                Message.Icone = "ERRO";
                formMsg.ShowDialog();
            }
            else
            {
                Msg formMsg = new Msg();
                Message.Msg = cmbHead.SelectedItem.ToString();
                Message.Icone = "OK";
                formMsg.ShowDialog();
            }
        }


    }
}
