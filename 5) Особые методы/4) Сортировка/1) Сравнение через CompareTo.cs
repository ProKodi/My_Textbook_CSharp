



/* Сорировка обьектов
Для массивов можно использовать можно использовать следующую конструкцию 
которая отвортирует массив:
    Array.Sort("название массива");
Для того чтобы данная конструкция работала для собственых классов, 
    необходимо чтобы собственный класс реализовывал интерфейс IComparable
    и его метод CompareTo
*/


class My_class: IComparable<My_class>{
    private int number = 0; 
    private string name = ""; 

    public My_class(string name, int number){
        this.number = number;
        this.name = name; 
    }

    /*
    Метод CompareTo предназначен для сравнения текущего объекта с объектом, 
        который передается в качестве параметра. 
    На выходе он возвращает целое число, которое может иметь одно из трех значений:
        1) Меньше нуля. Значит, текущий объект должен находиться перед объектом,
            который передается в качестве параметра
        2) Равен нулю. Значит, оба объекта равны
        3) Больше нуля. Значит, текущий объект должен находиться после объекта,
            передаваемого в качестве параметра
    */
    public int CompareTo(My_class? other){
        // Проверки
        if (other == null){throw new ArgumentException("Некорректное значение параметра");}
        // Здесь идет сравнение по полю name
        return this.name.CompareTo(other.name);
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

        // Сортируем массив
        Array.Sort(arr);

        // Выводим массив
        foreach (My_class obj in arr){
            Console.WriteLine(obj); 
        }
    }
}