Console.Title = "Conversion App Test";

decimal convoFrom = 0.00m;
decimal convoResult = 0.00m;
decimal value = 0.00m;


Console.Write("Enter degrees in Celsius: ");
convoFrom = Convert.ToDecimal(Console.ReadLine());
value = celsiusToFahrenheit();
Console.WriteLine($"{value} degrees Fahrenheit.");

decimal celsiusToFahrenheit()
{
    convoResult = ((convoFrom * 9) / 5) + 32;
    return convoResult;
}
decimal fahrenheitToCelsius()
{
    convoResult = ((convoFrom - 32) * 5 / 9);
    return convoResult;
}