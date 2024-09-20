



class My_class{
    protected int number = 0; 
    public My_class(int number){this.number = number;}
    public virtual void print(){
        Console.WriteLine($"this.number = {this.number}");
    }
}


class My_super_class: My_class{
    protected int number2; 
    public My_super_class(int number, int number2): base(number){
        this.number2 = number2;
    }
    public override sealed void print(){ 
        // При наследовании от класса My_super_class, 
        //    метод print переопределить будет нельзя
        // Для свойств все будет идентично
        Console.WriteLine($"this.number = {this.number}, this.number2 = {this.number2}");
    }
}


class Program{
    public static void Main(){ 
        // Создаем базовый класс с свойством
        My_class temp = new My_class(-56);
        temp.print();

        // Создаем производный класс с перегруженным свойством
        My_super_class temp2 = new My_super_class(-72, 43);
        temp2.print();
    }
}

