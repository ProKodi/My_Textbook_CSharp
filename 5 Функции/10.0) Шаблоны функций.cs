﻿



/*
Шаблоная функция/Обобщеная функция - представляет из себя шаблон где при вызове
    функции необходимо указать с какими типами данных будет работать функция

Пример:
    "тип возращемый функцией" "имя функции"<типы данных с которыми будет работать функция через запятую>("аргументы функции"){
        "Тело функции"
    }

Использование шаблонов функций позволяет избежать ненужного 
    преобразования типов данных
*/


/* Создание шаблонной функции*/
void my_fun<type1, type2>(type1 number_1, type2 number_2){
    Console.WriteLine($"number_1 = {number_1}\t number_2 = {number_2}");
}


/* Вызывать шаблонные функции можно 2 спосабами:
    1) С указанием используемых типов данных (предпочтительнее)
    2) Без указания используемых типов данных 

*/


// Вызов шаблонной функции
my_fun<int, float>(12, 87.4f); // Вызов с указанием используемых типов данных
my_fun(12, "some text"); // Вызов без указания используемых типов данных
my_fun(87.4f, "some text"); // Вызов без указания используемых типов данных
my_fun("some inform", "some text"); // Вызов без указания используемых типов данных

