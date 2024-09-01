



/*
Установка пакетов 
Для упрощения разработке в приложении можно испольхзовать стороние библиотеки
    которые были написаны другими разработчиками. 
(данные библиотеки расположены на сайте nuget.org)
Для того чтобы установить библиотеку необходимо проделать следующие манипуляции с консолью:
    0) Открыть консоль
    1) Перейти в папку проекта
    2) выполнить команду: dotnet new console
    3) выполнить команду: dotnet add package "название пакета"

В качестве примера будет пакет Newtonsoft.Json
Команды для консоли (P.S в папку где будет проект мы перешли):
    1) dotnet new console
    2) dotnet add package Newtonsoft.Json
*/

using Newtonsoft.Json;  // подключаем пространство имен из пакета Newtonsoft.Json


class Human{
    public string name;
    public uint age;

    public Human(string name, uint age){
        this.name = name;
        this.age = age;
    }
}


class Program{
    public static void Main(){ 
        Human bob = new Human("Bob", 38);
        // сериализуем объект bob в код json
        string json = JsonConvert.SerializeObject(bob);
        Console.WriteLine($"name in json: {json}"); 
    }
}