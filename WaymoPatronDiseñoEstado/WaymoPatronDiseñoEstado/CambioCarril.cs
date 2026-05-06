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
