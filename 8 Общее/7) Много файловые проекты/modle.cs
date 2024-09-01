



/*
Файл модуль
Тут будет реализован какой-то код 
*/


namespace Modle; 
/* 
Данная деректива указывает что все содержимое будет в области имен Modle
Конечно данную дерективу можно не использовать, 
    но это может привести к конфликту имен
*/


// Обьявляем класс в модуле 
class Test{
    public void print(){
        Console.WriteLine("Вывод через Modle.Test.print");
        (new Test_private()).print(); 
        // Вызываем метод print из класса Test_private
    }
}

// Класс который доступен только в файле модуля
file class Test_private{
    public void print(){
        Console.WriteLine("Вывод через Modle.Test_private.print");
    }
}