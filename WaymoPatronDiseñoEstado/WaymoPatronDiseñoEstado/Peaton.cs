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
