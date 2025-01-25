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
            #region Diretorios
            string diretorio_entrada         = "Arquivos_Entrada";
            string diretorio_redimensionados = "Arquivos_Redimensionados";
            string diretorio_finalizados     = "Arquivos_Finalizados";

            if (!Directory.Exists(diretorio_entrada))
            {
                Directory.CreateDirectory(diretorio_entrada);
            }

            if (!Directory.Exists(diretorio_redimensionados))
            {
                Directory.CreateDirectory(diretorio_redimensionados);
            }

            if (!Directory.Exists(diretorio_finalizados))
            {
                Directory.CreateDirectory(diretorio_finalizados);
            }
            #endregion

            while (true)
            {
                // O programa vai olhar pra pasta de entrada
                // SE tiver arquivo, irá redimensionar
                var arquivosEntrada = Directory.EnumerateFiles(diretorio_entrada);

                // Ler o tamanho que irá redimensionar
                int tamanho = 200; // pixels

                foreach ( var arquivo in arquivosEntrada)
                {

                    FileStream file = new FileStream(arquivo, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
                    FileInfo fileInfo = new FileInfo(arquivo);

                    // Redimensiona

                    // Copia os arquivos redimensionados para a pasta de redimensionados

                    // Move o arquivo de entrada para a pasta de finalizados
                }

                Thread.Sleep ( new TimeSpan ( 0, 0, 3 ) );
            }
        }
    }
}
