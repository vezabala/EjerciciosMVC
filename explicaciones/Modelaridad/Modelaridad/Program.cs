using Modelaridad.Entities;

//polimorfismo y casteo (atributos)
Entity vehiculoElectrico = new VehiculoElectrico(id: "1", placa: "hga223", horasCarga: 50.1);
var vel = (VehiculoElectrico)vehiculoElectrico;
Console.WriteLine(vel.HorasCarga);

//polimorfismo y casteo (metodos)
Entity ve = new VehiculoGasolina(id: "2", placa: "hga223");
var veh = (VehiculoGasolina)ve;
veh.ImprimirValores();