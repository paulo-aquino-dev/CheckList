using CheckList.config;
using CheckList.view.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Message = CheckList.view.utils.Message;

namespace CheckList.view
{
    public partial class apiGLPI : Form
    {
        public apiGLPI()
        {
            InitializeComponent();
        }

        private void ApiGLPI_Load(object sender, EventArgs e)
        {
            try
            {
                //CONEXAO BD GLPI
                ConexaoGLPI.objCnx.ConnectionString = ConexaoGLPI.conexao;
                //ABRE A CONEXAO COM O BANCO
                ConexaoGLPI.objCnx.Open();
            }
            catch (Exception Erro)
            {
                Msg formMsg2 = new Msg();
                Message.Msg = "ERRO: " + Erro.Message;
                Message.Icone = "ERRO";
                formMsg2.ShowDialog();
            }

            if (ConexaoGLPI.objCnx.State.Equals(ConnectionState.Open))
            {
                Msg formMsg2 = new Msg();
                Message.Msg = "CONEXÃO ABERTA";
                Message.Icone = "OK";
                formMsg2.ShowDialog();

                try
                {
                    string strSql = "INSERT INTO glpi_tickets (id, entities_id, name, date, date_mod, users_id_lastupdater, status, users_id_recipient, requesttypes_id, content, urgency, impact, priority, itilcategories_id, type, solutiontypes_id, global_validation, slas_ttr_id, slas_tto_id, ttr_slalevels_id, sla_waiting_duration, ola_waiting_duration, olas_tto_id, olas_ttr_id, ttr_olalevels_id, waiting_duration, close_delay_stat, solve_delay_stat, takeintoaccount_delay_stat, actiontime, is_deleted, locations_id, validation_percent, date_creation)"
                                  + "VALUES(null, '0', 'TESTE EDUARDO', now(), now(), '75', '1', '75', '1', 'teste', '3', '3', '3', '5', '2', '0', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '1', '0', now());";

                    //conexão com o comando
                    ConexaoGLPI.objCmd.Connection = ConexaoGLPI.objCnx;
                    //Atribui o comando
                    ConexaoGLPI.objCmd.CommandText = strSql;

                    ConexaoGLPI.objCmd.ExecuteNonQuery();

                    
                    Message.Msg = "DADOS CADASTRADOS";
                    Message.Icone = "OK";
                    formMsg2.ShowDialog();
                }
                catch (Exception Erro)
                {
                    Message.Msg = "ERRO: " + Erro.Message;
                    Message.Icone = "ERRO";
                    formMsg2.ShowDialog();
                }

            }
            
        }

    }
}
