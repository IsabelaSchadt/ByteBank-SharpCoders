namespace ByteBank1
{
    public class Program
    {

        static void ShowMenu()
        {
            Console.WriteLine("1- Inserir novo usuário");
            Console.WriteLine("2- Listar todos os usuarios registrados");
            Console.WriteLine("3- Deletar um usuário");
            Console.WriteLine("4- Detalhes de um usuário");
            Console.WriteLine("5- Total armazenado no banco");
            Console.WriteLine("6- Manipular conta"); // deposito, transferencia e saque 
            Console.WriteLine("0- Para sair do programa");
            Console.Write("Digite a opção desejada: ");
        }

         static void RegistrarNovoUsuario(List<string> cpfs, List<string> titulares, List<string> senhas, List<double> saldos)
        {
            Console.WriteLine("Digite o cpf: ");
            cpfs.Add(Console.ReadLine());

            Console.WriteLine("Digite o nome: ");
            titulares.Add(Console.ReadLine());

            Console.WriteLine("Digite a senha: ");
            senhas.Add(Console.ReadLine());

            saldos.Add(0);
        }

         static void ListarTodasAsContas(List<string> cpfs, List<string> titulares, List<double> saldos)
        {
           for(int i = 0;  i < cpfs.Count; i++) 
            {
                Console.WriteLine($"CPF: {cpfs[i]} | Titular: {titulares[i]} | Saldo: R$:{saldos[i]:F2}" );
            }
        }


        public static void Main(string[] args)
        {
            

            Console.WriteLine("Configurando alguns valores: ");
            Console.WriteLine("Digite a quantidade de usuarios: ");
            int quantidadeDeUsuarios = int.Parse(Console.ReadLine());

            List<string> cpfs = new List<string>();
            List<string> titulares = new List<string>();
            List<string> senhas = new List<string>();
            List<double> saldos = new List<double>();




            int option;
            do
            {
                ShowMenu();
                option = int.Parse(Console.ReadLine());
                Console.WriteLine("--------------------");

                switch (option)
                {
                    case 0: Console.WriteLine("\t\t\tObrigado por utilizar o Byte Bank!");
                        break;
                    case 1: 
                        RegistrarNovoUsuario(cpfs, titulares, senhas, saldos);
                        
                        break;
                    case 2:
                        ListarTodasAsContas(cpfs, titulares, saldos);
                        break;
                }
               
                Console.WriteLine("--------------------");

            } while (option != 0);
            
                 
            
           
        }

        
    }
}