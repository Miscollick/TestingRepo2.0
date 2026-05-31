using System;

class Hello {
    public static void Main() {
        Console.WriteLine("Hello from C# Cracker!");
        int sum = 0;
        for (int i = 1; i <= 10; i++) sum += i;
        Console.WriteLine($"Sum 1..10 = {sum}");
    }
}

// Извикваме метода ръчно, за да го стартира скриптът:
Hello.Main();
