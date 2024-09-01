﻿



/*
Для того чтобы реализовать ввод через консоль необходимо:
    1) Ввывести юзеру что мы от него хотим
    2) Запросить ввод с консоли

*/


Console.Write("Введите имя: "); // Вывод в консоль: "Немного текста"
var name = Console.ReadLine(); // Данная команда считывает всю строку
/* По умолчанию результат считывания с консоли приходит 
    в видео объекта экземпляра string
Так же если ничего не было введено, то результатом считывания будет null
Для того чтобы конвертировать результ считывания в другой класс 
    можно использовать следующие функции:
    
    // Строки
        string obj_string = Convert.ToString("результат считывания"); 

    // Символы
        char obj_char = Convert.ToChar("результат считывания"); 
    
    // Логический тип
        bool obj_log = Convert.ToBoolean("результат считывания"); 
    
    // Целые числа
        sbyte obj_sb = Convert.ToSByte("результат считывания"); 
        byte obj_b = Convert.ToByte("результат считывания"); 
        short obj_s = Convert.ToInt16("результат считывания"); 
        ushort obj_us = Convert.ToUInt16("результат считывания"); 
        int obj_i = Convert.ToInt32("результат считывания"); 
        uint obj_ui = Convert.ToUInt32("результат считывания"); 
        long obj_l = Convert.ToInt64("результат считывания"); 
        ulong obj_ul = Convert.ToUInt64("результат считывания"); 
    
    // Дроби
        float obj_f = Convert.ToSingle("результат считывания"); 
        double obj_do = Convert.ToDouble("результат считывания"); 
        decimal obj_de = Convert.ToDecimal("результат считывания"); 

При исполнении данных преобразований могут быть ошибки, 
    по этому необходимо преобразования использовать только в блоке try
*/


name = Convert.ToString(name); // Переводим результат сканирования в строку

Console.WriteLine($"Имя которое вы ввели: {name}");




