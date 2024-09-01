﻿



/*
Подключить пространтсва имен можно с помощью следующей конструкции:
    using "имя пространства имен"; 

Данная конструкция позволяет содержимое пространства имен 
    переместить в глобальное пространство имен 

Если возможен конфликт между именами - не использовать
*/
using my_space;
// Все что было в my_space попадает в глобальное пространство имен
// Подключать my_space2 не будем из-за конфликта с именем Test




/*
Пространство имен - необходимо для того чтобы чтобы организовать среду в 
    которой каждому имени бутет соответствовать свое уникальное значение

Конструкция:
    namespace "имя пространства имен"{
        "Классы/структуры которые хотим поместить в пространство имен"
    }

Пространтства имен необходимы для того чтобы избежать конфликты имен
*/

namespace my_space{
class Test{
    public void print(){Console.WriteLine("Вызов следующего: my_space.Test.print");}
}
}

/* 
Объявление нового пространства имен 
    (благодаря пространствам имен был решен конфлик имен с Test)

Теперь в прогрмме есть 2 класса Test которые находятся в 
    разных пространствах имен
*/
namespace my_space2{
class Test{
    public void print(){Console.WriteLine("Вызов следующего: my_space2.Test.print");}
}
}



// Добавление новых элементов к пространству имен my_space
namespace my_space{
// В пространство имен можно также вложить другое пространство имен
namespace my{
class Test2{
    public void print(){Console.WriteLine("Вызов следующего: my_space.my.Test2.print");}
}


}
}




class Program{
    public static void Main(){
        // Работа с содержимым области имен my_space
        Test obj1_1 = new Test(); 
        // Допустимо писать и так: my_space.Test obj1_1 = new my_space.Test()
        obj1_1.print();
        my_space.my.Test2 obj1_2 = new my_space.my.Test2(); 
        /* 
        Для того чтобы писать без my_space.my нужно 
            использовать пространство имен my_space.my
        */
        obj1_2.print();

        
        // Работа с содержимым области имен my_space2
        my_space2.Test obj2 = new my_space2.Test(); 
        obj2.print();
    }
}