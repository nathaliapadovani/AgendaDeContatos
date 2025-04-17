namespace AgendaDeContatos;
class Program
{

    // Método principal que inicia a execução do programa
    // Main ponto de entrada
    // Cria um objeto agenda, que será usado para gerenciar os contatos
    // int opcao: variável que vai guardar a opção que o usuário digitar

    // string[] args: argumentos de linha de comando, digitados junto com a execução do programa
    static void Main(string[] args)
    {
        Agenda agenda = new Agenda();
        int opcao;


        // Exibe o menu
        // int.TryParse tenta converter a entrada do usuário para um número inteiro
        // e armazena na variável opcao
        do
        {
            Console.WriteLine("\n=== Agenda de Contatos ===");
            Console.WriteLine("1. Adicionar Contato");
            Console.WriteLine("2. Listar contatos");
            Console.WriteLine("3. Buscar contato");
            Console.WriteLine("4. Remover contato");
            Console.WriteLine("5. Sair");
            Console.WriteLine("Escolha uma opção: ");

            int.TryParse(Console.ReadLine(), out opcao);

            switch (opcao)
            {
                // Usuário apertou o número 1 e então vem para o caso 1 para adicionar contato
                case 1:
                    Console.WriteLine("Nome: ");
                    string nome = Console.ReadLine();
                    Console.Write("Telefone: ");
                    string telefone = Console.ReadLine();
                    Console.Write("Email: ");
                    string email = Console.ReadLine();

                    // Cria um novo contato com os dados e chama o método AdicionarContato da agenda
                    agenda.AdicionarContato(new Contato(nome, telefone, email));
                    break;

                // Usuário apertou o número 2 e então vem para o caso 2 para listar os contatos
                case 2:
                    agenda.ListarContatos();
                    break;

                // Usuário apertou o número 3 e então vem para o caso 3 para buscar contato
                case 3:
                    Console.Write("Digite o nome para buscar: ");
                    string busca = Console.ReadLine();
                    agenda.BuscarContato(busca);
                    break;

                // Usuário apertou o número 4 e então vem para o caso 4 para remover contato
                case 4:
                    Console.Write("Digite o nome para remover: ");
                    string nomeRemover = Console.ReadLine();
                    agenda.RemoverContato(nomeRemover);
                    break;

                // Usuário apertou o número 5 e então vem para o caso 0 para sair do programa
                case 5:
                    Console.WriteLine("Saindo...");
                    break;

                // Caso o usuário aperte qualquer outro número diferente de 0 a 4
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        } while (opcao != 0);
    }
}
