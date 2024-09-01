




int k = 2; 
    
/* Использовать goto необходимо в крайних случаях когда без него не обойтись
Может ломать код

Может быть использован для того чтобы избезать не нужной рекурсии
    (хотя в таких случаях лучше использовать while(true))

*/

void fun(){
    link:  // Ссылка (куда нужно перейти)
    int a = 7;
    a -= k;
    Console.WriteLine($"a = {a}"); 
    k -= 1;

    if (k > 0){goto link;} // link - ссылка (куда нужно перейти)
    else{Console.WriteLine($"k = {k}");}
}



/*
// Вариант здорового человека
void fun(){
    while(true){
        int a = 7;
        a -= k;
        Console.WriteLine($"a = {a}"); 
        k -= 1;

        if (k > 0){continue;} 
        else{Console.WriteLine($"k = {k}"); break;}
    }
}
*/


fun(); 