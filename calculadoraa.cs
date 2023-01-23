using System;

namespace calculadora
{
    class Calculadoraa
    {
        private int OperacaoDigitada;
        private int resultado;
        private int numero1;
        private int numero2;

        public Calculadoraa()
        {
            this.numero1=0;
            this.numero2=0;
        }

        public void executar()
        {
            this.menu();
        }
        private string somar(){
            this.resultado = this.numero1 + this.numero2;
            return this.resultadoconta();
        }

        private string subtrair(){
            this.resultado = this.numero1 - this.numero2;
            return this.resultadoconta();     
        }

        private string multiplicar(){
            this.resultado = this.numero1 * this.numero2;
            return this.resultadoconta();     
        }

        private string dividir(){
            this.resultado = this.numero1 / this.numero2;
            return this.resultadoconta();     
        }

        private string resultadoconta(){
            return $"Resultado:{this.resultado}";    
        }

        private void alerta ()
        {
            Console.Clear();
            Console.WriteLine("Opção invalida");
            Console.WriteLine("Digite qualquer tecla para continuar");
            Console.ReadKey();
        }
        private void menu ()
        {
            int opcao = 6;
            while (opcao != 0)
            {
                Console.Clear();
                Console.WriteLine("Escolha a opção");
                Console.WriteLine("1 - Somar");
                Console.WriteLine("2 - Subtrair");
                Console.WriteLine("3 - Multiplicar");
                Console.WriteLine("4 - Dividir");
                Console.WriteLine("0 - Sair");

                Console.WriteLine("==========================================");
                Console.WriteLine("Digite a opção:");
                try
                {
                    opcao = Convert.ToInt16(Console.ReadLine());
                    if (opcao > 0 && opcao < 5)
                    {
                        this.OperacaoDigitada = opcao;
                        this.primeiro();
                        this.segundo();
                        this.operacoes();
                    }
                    else if (opcao < 0 || opcao > 4)
                    this.alerta();
                }catch (Exception)
                {
                    this.alerta();
                }  
            }
            Console.Clear();
            Console.WriteLine("===============FIM DA CALCULADORA==========");
        }

        private void primeiro()
        {
            Console.Clear();
            Console.WriteLine("Digite o primeiro valor:");
            try
            {
                this.numero1 = Convert.ToInt16(Console.ReadLine());
            }
            catch (Exception)
            {
                this.numero1 = 0;
            }
        }

        private void segundo()
        {
            Console.Clear();
            Console.WriteLine("Digite o segundo valor:");
            try
            {
                this.numero2 = Convert.ToInt16(Console.ReadLine());
            }
            catch (Exception)
            {
                this.numero1 = 0;
            }
        }

        private void operacoes()
        {
            switch (this.OperacaoDigitada)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("## Soma ##");
                    Console.WriteLine($"Resultado:{this.numero1} + {this.numero2}");
                    Console.WriteLine(somar());
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("## Subtrair ##");
                    Console.WriteLine($"Resultado:{this.numero1} - {this.numero2}");
                    Console.WriteLine(subtrair());
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("## Multiplicar ##");
                    Console.WriteLine($"Resultado:{this.numero1} * {this.numero2}");
                    Console.WriteLine(multiplicar());
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("## Dividir ##");
                    Console.WriteLine($"Resultado:{this.numero1} / {this.numero2}");
                    Console.WriteLine(dividir());
                    break;
            }
              Console.WriteLine("Digite qualquer tecla para continuar");
              Console.ReadKey();
         }
    }
}
