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
