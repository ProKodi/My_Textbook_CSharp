﻿



/* Замыкания
Замыкание представляет объект функции, который запоминает свое окружение даже 
    в том случае, когда она выполняется вне своей области видимости.
Технически замыкание включает три компонента:
    1) Внешняя функция, которая определяет область видимости и в которой 
        определены переменные и параметры (окружение)
    2) переменные и параметры (лексическое окружение), которые определены во внешней функции
    3) вложенная функция, которая использует переменные и параметры внешней функции
*/


Action fun1(){
    int x = 9; 
    void fun2(){
        x += 1;
        Console.WriteLine($"x = {x}");
    }
    return fun2; 
}

// Тут создается окружение для функции fun2
// В делигат возращается результат функции fun1 
//    (то есть функция fun2 с окружением которая создала fun1)
Action fun = fun1(); 
// В данной переменной сожержится ссылка на fun2 и ее окружение

fun(); // Выведет: x = 10
fun(); // Выведет: x = 11

// Тут создается окружение для функции fun2
Action fun2 = fun1(); 
// В данной переменной сожержится ссылка на fun2 и ее окружение

fun2(); // Выведет: x = 10