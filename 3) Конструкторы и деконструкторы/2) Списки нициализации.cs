



/*
Списки инициализации необходимы для того чтобы через один конструктор можно было 
    вызвать другой конструктор этого-же класса/структуры.
Списки инициализации перечисляются через двоеточие после списка параметров конструктора
Конструкция:
        "конструктор": this("значения которые мы хотим передать в другой конструктор этого же класса/структуры"){
        "код конструктора"
    }
*/


class My_class{
private int number = 0; 

public My_class(int number){
        Console.WriteLine("Работает конструктор с 1 параметром (класс)"); 
        this.number = number;
    }

    // Список инициализации, который вызывает другой конструктор этого класса
public My_class(My_class obj): this(obj.number){
        Console.WriteLine("Работает конструктор копирования (класс)"); 
    }

}


struct My_struct{
private int number = 0; 

public My_struct(int number){
        Console.WriteLine("Работает конструктор с 1 параметром (структура)"); 
        this.number = number;
    }

    // Список инициализации, который вызывает другой конструктор этой структуры
public My_struct(My_struct obj): this(obj.number){
        Console.WriteLine("Работает конструктор копирования (структура)"); 
    }
}


class Program{
    public static void Main(){
        // Создаем обьект с 1 аргументом для инициализации
        My_class new_class1 = new My_class(10); 
        // Создаем обьект с помощью конструктора копирования
        My_class new_class2 = new My_class(new_class1);

        
        // Создаем значение с 1 аргументом для инициализации
        My_struct ogk1 = new My_struct(10); 
        // Создаем значение с помощью конструктора копирования
        My_struct ogk2 = new My_struct(ogk1);
    }

}