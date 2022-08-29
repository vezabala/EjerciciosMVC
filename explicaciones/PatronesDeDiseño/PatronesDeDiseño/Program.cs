//Patrones de software: Requerimientos - Diseño - Desarrollo - Test
//patrones de diseño: Es una tecnica de desarrollo- uNA ESTRUCTURA REUTILIZABLE DEL SOFTWARE
// diseñar algunos componentes del softare no se aplica a todos ( un diseño detallado)

//Diseño arquitectonico va aplicado a todo el sistema

// Tiene estructura, comportamiento y Creacion el patron de diseño

/////////////////Estructurales////////////////////////
//Factori; da la estructura para la creacion de objetos

using PatronesDeDiseño.Entities;
using PatronesDeDiseño.Fabricas;

IFactory factory = new Factory();
factory.buildProfesor(1, "200000");

var estudiante = (Estudiante)factory.buildEstudiante(2); 