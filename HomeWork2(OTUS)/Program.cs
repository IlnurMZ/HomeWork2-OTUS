using System;
using System.Text;
using System.Collections;
using System.Diagnostics;

namespace HomeWork2_OTUS_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            ArrayList arrayList = new ArrayList();
            LinkedList<int> linkedList = new LinkedList<int>();

            Stopwatch timerList = new Stopwatch();
            Stopwatch timerArrayList = new Stopwatch();
            Stopwatch timerLinkedList = new Stopwatch();

            timerList.Start();
            FillList(list);  
            timerList.Stop();

            timerArrayList.Start();
            FillArrayList(arrayList);
            timerArrayList.Stop();

            timerLinkedList.Start();
            FillLinkedList(linkedList);
            timerLinkedList.Stop();
            
            Console.WriteLine($"Время заполнения List в мс:  {timerList.ElapsedMilliseconds} \n" +
                $"Время заполнения ArrayList в мс:  {timerArrayList.ElapsedMilliseconds} \n" +
                $"Время заполнения LinkedList в мс:  {timerLinkedList.ElapsedMilliseconds} \n");

            timerList.Restart();
            FindAndShowElementList(list);
            timerList.Stop();           

            timerArrayList.Restart();
            FindAndShowElementArrayList(arrayList);
            timerArrayList.Stop();            

            timerLinkedList.Restart();
            FindAndShowElementLinkedList(linkedList);
            timerLinkedList.Stop();            

            Console.WriteLine($"Время поиска и вывода элемента 496753 в List  в мс: {timerList.ElapsedMilliseconds} \n" +
                $"Время поиска и вывода элемента 496753 в ArrayList в мс: {timerArrayList.ElapsedMilliseconds} \n" +
                $"Время поиска и вывода элемента 496753 в LinkedList в мс: {timerLinkedList.ElapsedMilliseconds} \n");            

            timerList.Restart();
            Division777List(list);
            timerList.Stop();

            timerArrayList.Restart();
            Division777ArrayList(arrayList);
            timerArrayList.Stop();

            timerLinkedList.Restart();
            Division777LinkedList(linkedList);
            timerLinkedList.Stop();

            Console.WriteLine($"Время поиска деления без остатка на 777 в List в мс: {timerList.ElapsedMilliseconds} \n" +
                $"Время поиска деления без остатка на 777 в ArrayList в мс: {timerArrayList.ElapsedMilliseconds} \n" +
                $"Время поиска деления без остатка на 777 в LinkedList в мс: {timerLinkedList.ElapsedMilliseconds} \n");

            Console.ReadLine();
        }
        // Заполнение списка элементами
        static void FillList(List<int> list)
        {
            for (int i = 1; i <= 1_000_000; i++)
            {
                list.Add(i);
            }
        }

        static void FillArrayList(ArrayList arrayList)
        {
            for (int i = 1; i <= 1_000_000; i++)
            {
                arrayList.Add(i);
            }
        }

        static void FillLinkedList(LinkedList<int> linkedList)
        {
            for (int i = 1; i <= 1_000_000; i++)
            {
                linkedList.AddLast(i);
            }
        }

        // Поиск элемента 496753
        static void FindAndShowElementList(List<int> list)
        {
            int indexList = list.FindIndex(x => x == 496753);
            if (indexList != -1)                            
                Console.WriteLine($"Элемент List: {list[indexList]}. ");
            else            
                Console.WriteLine("Элемент не найден");            
        }

        static void FindAndShowElementArrayList(ArrayList arrayList)
        {
            int indexArrayList = arrayList.IndexOf(496753);
            if (indexArrayList != -1)            
                Console.WriteLine($"Элемент ArrayList: {arrayList[indexArrayList]}. ");            
            else            
                Console.WriteLine("Элемент не найден");            
        }

        static void FindAndShowElementLinkedList(LinkedList<int> linkedList)
        {
            LinkedListNode<int>? nodeLinkedList = linkedList.Find(496753);
            if (nodeLinkedList != null)
                Console.WriteLine($"Элемент LinkedList {nodeLinkedList.Value}. ");
            else
                Console.WriteLine("Элемент не найден");
        }

        // Деление на 777
        static void Division777List(List<int> list)
        {
            foreach (int item in list)
            {
                if (item % 777 == 0)
                Console.WriteLine(item + " ");
            }
            Console.WriteLine("----------\n");
        }

        static void Division777ArrayList(ArrayList arrayList)
        {
            foreach (int item in arrayList)
            {
                if (item % 777 == 0)
                {
                    Console.WriteLine(item + " ");
                }
            }
            Console.WriteLine("----------\n");
        }

        static void Division777LinkedList(LinkedList<int> linkedList)
        {
            var nodeList = linkedList.First;
            for (int i = 0; i < linkedList.Count; i++)
            {
                if (nodeList?.Value % 777 == 0)
                {
                    Console.WriteLine(nodeList?.Value + " ");
                }
                nodeList = nodeList?.Next;
            }
            Console.WriteLine("----------\n");
        }
    }
}
