



interface Inter1{
    public void print(){
        Console.WriteLine("Work Inter1.print");
    }
}

// Наследование интерфейсом интерфейса
interface Inter2: Inter1{
    // Скрываем метод print от интерфейса Inter1
    public new void print(){
        Console.WriteLine("Work Inter2.print");
    }

    // Добаывляем новый метод
    public void print2();
}


// Реализация интерфейсов
class My_class: Inter2{
    private int number = 0; 

    public My_class(int number){
        // Ссылаем поле number текущего объекта на новое значение
        this.number = number;
    }

    public void print2(){
        Console.WriteLine($"number = {this.number}"); 
    }
}
/*
В интерфейсах, так же как и в классах можно переопределять и скрывать атрибуты 
    (для интерфейсов все аналочино тому как это работает в классах)
*/


class Program{
    public static void Main(){
        Inter2 obj = new My_class(123);
        obj.print();
        obj.print2();
    }
}