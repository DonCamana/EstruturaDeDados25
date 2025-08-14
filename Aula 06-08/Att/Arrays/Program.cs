using System.Globalization;
using Microsoft.VisualBasic;

Console.WriteLine(
    "Olá, mundo!"
);

Console.WriteLine("");

Console.WriteLine(
    "Informe seu nome:"
);

// ? -> operador do nullable.
// indica que a variavel pode receber valor nulo.
string? name =
    Console.ReadLine();

Console.WriteLine(
    $"Seja bem-vindo {name}"
);

//Declarando vetores.
int[] numbers; // Sem inicialização.

//Inicializando vetores.

numbers = new int[5];

numbers[0] = 1;
numbers[1] = 2;
numbers[2] = 3;
numbers[3] = 4;
numbers[4] = 5;

//criando tudo na mesma linha.

int[] numbers2 = new int[5];

// Atribuindo valores.

numbers2[0] = 1;
numbers2[1] = 2;
numbers2[2] = 3;
numbers2[3] = 4;
numbers2[4] = 5;

// declarando e inicializando com valores.

int[] numbers3 = new int[] { 1, 2, 3, 4, 5 };

//Simplificada 

int[] numbers4 = { 1, 2, 3, 4, 5 };

//Preenchendo um vetor com os 12 meses do ano.

Console.WriteLine("");

string[] months = new string[12];

for (int i = 1; i <= 12; i++)
{

    DateTime firstDay =

        new DateTime(

            DateTime.Now.Year,
            i,
            1

        );



    string monthName = firstDay.ToString(
                        "MMMM",
                        CultureInfo.CreateSpecificCulture("en")
                    );

    months[i - 1] = monthName;

}

foreach (var month in months)
{

    Console.WriteLine(month);

}

// Array Multi-dimensional.

//2 dimensões

int[,] numbers52 = new int[5, 2];


//3 dimensões

int[, ,] numbres543 = new int[5, 4, 3];

// inicializando matriz valorada.

int[,] nmb = new int[,]{

    {   1, 2, -9   },
    {   5, 7, 10   },
    {   6, 115, 54 }

};

// Também podemos acessar a matriz da seguinte forma.

int myNumber = nmb[2,1];
Console.WriteLine("Imprimindo valor da matriz:");
Console.WriteLine(myNumber);