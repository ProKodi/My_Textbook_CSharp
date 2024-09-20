



/*
Любой класс или структура наследуют от Object такой метод как Equals
Данный метод необходим для сравнения 2 экземпляров.
Для оптимизации вместе с сравнением используется также и хеширование (GetHashCode)
*/


class My_class{
    private int number = 0; 
    private string inform = "";


    public My_class(int number, string inform){
        this.number = number;
        this.inform = inform;
    }

    /* Хеширование экземпляра*/
    public override int GetHashCode(){
        int res = this.number.GetHashCode(); 
        int res1 = this.inform.GetHashCode(); 
        int res_xor = (res ^ res1); 
        return res_xor; 
    }

    /* Данный метод используется для сравнения экземпляров на равенство 
        Данный метод является виртуальным.
        Для его работы необходимо данный метод перегрузить (использовать модификатор override)
        Данный метод обязательно должен возвращать логическую переменную (bool).
        Данный метод имеет 1 аргумет (в данный аргумет помещается сравниваемый экземпляр)*/
    public override bool Equals(object? obj){
        // Если объект ссылается на пустое значение
        if (obj == null){return false;}

        // Если обьект не является нужным нам типом
        if (obj is not My_class){return false;}

        // Если у обьектов не совпадают хеш коды
        if (this.GetHashCode() != obj.GetHashCode()){return false;}


        My_class temp = (My_class)obj; 
        // Приводим сравниваемый экземпляр к нужному типу данных 

        // Если все проверки пройдены, то начинаем проверять поля на равенство
        if ((this.number == temp.number) && (this.inform == temp.inform)){return true; }

        // Если последняя проверка по полям не была пройдена
        return false;
    }


}


class Program{
    public static void Main(){ 
        My_class temp1 = new My_class(34, "some inform");

        object temp2 = new My_class(34, "some inform");

        Console.WriteLine($"temp1 is equals temp2 = {temp1.Equals(temp2)}");
        // Экземпляры одинаковые
        Console.WriteLine($"temp2 is equals temp1 = {temp2.Equals(temp1)}");
        // Экземпляры одинаковые

        My_class temp3 = new My_class(33, "some inform");

        Console.WriteLine($"temp1 is equals temp3 = {temp1.Equals(temp3)}");
        // Экземпляры не одинаковые

        object temp4 = 87;
        Console.WriteLine($"temp1 is equals temp4 = {temp1.Equals(temp4)}");
        // Экземпляры не одинаковые


        My_class? temp5 = null;
        Console.WriteLine($"temp1 is equals temp5 = {temp1.Equals(temp5)}");
        // Экземпляры не одинаковые

        /*
        Хеш код совпадет только у temp1 и temp2 так как данные обьекты одинаковы
        */
    }
}

