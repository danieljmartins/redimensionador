using System;
using System.IO;
using System.Threading;

namespace didaticos.redimensionador
{
    internal class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Iniciando Redimencionador");

            Thread thread = new Thread(Redimensionar);
            thread.Start();

            Console.WriteLine("Tecle para fechar");
            Console.Read();
        }

        static void Redimensionar()
        {
            string diretorio_entrada = "Arquivos_Entrada";

            if (!Directory.Exists(diretorio_entrada))
            {
                Directory.CreateDirectory(diretorio_entrada);
            }

            while (true)
            {
                Thread.Sleep ( new TimeSpan ( 0, 0, 3 ) );
            }
        }
    }
}
