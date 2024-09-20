



interface IMy_class{
    public const int number = 5; 
    public static int snumber = 10;
    public void print_number(); 
    public void print(){Console.WriteLine($"IMy_class.print. snumber = {IMy_class.snumber}");}
    public string Name{get; set;}
    public delegate void Print_name(); 
    public event Print_name MoveEvent;
}


/*
Реализация интерфейса: 
С помощью реализации интерфейсов можно добится того что классы реализующие
    интерфейсы, будут иметь реализацию методов которые есть в интерфейсе
Класс должен реализовать все атрибуты которые есть в интерфейсе. 
    Иначе будет ошиба
Можно не реализовывать все атрибуты из интерфейсы, только класс 
    нужно будет сделать абстрактным, а не реализованные атрибуты интерфейса 
    обьявить в абстрактном классе абстрактными атрибутами

Конструкция для реализации интерфейсов:
    class "название класса": "интерфейсы которые хотим реализовать (через ,)"{
        "реализация класса"
    }
Если класс еще наследуется от другого класса, то этот класс должен 
    быть перед интерфейсами
*/

// Частичная реализация интерфейса
abstract class AMy_class: IMy_class{
    // Данный атрибут делаем абстрактным так как он не реализован
    public abstract void print_number();

    // Реализуем свойство Name из интерфейса IMy_class
    public string Name{get; set;} = "";

    // Данный атрибут делаем абстрактным так как он не реализован
    public abstract event IMy_class.Print_name MoveEvent; 
}



// Полная реализация интерфейса
class My_class: IMy_class{
    public My_class(){
        // Ссылаем событие на функцию
        this.MoveEvent = delegate(){
            Console.WriteLine($"Name = {this.Name}");
        };
    }

    // Реализуем метод print_number из интерфейса IMy_class
    public void print_number(){
        Console.WriteLine($"snumber = {IMy_class.snumber}"); 
        this.MoveEvent(); 
    }

    // Реализуем свойство Name из интерфейса IMy_class
    public string Name{get; set;} = "";

    // Реализуем событие MoveEvent из интерфейса IMy_class
    public event IMy_class.Print_name MoveEvent; 
}


class Program{
    public static void Main(){
        // Работа с обьектом класса My_class через интерфейс IMy_class
        IMy_class obj = new My_class();
        obj.Name = "Some inform"; 
        obj.print_number(); 
        obj.print(); 
        
    }
}