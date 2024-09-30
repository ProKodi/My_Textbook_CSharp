



/* Кортеж представляет набор значений, заключенных в круглые скобки
Кортежи создаются с помощью следующей конструкции:
    (типы которые встречаются в кортеже) название кортежа = (элементы кортежа)
Порядок типов важен так как при его не соблюдении будет ошибка
*/

// Создание кортежа
(int, string) Peope = (32, "Oleg");
// Вывод кортежа
Console.WriteLine($"Peope = {Peope}");  
// Обращение к первому элементу кортежа 
Console.WriteLine($"Peope.int = {Peope.Item1}"); 
// Обращение к второму элементу кортежа 
Console.WriteLine($"Peope.string = {Peope.Item2}"); 


/// Возращение и подача кортежа из функции

(int, float) fun((int, float) arg){
    return (arg.Item1 + 4, arg.Item2 + 98.87f);
}

// Получение кортежа из функции
(int, float) numbers = fun((8, 32.67f)); 

// Вывод полученного кортежа
Console.WriteLine($"numbers = {numbers}");  
// Обращение к первому элементу полученного кортежа 
Console.WriteLine($"numbers.int = {numbers.Item1}"); 
// Обращение к второму элементу полученного кортежа 
Console.WriteLine($"numbers.float = {numbers.Item2}"); 