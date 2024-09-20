



delegate void Fun_print(int arg);


class Program{
    public static void Main(){
        /*
        Анонимные функции - функции которые создаются с помощью делигата
        Конструкция:
            "объявляем обьект делигата" = delegate(параметры){"код функции"};
        С анонимными функциями можно делать все тоже, что и с делегатами
        */


        // Обьявляем обьект делегата ссылающевося на анонимную функцию
        Fun_print message1 = delegate(int number){
            Console.WriteLine($"number = {number}");
        };

        // Вызываем делигат с анонимной функцией
        message1(456);
    }
}
