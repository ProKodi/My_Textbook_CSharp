



/*
Итерфейсы так же как и классы могут быть обобщеными (шаблон интерфейса)
Наследование между обобщеными интерфейсами аналогично наследованию 
    между обобщеными классами
*/


interface IMy_class<Type1>{
    // Создание шаблонного свойства 
    public Type1 number{get; set;}
    
    public void print();
}

/* Реализация обобщеного интерфейса
Реализация обобщеного интерфейса происходит точно так же как и наследование
    между обобщеными классами
*/
class My_class<Type1>:IMy_class<Type1>{
    // Создание шаблонного свойства 
    public Type1 number{get; set;}

    public My_class(Type1 number){this.number = number;}

    public void print(){
        Console.WriteLine($"number = {this.number}");
    }
}




class Program{
    public static void Main(){
        IMy_class<int> obj = new My_class<int>(123);
        obj.print();
        IMy_class<float> obj1 = new My_class<float>(13.87f);
        obj1.print();
    }
}