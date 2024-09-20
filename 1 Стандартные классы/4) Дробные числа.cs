






// float - 4 байт (Значения: одинарная точность). Аналог: System.Single
float number_flt = 23.6f;  // Так создается переменная с дробным численым типом данных
Console.WriteLine($"number_flt = {number_flt}");


// double - 8 байт (Значения: двойная точность). Аналог: System.Double
double number_dbl = 45.9;  // Так создается переменная с дробным численым типом данных
// Аналог: double number_dbl = 45.9d;
Console.WriteLine($"number_dbl = {number_dbl}");

// decimal - 16 байт (Значения: двойная точность). Аналог: System.Decimal
decimal number_dec = 45.9m;  // Так создается переменная с дробным численым типом данных
Console.WriteLine($"number_dec = {number_dec}");
    

// Обрубание дробной части у числа
int number_in_int = (int)38765.756; 
// На горячую: (int)number_dbl
Console.WriteLine($"Обрубание дробной части у числа (38765.756) = {number_in_int}");


/*
PositiveInfinity - позитивная бесконеность
NegativeInfinity - негативная бесконечность
Nan - не является числом
*/