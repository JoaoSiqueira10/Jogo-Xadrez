using System;

namespace Manipulacao_de_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string original = "abcde FGHIJ ABC abc DEFG ";
            string s1 = original.ToUpper();     //tudo maiusculo
            string s2 = original.ToLower();     //tudo minusculo
            string s3 = original.Trim();        //apada os espaços em branco antes e depois da string
            
            int n1 = original.IndexOf("bc");    //funcao de procura da primeira posicao de ocorrencia
            int n2 = original.LastIndexOf("bc");//funcao de procura da ultima posicao de ocorrencia
            
            string s4 = original.Substring(3);              //cortar a string apartir da posicao 3
            string s5 = original.Substring(3, 5);           //corta a string da posicao 3 ate 5
            string s6 = original.Replace('a', 'x');         //substitui todo caracter 'a' por 'x'
            string s7 = original.Replace("abc", "xy");      //substitui 'abc' por 'xy'
            bool b1 = String.IsNullOrEmpty(original);       //verifica se o conteudo da string é nulo ou vazio
            bool b2 = String.IsNullOrWhiteSpace(original);  //verifica se é nula ou espaço em branco
            
            Console.WriteLine("Original: -" + original + "-");
            Console.WriteLine("ToUpper: -" + s1 + "-");
            Console.WriteLine("ToLower: -" + s2 + "-");
            Console.WriteLine("Trim: -" + s3 + "-");
            Console.WriteLine("IndexOf('bc'): " + n1);
            Console.WriteLine("LastIndexOf('bc'): " + n2);
            Console.WriteLine("Substring(3): -" + s4 + "-");
            Console.WriteLine("Substring(3, 5): -" + s5 + "-");
            Console.WriteLine("Replace('a', 'x'): -" + s6 + "-");
            Console.WriteLine("Replace('abc', 'xy'): -" + s7 + "-");
            Console.WriteLine("IsNullOrEmpty: " + b1);
            Console.WriteLine("IsNullOrWhiteSpace: " + b2);

        }
    }
}
