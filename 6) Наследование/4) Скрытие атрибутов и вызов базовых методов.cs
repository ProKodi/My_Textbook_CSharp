



class Human{
    protected string name; // Поле которое будем скрывать
    protected char name_company{set; get;} // Создаем свойство которое будем скрывать


    public Human(string name, char name_company){
        this.name = name;
        this.name_company = name_company; 
    }

    // Метод для отображения информации в консоли
    public void print(){  // Метод который будем скрывать
        Console.WriteLine($"Name(Human): {this.name}");
    }
};


/* При переопределении не виртуальных атрибутов в дочерних классах необходимо
    использовать модификатор new (данная операция называется скрытие). 
Данный модификатор скрывает атрибуты базового класса, который мы перегружаем
Модификатор new можно использовать для полей, методов, свойств

Стоить помнить что при скрытитии базовых полей в дочернем классе, 
    базовые поля остаются (их так же нужно инициализировать) + 
    создаются новые поля в производном классе

Отличие от перегрузки виртулаьных атрибутов заключается в том что выборка 
    атрибута зависит не от типа данных обьекта который находится в 
    оперативной памяти, а от типа переменной
*/

class Company: Human{
    private new string name; // Скрываем поле
    protected new string name_company{set; get;} = ""; // Скрываем свойство
    public Company(string name, string name_company): base(name, name_company[0]){
        this.name = name + " Job"; 
        this.name_company = name_company;
    }

    public new void print(){ // Скрываем метод
        /*
        Конструкция для вызова базовых методов:
            base."метод базового класса"("аргументы для метода")
        */
        base.print(); // вызываем метод print у базового класса (Human)
        Console.WriteLine($"Name(Company): {this.name}\tCompany: {this.name_company}"); 
    }
};


class Program{
    public static void Main(){
        Human obj = new Human("Mickle", '0'); // Переменная базового класса
        obj.print(); // Вызываем базовый метод

        Console.WriteLine("Создание нового обьекта"); 

        Company obj2 = new Company("Bob", "My company"); // Переменная производного класса
        obj2.print(); // Вызываем метод производного класса

        Human obj3 = new Company("Muchel", "My company"); 
        // Переменная базового класса которая ссылается на обьект произодного класса
        obj3.print(); 
        // Будет использован метод класса Human (потому что метод print не виртуальный)
    }
}