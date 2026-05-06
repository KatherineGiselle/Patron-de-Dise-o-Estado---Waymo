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
