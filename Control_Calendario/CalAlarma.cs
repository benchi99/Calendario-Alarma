using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_Calendario
{
    public partial class CalAlarma: UserControl
    {

        string formato2anios = "dd-MM-yy";
        string formato4anios = "dd-MM-yyyy";

        string docehoras = "hh:mm";
        string doscuatrohoras = "HH:mm";

        string formatoAniosAct;
        string formatoHoraAct;
        string cuerpo;

        StringBuilder strb;
        DateTime alarm;

        bool alarmaActiva;

        public CalAlarma()
        {
            InitializeComponent();
            timer1.Enabled = true;

            formatoAniosAct = formato4anios;
            formatoHoraAct = doscuatrohoras;
        }

        private void formatoFecha_CheckedChanged(object sender, EventArgs e)
        {
            if (formatoFecha.Checked)
            {
                formatoAniosAct = formato2anios;
            }
            else if (!formatoFecha.Checked)
            {
                formatoAniosAct = formato4anios;
            }

            aplicar();
        }

        private void formatoHora_CheckedChanged(object sender, EventArgs e)
        {
            if (formatoHora.Checked)
            {
                formatoHoraAct = docehoras;
            }
            else if (!formatoHora.Checked)
            {
                formatoHoraAct = doscuatrohoras;
            }
            aplicar();
        }
        
        private void aplicar()
        {
            strb = new StringBuilder();

            strb.Append(formatoAniosAct);
            strb.Append(" ");
            strb.Append(formatoHoraAct);

            datePick.CustomFormat = strb.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int anno = alarmPick.Value.Year;
            int mes = alarmPick.Value.Month;
            int dia = alarmPick.Value.Day;
            int hora = (int)horaNumAlarm.Value;
            int min = (int)minNumAlarm.Value;
            int sec = 0;
            

            alarm = new DateTime(anno, mes, dia, hora, min, sec);
            alarmaActiva = true;
            if (cuerpoAlarmaTbx.Text == null)
            {
                cuerpo = "ALARMA!";
            }
            else
            {
                cuerpo = cuerpoAlarmaTbx.Text;
            }
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime horaSis = DateTime.Now;

            if (horaSis.ToShortTimeString().Equals(alarm.ToShortTimeString()) && alarmaActiva)
            {
                alarmaActiva = false;
                timer1.Stop();
                MessageBox.Show(cuerpo);
            }
        }

        private void CalAlarma_Load(object sender, EventArgs e)
        {

        }
    }
}
