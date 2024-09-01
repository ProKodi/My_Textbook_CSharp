



/* Коментарий к функции */
void my_fun(int number_1, int number_2){
    // Локальные функции - функции которые определены в другой функции
    
    /* Коментарий к локальной функции */
    void print_number_1(int number_1){
        Console.Write($"number_1 = {number_1} ");
        /* Так как функция не статическая, то мы можем использовать 
            параметры которые не пренадлежат этой функции */
        // Console.Write($"number_2 = {number_2}"); 
        // Ошибки не будет
    }

    /* Коментарий к локальной статической функции */
    static void print_number_2(int number_2){
        Console.Write($"number_2 = {number_2} \n");
        // Console.Write($"number_1 = {number_1}"); 
        /* Будет ошибка так как это статическая функция и она работает 
            только с теми аргументами которые ей передали */
    }

    print_number_1(number_1); 
    print_number_2(number_1); 
}


my_fun(7, 8); 