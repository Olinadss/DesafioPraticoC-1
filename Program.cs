using System;

namespace BoasVindas
{
    class Program
    {
        static void Main(string[] args)
        {
            DateNow();
        }

        static void BoasVindas()
        {
            string nome = string.Empty;

            Console.Write("Por favor, digite seu nome: ");
            nome = Console.ReadLine();

            if (nome.Length > 1)
            {
                Console.WriteLine($"Olá, {nome}! Seja muito bem-vindo!");
            }
            else
            {
                Console.WriteLine("Você não digitou seu nome");
            }
        }

        static void FirstLastName()
        {

            Console.Write("Por favor, digite seu nome: ");
            string nome = Console.ReadLine();

            Console.Write("Por favor, digite seu sobrenome: ");
            string sobrenome = Console.ReadLine();

            Console.WriteLine($"{nome} {sobrenome}!");

        }

        static void SomaDoisNumeros()
        {
            double numeroConvert1;
            double numeroConvert2;

            Console.Write("Por favor, digite um número: ");
            string numero1 = Console.ReadLine();
            Console.Write("Por favor, digite outro número: ");
            string numero2 = Console.ReadLine();

            double.TryParse(numero1, out numeroConvert1);
            double.TryParse(numero2, out numeroConvert2);



            Console.WriteLine($"A soma entre esses dois números é: {numeroConvert1 + numeroConvert2}");
            Console.WriteLine($"A subtração entre os dois números é: {numeroConvert1 - numeroConvert2}");
            Console.WriteLine($"A multiplicação entre os dois números é: {numeroConvert1 * numeroConvert2}");
            if (numeroConvert2 != 0)
            {
                Console.WriteLine($"A divisão entre os dois números é: {numeroConvert1 / numeroConvert2}");
            } else
            {
                Console.WriteLine($"Nenhum numero pode ser dividido por zero!");
            }
            Console.WriteLine($"A média entre os dois números é: {(numeroConvert1 + numeroConvert2) / 2}");
        }

        static void ContaCaractere()
        {
            Console.Write("Por favor, digite uma palavra: ");
            string palavra = Console.ReadLine();

            Console.WriteLine(palavra.Replace(" ", "").Length);
        }

        static void VerificaPlaca()
        {
            bool result = true;

            Console.Write("Por favor, digite sua placa: ");
            string placa = Console.ReadLine().ToUpper();

            if (placa.Length < 7)
            {
                Console.WriteLine("Falso");
            }

            for (int i = 0; i < 3; i++)
            {
                if (!char.IsLetter(placa[i]))
                {
                    result = false;
                }
            }

            for (int i = 0; i < placa.Length - 4; i++)
            {
                if (!char.IsDigit(placa[i]))
                {
                    result = false;
                }
            }

            if (result)
            {
                Console.WriteLine("Verdadeiro");
            }else
            {
                Console.WriteLine("Falso");
            }
        }

        static void DateNow()
        {
            Console.WriteLine("Digite um numero de 1 à 4 para exibição da data atual: ");
            Console.WriteLine("1 - dia da semana, dia do mês, mês, ano, hora, minutos, segundos");
            Console.WriteLine("2 - Apenas a data no formato \"01/03/2024");
            Console.WriteLine("3 - Apenas a hora no formato de 24 horas.");
            Console.WriteLine("4 - A data com o mês por extenso");

            Console.Write("Escolha um formato: ");
            string numeroDigitado = Console.ReadLine();

            DateTime dataAtual = DateTime.Now;

            string dataFormatada;


            switch (numeroDigitado)
            {
                case "1":
                    dataFormatada = dataAtual.ToString("dddd, dd MMMM yyyy HH:mm:ss");
                    break;
                case "2":
                    dataFormatada = dataAtual.ToString("dd/MM/yyyy");
                    break;
                case "3":
                    dataFormatada = dataAtual.ToString("HH:mm:ss");
                    break;
                case "4":
                    dataFormatada = dataAtual.ToString("dd 'de' MMMM 'de' yyyy");
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    return;
            }

            Console.WriteLine(dataFormatada);
        }
    }
}
