



class Human{
    protected string name; 

    /* Создаем виртуальное свойство 
        (чтобы потом переопределить его в производном классе)*/
    protected virtual char name_company{set; get;} // Создаем свойство которое будем переопределять

    public Human(string name, char name_company){
        this.name = name;
        this.name_company = name_company; 
    }

    public virtual void print(){ // Метод который будем переопределять
        Console.WriteLine($"this.number = {this.name}");
    }
}


/* При переопределении виртуальных атрибутов в дочерних классах необходимо
    использовать модификатор override (данная операция называется переопределение). 
Данный модификатор переопределяет виртуальный атрибут базового класса 
Модификатор override можно использовать для  методов, свойств


Отличие от сокрытия атрибутов заключается в том что выборка 
    атрибута зависит от типа данных обьекта который находится в 
    оперативной памяти, а не от типа переменной
*/


class Company: Human{

    /* Перегружаем виртуальное свойство */
    protected override char name_company{set; get;} = '0'; // Переопределяем свойство

    public Company(string name, char name_company): base(name, name_company){}


    public override void print(){ // Переопределяем метод
        /*
        Конструкция для вызова базовых методов:
            base."метод базового класса"("аргументы для метода")
        */
        base.print(); // вызываем метод print у базового класса (Human)
        Console.WriteLine($"Name(Company): {this.name}\tCompany: {this.name_company}"); 
    }
}


class Program{
    public static void Main(){ 
        Human obj = new Human("Mickle", '0'); // Переменная базового класса
        obj.print(); // Вызываем базовый метод

        Console.WriteLine("Создание нового обьекта"); 

        Company obj2 = new Company("Bob", 'M'); // Переменная производного класса
        obj2.print(); // Вызываем метод производного класса

        Human obj3 = new Company("Muchel", 'c'); 
        // Переменная базового класса которая ссылается на обьект произодного класса
        obj3.print(); 
        // Будет использован метод класса Company (потому что метод print виртуальный)
    }
}
