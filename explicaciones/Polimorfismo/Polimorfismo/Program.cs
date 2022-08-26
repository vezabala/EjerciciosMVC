using ConsoleApp1;
using Polimorfismo;

//Persona p = new Persona("Juan", "Gomez");
//Animal a = new Animal("Perro", "Can");
//Console.WriteLine($"persona: {p.Name} {p.FirstName}");
//Console.WriteLine($"animal: {a.Name} {a.FirstName}");

//Polimorfismo (casteo):
Entidad persona = new Persona("Juan", "Gomez");
// Regla uno: Una clase abstracta no se puede instanciar
// Regla dos: solo el hijo se puede convertir en el padre
// Regla tres: no se puede llamar un metodo que no exista desde el padre
//EJEMPLO:
persona.ImprimirValores();

//persona.ImprimirApellido(); no se puede porque es una instancia de Entidad
//solucionar casteando o creando un var (no es debido) 
var persona1 = (Persona) persona;
persona1.ImprimirApellido();
