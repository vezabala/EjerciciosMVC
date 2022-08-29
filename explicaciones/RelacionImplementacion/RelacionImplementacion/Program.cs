// using RelacionImplementacion;

// IEstudiante estudiante = new Trabajador();
//estudiante.AsistirClases();

using RelacionImplementacion.Ejemplo;
using RelacionImplementacion.Ejemplo.Computadores;
using RelacionImplementacion.Ejemplo.Perifericos;

//Crear Perifericos
IPeriferico periferico = new Teclado();
IPeriferico periferico1 = new TarjetaExterna();

Computadora computadora = new Computadora(periferico, periferico1);