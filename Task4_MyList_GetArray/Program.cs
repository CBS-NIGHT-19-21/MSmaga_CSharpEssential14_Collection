class Program
{
 
    static void Main()
    {
        MyList<int> myList = new MyList<int>();

        myList.Add(13);
        myList.Add(239);
        myList.Add(39);

        int[] intArray = ExtensionClass.GetArray<int>(myList);
         
      
        foreach (int item in intArray)
        {
            Console.WriteLine(item);
        }

        Console.ReadKey();
    }
    
}