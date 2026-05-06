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
