



// Использование перечислений в функциях
void fun(My_type obj){
    switch (obj){
        case My_type.int_1:
            Console.WriteLine($"Select int_1. int_1 = {obj}"); 
            break;
        case My_type.int_2:
            Console.WriteLine($"Select int_2. int_2 = {obj}"); 
            break;
        case My_type.int_3:
            Console.WriteLine($"Select int_3. int_3 = {obj}"); 
            break;
    }
}

// Передаем перечисляемый тип в функцию
fun(My_type.int_1);
fun(My_type.int_2);
fun(My_type.int_3);



// Создаем перечисляемый тип
enum My_type{int_1 = 1, int_2/*= 2*/, int_3/*= 3*/}
