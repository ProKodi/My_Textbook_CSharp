



/*
Перегрузка операторов переобразования типов позволяет переопределить тип у 
    собственного класса.

Для определения оператора для  объектов своего класса, необходимо 
    определить функцию следующей конструкции:
    1) Для неявного преобразования (будет работать и для явного):
        public static implicit operator "Тип в который надо преобразовать"("аргументы"){
            "реализация
        }
    2) Для явного преобразования (работать для неявного не будет):
        public static explicit operator "Тип в который надо преобразовать"("аргументы"){
            "реализация
        } 

*/


class My_class{
    private int number = 0; 

    public My_class(int number){
        this.number = number;
    }

    public static implicit operator int(My_class obj){
        return obj.number; 
    }

    public static explicit operator float(My_class obj){
        return (float)obj.number - 0.8f; 
    }

    public static explicit operator string(My_class obj){
        return '[' + obj.number.ToString() + ']'; 
    }



}



class Program{
    public static void Main(){
        My_class tem1 = new My_class(76); 

        int inum = tem1; 
        Console.WriteLine($"inum = {inum}"); 

        float fnum = (float)tem1; // Без явного преобразования вызвает int
        Console.WriteLine($"fnum = {fnum}"); 

        string snum = (string)tem1; // Без явного преобразования вообще не будет работать
        Console.WriteLine($"snum = {snum}"); 
    }
}