



Object temp = 30; 

// typeof - возращает System.Type который соответструет указаному типу данных
Type type_int = typeof(int); // Получаем тип данных (System.Type) у указаного типа данных

// GetType - позволяет получить тип данных переменной (возращает System.Type)
Console.WriteLine($"temp имеет тип данных {temp.GetType()}"); // Получаем тип данных у переменной


// равниваем тип данных переменной с предпологаемым типом данных

// Используя GetType и typeof
Console.WriteLine($"temp имеет тип данных int: {temp.GetType() == type_int}");
Console.WriteLine($"temp имеет тип данных float: {temp.GetType() == typeof(float)}");

// Используя is / is not
Console.WriteLine($"temp имеет тип данных int: {temp is int}");
Console.WriteLine($"temp имеет не тип данных float: {temp is not float}");