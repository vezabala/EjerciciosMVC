// Patron entidad
// Tiene identificador

using MVC.Controllers;
using MVC.Models;
using MVC.Vistas.Estudiantes;

EstudianteController estudianteController = new EstudianteController(new CrearEstudiante());

estudianteController.Crear("1","David", Escuela.Build("1", "Calle 14 312"));