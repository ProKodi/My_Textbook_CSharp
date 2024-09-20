﻿



/*
Любой класс или структура наследуют от Object такой метод как ToString
Данный метод вызывается когда нужно представление экземпляра в строковом виде
Данный метод будет вызыватся при:
    Выводе экземпляра в консоль
    Вставки экземпляра в строку
    Представление объекта в виде строки (прямой вызов ToString)
*/


class My_class{
    private int number = 0; 


    public My_class(int number){
        this.number = number;
    }

    // Данный метод представляет экземпляр данного класса 
    //    в строковом представлении. Данный метод является виртуальным.
    //    Для его работы необходимо данный метод перегрузить (использовать модификатор override)
    //    Данный метод обязательно должен возращать строку. 
    //    Так же данный метод не имеет аргументов
    public override string ToString(){
        return $"(My_class.number = {this.number})";
    }
}




class Program{
    public static void Main(){ 
        My_class temp = new My_class(34);
        // Есле бы метод ToString небыл перегружен, то в консоль
        //    было бы выведено temp = My_class
        Console.WriteLine($"temp = {temp}"); 
        // В консоль выведет: temp = (My_class.number = 34)
    }
}

