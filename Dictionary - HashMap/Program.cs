using System;
using System.Collections.Generic;
using System.Linq;

public class GerenciadorEtiquetas
{
    private Dictionary<string, string> rastreioParaCodigoBarras = new Dictionary<string, string>();

    public void InserirInformacoes(int quantidade)
    {
        Console.WriteLine($"\n### Inserir {quantidade} Informações de Rastreio ###");
        for (int i = 0; i < quantidade; i++)
        {
            Console.WriteLine($"\n--- Pacote {i + 1} de {quantidade} ---");

            string codigoRastreio;
            do
            {
                Console.Write("Digite o Código de Rastreio (Chave): ");
                codigoRastreio = Console.ReadLine().Trim();

                if (rastreioParaCodigoBarras.ContainsKey(codigoRastreio))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ERRO: Este Código de Rastreio já foi inserido. Por favor, insira um código único.");
                    Console.ResetColor();
                }
                else if (string.IsNullOrWhiteSpace(codigoRastreio))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ERRO: O Código de Rastreio não pode ser vazio.");
                    Console.ResetColor();
                }

            } while (rastreioParaCodigoBarras.ContainsKey(codigoRastreio) || string.IsNullOrWhiteSpace(codigoRastreio));

            string codigoBarras;
            do
            {
                Console.Write("Digite o Código de Barras (Valor): ");
                codigoBarras = Console.ReadLine().Trim();

                if (rastreioParaCodigoBarras.ContainsValue(codigoBarras))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("AVISO: Este Código de Barras já está associado a outro rastreio. Inserindo mesmo assim...");
                    Console.ResetColor();
                }
                else if (string.IsNullOrWhiteSpace(codigoBarras))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ERRO: O Código de Barras não pode ser vazio.");
                    Console.ResetColor();
                }
            } while (string.IsNullOrWhiteSpace(codigoBarras));

            rastreioParaCodigoBarras.Add(codigoRastreio, codigoBarras);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Informação inserida com sucesso!");
            Console.ResetColor();
        }
    }

    public void BuscarInformacao()
    {
        Console.WriteLine("\n### Buscar Informação ###");
        if (rastreioParaCodigoBarras.Count == 0)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("O dicionário está vazio. Não há informações para buscar.");
            Console.ResetColor();
            return;
        }

        Console.Write("Digite o termo de busca (Código de Rastreio OU Código de Barras): ");
        string termoBusca = Console.ReadLine().Trim();

        if (string.IsNullOrWhiteSpace(termoBusca))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("ERRO: O termo de busca não pode ser vazio.");
            Console.ResetColor();
            return;
        }

        Console.WriteLine($"\n--- Resultado da Busca para: **{termoBusca}** ---");

        if (rastreioParaCodigoBarras.TryGetValue(termoBusca, out string codigoBarrasEncontrado))
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"ENCONTRADO como **CÓDIGO DE RASTREIO**:");
            Console.WriteLine($"   Código de Rastreio: **{termoBusca}**");
            Console.WriteLine($"   Código de Barras: **{codigoBarrasEncontrado}**");
            Console.ResetColor();
            return;
        }

        var resultadoValor = rastreioParaCodigoBarras
            .Where(kvp => kvp.Value.Equals(termoBusca, StringComparison.OrdinalIgnoreCase))
            .ToList();

        if (resultadoValor.Any())
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"ENCONTRADO como **CÓDIGO DE BARRAS**:");
            foreach (var item in resultadoValor)
            {
                Console.WriteLine($"   Código de Barras: **{item.Value}**");
                Console.WriteLine($"   Código de Rastreio associado: **{item.Key}**");
                Console.WriteLine("---------------------------------");
            }
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Nenhum resultado encontrado. O termo não corresponde a um Código de Rastreio ou Código de Barras existente.");
            Console.ResetColor();
        }
    }

    public static void Main(string[] args)
    {
        GerenciadorEtiquetas gerenciador = new GerenciadorEtiquetas();

        Console.WriteLine("--- Sistema de Gerenciamento de Etiquetas e Códigos de Barras ---");

        int quantidade;
        Console.Write("Quantas informações de rastreio/pacote você deseja inserir inicialmente? ");
        if (int.TryParse(Console.ReadLine(), out quantidade) && quantidade > 0)
        {
            gerenciador.InserirInformacoes(quantidade);
        }
        else
        {
            Console.WriteLine("Entrada inválida. Inserindo 3 informações para demonstração.");
            gerenciador.InserirInformacoes(3);
        }

        Console.WriteLine("\n\n###############################");
        Console.WriteLine("DEMONSTRAÇÃO DE RECURSOS DE BUSCA");
        Console.WriteLine("###############################");

        while (true)
        {
            gerenciador.BuscarInformacao();
            Console.Write("\nDeseja realizar outra busca? (s/n): ");
            if (Console.ReadLine().Trim().ToLower() != "s")
            {
                break;
            }
        }

        Console.WriteLine("\nFim do Programa. Obrigado!");
    }
}