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
            // IMPLEMENTADO
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string dados = Console.ReadLine();
            veiculos.Add(dados.ToUpper());

        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            // Pedir para o usuário digitar a placa e armazenar na variável placa
            string dadosPlaca = Console.ReadLine();
            string placa = dadosPlaca.ToUpper();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x == placa))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                // IMPLEMENTADO         
                string dadosHoras = Console.ReadLine();
                int horas = Convert.ToInt32(dadosHoras);
                decimal valorTotal = precoInicial + precoPorHora * horas;

                // IMPLEMENTADO
                veiculos.Remove(placa);
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void LimparDados()
        {
            Console.WriteLine("Deseja realmente remover todos os dados salvos? Se sim precione Y ou N para cancelar");
            string resposta = Console.ReadLine();

            if (resposta.ToUpper() == "Y")
            {
                veiculos.Clear();
            }
            else
            {
                Console.WriteLine("Operacao cancelada");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                // IMPLEMENTADO
                foreach (string veiculo in veiculos)
                {
                    Console.WriteLine($"{veiculo}");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
