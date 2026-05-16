string estaMovendoTexto, DeveriaTexto;
bool EstaMovendo, deveria;

Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine("---Fluxograma da Engenharia---");
Console.ResetColor();

Console.WriteLine("O objeto deveria estar se Movendo? (S/N):");

estaMovendoTexto = Console.ReadLine()!;

 Console.WriteLine("Deveria?");
DeveriaTexto = Console.ReadLine()!;

EstaMovendo = estaMovendoTexto.ToUpper().Substring(0,1) == "S";

deveria = DeveriaTexto.ToUpper().Substring(0,1) == "S";

if (EstaMovendo && !deveria)
{
    Console.ForegroundColor= ConsoleColor.DarkGray;
        Console.WriteLine("Use Silver Tape!");
        Console.ResetColor();
}
else if (!EstaMovendo && deveria)
{
    Console.ForegroundColor=ConsoleColor.DarkBlue;
    Console.WriteLine("Use WD-40!");
 Console.ResetColor();
}
else
{
    Console.ForegroundColor= ConsoleColor.Green;
     Console.WriteLine("ótimo!");
      Console.ResetColor();
}
