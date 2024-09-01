﻿



class My_class{
/* 
required - модификатор который обязывает пользователя 
    инициализировать данные поля через инициализатор
*/
    public required int number{get; set;} = 0; 

    public required float number2{get; init;} = 0; 

    public My_class(){}

    public My_class(int number, float numberf){
        this.number = number; 
        this.number2 = numberf; 
    }

    public void print(){
        // this.number2 = 8.9f; // Ошибка, так как мы не можем менять это поле
        Console.WriteLine($"this.number = {this.number}\tthis.number2 = {this.number2}");
    }
}


class Program{
    public static void Main(){ 
        // Инициализация через конструктор 
        //My_class temp = new My_class(2, 4.6f); // Будет ошибка так так не использован инициализатор
        // Инициализация через инициализатор
        My_class temp = new My_class {number = 2, number2 = 4.6f};

        temp.print();

        // Взаимодействуем с полем обьекта через определитель 
        temp.number = 9; // сетер
        Console.WriteLine($"temp.number = {temp.number}"); // гетер
        // temp.number2 = 9.8f; // Ошибка, так как мы не можем менять это поле
        Console.WriteLine($"temp.number2 = {temp.number2}"); // гетер

        temp.print();
    }
}