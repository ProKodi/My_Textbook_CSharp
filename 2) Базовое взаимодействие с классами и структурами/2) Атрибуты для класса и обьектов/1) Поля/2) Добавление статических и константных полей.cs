﻿


/* В C# можно определить атрибуты которые будут относится не к объекту а именно к самому классу

Статические поля определяется только один раз и будут существовать,
    даже если экземпляры класса/структуры не были созданы
Если статическое поле будет изменено, то поле изменится во всех экземплярах 
    класса/структуры а не только в конкретном экземпляре

Конструкция для полей:
    static "тип данных поля" "имя поля" = "значение поля"

Статические поля называют не полями экземпляра, а полями класса/структуры
Если поле является константой, то данное поле уже является 
    полем класса/структура а следовательно использовать модификатор static не надо
*/



class My_class{
public static int super_number = 0; 
public const int number = 0; 
// Константа должна быть обязательно инициализированна иначе будет ошибка
}


class Program{
    public static void Main(){
        /*
        Конструкция для взаимодействия с статическими атрибутами:
            "название класса/структуры"."статический атрибут класса/структуры"
        К экземпляру статические атрибуты применять нельзя
        */

        Console.WriteLine($"My_class.super_number = {My_class.super_number}");
        Console.WriteLine($"My_class.number = {My_class.number}");

        My_class new_class = new My_class(); 

        // Меняем статическое поле
        My_class.super_number += 1;
        // My_class.number += 1; // Получаем ошибку так как константу нельзя менять
        Console.WriteLine($"My_class.super_number = {My_class.super_number}");
        Console.WriteLine($"My_class.number = {My_class.number}");
    }
}