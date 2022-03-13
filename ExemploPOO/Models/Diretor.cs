namespace ExemploPOO.Models
{
    public class Diretor : Professor
    {
        public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} tenho {Idade} anos, sou diretor e recebo o salario de {Salario} Reais");
        }
    }
}