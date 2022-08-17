Console.WriteLine("Введите номер для недели от 1-7: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number == 6 || number == 7 ) Console.WriteLine("Выходной день");
else Console.WriteLine("Будний день");