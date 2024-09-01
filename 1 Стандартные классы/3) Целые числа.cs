



//sbyte - 1 байта (Значения: [-128; 127]).
sbyte number_bt = 56; // Так создается переменная с целочисленым типом данных
Console.WriteLine($"number_bt = {number_bt}");
// byte - 1 байта (Значения: [0; 255]).
byte number_bt_pos = 56; // Так создается переменная с целочисленым типом данных
Console.WriteLine($"number_bt_pos = {number_bt_pos}");



//short - 2 байта (Значения: [-322768; 322767]). Аналог: System.Int16
short number_shr = 56; // Так создается переменная с целочисленым типом данных
Console.WriteLine($"number_shr = {number_shr}");

//ushort - 2 байта (Значения: [0; 65535]). Аналог: System.UInt16
ushort number_shr_pos = 56; // Так создается переменная с целочисленым типом данных
Console.WriteLine($"number_shr_pos = {number_shr_pos}");

//int - 4 байт (Значения: [-2147483648; 2147483647]). Аналог: System.Int32
int number_int = 34; // Так создается переменная с целочисленым типом данных
Console.WriteLine($"number_int = {number_int}"); 

//uint - 4 байт (Значения: [ 0; 4294967295]). Аналог: System.UInt32
uint number_int_pos = 34; // Так создается переменная с целочисленым типом данных
Console.WriteLine($"number_int_pos = {number_int_pos}");


// long - 8 байт (Значения: [-9223372036854775808 до 9223372036854775807]). Аналог: System.Int64
long number_lng = 908; // Так создается переменная с целочисленым типом данных
Console.WriteLine($"number_lng = {number_lng}");

//ulong - 8 байт (Значения: [0; 18446744073709551615]). Аналог: System.UInt64
ulong number_lng_pos = 98; // Так создается переменная с целочисленым типом данных
Console.WriteLine($"number_lng_pos = {number_lng_pos}");


//Int128 - 16 байт 
System.Int128 number_128 = 4; // Так создается переменная с целочисленым типом данных
Console.WriteLine($"number_128 = {number_128}");
//UInt128 - 16 байт 
System.UInt128 number_128_pos = 89; // Так создается переменная с целочисленым типом данных
Console.WriteLine($"number_128_pos = {number_128_pos}");


// Целые числа в двоичной системе счисления
int number = 0b110; // Получение числа из двоичной системы счисления 
Console.WriteLine($"0b100 = {number}");
int neg_number = -0b110; 
Console.WriteLine($"-0b100 = {neg_number}");
