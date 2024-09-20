



class My_class{
private int number;

public My_class(int number){
        this.number = number;
    }

public int get_number(){return this.number;}
};



class My_super_class: My_class{
private string inform = "None";

    /* Обьявление конструкторов для классов наследников 
        с использованием конструкторов родительских классов
    Конструкция:
        "конструктор дочернего класса": base("данные для базового конструктора"){
            "Реализация конструктор дочернего класса"
        }
    */
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
        My_super_class new_good_class = new My_super_class(5, "good inform");

        new_good_class.show_iform();
    }
}