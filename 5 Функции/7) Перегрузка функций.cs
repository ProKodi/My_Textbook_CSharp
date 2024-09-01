﻿



/*
Для того чтобы перегрузить функцию необходимо реализовать новую функцию с точно таким же именем как у старой

При перегрузке можно изменить:
    Количество и тип аргументов
    Возвращаемый тип данных
    Действия в функции

При перегрузке выбор функции зависит от типа данных которые подаются в функцию и их количества
Перегрузку функций можно выполнить только используя классы
*/



class Program{
    /* Коментарий к функции 1*/
    static int my_fun(int number_1, int number_2){
        return number_1 + number_2;
    }

    /*Коментарий к функции 2*/
    static double my_fun(double number_1, double number_2){
        return number_1 * number_2;
    }

    /*Коментарий к функции 3*/
    static void my_fun(double number_1){
        Console.WriteLine($"Выполнение функции 3: number_1 = {number_1}");
    }

    public static void Main(){
        Console.WriteLine($"Результат функции 1: {my_fun(10, 5)}");
        Console.WriteLine($"Результат функции 2: {my_fun(10.5, 5.9)}");
        my_fun(10.59789); // Выполнение функции 3
    }
}