﻿



/*
При вызове функции программа должна определять, 
    с какой именно реализацией функции соотносить этот вызов, то есть связать вызов функции с самой функцией. 
В С# есть два типа связывания - статическое и динамическое:
    1) статическое/раннее связывание -  когда вызов функций фиксируются до выполнения программы на этапе компиляции
        (выбор интерфейса осуществляется по типу переменной, а не по обьекту в памяти). 
    2) динамическое/позднее связывание - позволяет на этапе выполнения решать, метод какого типа вызвать 
        (выбор интерфейса осуществляется не по типу переменной, а по обьекту в памяти). 

Виртуальные функции обьявляются в классе и имеют модификатор virtual.
Отличие от переопределения в том, что выбор метода для виртуальных методов осуществляется на этапе выполнения 
    (когда уже известен тип обьекта)
Виртуальный метод должен быть обьявлен в родительском классе. 
Если мы хотим переопределить базовый виртуальный метод, на дочерний виртуальный метод, 
    то вместо модификатора virtual необходимо писать модификатор override

Правила:
    1) Виртуальные методы наследуются (их можно переопределять)
    2) если виртуальный метод переопределен в производном классе, то обьекты 
        этого класса могут получить доступ к варианту метода базового класса с помощью видимости
    3) Виртуальный метод не может быть статическим 
*/


class Human{
    protected string name;

    public Human(string name){
        this.name = name;
    }
    // Метод для отображения информации в консоли
    public virtual void print(){ // Создаем вирутальный метод
        Console.WriteLine($"Name: {this.name}");
    }
};


class Company: Human{
    protected string name_company; 
    public Company(string name, string name_company): base(name){
        this.name_company = name_company;
    }

    // Метод для отображения информации в консоли 
    public override void print(){ // Перегружаем базовый метод print
        Console.WriteLine($"""Name: {this.name};""" +
        $"""Company: {this.name_company}"""); 
    }
};


class Program{
    public static void Main(){
        // Обьявляем обьект 
        Human obj = new Human("Mickle"); 

        // Выводим информацию
        obj.print(); 
        /* Будет выбран интерфейс класса Human, так как переменная ссылается
            именно на обьект этого типа данных 
        По итогу будет вызван метод класса Human
        */

        // Ссылаем переменную на обьект типа Company
        obj = new Company("Bob", "My company"); 
        obj.print(); 
        /* Будет выбран интерфейс класса Company, так как переменная ссылается
            именно на обьект этого типа данных 
            (даже не смотря на то что тип переменной - Human)
        По итогу будет вызван метод класса Company
        */
    }
}