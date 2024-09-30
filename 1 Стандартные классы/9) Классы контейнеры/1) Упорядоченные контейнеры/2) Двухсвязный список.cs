



class Program{
    public static string list_to_string(LinkedList <int> numbers){
        string res = "[";
        foreach(int number in numbers){res += $"{number}, ";}
        res += $"\b\b]";
        return res;
    }


    public static void Main(){
        /* Конструкция создания списка:
            LinkedList<"тип данных который должен хранить список"> "имя списка" = 
                new LinkedList<"тип данных который должен хранить список">(){"значения для списка"}
        Данный список является односвязным
            (каждый элемент хранит значение и ссылку на следующий элемент)
        В списке LinkedList<T> обьекты будут типами LinkedListNode<T>
            Для получения значения от LinkedListNode использовать метод Value
        */
        // Создание списка
        LinkedList<double> list1 = new LinkedList<double>(); // Создание пустого списка
        // Аналог: LinkedList <double> list1 = [];
        //LinkedList <float> list2 = new LinkedList <float>(new List<float>)
        // Создание двухсвязного списка на основе односвязного
        LinkedList <float> list2 = new LinkedList<float>(
            new List<float>(){1.2f, 2.3f, 3.4f}
        );
        // Создание двухсвязного списка на основе односвязного (аналог)
        LinkedList <int> list3 = new LinkedList<int>(
            [1, 2, 3, 4, 5]
        ); 

        // Копирование списка
        LinkedList <int> numbers = new LinkedList<int>(list3); 
        // Создание списка c элементами списка list3
        
        
        // Копирование списка в массив (почему-то не работает)
        /*{
            int[] arr_number = new int[numbers.Count - 1]; // Массив обязателено должен быть инициализирован
            numbers.CopyTo(arr_number); // Копируем список в массив
            Console.Write("numbers в виде массива (arr_number) = {");
            for(int i = 0; i < arr_number.Length; i += 1){Console.Write($"{arr_number[i]}, ");}
            Console.WriteLine("}");
            // Похожая функция: 
            // CopyTo(int index, T[] array, int arrayIndex, int count): копирует из списка
            //    начиная с индекса index элементы, количество которых равно count, 
            //    и вставляет их в массив array начиная с индекса arrayIndex
        }*/
    

        // Взаимодействие с длиной списка
        // "имя списка".Count - позволяет вернуть количество элементов
        Console.WriteLine($"Размер списка numbers = {numbers.Count}"); 
    

        // Взаимодействие с элементами списка
        Console.WriteLine($"Первый элемент списка: {numbers.First}");
        Console.WriteLine($"Последний элемент списка: {numbers.Last}"); 
        // Проверка элемента на наличие в списке (вернет bool )
        Console.WriteLine($"Элемент 2 есть в списке: {numbers.Contains(2)}");



        // Перебор элементов списка в цикле с помощью итераций
        Console.Write("numbers = "); 
        foreach (int n in numbers) {Console.Write($"{n}, ");}
        Console.WriteLine($"\b\b");
    
    
    
        // Добавление элементов в список
        // "имя списка".AddLast(item) данный метод добавляет значение item в конец списка
        numbers.AddLast(11); 
        // Аналог: numbers.AddLast(new LinkedListNode<int>(11)) // Тут 11 обернута в обьект LinkedListNode
        Console.WriteLine($"numberss.AddLast(11) -> {Program.list_to_string(numbers)}"); 

   /* // "имя списка".Insert(pos, val) данный метод вставляет элемент val на позицию, на которую указывает итератор pos. Возвращает итератор на добавленный элемент
        numbers.Insert(0, 77);
        Console.WriteLine($"numbers.Insert(0, 77) -> {Program.list_to_string(numbers)}");
    // "имя списка".InsertRange(pos, val) -  данный метод вставляет колекцию val в список на накоторую указывает pos. 
    numbers.InsertRange(3, [10, 20, 30]);
    Console.WriteLine($"numbers.InsertRange(3, [10, 20, 30] -> {Program.list_to_string(numbers)}");*/
    
    
    // Удаление элементов из списка
    /* "имя списка".RemoveAt("индекс который хотим удалить") - 
    удаляет элемент из списка по индексу. Если этого элемента нет то ошибка*/
   /* numbers.RemoveAt(numbers.Count - 1);
    Console.WriteLine($"Список после удаления последнего элемента -> {Program.list_to_string(numbers)}");
    numbers.RemoveAt(0);
    Console.WriteLine($"Список после удаления первого элемента -> {Program.list_to_string(numbers)}");
    *//*bool "имя списка".Remove("элемент который хотим удалить"): удаляет элемент из списка, 
        и если удаление прошло успешно, то возвращает true. 
        Если в списке несколько одинаковых элементов, то удаляется только первый из них
    */
   /* Console.WriteLine($"Элемент 100 удален из списка: {numbers.Remove(100)}");
    Console.WriteLine($"Элемент 11 удален из списка: {numbers.Remove(11)}");*/
    /* "имя списка".RemoveRange("индекс с которого начать удалять", "сколько хотим удалить") - 
        Данный метод удаляет колекцию с определенного идекса и определеное количество
    */
    /*numbers.RemoveRange(2, 3);
    Console.WriteLine($"Список после удаления 3 элементов с 2 индекса: {Program.list_to_string(numbers)}");

    // Clear() данный метод удаляет все элементы из списка
    numbers.Clear();
    Console.WriteLine($"Список после очистки -> {Program.list_to_string(numbers)}");*/
    }
}