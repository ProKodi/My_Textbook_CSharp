



class My_class{
    protected int[] arr; 

/* Индексатор - разновидность свойства
Необходим для возможности индексировать обьект
Конструкция:
    "модификатор доступа" "возращаемый тип данных" this["аргумент"]{
        get{"код для гетера"}
        set{"код для сетера"}
    }
    В качестве аргумента может быть любой тип данных
    Индексатор так же можно перегружать 
        (перегрузка индексаторов аналогична перегрузке методов)
*/
    public int this[int index]{
        get{return arr[index];}
        set{arr[index] = value;}
    }

    public int[] this[int start_index, int final_index]{
        get{int size = final_index - start_index; 
            int[] temp = new int[size]; 
            for (int i = 0; i < size; i += 1){
                temp[i] = arr[start_index + i]; 
            }
            return temp; 
        }
        set{int size = final_index - start_index; 
            for(int i = 0; i < size; i += 1){
                arr[start_index + i] = value[i];
            }
        }
    }


    public My_class(int size_arr){
        this.arr = new int[size_arr]; 
        for (int i = size_arr; i > 0; i -= 1){
            this.arr[size_arr  - i] = i; 
        }
    }


}


class Program{
    public static void Main(){ 
        My_class temp = new My_class(5);
        // Через индексатор меняем значение в массиве по индексу
        temp[2] = 30; 
        // Используется метод set индексатора this[int index]

        // Через индексатор получаем элемент по индексу
        Console.WriteLine($"temp[2] = {temp[2]}");
        // Используется метод get индексатора this[int index]

        // Через индексатор меняем значения в массиве по индексам
        temp[1, 4] = [100, 200, 300]; 
        // Используется метод set индексатора this[int start_index, int final_index]

        foreach (int i in temp[1, 4]){
            // Через индексатор получаем элементы по индексам
            // Используется метод get индексатора this[int start_index, int final_index]
            Console.Write($"{i}, ");
        }
        Console.Write("\b\b\n");
    }
}