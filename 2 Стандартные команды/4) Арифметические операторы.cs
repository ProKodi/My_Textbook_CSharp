



float number_1 = 23;
float number_2 = 77;

/*Виды операторов:
    1) Унарные (нужен только один операнд)
    2) Бинарные (нужно два операнда)
    3) Тернарные (нужно три операнда)
При работе с операторами все операнды должны быть одного типа
*/

// Унарные операторы

// Унарный минус (умножает число на -1)
Console.WriteLine($"Унарный минус =  {- number_1}");
// ++ Инкримент ( аналог += 1)
Console.WriteLine($"'number'++ = {number_1 ++}"); // Отображает 23 но на самом деле 24
Console.WriteLine($"++'number' = {++ number_1}"); // Отображает все как надо
// -- Дикремент (херовый аналог -= 1)
Console.WriteLine($"'number'-- = {number_1 --}");  // Отображает 25 но на самом деле 24
Console.WriteLine($"--'number' = {-- number_1}");  // Отображает все как надо


number_1 = 23;

// Бинарные операторы


// + Сложение
number_1 += number_2; 
Console.WriteLine($"+= {number_1}");
// number_1 += number_2 аналогично number_1 = number_1 + number_2
number_1 = 23;

// - Вычитание
number_1 -= number_2;
Console.WriteLine($"-= {number_1}");
// number_1 -= number_2 аналогично number_1 = number_1 - number_2
number_1 = 23;


// * Умножение
number_1 *= number_2;
Console.WriteLine($"*= {number_1}");
// number_1 *= number_2 аналогично number_1 = number_1 * number_2
number_1 = 23;


// / Деление
number_1 /= number_2;
Console.WriteLine($"/= {number_1}");
// number_1 /= number_2 аналогично number_1 = number_1 / number_2
number_1 = 23;


// % Деление по модулю (остаток от деления). Работает только с целочисленными числами
int number_2_int = (int)number_2;
number_2_int %= 2;
Console.WriteLine($"%= {number_2_int}");
// number_1 %= number_2 аналогично number_1 = number_1 % number_2


// Целочисленное деление
Console.WriteLine($"Целочисленное деление: {(int)(number_2 / number_1)}");
number_2_int = (int)(number_2 / number_1);
Console.WriteLine($"Целочисленное деление c присваиванием {number_2_int}");


// Побитовые сдвиги
int number_bin_1 = 0b10; // 2
int number_bin_2 = 0b01; // 1

Console.WriteLine($"1 << 2 = {number_bin_2 << 2}");
// number_bin_2 <<= 2 аналогично number_bin_2 = number_bin_2 << 2;

Console.WriteLine($"2 >> 1 = {number_bin_1 >> 1}");
// Аналог: number_bin_1 >>= 1 аналогично number_bin_1 = number_bin_1 >> 1;
