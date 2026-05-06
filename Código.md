## Carro
````cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaymoPatronDiseñoEstado
{
    public class Carro
    {
        private IEstadoCarro estado;
        public void SetEstado(IEstadoCarro estado)
        {
            this.estado = estado;
        }
        public void Manejar(Form1 form)
        {
            estado.Manejar(this, form);
        }
    }
}
````
## IEstadoCarro
````cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaymoPatronDiseñoEstado
{
   public interface IEstadoCarro
    {
        void Manejar(Carro carro, Form1 form);
    }
}

````


## IEstadoCarro
````cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaymoPatronDiseñoEstado
{
   public interface IEstadoCarro
    {
        void Manejar(Carro carro, Form1 form);
    }
}

````

## AceptaViaje
````cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaymoPatronDiseñoEstado
{
    public class AceptaViaje : IEstadoCarro
    {
        public void Manejar(Carro carro, Form1 form)
        {
            form.ActualizarEstado("Viaje aceptado");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaymoPatronDiseñoEstado
{
    public class AceptaViaje : IEstadoCarro
    {
        public void Manejar(Carro carro, Form1 form)
        {
            form.ActualizarEstado("Viaje aceptado");
        }
    }
}

````

## Alto
````cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaymoPatronDiseñoEstado
{
    public class Alto : IEstadoCarro
    {
        public void Manejar(Carro carro, Form1 form)
        {
            form.velocidad = 2;
            form.ActualizarEstado("Alto (detenido)");
        }
    }
}

````


## Apagado
````cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaymoPatronDiseñoEstado
{
    public class Apagado : IEstadoCarro
    {
        public void Manejar(Carro carro, Form1 form)
        {
            form.velocidad = 0;
            form.ActualizarEstado("Carro apagado");
        }
    }
}

````


## Bateria
````cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaymoPatronDiseñoEstado
{
    public class Bateria : IEstadoCarro
    {
        public void Manejar(Carro carro, Form1 form)
        {
           
            form.velocidad = 1;
            form.ActualizarEstado("Bateria baja");

        }
    }
}

````


## CambioCarril
````cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaymoPatronDiseñoEstado
{
    public class CambioCarril : IEstadoCarro
    {
        public void Manejar(Carro carro, Form1 form)
        {
            form.ActualizarEstado("Cambiando de carril");

           
 
            form.CambiarCarril();
            // Después de cambiar, vuelve a ruta
            carro.SetEstado(new EnRuta());
        }
    }
}

````


## Carro
````cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaymoPatronDiseñoEstado
{
    public class Carro
    {
        private IEstadoCarro estado;
        public void SetEstado(IEstadoCarro estado)
        {
            this.estado = estado;
        }
        public void Manejar(Form1 form)
        {
            estado.Manejar(this, form);
        }
    }
}

````

## Destino
````cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaymoPatronDiseñoEstado
{
    public class Destino : IEstadoCarro
    {
        public void Manejar(Carro carro, Form1 form)
        {
            form.velocidad = 0;
            form.ActualizarEstado("Destino alcanzado");
        }
    }
}

````

## DetectandoObstaculo
````cs
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaymoPatronDiseñoEstado
{
    public class DetectandoObstaculo : IEstadoCarro
    {
        public void Manejar(Carro carro, Form1 form)
        {
            form.velocidad = 2;
            form.ActualizarEstado("Detectando obstáculo");

            // Cambia automáticamente a frenando
            carro.SetEstado(new Frenando());
        }
    }
}

````

## Encendido
````cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaymoPatronDiseñoEstado
{
    public class Encendido : IEstadoCarro
    {
        public void Manejar(Carro carro, Form1 form)
        {
            form.ActualizarEstado("Carro encendido");
        }
    }
}

````

## EnRuta
````cs
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaymoPatronDiseñoEstado
{
    public class EnRuta : IEstadoCarro
    {
        public void Manejar(Carro carro, Form1 form)
        {
            form.velocidad = 5;
            form.ActualizarEstado("Carro en ruta");
            form.BackColor = Color.FromArgb(18, 80, 40);
        }
    }
}

````

## Frenando
````cs
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaymoPatronDiseñoEstado
{
    public class Frenando : IEstadoCarro
    {
        public void Manejar(Carro carro, Form1 form)
        {
            form.velocidad = 0;
            form.ActualizarEstado("Frenando: " + form.motivoFreno);
            form.BackColor = Color.FromArgb(120, 30, 30);
        }
    }
}

````

## Peaton
````cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaymoPatronDiseñoEstado
{
    public class Peaton : IEstadoCarro
    {
        public void Manejar(Carro carro, Form1 form)
        {
            form.velocidad = 0;
            form.ActualizarEstado("Peaton cruzando - detenido");
        }
    }
}

````

## Semaforo
````cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaymoPatronDiseñoEstado
{
    public class Semaforo : IEstadoCarro
    {
        public void Manejar(Carro carro, Form1 form)
        {
            form.velocidad = 0;
            form.ActualizarEstado("Semaforo en rojo - Detenido");
        }
    }
}

````

## Form1
````cs
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WaymoPatronDiseñoEstado
{
    public partial class Form1 : Form
    {
        private Carro carro = new Carro();
        public int velocidad = 0;
        int bateria = 100;
        int contadorBateria = 0;
        bool semaforoRojo = true;
        int contadorSemaforo = 0;
        bool peatonCruzando = false;
        bool peatonYaCruzo = false;

        int posicionFinalPeaton;
        int posicionInicialPeaton;
        int carrilOriginal;
        List<string> historialEstados = new List<string>();
        public string motivoFreno = "";
        public Form1()
        {
            InitializeComponent();

            carrilOriginal = picCarro.Top;
            // Estado inicial
            carro.SetEstado(new Apagado());
            carro.Manejar(this);

            posicionInicialPeaton = picPeaton.Top;
            posicionFinalPeaton = picPeaton.Top + 300;



            // Fondo general 
            this.BackColor = Color.FromArgb(18, 80, 40);

            // Carretera
            panelRoad.BackColor = Color.FromArgb(50, 50, 50);

            // Texto principal
            lblEstado.ForeColor = Color.White;
            lblEstado.Font = new Font("Segoe UI", 16, FontStyle.Bold);

            // Bateria
            lblBateria.ForeColor = Color.LightGreen;
            lblBateria.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            // Botones 
            btnIniciar.BackColor = Color.FromArgb(0, 120, 215);
            btnIniciar.ForeColor = Color.White;
            btnIniciar.FlatStyle = FlatStyle.Flat;

            btnReiniciar.BackColor = Color.FromArgb(80, 80, 80);
            btnReiniciar.ForeColor = Color.White;
            btnReiniciar.FlatStyle = FlatStyle.Flat;

            DibujarLineasCarril();
        }
        private void DibujarLineasCarril()
        {
            for (int i = 0; i < panelRoad.Width; i += 80)
            {
                Panel linea = new Panel();
                linea.BackColor = Color.Gold;
                linea.Width = 40;
                linea.Height = 5;
                linea.Top = panelRoad.Height / 2;
                linea.Left = i;

                panelRoad.Controls.Add(linea);
            }
        }

        public void ActualizarEstado(string mensaje)
        {
            lblEstado.Text = mensaje;
            if (historialEstados.Count == 0 || historialEstados.Last() != mensaje)
            {
                historialEstados.Add(mensaje);
            }
        }

        public void CambiarCarril()
        {
            picCarro.Top -= 15;

            // limite 
            if (picCarro.Top < carrilOriginal - 40)
            {
                picCarro.Top = carrilOriginal - 40;
            }
        }

        public void MostrarHistorial()
        {
            string historial = "Historial de estados:\n\n";

            foreach (string estado in historialEstados)
            {
                historial += "- " + estado + "\n";
            }

            MessageBox.Show(historial, "Recorrido finalizado");
        }
        private void btnEncender_Click(object sender, EventArgs e)
        {
            carro.SetEstado(new Encendido());
            carro.Manejar(this);
        }

        private void btnRuta_Click(object sender, EventArgs e)
        {
            carro.SetEstado(new EnRuta());
            carro.Manejar(this);
        }

        private void btnObstaculo_Click(object sender, EventArgs e)
        {
            carro.SetEstado(new DetectandoObstaculo());
            carro.Manejar(this);
        }

        private void btnFrenar_Click(object sender, EventArgs e)
        {
            carro.SetEstado(new Frenando());
            carro.Manejar(this);
        }

   

        private void panelCarretera_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnApagado_Click(object sender, EventArgs e)
        {
            carro.SetEstado(new Apagado());
            carro.Manejar(this);
        }

        private void lblEstado_Click(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            carro.SetEstado(new AceptaViaje());
            carro.Manejar(this);

            carro.SetEstado(new Encendido());
            carro.Manejar(this);

            carro.SetEstado(new EnRuta());
            carro.Manejar(this);

            timer1.Start();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            // Movimiento del carro
            picCarro.Left += velocidad;

            // Distancias
            int distancia = picObstaculo.Left - picCarro.Right;
            int distanciaAlto = picAlto.Left - picCarro.Right;
            int distSemaforo = picSemaforo.Left - picCarro.Right;
            int distDestino = picDestino.Left - picCarro.Right;
            int distPeaton = picPeaton.Left - picCarro.Right;

            // BATERÍA 
            contadorBateria++;

            if (contadorBateria >= 10)
            {
                bateria--;
                contadorBateria = 0;
            }

            lblBateria.Text = "Batería: " + bateria + "%";


            // SEMAFORO 
            contadorSemaforo++;

            if (contadorSemaforo >= 30)
            {
                semaforoRojo = !semaforoRojo;
                contadorSemaforo = 0;

                if (semaforoRojo)
                    picSemaforo.BackColor = Color.Red;
                else
                    picSemaforo.BackColor = Color.LimeGreen;
            }

            // PEATON CRUZANDO
            if (peatonCruzando && !peatonYaCruzo)
            {
                picPeaton.Top += 3; 

                if (picPeaton.Top >= posicionFinalPeaton)
                {
                    picPeaton.Top = posicionFinalPeaton;
                    peatonCruzando = false;
                    peatonYaCruzo = true;
                }
            }

            // DESTINO
            if (distDestino < 50 && distDestino > 0)
            {
                carro.SetEstado(new Destino());
                carro.Manejar(this);
                timer1.Stop();
                MostrarHistorial();
                return;
            }

            // BATERÍA AGOTADA
            if (bateria <= 0)
            {
                carro.SetEstado(new Frenando());
                carro.Manejar(this);

                carro.SetEstado(new Apagado());
                carro.Manejar(this);

                timer1.Stop();

                MostrarHistorial();
                return;
            }
            if (contadorBateria >= 10)
            {
                bateria--;

                if (bateria < 0)
                    bateria = 0;

                contadorBateria = 0;
            }

            // PEATÓN
            if (distPeaton < 40 && distPeaton > 0 && !peatonYaCruzo)
            {
                peatonCruzando = true;

                motivoFreno = "Peaton cruzando";
                carro.SetEstado(new Frenando());
                carro.Manejar(this);
                return;
            }

            // semaforoo
            if (distSemaforo < 100 && distSemaforo > 0)
            {
                if (semaforoRojo)
                {
                    motivoFreno = "Semaforo en rojo";
                    carro.SetEstado(new Frenando());
                }
                else
                {
                    carro.SetEstado(new EnRuta());
                }

                carro.Manejar(this);
                return;
            }

            // ALTO
            if (distanciaAlto < 100 && distanciaAlto > 0)
            {
                carro.SetEstado(new Alto());
                carro.Manejar(this);
                return;
            }

            // OBSTÁCULO LEJOS → SOLO DETECTA
            if (distancia < 120 && distancia > 60)
            {
                carro.SetEstado(new DetectandoObstaculo());
                carro.Manejar(this);
                return;
            }

            // OBSTÁCULO CERCA → CAMBIA DE CARRIL
            if (distancia <= 60 && distancia > 0)
            {
                carro.SetEstado(new CambioCarril());
                carro.Manejar(this);
                return;
            }
            // OBSTÁCULO MUY CERCA → FRENAR
            if (distancia <= 30 && distancia > 0)
            {
                motivoFreno = "Obstaculo";
                carro.SetEstado(new Frenando());
                carro.Manejar(this);
                return;
            }

            // NORMAL
            carro.SetEstado(new EnRuta());
            carro.Manejar(this);
        }

        private void picCarro_Click(object sender, EventArgs e)
        {
            picCarro.Top -= 40;
            picCarro.BackColor = Color.Transparent;

        }

        private void picObstaculo_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void ReiniciarSimulacion()
        {
            picCarro.Left = 40;
            velocidad = 0;

            carro.SetEstado(new Apagado());
            carro.Manejar(this);
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            ReiniciarSimulacion();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void lblBateria_Click(object sender, EventArgs e)
        {
            lblBateria.Text = "Batería: 100%";
        }

        private void btnPeaton_Click(object sender, EventArgs e)
        {
            carro.SetEstado(new Peaton());
            carro.Manejar(this);
        }
    }
}

````
