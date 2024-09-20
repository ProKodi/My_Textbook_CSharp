



/*
Любой класс или структура наследуют от Object такой метод как GetHashCode
Данный метод вызывается перед сравнением экземпляров.
Если хеш двух экземпляров совпал то сравнение происходит дальше, 
    если же нет то сравнение заканчивается тем что два обьекта не равны
*/


class My_class{
    private int number = 0; 
    private string inform = "";


    public My_class(int number, string inform){
        this.number = number;
        this.inform = inform;
    }

    /* Данный метод используется перед сравнением экземпляра на равенство 
        Данный метод является виртуальным.
        Для его работы необходимо данный метод перегрузить (использовать модификатор override)
        Данный метод обязательно должен возращать число. 
        Так же данный метод не имеет аргументов*/
    public override int GetHashCode(){
        /* Для того чтобы получить значения хеша для экземпляра необходимо:
            1) получить хеш всех полей 
            2) после данный хеш пропустить через функцию xor
            3) Вернуть результат функции xor
        Так же нужно помнить что статические поля не должны участвовать в хешировании 
            (так как данное поле будет у всех экземпляров одинаковое)
        */
        int res = this.number.GetHashCode(); 
        // Получаем хеш код 1 поля
        int res1 = this.inform.GetHashCode(); 
        // Получаем хеш код 2 поля
        int res_xor = (res ^ res1); 
        // Пропускаем хеш коды через xor и получаем результат
        return res_xor; 
    }
}


class Program{
    public static void Main(){ 
        My_class temp1 = new My_class(34, "some inform");
        Console.WriteLine($"temp1 has hashcode = {temp1.GetHashCode()}");

        My_class temp2 = new My_class(34, "some inform");
        Console.WriteLine($"temp2 has hashcode = {temp2.GetHashCode()}");

        My_class temp3 = new My_class(33, "some inform");
        Console.WriteLine($"temp3 has hashcode = {temp3.GetHashCode()}");

        My_class temp4 = new My_class(34, "good inform");
        Console.WriteLine($"temp4 has hashcode = {temp4.GetHashCode()}");

        My_class temp5 = new My_class(33, "good inform");
        Console.WriteLine($"temp5 has hashcode = {temp5.GetHashCode()}");

        /*
        Хеш код совпадет только у temp1 и temp2 так как данные обьекты одинаковы
        */
    }
}

