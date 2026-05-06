````mermaid
classDiagram

class Carro {
    -IEstadoCarro estado
    +SetEstado(IEstadoCarro estado)
    +Manejar(Form1 form)
}

class IEstadoCarro {
    <<interface>>
    +Manejar(Carro carro, Form1 form)
}

class Apagado
class Encendido
class EnRuta
class DetectandoObstaculo
class CambioCarril
class Frenando
class Bateria
class Destino
class Alto
class Emergencia
class Peaton
class Semaforo

IEstadoCarro <|.. Apagado
IEstadoCarro <|.. Encendido
IEstadoCarro <|.. EnRuta
IEstadoCarro <|.. DetectandoObstaculo
IEstadoCarro <|.. CambioCarril
IEstadoCarro <|.. Frenando
IEstadoCarro <|.. Bateria
IEstadoCarro <|.. Destino
IEstadoCarro <|.. Alto
IEstadoCarro <|.. Emergencia
IEstadoCarro <|.. Peaton
IEstadoCarro <|.. Semaforo

Carro --> IEstadoCarro : usa
````
