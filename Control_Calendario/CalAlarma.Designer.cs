namespace Control_Calendario
{
    partial class CalAlarma
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.datePick = new System.Windows.Forms.DateTimePicker();
            this.formato = new System.Windows.Forms.GroupBox();
            this.formatoHora = new System.Windows.Forms.CheckBox();
            this.formatoFecha = new System.Windows.Forms.CheckBox();
            this.alarma = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cuerpoAlarmaTbx = new System.Windows.Forms.TextBox();
            this.minNumAlarm = new System.Windows.Forms.NumericUpDown();
            this.horaNumAlarm = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.alarmPick = new System.Windows.Forms.DateTimePicker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.formato.SuspendLayout();
            this.alarma.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minNumAlarm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horaNumAlarm)).BeginInit();
            this.SuspendLayout();
            // 
            // datePick
            // 
            this.datePick.CustomFormat = "dd-MM-yyyy HH:mm";
            this.datePick.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePick.Location = new System.Drawing.Point(9, 3);
            this.datePick.Name = "datePick";
            this.datePick.Size = new System.Drawing.Size(345, 20);
            this.datePick.TabIndex = 0;
            // 
            // formato
            // 
            this.formato.Controls.Add(this.formatoHora);
            this.formato.Controls.Add(this.formatoFecha);
            this.formato.Location = new System.Drawing.Point(3, 29);
            this.formato.Name = "formato";
            this.formato.Size = new System.Drawing.Size(357, 46);
            this.formato.TabIndex = 1;
            this.formato.TabStop = false;
            this.formato.Text = "Formato";
            // 
            // formatoHora
            // 
            this.formatoHora.AutoSize = true;
            this.formatoHora.Location = new System.Drawing.Point(223, 19);
            this.formatoHora.Name = "formatoHora";
            this.formatoHora.Size = new System.Drawing.Size(130, 17);
            this.formatoHora.TabIndex = 1;
            this.formatoHora.Text = "Cambiar de 12h a 24h";
            this.formatoHora.UseVisualStyleBackColor = true;
            this.formatoHora.CheckedChanged += new System.EventHandler(this.formatoHora_CheckedChanged);
            // 
            // formatoFecha
            // 
            this.formatoFecha.AutoSize = true;
            this.formatoFecha.Location = new System.Drawing.Point(6, 19);
            this.formatoFecha.Name = "formatoFecha";
            this.formatoFecha.Size = new System.Drawing.Size(211, 17);
            this.formatoFecha.TabIndex = 0;
            this.formatoFecha.Text = "Cambiar de año con dos cifras a cuatro";
            this.formatoFecha.UseVisualStyleBackColor = true;
            this.formatoFecha.CheckedChanged += new System.EventHandler(this.formatoFecha_CheckedChanged);
            // 
            // alarma
            // 
            this.alarma.Controls.Add(this.label2);
            this.alarma.Controls.Add(this.cuerpoAlarmaTbx);
            this.alarma.Controls.Add(this.minNumAlarm);
            this.alarma.Controls.Add(this.horaNumAlarm);
            this.alarma.Controls.Add(this.button1);
            this.alarma.Controls.Add(this.label1);
            this.alarma.Controls.Add(this.alarmPick);
            this.alarma.Location = new System.Drawing.Point(3, 81);
            this.alarma.Name = "alarma";
            this.alarma.Size = new System.Drawing.Size(357, 135);
            this.alarma.TabIndex = 2;
            this.alarma.TabStop = false;
            this.alarma.Text = "Alarma";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cuerpo de alarma (Opcional)";
            // 
            // cuerpoAlarmaTbx
            // 
            this.cuerpoAlarmaTbx.Location = new System.Drawing.Point(12, 79);
            this.cuerpoAlarmaTbx.Name = "cuerpoAlarmaTbx";
            this.cuerpoAlarmaTbx.Size = new System.Drawing.Size(339, 20);
            this.cuerpoAlarmaTbx.TabIndex = 6;
            // 
            // minNumAlarm
            // 
            this.minNumAlarm.Location = new System.Drawing.Point(267, 36);
            this.minNumAlarm.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.minNumAlarm.Name = "minNumAlarm";
            this.minNumAlarm.Size = new System.Drawing.Size(85, 20);
            this.minNumAlarm.TabIndex = 5;
            // 
            // horaNumAlarm
            // 
            this.horaNumAlarm.Location = new System.Drawing.Point(176, 36);
            this.horaNumAlarm.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.horaNumAlarm.Name = "horaNumAlarm";
            this.horaNumAlarm.Size = new System.Drawing.Size(85, 20);
            this.horaNumAlarm.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(267, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Añadir alarma";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Avísame el...";
            // 
            // alarmPick
            // 
            this.alarmPick.CustomFormat = "dd-MM-yyyy";
            this.alarmPick.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.alarmPick.Location = new System.Drawing.Point(12, 36);
            this.alarmPick.Name = "alarmPick";
            this.alarmPick.Size = new System.Drawing.Size(158, 20);
            this.alarmPick.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CalAlarma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.alarma);
            this.Controls.Add(this.formato);
            this.Controls.Add(this.datePick);
            this.Name = "CalAlarma";
            this.Size = new System.Drawing.Size(365, 220);
            this.Load += new System.EventHandler(this.CalAlarma_Load);
            this.formato.ResumeLayout(false);
            this.formato.PerformLayout();
            this.alarma.ResumeLayout(false);
            this.alarma.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minNumAlarm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horaNumAlarm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker datePick;
        private System.Windows.Forms.GroupBox formato;
        private System.Windows.Forms.CheckBox formatoHora;
        private System.Windows.Forms.CheckBox formatoFecha;
        private System.Windows.Forms.GroupBox alarma;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker alarmPick;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NumericUpDown horaNumAlarm;
        private System.Windows.Forms.NumericUpDown minNumAlarm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cuerpoAlarmaTbx;
    }
}
