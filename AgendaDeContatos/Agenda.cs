using System.Collections.Generic;

namespace AgendaDeContatos
{
    // Classe que irá armazenar e gerenciar os contatos
    public class Agenda
    {
        // List<Contato> é uma lista (tipo um array flexível) que vai guardar vários objetos do tipo Contato
        // private significa que só essa classe pode acessar diretamente essa lista (encapsulamento)
        private List<Contato> contatos = new List<Contato>();

        // Método para adicionar contatos
        // Esse método recebe um Contato e adiciona ele à lista usando Add()
        // Depois exibe uma mensagem de sucesso
        public void AdicionarContato(Contato contato)
        {
            contatos.Add(contato);
            Console.WriteLine("Contato adicionado com sucesso!");
        }

        // Listar contatos
        // Verifica se a lista está vazia com contatos.Count == 0
        // Se tiver contatos, ele usa o foreach para passar por cada contato e chama o método ExibirContato()
        public void ListarContatos()
        {
            if(contatos.Count == 0)
            {
                Console.WriteLine("Agenda vazia.");
                return;
            }

            Console.WriteLine("Lista de contatos:");
            foreach (var contato in contatos)
            {
                contato.ExibirContato();
            }
        }

        // Buscar os contatos pelo nome
        // Esse método busca todos os contatos cujo nome contém a palavra buscada.
        // FindAll retorna todos que satisfazem a condição dentro do c => (expressão lambda)
        public void BuscarContato(string nome)
        {
            var encontrados = contatos.FindAll(c => c.Nome.ToLower().Contains(nome.ToLower()));

           // Se nenhum contato for encontrato, exibe uma mensagem
           if (encontrados.Count == 0)
            {
                Console.WriteLine("Nenhum contato encontrado com esse nome.");
            }
           // Se encontrar algum contato, exibe todos com foreach
           else
            {
                Console.WriteLine("Contatos encontrados:");
                foreach (var contato in encontrados)
                {
                    contato.ExibirContato();
                }
            }
        }

        // Remover contato
        // Aqui ele usa Find (ao invés de FindAll) para encontrar apenas o primeiro contato que tiver o nome exato
        // Ignora maiúsculas e minúsculas com ToLower()
        public void RemoverContato(string nome)
        {
            var contato = contatos.Find(c => c.Nome.ToLower() == nome.ToLower());

            // Se o contato for encontrado, remove ele da lista com Remove() e exibe mensagem
            if (contato != null)
            {
                contatos.Remove(contato);
                Console.WriteLine("Contato removido com sucesso!");
            }

            //Se não encontrar, exibe mensagem que não encontrou
            else
            {
                Console.WriteLine("Contato não encontrado.");
            }
        }
    }
}
