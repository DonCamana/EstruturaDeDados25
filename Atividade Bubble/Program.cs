using BubbleSort;
Console.WriteLine("Ordenação com Bubble Sort!");

// Ordenação numérica
int[] arrnumbers = new int [] { 99, 50, -24, 0, 1 };
Console.WriteLine("\nVetor numérico original:");
foreach (var arrnumber in arrnumbers)
    Console.Write($" [{arrnumber}] ");

var arrOrdered = BubbleSort.BubbleSortOrder.Sort<int>(arrnumbers);
Console.WriteLine("\nVetor numérico ordenado: ");
foreach (var number in arrOrdered)
    Console.Write($" [{number}] ");

var arrDescending = BubbleSort.BubbleSortOrder.SortDescending<int>(arrnumbers);
Console.WriteLine("\nVetor numérico ordenado ao contrário:");
foreach (var number in arrDescending)
    Console.Write($" [{number}] ");

// Ordenação alfanumérica
string[] arrStrings = new string[] { "maçã", "...banana", "Limão", "laranja", "123", "abc!" };
Console.WriteLine("\n\nVetor alfanumérico original:");
foreach (var str in arrStrings)
    Console.Write($" [{str}] ");

var arrStringOrdered = BubbleSort.BubbleSortOrder.Sort<string>(arrStrings);
Console.WriteLine("\nVetor alfanumérico ordenado:");
foreach (var str in arrStringOrdered)
    Console.Write($" [{str}] ");

string[] arrStrings2 = new string[] { "maçã", "...banana", "Limão", "laranja", "123", "abc!" };
Console.WriteLine("\nVetor alfanumérico ordenado DECRESCENTE:");
var arrStringDescending = BubbleSort.BubbleSortOrder.SortDescending<string>(arrStrings2);
foreach (var str in arrStringDescending)
    Console.Write($" [{str}] ");