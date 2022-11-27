namespace USING3_C_SHARP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variável numeros do tipo string que a classe StringReader fará a leitura
            string numeros = @"Um Dois Três Quatro";

            //Variável letras do tipo string que a classe StringReader fará a leitura
            string letras = @"A B C D";

            //Criação dos objetos esquerda e direita como parâmetro do Using
            using (StringReader esquerda = new StringReader(numeros), direita = new StringReader(letras))
            {
                string? item; // significa que o tipo primitivo pode receber null como valor.

                do // Do While (Fazer enquanto)
                {
                    item = esquerda.ReadLine(); //Variável item recebe o conteúdo de esquerda
                    Console.WriteLine(item);    // Impressão de item
                    Console.WriteLine("  ");
                    item = direita.ReadLine(); //Variável item recebe o conteúdo da Direita
                    Console.WriteLine(item);   // Impressão de item

                } while (item != null);
            }
        }
    }
}