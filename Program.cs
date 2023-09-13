﻿Console.WriteLine("--- Pet Hotel Check-in ---\n");

Console.Write("Espécie......: ");
string especie = Console.ReadLine()!;

Console.Write("Raça.........: ");
string raca = Console.ReadLine()!;

Console.Write("Nome.........: ");
string nome = Console.ReadLine()!;

Console.Write("Idade (anos).: ");
string idade = Console.ReadLine()!;

Console.Write("Pelagem/cor..: ");
string pelagemCor = Console.ReadLine()!;

Console.WriteLine();
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("+=========================================================+");
Console.Write("|                 ");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write("Pet Hotel \"Bom pra cachorro\"");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("            |");

Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("+=========================================================+");
Console.Write("| Espécie: ");
Console.ForegroundColor = ConsoleColor.Green;
Console.Write(especie.Trim().ToUpper().PadLeft(15, '.').Substring(0, 15));
Console.ForegroundColor = ConsoleColor.White;
Console.Write(" | Raça: ");
Console.ForegroundColor = ConsoleColor.Green;
Console.Write(raca.Trim().ToUpper().PadLeft(22, '.').Substring(0, 22));
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine(" |");

Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("+=========================================================+");
Console.Write("| Atende pelo nome de: ");
Console.ForegroundColor = ConsoleColor.Green;
Console.Write(nome.Trim().ToUpper().PadLeft(34, '.').Substring(0, 34));
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine(" |");
Console.Write("| Idade: ");
Console.ForegroundColor = ConsoleColor.Green;
Console.Write($"{idade.Trim().ToUpper().PadLeft(2, '0').Substring(0, 2)} ano(s)");
Console.ForegroundColor = ConsoleColor.White;
Console.Write(" | Pelagem/cor: ");
Console.ForegroundColor = ConsoleColor.Green;
Console.Write(pelagemCor.Trim().ToUpper().PadLeft(23, '.').Substring(0, 23));
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine(" |");

Console.ForegroundColor = ConsoleColor.White;
Console.Write("+=========================================================+");

Console.ResetColor();