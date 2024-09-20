



static class Oth{
    public static void print1(int arg){
        Console.WriteLine($"work print1. Arg = {arg}"); 
    }
    public static void print2(){
        Console.WriteLine($"work print2"); 
    }

    public static void print3(int arg){
        Console.WriteLine($"work print3. Arg = {arg + 100}"); 
    }
}

/* Делигат - обьект который ссылается функции
По факту делигаты представляют собой указатель на функцию 
    (функция может быть любой, только она должна соответсвовать возращаемому типу данных и аргументам). 

Конструкция:
    delegate "тип данных который возращает функция" "название делигата" ("аргументы передаваемые в функцию"); 

Делегат может быть определен в методе, классе/структуре, вне чего-либо
К делегатам также можно применять шаблонны/обобщения
*/
delegate void Fun_print(int arg);


class Program{
    // Создаем метод/функцию которая использует делигат
    public static void print(Fun_print fun){
        // Используем делигат
        fun(4); 
    }


    public static void Main(){
        // Обьявляем обьект делегата
        Fun_print message1;

        message1 = Oth.print1; // Ссылаем делегат на функцию print1
        // Аналог: message1 = Fun_print(Oth.print1);
        
        // Перед вызовом рекомендуется порверать делигат на наличия null
        message1(7); // Вызываем функцию print1 через делегат
        // Аналог: message1.Invoke() // Позволяет избежать ошибок

        // message1 = Oth.print2; 
        // Ошибка так как print2 не принимает аргументов в отличии от делигата

        Console.WriteLine($"Создание очереди из функций"); 
        // Добавляем еще одну функцию в делегат
        // Добавление функции работает по принцепу очереди: 
        //    что первое было добавленно, то и вызовится
        message1 += Oth.print3;

        message1(7); // Вызываем функцию print1 и print3 через делегат

        Console.WriteLine($"Удаление функций из очереди"); 

        Fun_print? message2 = message1 - Oth.print1;
        // Аналог: message1 -= Oth.print1 (Возможна ошибка с null)

        if (message2 == null){
            Console.WriteLine("Делегат пуст");
        }
        else{
            message2(7); // Вызываем функцию print3 через делегат
        }

        Console.WriteLine($"Обьединеный делигат"); 

        Fun_print message3 = message2 + message1;

        // Передаема полученный делигат в функцию
        Program.print(message3); 
        // Будут вызваны функции print3, print1, print3 через делегат
    }
}