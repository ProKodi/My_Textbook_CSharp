



class My_class{
protected int number2 = 70; // Какое-то поле класса

protected int get_number2(){ // Какое-то метод класса
        return this.number2;
    }

public int number = 7; // Какое-то поле класса
public int get_number(){ // Какое-то метод класса
        return this.number;
    }
};


/* Конструкция наследования:
class "Имя класса наследника": "Имя класса родителя"{
    "реализация класса наследника"
}

Данная конструкция может из класса родителя вытянуть поля protected, public
    (private будет наследоватся, но не будет доступна) 
При наследовании методы и атрибуты из класса родителя можно использовать 
    только в классе наследнике

Наследовать можно только один класс. 

При создании производного класса надо учитывать тип доступа к базовому классу -
    тип доступа к производному классу должен быть таким же, как и у базового класса, или более строгим. 
То есть, если базовый класс у нас имеет тип доступа internal, 
    то производный класс может иметь тип доступа internal или private, но не public.

Если класс объявлен с модификатором sealed, то от этого класса нельзя наследовать 
    и создавать производные классы. 
    
Нельзя унаследовать класс от статического класса.
*/

class My_super_class: My_class{
public
    void show_iform(){
        Console.WriteLine($"number = {this.get_number()}"); 
        Console.WriteLine($"number2 = {this.get_number2()}"); 
    }
};



class Program{
    public static void Main(){
        My_super_class new_class = new My_super_class();
        new_class.show_iform();
    }
}