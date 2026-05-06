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



