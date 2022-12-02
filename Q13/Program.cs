int number = new Random().Next(1,65536);
Console.WriteLine("Число: " + number);
if (number < 100){
    Console.WriteLine("Третьей цифры нет");
}
else if (number < 1000){
    Console.WriteLine("Третья цифра " + number%10);
}
else if (number < 10000){
    Console.WriteLine("Третья цифра " + (number/10)%10); 
}
else if (number < 100000){
    Console.WriteLine("Третья цифра " + (number/100)%10);
}
