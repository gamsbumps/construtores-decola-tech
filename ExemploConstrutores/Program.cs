using ExemploConstrutores.Models;

namespace ExemploConstrutores
{
    class Program
    {
        public delegate void Operacao(int x, int y);
        static void Main(string[] args)
        {

            Matematica a = new Matematica(10, 20);
            a.Somar();


            // Operacao op = Caluladora.Somar;
            // Operacao op = new Operacao(Calculadora.Somar);
            // op += Calculadora.Subtrair;

            // op.Invoke(10, 20);
            


            // const double pi = 3.14;
            // System.Console.WriteLine(pi);


            // Data data = new Data();
            // data.SetMes(2);

            // data.Mes = 12;
            // System.Console.WriteLine(data.Mes);
            // data.ApresentarMes();
            
            // Aluno p1 = new Aluno("Guilherme", "Augusto", "teste");
            // p1.Apresentar();

            // Log log = Log.GetInstance();
            // log.PropriedadeLog = "Teste instância.";
            // Log log2 = Log.GetInstance();
            // System.Console.WriteLine(log2.PropriedadeLog);

        }
    }
}