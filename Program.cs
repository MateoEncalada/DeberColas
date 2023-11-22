using System;
using System.Collections.Generic;

class ColaCorreo
{
    private Queue<string> cola = new Queue<string>();
    private int cantidadCartasPorPersona;

    public ColaCorreo(int cantidadCartas)
    {
        cantidadCartasPorPersona = cantidadCartas;
    }

    public void EntregarCartas(string[] cartas)
    {
        foreach (string carta in cartas)
        {
            if (cola.Count < cantidadCartasPorPersona)
            {
                cola.Enqueue(carta);
            }
            else
            {
                Console.WriteLine("No se recibirán más de " + cantidadCartasPorPersona + " cartas por persona.");
                break;
            }
        }
    }

    public void DespacharCartas()
    {
        while (cola.Count > 0)
        {
            string carta = cola.Dequeue();
            Console.WriteLine("Carta despachada: " + carta);
        }
    }
}

class Program
{
    static void Main()
    {
        ColaCorreo colaCorreo = new ColaCorreo(5);
        string[] cartas1 = { "Carta1", "Carta2", "Carta3", "Carta4", "Carta5", "Carta6", "Carta7" };
        colaCorreo.EntregarCartas(cartas1);

        colaCorreo.DespacharCartas();
    }
}

