



/*
Перегрузка операторов (operator overloading) позволяет определить 
    для объектов классов втроенные операторы, такие как +, -, * и т.д.

Для определения оператора для объектов своего класса, необходимо 
    определить функцию следующей конструкции:

    public static "что возращает функция" operator "перегружаемый оператор"("аргументы"){
        "реализация"
    }



Перегрузить можно только те операторы, которые уже определены в C#. 
Создать новые операторы нельзя. 
Также нельзя изменить количество операндов, их ассоциативность, приоритет.

Переопределить можно следующие операции:
Унарные операторы:
    +x, -x, !x, ~x, ++, --, true, false  
// (true, false) нужно перегружать парой

Бинарные операторы:
    +, -, *, /, %, 

Поразрядные операторы:
    &, |, ^, <<, >>, >>>

Операции сравнения:
    ==, !=, <, >, <=, >=
// (==, !=), (<, >), (<=, >=) нужно перегружать парой

Все остальные операторы перегрузить нельзя
*/


class My_class{
    private int number = 0; 

    public My_class(int number){
        this.number = number;
    }

    public static bool operator true(My_class obj){
        return obj.number > 0; 
    }

    public static bool operator false(My_class obj){
        return obj.number <= 0; 
    }

    public static bool operator !(My_class obj){
        if (obj){return false;} // Если обьект правдивый
        return true; 
    }

    public static My_class operator +(My_class obj, int number){
        return new My_class(obj.number + number); 
    }

    public static My_class operator -(My_class obj, int number){
        return new My_class(obj.number - number); 
    }

    public override string ToString(){
        return this.number.ToString();
    }

}



class Program{
    public static void Main(){
        My_class tem1 = new My_class(0); 
        Console.WriteLine($"tem1 = {tem1}"); 

        tem1 += 3; // Тут используется операция + (а += неявно перегружена)
        Console.WriteLine($"tem1 = {tem1}"); 

        if (tem1){ // тут вызывается оператор true/false
            Console.WriteLine("tem1 true"); 
        }

        tem1 -= 4; // Тут используется операция - (а -= неявно перегружена)
        Console.WriteLine($"tem1 = {tem1}"); 

        if (!tem1){ // тут вызывается оператор !
            Console.WriteLine("tem1 false"); 
        }
    }
}