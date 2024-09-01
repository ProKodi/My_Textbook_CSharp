




class My_class{
/*
readonly - данный модификатор позволяет создавать поля 
    которые предназначины только для чтения
Инициализировать такие поля можно только при их обьявлении или конструкторе
Иных местах изменение данных полей запрещено (можно только считывать)

Отличии от констант заключается в том что поля с модификатором можно не 
    инициализировать при обьявлении, а инициализировать в конструкторе
*/
    private readonly int number; 


    public My_class(int number){
        this.number = number;
    }

    public void print(){
        // this.number = 9; // Будет ошибка
        Console.WriteLine($"number = {this.number}"); 
    }
}





class Program{
    public static void Main(){
        My_class new_class1 = new My_class(10); 
        new_class1.print(); 
    }

}