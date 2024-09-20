



/*
Для создания собственного исключения необходимо:
    1) Создать класс который будет наследоватся от Exception
    2) Создать конструктор для класса (с коминтарием и без)
    3) (Опционально) Создать свою логику (методы, поля, свойства)
*/



// Наше исключение
class My_Exception: Exception{
    // Конструктор без коминтария
    public My_Exception(): base(){}

    // Конструктор с коминтарием
    public My_Exception(string message): base(message){}
}




class Program{
    public static void Main(){
        try{
            throw new My_Exception(); 
        }
        catch (My_Exception ex){
            Console.WriteLine("Было поймано собственное исключение");
            Console.Write($"Подробности {ex.Message}");
        }
    }
}