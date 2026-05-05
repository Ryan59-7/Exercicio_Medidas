
Console.Write("Entre com a medida (em metros): ");
decimal metros = Convert.ToDecimal (Console.ReadLine());

Console.WriteLine("--- Equivalência ---");

decimal cm = Convert.ToDecimal (metros ) * 100;
decimal km = Convert.ToDecimal (metros ) / 1000;

Console.WriteLine(cm + " cm");

Console.WriteLine(metros + " m");

Console.WriteLine(km + " km");