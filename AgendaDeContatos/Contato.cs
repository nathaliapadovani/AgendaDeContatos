namespace AgendaDeContatos
{
    // Classe com as propriedades básicas de um contato, representa uma pessoa que vai ficar na agenda
    public class Contato
    {
        // Nome, telefone e email são propriedades públicas (visíveis fora da classe)
        // o get e set significa que elas podem ser lidas e alteradas
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

        // Esse é o construtor da classe. Ele serve para criar um novo objeto Contato já com os dados preenchidos
        public Contato(string nome, string telefone, string email)
        {
            Nome = nome;
            Telefone = telefone;
            Email = email;
        }

        // Esse é um método da classe que exibe o contato no console
        public void ExibirContato()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Telefone: {Telefone}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine("------------------------------");
        }
    }
}
