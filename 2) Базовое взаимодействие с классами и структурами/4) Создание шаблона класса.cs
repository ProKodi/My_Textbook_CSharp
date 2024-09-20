



/*
Шаблоны классов/Обобщенный класс - представляют из себя шаблон где при создании обьекта необходимо
    указать с какими типами данных он будет работать
Инстанцирование - процесс генерации компилятором определеного класса

Пример:
    class "Имя класса<типы данных с которыми будет работать класс через запятую>{
        "Тело класса"
    }
Использование шаблонов классов позволяет избежать ненужного 
    преобразования типов данных

Создание и ограничения шаблона делаются так же как и у функций
*/


class Point<Type1, Type2>{
    protected Type1 x;
    protected Type2 y;

    public Point(Type1 x, Type2 y){
        this.x = x;
        this.y = y;
    }
    public override string ToString(){
        return $"({this.x}; {this.y})";
    }
};



class Program{
    public static void Main(){ 
        Point<int, int> poi1 = new Point<int, int>(4, 6); 
        Console.WriteLine($"poi1 = {poi1}");

        Point<float, int> poi2 = new Point<float, int>(4.87f, 90); 
        Console.WriteLine($"poi2 = {poi2}");
    }
}