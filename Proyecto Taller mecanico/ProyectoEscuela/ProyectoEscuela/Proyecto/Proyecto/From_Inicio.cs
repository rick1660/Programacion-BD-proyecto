using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class From_Inicio : Form
    {
        public From_Inicio()
        {
            InitializeComponent();
        }

        DateTime Actual;
        string mes, apm, minuto, segundo;

        private void From_Inicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();
        }

        int hora, DiasRes;

        //Timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            Actual = DateTime.Now;
            hora = Actual.Hour;

            //Condición para la hora
            if (hora > 12)
            {
                hora = hora - 12;
                apm = "pm";
            }
            else
                apm = "am";

            //Condición para el minuto
            if (Actual.Minute < 10)
            {
                minuto = "0" + Actual.Minute.ToString();
            }
            else
                minuto = Actual.Minute.ToString();

            //Condición para el segundo
            if (Actual.Second < 10)
            {
                segundo = "0" + Actual.Second.ToString();
            }
            else
                segundo = Actual.Second.ToString();

            //Condicion para el mes
            switch (Actual.Month)
            {
                case 1:
                    mes = "Enero";
                    break;
                case 2:
                    mes = "Febrero";
                    break;
                case 3:
                    mes = "Marzo";
                    break;
                case 4:
                    mes = "Abril";
                    break;
                case 5:
                    mes = "Mayo";
                    break;
                case 6:
                    mes = "Junio";
                    break;
                case 7:
                    mes = "Julio";
                    break;
                case 8:
                    mes = "Agosto";
                    break;
                case 9:
                    mes = "Septiembre";
                    break;
                case 10:
                    mes = "Octubre";
                    break;
                case 11:
                    mes = "Noviembre";
                    break;
                case 12:
                    mes = "Diciembre";
                    break;
            }

            /*Condición para el ciclo y días restantes
            if (Actual.Month >= 8 && Actual.Month <= 12)
            {
                if (Actual.Year % 4 == 0)
                {
                    if (Actual.DayOfYear <= 342)
                    {
                        DiasRes = 342 - Actual.DayOfYear;
                        lblFin.Text = DiasRes + " días para finalizar el ciclo escolar.";
                    }
                    else
                        lblFin.Text = "Ciclo escolar finalizado.";
                }

                else
                {
                    if (Actual.DayOfYear <= 341)
                    {
                        DiasRes = 341 - Actual.DayOfYear;
                        lblFin.Text = DiasRes + " días para finalizar el ciclo escolar.";
                    }
                    else
                        lblFin.Text = "";
                }

                lblCiclo.Text = "Ciclo escolar Agosto-Diciembre";
            }
            else if (Actual.Month == 7)
            {
                lblCiclo.Text = "Periodo vacacional";
                lblFin.Text = "";
            }
            else
            {
                if (Actual.Year % 4 == 0)
                {
                    if (Actual.DayOfYear <= 153)
                    {
                        DiasRes = 153 - Actual.DayOfYear;
                        lblFin.Text = DiasRes + " días para finalizar el ciclo escolar.";
                    }
                    else
                        lblFin.Text = "Ciclo escolar finalizado.";
                }

                else
                {
                    if (Actual.DayOfYear <= 152)
                    {
                        DiasRes = 152 - Actual.DayOfYear;
                        lblFin.Text = DiasRes + " días para finalizar el ciclo escolar.";
                    }
                    else
                        lblFin.Text = "";
                }
            }

    */
            //Salida de la fecha
            lblfecha.Text = Actual.Day + " de " + mes + " del " + Actual.Year + " a las " + hora + ":" + minuto + ":" + segundo + " " + apm;
        }

       
        
    }
}
