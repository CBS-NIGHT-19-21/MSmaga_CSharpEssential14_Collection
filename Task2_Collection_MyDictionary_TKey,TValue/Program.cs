namespace Task2_Collection_MyDictionary_TKey_TValue
{
    class Program
    {
        static void Main()
        {
            #region Задание 3 MyDictionary<TKey, TValue>

            //Используя Visual Studio, создайте проект по шаблону Console Application.
            //Создайте коллекцию MyDictionary<TKey, TValue>.Реализуйте в простейшем приближении
            //возможность использования ее экземпляра аналогично экземпляру класса Dictionary<TKey, TValue>.
            //Минимально требуемый интерфейс взаимодействия с экземпляром, должен включать метод
            //добавления элемента, индексатор для получения значения элемента по указанному индексу и свойство
            //только для чтения для получения общего количества элементов. Реализуйте возможность перебора
            //элементов коллекции в цикле foreach.
            #endregion

            MyDictionary<int,string> myDictionary = new();

            myDictionary.Add(13, "Hi There!");
            myDictionary.Add(19, "Farewell!");

            Console.WriteLine(myDictionary[1]);

            Console.WriteLine(myDictionary[2]+"\n");

            foreach (var item in myDictionary)
            {
                Console.WriteLine(item);
            }
 
            //Delay
            Console.ReadLine();

        }
    }
}

