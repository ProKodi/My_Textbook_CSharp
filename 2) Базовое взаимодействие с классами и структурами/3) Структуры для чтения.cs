



/*
Структуры для чтения - особенность данных структур является то 
    что все поля имеют модификатор readonly (даже если он не указан)
*/


readonly struct My_class{
    /*данное поле уже имеет модификатор readonly так 
        как у струкуры установлин модификатор readonly*/
    private readonly int number; 
    public int number2 { get; } // указывать readonly необязательно



    public My_class(int number, int number2){
        // Ссылаем поле number текущего объекта на новое значение
        this.number = number;
        this.number2 = number2;
    }

    public void print(){
        Console.WriteLine($"number = {this.number}, number = {this.number2}");
    }
}





class Program{
    public static void Main(){
        My_class new_class1 = new My_class(10, 87); 
        new_class1.print(); 
    }

}