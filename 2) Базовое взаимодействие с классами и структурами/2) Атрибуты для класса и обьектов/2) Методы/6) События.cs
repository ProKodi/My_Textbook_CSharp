



/*
События сигнализируют системе о том, что произошло определенное действие. 
И если нам надо отследить эти действия, то как раз мы можем применять события.
События объявляются в классе с помощью ключевого слова event, 
    после которого указывается тип делегата, который представляет событие:
        event "имя делигата" "название события";

С событиями взаимодействие осуществляется так же как и с делегатами
Вызывать события можно только только в классе
*/

// Создаем делигат который будет нужен для события
delegate void print_event(int code_for_event); 


class My_class{
    public My_class(){}

    // Создаем событие для класса
    public event print_event? prin_even; 

    
    protected print_event? even;  // делегат для управляемого события
    // Если мы хотим управлять добавление/удалением событий
    public event print_event? sup_prin_even{
        add{ // Данная секция отвечает за добавление события
            if (value != null){
                this.even += value; 
            }
            Console.WriteLine("Была добавлена функция для события");

        }
        remove{ // Данная секция отвечает за удаление события
            if (value != null){
                this.even -= value; 
            }
            Console.WriteLine("Была удалена функция для события");

        }
    }


    // Функция которая запускает событие
    public void run_event(int code){
        Console.WriteLine($"Вызов события");
        // Проверяем что событие не равно нулю
        if (prin_even != null){
            // Вызываем событие для класса
            this.prin_even(code);  
        }
        if (even != null){
            Console.WriteLine($"Управляемые события");
            // Вызываем управляемое событие для класса
            this.even(code);
        }
    }
}



class Program{
    public static void Main(){
        // Вызывать события можно только только в классе
        My_class obj = new My_class();
        // Работа с обычным событием
        obj.prin_even += (int code) => {Console.WriteLine($"Was started event. Code event = {code}");};

        // запускаем события
        obj.run_event(98);

        // Функции для управляемых событий
        print_event fun1 = (int code) => {Console.WriteLine($"Code event = {code}");}; 
        print_event fun2 = delegate(int code){
            Console.WriteLine($"Event = {code}");
        };

        // Работа с управляемым событием
        obj.sup_prin_even += fun1;
        obj.sup_prin_even += fun2;

        // запускаем события
        obj.run_event(98);

        // Работа с управляемым событием
        obj.sup_prin_even -= fun1;
        obj.sup_prin_even -= fun2;

        // запускаем события
        obj.run_event(98);
    }
}
