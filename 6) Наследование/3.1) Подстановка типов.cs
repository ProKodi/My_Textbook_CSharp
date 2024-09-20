



class My_class{
    private int number;
    public My_class(int number){this.number = number;}
    public int get_number(){return this.number;}
};



class My_super_class: My_class{
    private string inform = "None";

    public My_super_class(int number, string inform): base(number){
        this.inform = inform;
    }

    public void show_iform(){
        Console.WriteLine($"number = {this.get_number()}");
        Console.WriteLine($"inform = {this.inform}");
    }
};


class Program{
    public static void Main(){
        /* Понятия ковариантности и контравариантности связаны с возможностью 
        использовать в приложении вместо некоторого типа другой тип, 
        который находится ниже или выше в иерархии наследования.
        Имеется три возможных варианта поведения:
            1) Ковариантность: позволяет использовать более конкретный тип, 
                чем заданный изначально
            2) Контравариантность: позволяет использовать более универсальный 
                тип, чем заданный изначально
            3) Инвариантность: позволяет использовать только заданный тип
        
        */
        // Инвариантность (использует тот тип которым является сам обьект)
        My_super_class new_good_class = new My_super_class(5, "good inform");

        // Контравариантность (используем более общий тип чем изначально) 
        // Данный процесс называется Upcasting (My_super_class -> My_class)
        My_class obj = new_good_class; 

        // Ковариантность (используем более конкретный тип чем изначально)
        // Данный процесс называется Downcasting (My_class -> My_super_class)
        My_super_class new_inform; 
        if (obj is My_super_class temp){
            new_inform = temp; 
        }
    }
}