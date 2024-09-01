



/* В C# можно определить атрибуты которые будут относится не к объекту а именно к самому классу

Конструкция для методов:
    static  "тип данных возращаемым методом" "имя метода и его аргументы"{
        "код метода. В коде не допускается использование this и атрибутов объекта"
    }
Статические методы называют не методами экземпляра, а методами класса/структуры
*/


class My_class{
protected static int super_number = 0; 

// Коментарий к статическому методу
public static int get_super_number(){
    super_number += 1;
    // Возращаем атрибут класса
    return super_number - 1; 
    }
}


class Program{
    public static void Main(){
        /*
        Конструкция для взаимодействия с статическими атрибутами:
            "название класса/структуры"."статический атрибут класса/структуры"
        */
        // Вызываем метод класса
        Console.WriteLine($"My_class.get_super_number() = {My_class.get_super_number()}");

        My_class new_class = new My_class(); 

        // Вызываем метод класса
        Console.WriteLine($"My_class.get_super_number() = {My_class.get_super_number()}");
    }
}