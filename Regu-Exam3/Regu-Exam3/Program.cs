using System;
using System.Collections.Generic;
using System.Collections;

namespace ReguExam3
{
    public class Operaciones
    {
        public ArrayList lista = new ArrayList();
        public ArrayList newList = new ArrayList();
        public Queue cola = new Queue();
        public Stack pila = new Stack();
        
   
        public void Clone()
        {
            lista.Add(2);
            lista.Add(3);
            lista.Add(4);
            lista.Add(7.5);
            lista.Add(4);
            lista.Add("H");
            lista.Add("U");
            lista.Add("J");
            lista.Add(67);
            lista.Add(23);
            lista.Add(9);
            lista.Add(80);

            ArrayList nuevaList = (ArrayList)lista.Clone();
            Console.WriteLine("Imprimiendo desde la nueva lista generada\n");
            foreach (var item in nuevaList)
            {
                Console.WriteLine(item);
            }

        }
        public Queue FillQueue()
        {
            cola.Enqueue(5);
            cola.Enqueue(3);
            cola.Dequeue();
            cola.Enqueue(2);
            cola.Enqueue(8);
            cola.Dequeue();
            cola.Dequeue();
            cola.Enqueue(9);
            cola.Enqueue(1);
            cola.Dequeue();
            cola.Enqueue(7);
            cola.Enqueue(6);
            cola.Dequeue();
            cola.Dequeue();
            cola.Enqueue(4);
            cola.Dequeue();
            cola.Dequeue();
            return cola;
        }

        public void FillStack()
        {
            pila.Push(2);
            pila.Push(3);
            pila.Push(6);
            pila.Push(4);
            pila.Push(7);
            pila.Push("j");
            pila.Push(2);
            pila.Push(0.1);
            pila.Push("Tec");
            pila.Push(23);
            pila.Push(65);

            Console.WriteLine("El tamaño de la pila: " + pila.Count);
            Recursivo(pila);
            Console.WriteLine("After recursive function: " + pila.Count);
           
        }
        public void Recursivo(Stack pila)
        {

            if (pila.Count != 0)
            {
                pila.Pop();
                Recursivo(pila);
            }

           
        }
        public void Print()
        {
            FillQueue();
            foreach (var item in cola)
            {
                Console.WriteLine(item);
            }
             
        }

    }
    class MainClass
    {
        public static void Main(string[] args)
        {
            Operaciones op = new Operaciones();
            op.Print();
            op.FillStack();
            op.Clone();
        }
    }
}
