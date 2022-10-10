

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal PrecoInicial = 0;
        private decimal PrecoPorHora = 0;
        private List<string> Veiculos = new List<string>();

        //Estanciou o Veiculos na memoria stack



        // Construtor       

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            PrecoInicial = precoInicial;
            PrecoPorHora = precoPorHora;
        }


        //Entrada console.readline para usuario digitar a placa
        public void AdicionarVeiculo()
        {
             
            
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string addPlaca = Console.ReadLine();
            Veiculos.Add(addPlaca);
            
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");


            
            string placa = "";
            Console.WriteLine("Digite a placa do veículo para remover: ");
            placa = Console.ReadLine();

            // Verifica se o veículo existe
              if (Veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                int horas = int.Parse(Console.ReadLine());

                               
               
                horas = 0;
                decimal valorTotal = 0; 
                valorTotal = Convert.ToInt32(PrecoInicial + PrecoPorHora * horas);

                // TODO: Remover a placa digitada da lista de veículos
                // *IMPLEMENTE AQUI*
                Veiculos.Remove(placa);

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }


        // Verifica se há veículos no estacionamento
        public void ListarVeiculos()
        {
            
            if (Veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
               
               
                int i = 1;             
                foreach(string item in Veiculos)
                {
                     Console.WriteLine($"{i}° - {item}");
                    i++;
                }
                   
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
