



/* Сорировка обьектов
Для массивов можно использовать можно использовать следующую конструкцию 
которая отвортирует массив:
    Array.Sort("название массива");

Для того чтобы данная конструкция работала для собственых классов, 
    необходимо чтобы был создан класс-компоратор который реализует 
    интерфейс IComparer и его метод Compare
*/


class My_classCompare: IComparer<My_class>{

    /*
    Метод Compare предназначен для двух объектов, 
        которыt передаются в качестве параметров. 
    На выходе он возвращает целое число, которое может иметь одно из трех значений:
        1) Меньше нуля. Значит, 1 объект должен находиться перед объектом 2
        2) Равен нулю. Значит, оба объекта равны
        3) Больше нуля. Значит, 1 объект должен находиться после 2 объекта
    */
    public int Compare(My_class? other1, My_class? other2){
        if ((other1 == null) || (other2 == null)){
            throw new ArgumentException("Некорректное значение параметра");
        }
        // Здесь идет сравнение по полю name
        return other1.name.CompareTo(other2.name);
    }
}


class My_class{
    public int number = 0; 
    public string name = ""; 

    public My_class(string name, int number){
        this.number = number;
        this.name = name; 
    }


    public override string ToString(){
        return $"[name = {this.name}, number = {this.number}]"; 
    }
}



class Program{
    public static void Main(){
        // Создаем массив 
        My_class[] arr = {new My_class("Tom", 37), new My_class("Bob", 41), 
            new My_class("Sam", 25), new My_class("Bob", 41), new My_class("Tom", 37)
        }; 

        /* Сортируем массив (в метод добавляем созданный копроратор)
        Правила сортировки установленные компоратором имеют 
            более высокий приоритет чем все остальное
        */
        Array.Sort(arr, new My_classCompare());

        // Выводим массив
        foreach (My_class obj in arr){
            Console.WriteLine(obj); 
        }
    }
}