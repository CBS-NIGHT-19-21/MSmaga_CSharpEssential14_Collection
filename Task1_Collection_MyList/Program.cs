namespace Task1_Collection_MyList
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Задание Дополнительное

            // Создайте коллекцию MyList<T>.Реализуйте в простейшем приближении возможность использования
            // ее экземпляра аналогично экземпляру класса List<T>. Минимально требуемый интерфейс
            // взаимодействия с экземпляром, должен включать метод добавления элемента, индексатор для
            // получения значения элемента по указанному индексу и свойство только для чтения для получения
            // общего количества элементов. Реализуйте возможность перебора элементов коллекции в цикле
            // foreach.
            #endregion

            MyList<int> myList = new();

            myList.Add(13);
            myList.Add(19);
            myList.Add(1319);

            foreach (var item in myList)
            {
                Console.WriteLine($"Element is {item}");
            }

            Console.WriteLine($"Number of List Elements is {myList.Count}");

            Console.WriteLine(myList[1]);

            Console.WriteLine(myList[2]);

            Console.WriteLine(myList[3]);


            //Delay
            Console.ReadLine();

        }
    }
}

