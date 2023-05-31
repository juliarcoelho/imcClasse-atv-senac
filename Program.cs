using System;

namespace imcClasse
{
    class Imc
    {
        private string nome;
        private double peso, altura;

        public string nomePublico
        {
            get { return nome; }
            set { nome = value; }
        }

        public double pesoPublico
        {
            get { return peso; }
            set { peso = value; }
        }

        public double alturaPublico
        {
            get { return altura; }
            set { altura = value; }
        }
        public Imc() { }

        public double CalculaImc()
        {
            double imc;

            imc = peso / (altura * altura);
            return imc;
        }
        public void MostraImc()
        {
            Console.WriteLine(nome + " o seu IMC é: " + CalculaImc());
        }
        public void MostraSituacao(double imc)
        {
            if (imc < 20)
            {
                Console.WriteLine("Abaixo do peso.");
            }
            else
            {
                Console.WriteLine("Peso normal.");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Imc paciente = new Imc();

            Console.WriteLine("Digite o nome: ");
            paciente.nomePublico = Console.ReadLine();

            Console.WriteLine("Digite o peso: ");
            paciente.pesoPublico = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a altura: ");
            paciente.alturaPublico = Convert.ToDouble(Console.ReadLine());

            paciente.MostraImc();
            paciente.MostraSituacao(paciente.CalculaImc());

        }
    }
}
