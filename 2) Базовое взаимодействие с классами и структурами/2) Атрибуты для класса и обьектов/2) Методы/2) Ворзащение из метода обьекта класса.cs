



// Самописный класс
class My_class{
public int te = 0;  

// Метод возращающий обьект класса
public My_class get_copi(){
        My_class obj = new My_class();
        obj.te = this.te + 1; 
        return obj;
    }
}


class Program{
    public static void Main(){
        My_class new_class = new My_class(); 
        Console.WriteLine($"До копирования (класс): {new_class.te}");
        My_class new_obj = new_class.get_copi();
        Console.WriteLine($"После копирования (класс): {new_obj.te}");
    }
}
