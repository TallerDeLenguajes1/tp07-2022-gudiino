using System;
Console.WriteLine("Hola, mundo!");
Console.WriteLine();
ListaTareas NuevaLista = new ListaTareas();
Console.WriteLine("Cargar una lista nueva de tareas");
Console.WriteLine("................................");
Console.WriteLine();
NuevaLista.CargarLista();
Console.WriteLine("Muestra contenido de la lista de tareas nuevas");
Console.WriteLine("..............................................");
Console.WriteLine();
NuevaLista.MostrarLista();
Console.WriteLine("Control de tareas");
Console.WriteLine(".................");
Console.WriteLine();
ListaTareas TareasRealizadas = new ListaTareas();
TareasRealizadas=NuevaLista.ControlTarea();
Console.WriteLine();
Console.WriteLine("Lista de tareas pendientes");
Console.WriteLine("..........................");
Console.WriteLine();
NuevaLista.MostrarLista();
Console.WriteLine("Lista de tareas realizadas");
Console.WriteLine("..........................");
Console.WriteLine();
TareasRealizadas.MostrarLista();
Console.WriteLine();
Console.WriteLine("FIN.");

//idTareas=NuevaLista.ControlTarea();

// Console.WriteLine("Ingrese la cantidad de tareas a cargar.");
// int nTarea;
// nTarea = Convert.ToInt32(Console.ReadLine());
// //List<Tarea> ListaTareas = new List<Tarea>();
// //string descri2;
// Random numRan= new Random();
// int numDesc;
// string descri2="Aqui va la descripcion tarea X";
// Console.WriteLine("Ingrese los datos de la tarea.");
// Console.WriteLine();
// //carga de tareas
// for (int i = 0; i < nTarea; i++)
// {
//     Console.WriteLine($"Tarea ID: {i+1}");
//     //descri2 = Console.ReadLine();
//     Console.Write($"Descripcion: {descri2}");
//     Console.WriteLine();
//     numDesc=numRan.Next(10,100);
//     Console.WriteLine($"Duracion: {numDesc} Horas"); 
//     Tarea tar= new Tarea(i+1,descri2 , numDesc);
//     ListaTareas.Add(tar);
//     Console.WriteLine();
// }
// //control de tareas
// List<Tarea> TareasRealizadas = new List<Tarea>();
// Console.WriteLine("Indique si realizo la siguientes tareas");
// int opc;
// foreach (var item in ListaTareas)
// {
//     item.MostrarTarea();
//     Console.WriteLine("¿Se realizo la tarea?");
//     Console.WriteLine("1 -> SI");
//     Console.WriteLine("2 -> NO");
//     Console.Write("Seleccion: ");
//     opc = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine();
// }