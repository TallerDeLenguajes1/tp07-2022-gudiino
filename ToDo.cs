using System;
public class Tarea
{
    public int TareaID;
    public string Descripcion;
    public int Duracion;//10 - 100
    public Tarea(int tare, string desc, int tiemp)
    {
        TareaID = tare;
        Descripcion=desc;
        Duracion=tiemp;
    }
    public void MostrarTarea()
    {
            Console.WriteLine($"Tarea ID: {TareaID}");
            Console.WriteLine($"Descripcion: {Descripcion}");
            Console.WriteLine($"Duracion: {Duracion} minutos");
            Console.WriteLine();
    }
}

public class ListaTareas
{
    public List<Tarea> ListaT= new List<Tarea>();
    
    public void CargarLista()
    {
        Console.Write("Ingrese la cantidad de tareas a cargar: ");
        int nTarea;
        nTarea = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        Random numRan= new Random();
        int numDesc;
        string descri2="Detalles de la tarea X";
        Console.WriteLine("Ingrese los datos de la tareas.");
        Console.WriteLine();
        for (int i = 0; i < nTarea; i++)
        {
            Console.WriteLine($"Tarea ID: {i+1}");
            Console.WriteLine($"Descripcion: {descri2}");
            numDesc=numRan.Next(10,100);
            Console.WriteLine($"Duracion: {numDesc} Horas"); 
            Tarea tar= new Tarea(i+1,descri2 , numDesc);
            ListaT.Add(tar);
            Console.WriteLine();
        }
    }
    public void CargarUnaTarea(Tarea tar)
    {
        ListaT.Add(tar);
    }
    public void MostrarUnaTarea(Tarea T)
    {
        Console.WriteLine($"Tarea ID: {T.TareaID}");
        Console.WriteLine($"Descripcion: {T.Descripcion}");
        Console.WriteLine($"Duracion: {T.Duracion} minutos");
        Console.WriteLine();
    }
    public void MostrarLista()
    {
        if (ListaT.Count!=0)
        {
            foreach (var item in ListaT)
            {
                MostrarUnaTarea(item);
            }
            
        }else{
            Console.WriteLine("Lista Vacia.");
            Console.WriteLine();
        }
        
    }
    public ListaTareas ControlTarea()
    {
        Console.WriteLine("Indique si realizo la siguientes tareas");
        int opc;
        ListaTareas estado= new ListaTareas();
        foreach (var item in ListaT)
        {
            MostrarUnaTarea(item);
            Console.WriteLine("¿Se realizo la tarea?");
            Console.WriteLine("1 -> SI");
            Console.WriteLine("2 -> NO");
            Console.WriteLine("0 -> Finalizar");
            Console.Write("Seleccion: ");
            opc = Convert.ToInt32(Console.ReadLine());
            if (opc==0)
            {
                ActualizarLista(estado);
                return estado;
            }else if (opc==1)
            {
                estado.CargarUnaTarea(item);
            }
            Console.WriteLine();
        }
        ActualizarLista(estado);
        return estado;
    }
    public void ActualizarLista(ListaTareas Tar2)
    {
        foreach (var item in Tar2.ListaT)
        {
            ListaT.Remove(item);
        }
    }

}
