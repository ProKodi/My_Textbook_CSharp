﻿



/* Добаление конструктора для класса/струтуры
Конструкторы представляют специальную функцию, которая имеет то же имя, что и класс/структура. 
Данная функция не возвращает никакого значения и позволяют инициалилизировать 
    (объект класса)/(значение структуры) во время создания.

Данная функция гарантирует что, что поля класса/структуры будут иметь определенные значения. 
При каждом создании нового (объект класса)/(значение структуры) вызывается конструктор.
    
Конструкция:
    "название класса/структуры"("аргументы для конструктора"){
        "действия конструктора"
    }
    
*/



class My_class{
private int number = 0; 

    /* Конструктор по умолчанию 
        (используется когда создаем обьект без инициализации)
    Обычно такие конструкторы использую для того 
        что-бы создать путой объект с последующей инициализацией 
    */
public My_class(){
        Console.WriteLine("Работает стандартный конструктор (класс)"); 
    }

    // Конструктор с 1 пареметром
public My_class(int number){
        Console.WriteLine("Работает конструктор с 1 параметром (класс)"); 
        // Ссылаем поле number текущего объекта на новое значение
        this.number = number;
    }

    /* Конструктор копирования 
        (используется когда инициализирем обьектом это-го же класса)
    Использовать данный конструктор нужно для создания копий обьекта
    */
public My_class(My_class obj){
        Console.WriteLine("Работает конструктор копирования (класс)"); 
        // Ссылаем поле number текущего объекта на новое значение
        this.number = obj.number;
    }

}


struct My_struct{
private int number = 0; 

    /* Конструктор по умолчанию 
        (используется когда создаем обьект без инициализации)
    Обычно такие конструкторы использую для того 
        что-бы создать путой объект с последующей инициализацией 
    */
public My_struct(){
        Console.WriteLine("Работает стандартный конструктор (структура)"); 
    }

    // Конструктор с 1 пареметром
public My_struct(int number){
        Console.WriteLine("Работает конструктор с 1 параметром (структура)"); 
        // Ссылаем поле number текущего объекта на новое значение
        this.number = number;
    }

    /* Конструктор копирования 
        (используется когда инициализирем значением этой же структуры)
    */
public My_struct(My_struct obj){
        Console.WriteLine("Работает конструктор копирования (структура)"); 
        // Ссылаем поле number текущего объекта на новое значение
        this.number = obj.number;
    }
}


class Program{
    public static void Main(){
        // Создаем обьект с помощью конструктора по умолчанию
        My_class new_class = new My_class(); 
        // Создаем обьект с 1 аргументом для инициализации
        My_class new_class1 = new My_class(10); 
        // Создаем обьект с помощью конструктора копирования
        My_class new_class2 = new My_class(new_class1);

        
        // Создаем значение с помощью конструктора по умолчанию
        My_struct ogk = new My_struct(); 
        // Создаем значение с 1 аргументом для инициализации
        My_struct ogk1 = new My_struct(10); 
        // Создаем значение с помощью конструктора копирования
        My_struct ogk2 = new My_struct(ogk1);
    }

}