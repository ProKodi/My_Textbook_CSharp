﻿



/*
Переменные ссылки - данные переменные не имеют своего собственного адресса.
Данный переменные ссылаются на определенный адресс памяти на который уже 
    ссылается какая-то переменная
Конструкция:
    ref "тип данных переменной ссылки" "имя ссылки" = 
        ref "переменная на которую хотим сослать ссылку"; 

Через ссылки можно измененять переменные на которую ссылаются ссылка

Переменные-сслыки не могут иметь следующие значения:
    Значение null
    Константу
    Значение перечисления enum
    Свойство класса или структуры
    Поле для чтения (которое имеет модификатор read-only)
*/

int number = 100; // Создаем переменную

// Создаем ссылку на переменную
ref int linkc = ref number; 


// Получаем значение переменной number по ссылке linkc
Console.WriteLine($"linkc = {linkc}. number = {number}");

// Меняем значение ссылки а в месте с ней и значение переменной
linkc = 23;

// Получаем значение переменной number по ссылке linkc
Console.WriteLine($"linkc = {linkc}. number = {number}");