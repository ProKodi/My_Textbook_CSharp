﻿


/*
object - тип данных от которого наследуются все типы данных в C#
Переменные данного типа могут могут принимать 
    обьект абсолютно любого класса
Размер данного обьекта = 4 байт если 32 битная платформа 
    или 8 байт  если 64 битная платформа 
*/
object a = 5; // Передаем в переменную число
Console.WriteLine($"a = {a}");

a = "iygiug"; // Передаем в переменную строку
Console.WriteLine($"a = {a}");
a = 87.9; // Передаем в переменную дробь
Console.WriteLine($"a = {a}");
a = 'g';  // Передаем в переменную символ
Console.WriteLine($"a = {a}");


