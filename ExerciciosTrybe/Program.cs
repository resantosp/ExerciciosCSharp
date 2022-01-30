using System;
public class Program
{
    public static int calculadoraAdicaoSubtracao(int numero, int outroNumero, string operacao)
    {
        int resultado;
        if (operacao == "+")
        {
            resultado = numero + outroNumero;
        }
        else if (operacao == "-")
        {
            resultado = numero - outroNumero;
        }
        else
        {
            resultado = 0;
        }

        return resultado;

    }
    public static int[] tripleTheChances(int[] chances)
    {
        int[] array = new int[chances.Length];
        int x;
        for (int i = 0; i < chances.Length; i++)
        {
            x = chances[i] * 3;
            array[i] = x;
        }

        return array;
    }
    public static int vezesLetraAparece(string frase, char letra)
    {
        int n = 0;
        char[] lista;
        lista = frase.ToCharArray(0, frase.Length);
        for (int i = 0; i < lista.Length; i++)
        {
            if (lista[i] == letra)
            {
                n += 1;
            }
        }

        return n;
    }
    public static void Main()
    {
        //Calculadora Adição e Subtração
        System.Console.WriteLine("===== Calculadora Adição e Subtração =====");
            //Criar readlines para inputar os valores e a operação desejada
        int resultado = calculadoraAdicaoSubtracao(5, 4, "+");
        System.Console.WriteLine(resultado);
        System.Console.WriteLine();

        //Triplicando as Chances
        System.Console.WriteLine("===== Multiplicando valores por 3 =====");
        int[] chances = new int[]{2, 3, 5, 8, 10};
        int[] array = tripleTheChances(chances);
        for (int i = 0; i < array.Length; i++)
        {
            System.Console.Write($"{array[i]}. ");
        }
        System.Console.WriteLine("\n");

        //Contador de Caracter: quantas vezes a letra aparece?
        System.Console.WriteLine("===== Contador de Caracter =====");
        int n = vezesLetraAparece("The Lord of the Rings", 'o');
        System.Console.WriteLine($"A letra 'o' aparece -> {n} <- vezes na frase atribuída.");
        
    }
}