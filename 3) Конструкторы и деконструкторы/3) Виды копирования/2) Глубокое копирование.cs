



class Test{
    public string name{set; get;} 

    public Test(string name){this.name = name; }

    public Test(in Test obj){this.name = obj.name;}

    public override string ToString(){return $"{this.name}";}
}


class My_class: ICloneable{
    // Элементарный тип данных который хранится в стеке (значение)
    public int number = 0;

    // Ссылочный тип данных который хранится в куче (объект)
    public Test obj; 

    public My_class(int number, Test obj){
        this.number = number;
        this.obj = obj;  
    }

    /* Копирование глубокого уровня 
        (работает c обьектами имеющие сложные поля)
    Для обьектов имеющие элементарные поля будет работать хуже.
    При таком копировании обьекты классов будут иметь атрибуты которые будут 
        ссылатся на разные адресса в памяти
    */
    public My_class(in My_class self){
        // this.number - элементарный тип, this.obj - сложный тип
        this.number = self.number;
        this.obj =  new Test(self.obj);  
    }

    // Перегружаем метод копирования
    public object Clone(){
        return new My_class(this); 
    }

    public override string ToString(){
        return $"[number = {this.number}, obj = {this.obj}]"; 
    }
}

/*
Выбор конструктора копирования:
    Если класс имеет только элементарные типы данных -> Нужно использовать 
        поверхностное копирование
    Если класс имеет только сложные типы данных -> Нужно использовать 
        глубокое копирование
    Если в классе есть одновременно элементарные и сложные типы данных то нужно 
        комбинировать виды копирования 
*/

class Program{
    public static void Main(){
        Console.WriteLine("Копируем обьекты с помощью глубокого копирования");
        
        My_class new_class1 = new My_class(10, new Test("some inform")); 
        My_class new_class2 = (My_class)new_class1.Clone();

        // Меняем значения для полей 
        new_class2.number = 78; // изменется только у new_class2 (тип элементарный)
        // изменется только у new_class2 (так как применено глубокое копирование)
        new_class2.obj.name = "new inform";

        Console.WriteLine($"new_class1 = {new_class1}"); 
        Console.WriteLine($"new_class2 = {new_class2}"); 
    }
}