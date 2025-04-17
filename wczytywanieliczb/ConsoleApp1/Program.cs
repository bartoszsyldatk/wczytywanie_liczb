void WczytajLiczby(ref int a, ref int b){
    Console.WriteLine("Podaj pierwszą liczbę:");
    while (!int.TryParse(Console.ReadLine(), out a)){
        Console.WriteLine("Podaj liczbę całkowitą:");
    }
    Console.WriteLine("Podaj drugą liczbę:");
    while (!int.TryParse(Console.ReadLine(), out b)){
        Console.WriteLine("Podaj liczbę całkowitą:");
    }
}

int x = 0, y = 0, w;

WczytajLiczby(ref x, ref y);
Console.WriteLine($"Wczytano liczby: {x} i {y}");
Console.WriteLine("1. Dodawanie\n2. Odejmowanie\n3. Zamiana\n4. Porównanie\n");

Console.WriteLine("Wybierz opcję:");
while(!int.TryParse(Console.ReadLine(), out w) || w > 4 || w < 1){
    Console.WriteLine("Wybierz prawidłową opcję: ");
}

switch (w){
    case 1:
        dodaj(x, y);
        break;
    case 2:
        Console.WriteLine($"Ich różnica: {x - y}");
        break; 
    case 3:
        zamien(ref x, ref y);
        break;
    case 4:
        if (x > y){
            Console.WriteLine($"{x} > {y}");
        }
        else if (x < y){
            Console.WriteLine($"{x} < {y}");
        }
        else if (x == y){
            Console.WriteLine($"Liczby są równe.");
        }
        break;
}

void dodaj(int a, int b){
    Console.WriteLine($"Ich suma: {a + b}");
}

void zamien(ref int a, ref int b){
    int temp = a;
    a = b;
    b = temp;
    Console.WriteLine($"Pierwsza liczba: {a}, Druga liczba: {b}");
}