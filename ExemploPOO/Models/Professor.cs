namespace ExemploPOO.Models
{
    public class Professor : Pessoa
    {
        public int Salario { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} tenho {Idade} anos, sou profesor e recebo o salario de {Salario} Reais");

        }
    }
}