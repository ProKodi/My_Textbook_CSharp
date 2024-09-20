



class Program{
    public static string list_to_string(List <int> numbers){
        string res = "[";
        foreach(int number in numbers){res += $"{number}, ";}
        res += $"\b\b]";
        return res;
    }


    public static void Main(){
    /*
    Конструкция создания списка:
        List<"тип данных который должен хранить список"> "имя списка" = 
            new List<"тип данных который должен хранить список">(){"значения для списка"}
    */
    // Создание списка
    List <double> list1 = new List<double>(); // Создание пустого списка
    // Аналог: List <double> list1 = [];
    List <float> list2 = new List<float>(5); // Создание списка с длиной 5 и значениями по умолчанию
    List <int> list3 = new List<int>(){1, 2, 3, 4, 5}; // Создание списка с инициализацией
    // Аналог: List <int> numbers = [1, 2, 3, 4, 5];
    

    // Копирование списка
    List <int> numbers = new List<int>(list3); // Создание списка c элементами списка numbers
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
    Console.WriteLine($"Первый элемент списка: {numbers[0]}");
    Console.WriteLine($"Последний элемент списка: {numbers[numbers.Count - 1]}"); 
    // Данный метод работает только на отсоритрованной коллекции
    Console.WriteLine($"Индекс элемента 3 в списке: {numbers.BinarySearch(3)}");
    // Проверка элемента на наличие в списке (вернет bool )
    Console.WriteLine($"Элемент 2 есть в списке: {numbers.Contains(2)}");
    // Получение индекса первого вхождения в список определенного элемента
    Console.WriteLine($"Индекс элемента 2 в списке (первое вхождение): {numbers.IndexOf(2)}");
    // Получение индекса последнего вхождения в список определенного элемента
    Console.WriteLine($"Индекс элемента 2 в списке (последнее вхождение): {numbers.LastIndexOf(2)}");
    // Возвращение списка определенных элементов, количество которых равно count, начиная с индекса index.
    Console.WriteLine($"Получение 3 элементов из списка начиная с индекса 1: {Program.list_to_string(numbers.GetRange(1, 3))}");
    /* "имя списка".Reverse("индекс с которого начать", "количество элементов"): 
        Данный метод изменяет порядок на обратный для элементов
    */
    numbers.Reverse(0, 3); // Реверсируем порядок для 3 элементов списка начиная с 0 индекса
    Console.WriteLine($"Список в котором реверснули 3 элементов начиная с 0 индекса: {Program.list_to_string(numbers)}");
    // "имя списка".Reverse() - Реверсируем порядок для всех всех элеменов списка
    numbers.Reverse(); // Реверсируем порядок для 5 элементов списка начиная с 0 индекса
    Console.WriteLine($"Список в котором реверснули все: {Program.list_to_string(numbers)}");

    // "имя списка".Sort("Компоратор") - метод сортировки списка. Компоратор можно не указывать
    numbers.Sort();
    Console.WriteLine($"Список который отсортировали: {Program.list_to_string(numbers)}");



    // Перебор элементов списка в цикле с помощью итераций
    Console.Write("numbers = "); 
    foreach (int n in numbers){
        Console.Write($"{n}, "); 
    }
    Console.WriteLine($"\b\b");

    Console.Write("numbers = "); 
    for (int i = 0; i < numbers.Count; i += 1){
        Console.Write($"{numbers[i]}, "); 
    }
    Console.WriteLine("\b\b");
    
    
    
    // Добавление элементов в список
    //  "имя списка".Add(item) данный метод добавляет значение item в конец списка
    numbers.Add(11); 
    Console.WriteLine($"numberss.Add(11) -> {Program.list_to_string(numbers)}"); 
    // "имя списка".AddRange("коллекция или массив") - добавление в список коллекции или массива
    numbers.AddRange([6, 7]); 
    Console.WriteLine($"numberss.AddRange([6, 7]) -> {Program.list_to_string(numbers)}"); 
    // "имя списка".Insert(pos, val) данный метод вставляет элемент val на позицию, на которую указывает итератор pos. Возвращает итератор на добавленный элемент
    numbers.Insert(0, 77);
    Console.WriteLine($"numbers.Insert(0, 77) -> {Program.list_to_string(numbers)}");
    // "имя списка".InsertRange(pos, val) -  данный метод вставляет колекцию val в список на накоторую указывает pos. 
    numbers.InsertRange(3, [10, 20, 30]);
    Console.WriteLine($"numbers.InsertRange(3, [10, 20, 30] -> {Program.list_to_string(numbers)}");
    
    
    // Удаление элементов из списка
    /* "имя списка".RemoveAt("индекс который хотим удалить") - 
    удаляет элемент из списка по индексу. Если этого элемента нет то ошибка*/
    numbers.RemoveAt(numbers.Count - 1);
    Console.WriteLine($"Список после удаления последнего элемента -> {Program.list_to_string(numbers)}");
    numbers.RemoveAt(0);
    Console.WriteLine($"Список после удаления первого элемента -> {Program.list_to_string(numbers)}");
    /*bool "имя списка".Remove("элемент который хотим удалить"): удаляет элемент из списка, 
        и если удаление прошло успешно, то возвращает true. 
        Если в списке несколько одинаковых элементов, то удаляется только первый из них
    */
    Console.WriteLine($"Элемент 100 удален из списка: {numbers.Remove(100)}");
    Console.WriteLine($"Элемент 11 удален из списка: {numbers.Remove(11)}");
    /* "имя списка".RemoveRange("индекс с которого начать удалять", "сколько хотим удалить") - 
        Данный метод удаляет колекцию с определенного идекса и определеное количество
    */
    numbers.RemoveRange(2, 3);
    Console.WriteLine($"Список после удаления 3 элементов с 2 индекса: {Program.list_to_string(numbers)}");

    // Clear() данный метод удаляет все элементы из списка
    numbers.Clear();
    Console.WriteLine($"Список после очистки -> {Program.list_to_string(numbers)}");
    }
}