using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace semaforo
{
    public partial class Form1 : Form
    {
      
        private Timer timerParpadeo = new Timer();
        private int contadorParpadeos = 0;
        private Timer timerFijo = new Timer();


        public Form1()
        {
            InitializeComponent();
            timerFijo.Interval = 5000;
            timerFijo.Tick += TimerFijo_Tick;
           
            timerParpadeo.Interval = 500; // Intervalo para el parpadeo (500ms)
            timerParpadeo.Tick += TimerParpadeo_Tick;
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //timer1.Start();
            rojo.Visible = true;
            timerFijo.Start();
        }

        private void TimerFijo_Tick(object sender, EventArgs e)
        {
            timerFijo.Stop(); // Detiene el timer fijo
           // Comienza el parpadeo
            timerParpadeo.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timerParpadeo.Stop();
            timer1.Stop();
            
            Task.Delay(1000).ContinueWith(t =>
            {
                timerFijo.Start();
                // Continuar con el siguiente estado del semáforo
            }, TaskScheduler.FromCurrentSynchronizationContext());
        
            
        }

        private void TimerParpadeo_Tick(object sender, EventArgs e)
        {
            verde.Visible = !verde.Visible; // Parpadea el semáforo en rojo
            verdep.Visible = !verdep.Visible;
            contadorParpadeos++;
            rojop.Visible = true;

            if (contadorParpadeos >= 6) // Después de 3 parpadeos (6 cambios de visibilidad)
            {
                rojo.Visible = false; 
                timerParpadeo.Stop();
                verde.Visible = true;
                verdep.Visible = false;
                timer2.Start(); // Continuar con el siguiente estado del semáforo
                contadorParpadeos = 0; // Restablecer el contador para el próximo ciclo
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
           
            rojo.Visible = true;
            amarillo.Visible = false;
            rojop.Visible = false;
            verdep.Visible = true;
            timer3.Start();
            timer2.Stop();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            amarillo.Visible = true;
            verde.Visible = false;
            rojop.Visible = false;
            timer1.Start();
            verdep.Visible = true; 
            timer3.Stop();
        }
    }
}

