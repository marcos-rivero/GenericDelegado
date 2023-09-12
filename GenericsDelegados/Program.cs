// See https://aka.ms/new-console-template for more information
using GenericsDelegados;

Console.WriteLine("Hello, World!");
var persona = new Persona("Juan", "Perez");
var resultadoPersona = new ResultadoOperacion<Persona>();
resultadoPersona.AsigneExitoso(persona);
resultadoPersona.AgregarMensaje("La persona fue agregada con exito");
resultadoPersona.AgregarMensaje("La persona fue actualizada");
foreach(var resultado in resultadoPersona.ListaDeMensaje){
    Console.WriteLine(resultado);
}

var vehiculo = new Vehiculo("Peugeot", "408");
var resultadoVehiculo = new ResultadoOperacion<Vehiculo>();
resultadoVehiculo.AsigneExitoso(vehiculo);
resultadoVehiculo.AgregarMensaje("El vehiculo fue agregada con exito");
resultadoVehiculo.AgregarMensaje("El vehiculo fue actualizada");
foreach (var resultadoVeh in resultadoVehiculo.ListaDeMensaje)
{
    Console.WriteLine(resultadoVeh);
}

var delegado = new EjemploDelegado();
delegado.DelegadoEjemplo();
delegado.EjemploAction();
delegado.EjemploFunc();
delegado.EjemploPredicate();

var nuevoDelegado = new ClaseDePrueba();
nuevoDelegado.ClaseParaProbarDelegado(delegado.ImprimirEnPantalla);
