
Console.Write("Entre com a medida (em metros): ");
decimal metros = Convert.ToDecimal (Console.ReadLine());

Console.WriteLine("--- Equivalência ---");

decimal cm = Convert.ToDecimal (metros ) * 100;

Console.WriteLine(cm);