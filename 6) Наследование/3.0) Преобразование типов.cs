



class My_class{
private int number;

public My_class(int number){
        this.number = number;
    }

public int get_number(){return this.number;}
};



class My_super_class: My_class{
private string inform = "None";

    /* Обьявление конструкторов для классов наследников 
        с использованием конструкторов родительских классов
    Конструкция:
        "конструктор дочернего класса": base("данные для базового конструктора"){
            "Реализация конструктор дочернего класса"
        }
    */
    public My_super_class(int number, string inform): base(number){
        this.inform = inform;
    }

    public void show_iform(){
        Console.WriteLine($"number = {this.get_number()}");
        Console.WriteLine($"inform = {this.inform}");
    }
};


class Program{
    public static void Main(){
        {
            Console.WriteLine("До преобразования типов");
            My_super_class new_good_class = new My_super_class(5, "good inform");
            new_good_class.show_iform();

            /* Upcasting - процесс при котором дочерний обьект приводят к базовому типу
            Благодаря тому что дочерний класс содержит в своем составе базовый класс,
                Upcasting происходит без явного указания типов
            */
            Console.WriteLine("После upcasting");
            // Upcasting (My_super_class -> My_class)
            My_class obj = new_good_class; 
            Console.WriteLine($"number = {obj.get_number()}");


            /* Downcasting - процесс при котором базовый обьект приводят к дочернему типу
            Без явных преобразований не обойтись, так как базовый обьект 
                не может быть переделан в дочерний обьект по умолчанию 
                (для решения этой проблемы нужно использовать конструктор дочернего класса)
            */
            Console.WriteLine("После downcasting");
            // Downcasting (My_class -> My_super_class)
            My_super_class new_inform = new My_super_class(obj.get_number(), "new inform"); 
            new_inform.show_iform();
        }

        {
            Console.WriteLine("Преобразования типов через as");

            My_super_class new_good_class = new My_super_class(5, "good inform");
            new_good_class.show_iform();

            /* 
            Для преобразования типов можно использовать as
            В случае не удачной попытки преобразования вернет null
            Конструкция:
                "переменная с желаемым типом данных + ?" = "переменная у которой преобразуем тип" as "желаемый тип данных"
            */

            Console.WriteLine("После upcasting");
            // Upcasting (My_super_class -> My_class)
            My_class obj = (new_good_class as My_class); 
            Console.WriteLine($"number = {obj.get_number()}");

            Console.WriteLine("После downcasting");
            // Downcasting (My_class -> My_super_class)
            My_super_class? new_inform = (obj as My_super_class); 
            // Преобразует без ошибки так как obj ссылается на new_good_class, а new_good_class на My_super_class
            if (new_inform == null){Console.WriteLine("Обьект не преобразован");}
            else{new_inform.show_iform();}
        }
    }
}