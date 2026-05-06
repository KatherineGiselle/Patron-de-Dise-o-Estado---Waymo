````mermaid
classDiagram

class Form1 {
    +velocidad
    +ActualizarEstado()
    +CambiarCarril()
}

class Carro {
    -IEstadoCarro estado
    +SetEstado()
    +Manejar()
}

class IEstadoCarro {
    <<interface>>
    +Manejar(Carro, Form1)
}

Form1 --> Carro
Carro --> IEstadoCarro

IEstadoCarro <|.. EnRuta
IEstadoCarro <|.. Frenando
IEstadoCarro <|.. CambioCarril
IEstadoCarro <|.. DetectandoObstaculo
IEstadoCarro <|.. Apagado
IEstadoCarro <|.. Encendido
````
