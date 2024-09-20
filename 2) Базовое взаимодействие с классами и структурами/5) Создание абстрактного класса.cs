



/*
Абстрактные классы - классы которые описывают сущностей которые не 
    могут иметь конкретной реализации. 
В основном данные классы используют для выделить что-то общее между сущьностями
    (может иметь атрибуты)
Абстрактный класс не предпологает создание экземпляров. 


Для создания абстрактного класса необходимо использовать следующую конструкцию:
    abstract class "название класса"{"реализация класса"}
*/

// Создаем абстрактный класс
abstract class Animal{
    // Создаем поле абстрактному классу
    protected string type_name = ""; 

    // Создаем метод
    public void print(){
        Console.WriteLine(this.stri());
    }

    // Создаем абстрактный метод 
    public abstract string stri(); 
}

/*Создаем класс на основе абстрактного класса 
    (пока не будут реализованны все абстрактные методы - будет ошибка)
Если какие-то методы абстрактного не будут реализованны в Cat, 
    то Cat станет абстрактным классом*/
class Cat: Animal{
    protected string name;

    public Cat(string name){
        base.type_name = "cat";
        this.name = name;
    }
    
    // Если данный метод не будет реализован, то будет ошибка (так как класс будет абстрактным)
    public override string stri(){
        return $"Name: {this.name}; Type: {this.type_name}";
    }
}



class Program{
    public static void Main(){ 
        Console.WriteLine("Работа через класс Cat");
        Cat my_cat = new Cat("Milka");  
        my_cat.print();

        Console.WriteLine("Работа через класс Animal");
        Animal my_animal = my_cat;  
        my_animal.print();

        // Animal my_animal2 = new Animal(); // Ошибка
    }
}

