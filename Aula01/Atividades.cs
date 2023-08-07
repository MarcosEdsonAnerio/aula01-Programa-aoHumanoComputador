internal class Atividades
{
        public class Funcionario
        {
            public string nome;

            public string cpf;

            public string matricula;

            public double salario;

            public void Bonificacao()
            {
                salario += 500;
            }
        }
        public void Exercicio1()
        {
            Funcionario fun1 = new Funcionario();
            Funcionario fun2 = new Funcionario();

            Console.WriteLine("Digite seu Nome: ");
            fun1.nome = Console.ReadLine();
            Console.WriteLine("Digite seu CPF: ");
            fun1.cpf = Console.ReadLine();
            Console.WriteLine("Digite sua Matricula: ");
            fun1.matricula = Console.ReadLine();
            Console.WriteLine("Digite seu Salario: ");
            fun1.salario = Convert.ToDouble(Console.ReadLine());

            fun1.Bonificacao();

            Console.WriteLine("\nFUNCIONARIO 2");
            Console.WriteLine("\nDigite seu Nome: ");
            fun2.nome = Console.ReadLine();
            Console.WriteLine("Digite seu CPF: ");
            fun2.cpf = Console.ReadLine();
            Console.WriteLine("Digite sua Matricula: ");
            fun2.matricula = Console.ReadLine();
            Console.WriteLine("Digite seu Salario: ");
            fun2.salario = Convert.ToDouble(Console.ReadLine());

            fun2.Bonificacao();

            if (fun1.salario > fun2.salario)
            {
                Console.WriteLine("O funcionário"+fun1.nome+"possui o maior salário: " + fun1.salario);
            }
            else if (fun2.salario > fun1.salario)
            {
                Console.WriteLine("O funcionário"+fun1.nome+"possui o maior salário: " + fun2.salario);
            }
            else
            {
                Console.WriteLine("Ambos os funcionários possuem salários iguais: " + fun1.salario);
            }
        }
        public class Triangulo
        {
            public double LadoA;
            public double LadoB;
            public double LadoC;
        
            public double CalcularArea()
            {
                double perimetro = (LadoA + LadoB + LadoC) / 2;

                double area = Math.Sqrt(perimetro * (perimetro - LadoA) * (perimetro - LadoB) * (perimetro - LadoC));
                return area;
            }
        }
        public void Exercicio2()
        {
            {
                Triangulo triangulo = new Triangulo();

                Console.WriteLine("Digite a medida do Lado A do triângulo:");
                triangulo.LadoA = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite a medida do Lado B do triângulo:");
                triangulo.LadoB = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite a medida do Lado C do triângulo:");
                triangulo.LadoC = Convert.ToDouble(Console.ReadLine());

                double areaTriangulo = triangulo.CalcularArea();
                Console.WriteLine("A área do triângulo é: " + areaTriangulo);
            }
        }
        public class Circulo
        {
            public double Raio;

        public double CalcularArea()
        {
            double area = Math.PI * Math.Pow(Raio, 2);
            return area;
        }
        }
        public void Exercicio3()
        {
        {
            Circulo circulo = new Circulo();

            Console.WriteLine("Digite o valor do raio do círculo:");
            circulo.Raio = Convert.ToDouble(Console.ReadLine());

            double areaCirculo = circulo.CalcularArea();
            Console.WriteLine("A área do círculo é: " + areaCirculo);
        }
    }
}