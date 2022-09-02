//Para resolver problemas computacionales de forma generico
//beneficio: se puede reutilizar codigo

using ParadigmaGenerico;
using ParadigmaGenerico.Educativos;
using ParadigmaGenerico.Entity;

//Matriculamos trabajador
IEscuela<Trabajador> escuela = new Escuela<Trabajador>();
escuela.Matricular(new Trabajador());

//Matriculamos estudiantes
IEscuela<Estudiante> universidad = new Universidad<Estudiante>();
universidad.Matricular(new Estudiante());