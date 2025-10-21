int x = 5;
int y = 10;
string resultado = "inicio";

//linha 1
if (x++ > 5 && y < 15)
{
    resultado = "A";
}
//linha 2
else if ( x < 7 || y-- ==10)
{
    resultado = "B";
}
//linha 3
else
{     resultado = "C";
}
Console.WriteLine($"x={x}, y={y}, resultado={resultado}");