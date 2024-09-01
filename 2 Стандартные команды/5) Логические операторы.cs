



/*Виды операторов:
    1) Унарные (нужен только один операнд)
    2) Бинарные (нужно два операнда)
    3) Тернарные (нужно три операнда)
*/


// Бинарные операторы
float number_float_1 = 15.6f;
float number_float_2 = 150.68f;


// Операторы сравнения
// < - меньше
bool res = number_float_1 < number_float_2;
Console.WriteLine($"number_float_1 < number_float_2 = {res}");

// > - больше
res = number_float_1 > number_float_2;
Console.WriteLine($"number_float_1 > number_float_2 = {res}");

// <= - меньше или равно
res = number_float_1 <= number_float_2;
Console.WriteLine($"number_float_1 <= number_float_2 = {res}");
// <= В некоторых ситуациях необходимо заменять на fabs(number_float_1 - number_float_2) <= "Класс точности числом"
    
// >= больше или равно
res = number_float_1 >= number_float_2;
Console.WriteLine($"number_float_1 >= number_float_2 = {res}");
// <= В некоторых ситуациях необходимо заменять на fabs(number_float_1 - number_float_2) >= "Класс точности числом"


// Операторы равенства
// == - равно
res = number_float_1 == number_float_2;
Console.WriteLine($"number_float_1 == number_float_2 = {res}");

// != - не равно
res = number_float_1 != number_float_2;
Console.WriteLine($"number_float_1 != number_float_2 = {res}");


// Побитовые операции
int number_1 = 10; // Бинарной форме = 1010
int number_2 = 3;  // Бинарной форме = 0011

int number_res = number_1 ^ number_2; // Операция XOR (побитовое не равно)
/* Данная операция находится следующием образом:
    1) Два числа приводятся к одинаковой форме
    2) Сравниваются одинаковый разряд у 2 разных операндов
    3) Если значения разрядов равны то результат 0,
        если не равны - 1

Пример: 
Данны числа 1010 (10) и 0011 (3)
1) Выполнено
2) 
    1 != 0 -> 1
    0 != 0 -> 0
    1 != 1 -> 0
    0 != 1 -> 1

Результат: 1001 (9)
*/
Console.WriteLine($"number_1 ^ number_2 (Операция XOR(побитовое не равно)) = {number_res}");

number_res = number_1 & number_2; // Операция побитовое и
/*Данная операция находится следующием образом:
    1) Два числа приводятся к одинаковой форме
    2) Сравниваются одинаковый разряд у 2 разных операндов
    3) Если оба значения разрядов равны 1 то результат 1, 
        иначе - 0

Пример: 
Данны числа 1010 (10) и 0011 (3)
1) Выполнено
2) 
    1 и 0 -> 0
    0 и 0 -> 0
    1 и 1 -> 1
    0 и 1 -> 0

Результат: 0010 (2)
*/
Console.WriteLine($"number_1 & number_2 (побитовое и) = {number_res}");

number_res = number_1 | number_2; // Операция побитовое или
/*Данная операция находится следующием образом:
    1) Два числа приводятся к одинаковой форме
    2) Сравниваются одинаковый разряд у 2 разных операндов
    3) Если значение хоть одного разряда равны 1 то результат 1, 
        иначе - 0

Пример: 
Данны числа 1010 (10) и 0011 (3)
1) Выполнено
2) 
    1 или 0 -> 1
    0 или 0 -> 0
    1 или 1 -> 1
    0 или 1 -> 1

Результат: 1011 (11)
*/
Console.WriteLine($"number_1 | number_2 (побитовое или) = {number_res}");

number_res = ~number_1; // Операция побитовое не
/*Данная операция находится следующием образом:
    1) Расширить число до типа  в котором возможна процессорцая адресация 
        (qword, dword, word, byte)
    2) В каждом разряде 0 меняется на 1, 1 на ноль

Пример: 
Данно число 1010 (10)
1) 1010 = 0000 1010
2)
    не 0 -> 1
    не 0 -> 1
    не 0 -> 1
    не 0 -> 1

    не 1 -> 0
    не 0 -> 1
    не 1 -> 0
    не 0 -> 1

Результат: 0101 (5)
*/
Console.WriteLine($"~number_1 (побитовое не) = {number_res}");




// Логические операторы
bool flag_1 = false;
bool flag_2 = true;


// && - и (логическое и)
res = flag_1 && flag_2;
Console.WriteLine($"flag_1 && (and) flag_2 = {res}");


// || - или (логическое или)
res = flag_1 || flag_2;
Console.WriteLine($"flag_1 || (or) flag_2 = {res}");

// != - не равно
res = flag_1 != flag_2;
Console.WriteLine($"flag_1 != flag_2 = {res}");

// == - равно
res = flag_1 == flag_2;
Console.WriteLine($"flag_1 == flag_2 = {res}");


// ! - не (лог отрицание\инверсия) 
res = (! flag_1);
Console.WriteLine($"!  = {res}");