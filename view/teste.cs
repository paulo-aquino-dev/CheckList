﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckList.view
{
    public partial class teste : Form
    {
        public teste()
        {
            InitializeComponent();
        }

        private void Teste_Load(object sender, EventArgs e)
        {
            ManagementObjectSearcher mos = new ManagementObjectSearcher("select * from Win32_Process");

            foreach (ManagementObject process in mos.Get())
            {
                String nome = process.GetPropertyValue("Name").ToString();
                String exec = process.GetPropertyValue("ExecutablePath").ToString();

                Console.WriteLine("NOME PROCESSO = {0} - exec = {1}", nome, exec);
            }
        }
    }
}