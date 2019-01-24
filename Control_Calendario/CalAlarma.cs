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
        private string fFecha = "dd-MM-yyyy HH:mm";

        string cuerpo;

        DateTime alarm;

        bool alarmaActiva;

        public CalAlarma()
        {
            InitializeComponent();
            timer1.Enabled = true;

        }

        [
        Category("Behaviour"),
        DisplayName("Formato de hora"),
        Description("El formato en el que se mostrará la hora, siendo las posibles 'dd-MM-yyyy HH:mm', 'dd-MM-yyyy hh:mm', 'dd-MM-yy HH:mm' ó , 'dd-MM-yy hh:mm'")
        ]
        public string FormatoHora
        {
            get
            {
                return fFecha;
            }
            set
            {
                fFecha = value;
                if (fFecha.Equals("dd-MM-yyyy HH:mm") || fFecha.Equals("dd-MM-yyyy hh:mm") || fFecha.Equals("dd-MM-yy hh:mm") || fFecha.Equals("dd-MM-yy HH:mm"))
                {
                    datePick.CustomFormat = fFecha;
                    alarmPick.CustomFormat = fFecha;
                } else
                {
                    fFecha = "dd-MM-yyyy HH:mm";
                }
                
                Invalidate();
            }
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
    }
}
