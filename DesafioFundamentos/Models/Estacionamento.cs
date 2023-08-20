namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
           
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine(); // recebendo o que o usuario digirar

            {
                veiculos.Add(placa); //Adicionando na lista veiculios a placa
            }
        }


        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
             string placa = Console.ReadLine(); ;

            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                string qthoras = Console.ReadLine();// recebendo o que o usuario digirar
                int horas = Convert.ToInt32(qthoras); // invertendo para int para poder receber o valor inteiro
               

                {
                    decimal valorTotal = precoInicial + precoPorHora * horas; // fazendo a contagem do valor total
                    Console.WriteLine(valorTotal);

                   Console.WriteLine($"O veículo '{placa}' foi removido e o preço total foi de: R$ {valorTotal},00 reais");
                    veiculos.Remove(placa); // removendo da lista veiculos a placa
                }
                }
            else
                {
                    Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
                }
            }

            public void ListarVeiculos()
            {
                
                if (veiculos.Any())
                {
                    Console.WriteLine("Os veículos estacionados são:");

                    foreach (string placa in veiculos)// fazendo a variavel placa porcorrer cada campo da lista veiculos 
                    {
                        Console.WriteLine(placa);

                    }
                }
                else
                {
                    Console.WriteLine("Não há veículos estacionados.");
                }
            }
        }
    }
