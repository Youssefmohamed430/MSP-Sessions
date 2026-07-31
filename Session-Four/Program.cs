namespace Session_Four;

class Program
{
    static void Main(string[] args)
    {
        int[] array = new int[10];
        Console.WriteLine(array.Length);

        List<int> list = new List<int>(5); // Dynamic array
        Console.WriteLine(list.Capacity);

        list.Add(1);
        list.Add(2);
        list.Add(3);
        list.Add(4);
        list.Add(5);
        list.Add(6);
        Console.WriteLine(list.Count);
        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine(list[i]);
        }

        //List<int> list1 = new List<int>(10);
        //list1.Add(8);
        //list1.Add(9);
        //list1.Add(10);
        //list1.Add(2);
        //list1.Add(5);
        //for (int i = 0; i < list1.Count; i++)
        //{
        //    Console.WriteLine(list1[i]);
        //}
        //Console.WriteLine("-------------------- Sorted List -------------------");
        //list1.Sort();
        //for (int i = 0; i < list1.Count; i++)
        //{
        //    Console.WriteLine(list1[i]);
        //}
        //list1.Remove(0);
        //list1.Remove(2);
        //Console.WriteLine(list1.Contains(2));
        //list1.ForEach(x => Console.WriteLine(x));
        //list1.Clear();

        //var list2 = list1.ToArray();
        //Console.WriteLine(list2);

        LinkedList<int> l = new LinkedList<int>();

        l.AddFirst(1);
        l.AddFirst(2);
        l.AddFirst(3);
        l.AddFirst(4);
        l.AddFirst(5);
        Console.WriteLine(l.First + " " + l.Last);
        l.AddLast(1);
        Console.WriteLine(l.Last);
        Console.WriteLine(l.Count);
        l.RemoveFirst();
        l.RemoveLast();
        l.Clear();


        Stack<int> stack = new Stack<int>();
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        stack.Push(4);
        stack.Push(5);
        Console.WriteLine(stack.Peek());
        Console.WriteLine(stack.Pop());
        Console.WriteLine(stack.Count);
        var element = stack.Pop();
        Console.WriteLine(element);


        Queue<int> queue = new Queue<int>();
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);
        queue.Enqueue(4);
        var first = queue.Dequeue();
        Console.WriteLine(first);
        Console.WriteLine(queue.Peek());

        HashSet<int> set = new HashSet<int>();
        set.Add(1);
        set.Add(2);
        set.Add(3);
        set.Add(1);

        foreach (var item in set)
        {
            Console.WriteLine(item);
        }
        

        Dictionary<int,string> dict = new Dictionary<int,string>();
        dict.Add(1, "Apple");
        dict.Add(2, "Orange");
        dict.Add(3, "Mango");

        foreach (var item in dict)
        {
            Console.WriteLine(item.Key + " " + item.Value);
        }
    }
}
