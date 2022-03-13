using System;
using ExemploPOO.Helper;
using ExemploPOO.Interfaces;
using ExemploPOO.Models;

namespace ExemploPOO
{
    
    
    class Program
    {
        static void Main(string[] args)
        {
            var caminho = "C:\\Users\\pczin\\Desktop\\Aula_Arquivos";
            var caminhoPathCombine = Path.Combine(caminho, "Pasta teste 1");
            var caminhoArquivo = Path.Combine(caminho, "arquivo-teste-stream.txt");
            var caminhoArquivoTeste = Path.Combine(caminho, "arquivo-teste.txt");
            var caminhoArquivoTesteCopia = Path.Combine(caminho, "arquivo-teste-bkp.txt");
            var novoCaminhoArquivo = Path.Combine(caminho,"pasta teste 2", "arquivo-teste-stream.txt");
            var listarString = new List<string> {"linha 1", "Linha 2", "Linha 3"};
            var listarStringContinuacao = new List<string> {"linha 4", "Linha 5", "Linha 6"};
            


            FileHelper helper = new FileHelper();
            

            //helper.ListarDiretorios(caminho);
            
            //helper.ListarArquivosDiretorios(caminho);
            
            //System.Console.WriteLine("Criando diretorio: " +caminhoPathCombine);
            //helper. CriarDiretorio(Path.Combine(caminho, "Pasta teste 3", "Subpasta teste 3"));
           
            //helper.ApagarDiretorio(caminhoPathCombine, true);

            // helper.CriarArquivoTextoStream(caminhoArquivo, listarString);
            // helper.AdcionarTextoStream(caminhoArquivo, listarStringContinuacao);

            //helper.LerArquivoStream(caminhoArquivo);

            //helper.MoverArquivo(caminhoArquivo, novoCaminhoArquivo, false);

            //helper.CopiarArquivo(caminhoArquivoTeste, caminhoArquivoTesteCopia, false);

            helper.DeletarArquivo(caminhoArquivoTesteCopia);

            // iCalculadora calc = new Calculadora();
            // System.Console.WriteLine(calc.Somar(10,20));



            // Computador comp = new Computador();
            // System.Console.WriteLine(comp.ToString());

            
            
            // Corrente c = new Corrente();
            // c.Creditar(100);

            // c.ExibirSaldo();
            



            //    Calculadora calc = new Calculadora();
            //    System.Console.WriteLine(" Resultado da primeira soma: " + calc.Somar(10,10));
            //    System.Console.WriteLine(" Resultado da segunda soma: " + calc.Somar(10,10,10));

            // Aluno p1 = new Aluno();           
            // p1.Nome = "João";
            // p1.Idade = 27;
            // p1.Documento = "0123456789";
            // p1.Nota = 10;

            // p1.Apresentar();

            // Professor p2 = new Professor();            
            // p2.Nome = "João";
            // p2.Idade = 27;
            // p2.Documento = "0123456789";
            // p2.Salario = 2000;

            // p2.Apresentar();









            // Retangulo r = new Retangulo();
            // r.DefinirMedidas (30, 30);
            // System.Console.WriteLine($"Area : {r.ObterArea()}");

            // Retangulo r2 = new Retangulo();
            // r.DefinirMedidas (0, 0);
            // System.Console.WriteLine($"Area : {r2.ObterArea()}");
            
            
            
            
            // Pessoa p1 = new Pessoa();

            // p1.Nome = "João";
            // p1.Idade = 27;

            // p1.Apresentar();

        }
    }
}
