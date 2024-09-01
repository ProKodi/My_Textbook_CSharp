



/*
Подключить класс который работает как пространтсво имен можно 
    с помощью следующей конструкции:

    using static "имя класса"; 

Данная конструкция позволяет содержимое класса
    переместить в глобальное пространство имен 

Если возможен конфликт между именами - не использовать
*/
using static my_space;
// Все что было в my_space попадает в глобальное пространство имен



/*
Вместо пространства имен можно также использовать статические классы
Преимуществом здесь будет то что некоторое содержимое можно инкапсулировать

Конструкция:
    static class "имя класса"{
        Все то что хочем засунуть в класс 
        (все кроме классов/структур должно иметь приписку static)
        
    }
*/
static class my_space{
// Определяем класс 
public class Test{
    public void print(){
        Console.WriteLine("Вызов следующего: my_space.Test.print");
    }
}
// Определяем функцию
public static void my_fun(int a){
        Console.WriteLine($"my_space.my_fun. Аргумет = {a}"); 
    }
// Определяем переменную
public static int number_1 = 100;
// Определяем константу
public const int number_2 = 100;
}




class Program{
    public static void Main(){
        // Работа с содержимым my_space
        Test obj1_1 = new Test(); // Работа с классом
        // Допустимо писать и так: my_space.Test obj1_1 = new my_space.Test()
        obj1_1.print();

        // Работа с функциями
        my_fun(29);

        // Работа с переменными
        Console.WriteLine($"переменная number_1 = {number_1}");

        // Работа с константами
        Console.WriteLine($"константа number_2 = {number_2}");
    }
}