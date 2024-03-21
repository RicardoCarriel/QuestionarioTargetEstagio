using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite uma palavra ou frase para inverter os caracteres: ");
        string texto = Console.ReadLine();

        string stringInvertida = InverterString(texto);

        Console.WriteLine("String invertida: " + stringInvertida);
    }

    static string InverterString(string str)
    {
        // transforma a string em um Array de caracteres
        char[] arrayCaracteres = str.ToCharArray();

        //  indice do último caractere na string
        int final = arrayCaracteres.Length - 1;

        // loop que inverte os caracteres
        for (int inicio = 0; inicio < final; inicio++, final--)
        {
            // variavel temporaria para guardar a letra que sera invertida
            char temp = arrayCaracteres[inicio];
            // primeira letra da string é substituida pela ultima
            arrayCaracteres[inicio] = arrayCaracteres[final];
            // o local do ultimo caractere recebe o caracter inicial que foi guardado na variavel temporaria
            arrayCaracteres[final] = temp;
        }

        // converte o array de caracteres de volta para uma string
        return new string(arrayCaracteres);
    }
}