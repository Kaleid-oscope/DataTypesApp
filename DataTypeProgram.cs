
Console.Write("Enter Apple Pieces: ");
int ApplePieces = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the total price of " + ApplePieces + " apple(s): ");
double TotalPrice = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("The total price of " + ApplePieces + " apple(s) is: " + TotalPrice);
Console.WriteLine("The Value of Original price is: " + TotalPrice);
Console.WriteLine("The value of Converted price is: " + Convert.ToInt32(TotalPrice));