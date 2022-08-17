int number = new Random().Next(100, 1000);
Console.WriteLine($"Число: {number}");

int secondNumber = (number % 100) / 10;
Console.WriteLine($"Вторая цифра числа: {secondNumber}");