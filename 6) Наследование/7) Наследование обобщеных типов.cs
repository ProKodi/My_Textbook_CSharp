



/*
Наследование от класса шаблонна
При наследовании от класса шаблонна можно использовать 
    следующие варианты наследования:

    1) Создание обобщеного класса наследника с тем же набором типов данных
    2) Создание необобщеного класса-наследника. При наследовании у базового 
        класса явным образом будет определен набор типов данных
    3) Использование в базовом классе типа отличного от используемонго 
        в производном классе
*/

// Базовый класс
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


// Создание класса наследника с тем же набором типов данных (1 случай)
class Super_point<Type1, Type2>: Point<Type1, Type2>{
    public Super_point(Type1 x, Type2 y): base(x, y){}
}


// Создание необобщеного класса-наследника. (2 случай)
class Float_point: Point<float, float>{
    public Float_point(float x, float y): base(x, y){}
}


// Использование в базовом классе типа отличного от используемонго 
//    в производном классе (3 случай)
class String_point<Type1, Type2>: Point<string, string>{
    public String_point(Type1 x, Type2 y): base(x.ToString(), y.ToString()){}
}


class Program{
    public static void Main(){ 
        Super_point<int, int> poi1 = new Super_point<int, int>(4, 6); 
        Console.WriteLine($"poi1 = {poi1}");

        Float_point poi2 = new Float_point(4.87f, 90.7f); 
        Console.WriteLine($"poi2 = {poi2}");

        String_point<int, string> poi3 = new String_point<int, string>(48, "some inform"); 
        Console.WriteLine($"poi3 = {poi3}");
    }
}