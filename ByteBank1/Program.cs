namespace ByteBank1
{
    public class Program
    {

        static void ShowMenu()
        {
            Console.WriteLine("1- Inserir novo usuário");
            Console.WriteLine("2- Listar todas as contas registradas");
            Console.WriteLine("3- Deletar um usuário");
            Console.WriteLine("4- Detalhes de um usuário");
            Console.WriteLine("5- Consutar valor total acumulado no banco");
            Console.WriteLine("6- Manipular conta"); // deposito, transferencia e saque 
            Console.WriteLine("0- Para sair do programa");
            Console.Write("Digite a opção desejada: ");
        }

        //MENU USUARIO

        static void ShowMenuUsuario()
        {
            
            Console.WriteLine("1- Deposito");
            Console.WriteLine("2- Saque");
            Console.WriteLine("3- Transferência");
            
            Console.Write("Digite a opção desejada: ");
        }

        //REGISTRAR USUARIO
        static void RegistrarNovoUsuario(List<string> cpfs, List<string> titulares, List<string> senhas, List<double> saldos)
        {
            Console.Write("Digite o cpf: ");
            cpfs.Add(Console.ReadLine());

            Console.Write("Digite o nome completo: ");
            titulares.Add(Console.ReadLine());

            Console.Write("Digite a senha: ");
            senhas.Add(Console.ReadLine());

            saldos.Add(0);
        }



        //LISTAR USUARIOS REGISTRADOS

        static void ListarTodasAsContas(List<string> cpfs, List<string> titulares, List<double> saldos)
        {
            for (int i = 0; i < cpfs.Count; i++)
            {
                ApresentarConta(i, cpfs, titulares, saldos);
            }
        }

        static void ApresentarConta(int index, List<string> cpfs, List<string> titulares, List<double> saldos)
        {
            Console.WriteLine($"CPF: {cpfs[index]} | Titular: {titulares[index]} | Saldo: R$:{saldos[index]:F2}");
        }


        // DELETAR USUARIO

        static void DeletarUsuario(List<string> cpfs, List<string> titulares, List<string> senhas, List<double> saldos)
        {
            Console.Write("Digite o cpf: ");
            string cpfParaDeletar = Console.ReadLine();
            int indexParaDeletar = cpfs.FindIndex(cpf => cpf == cpfParaDeletar);

            if (indexParaDeletar == -1)
            {
                Console.WriteLine("Conta não encontrada");
                ShowMenu();
            }

            cpfs.Remove(cpfParaDeletar);
            titulares.RemoveAt(indexParaDeletar);
            senhas.RemoveAt(indexParaDeletar);
            saldos.RemoveAt(indexParaDeletar);

            Console.WriteLine("Conta deletada com sucesso");
        }

        //DETALHES DE UM USUARIO 
        static void ApresentarUsuario(List<string> cpfs, List<string> titulares, List<double> saldos)
        {
            Console.Write("Digite o cpf: ");
            string cpfParaApresentar = Console.ReadLine();
            int indexParaApresentar = cpfs.FindIndex(cpf => cpf == cpfParaApresentar);

            if (indexParaApresentar == -1)
            {
                Console.WriteLine("Conta não encontrada");

            }

            ApresentarConta(indexParaApresentar, cpfs, titulares, saldos);
        }

        // TOTAL DO BANCO
        static void ApresentarValorAcumulado(List<double> saldos)
        {
            Console.WriteLine($"Total acumulado no banco: {saldos.Sum()}");

        }

        //MANIPULAR CONTA

       

        //LOGIN
        static void LoginUsuario(List<string> cpfs, List<string> senhas)
        {
            Console.Write("Digite o cpf: ");
            string cpfParaLogin = Console.ReadLine();
            int indexParaCpfLogin = cpfs.FindIndex(cpf => cpf == cpfParaLogin);
            Console.Write("Digite a senha: ");
            string senhaParaLogin = Console.ReadLine();
            int indexParaSenhaLogin = senhas.FindIndex(senha => senha == senhaParaLogin);
            
            if (indexParaCpfLogin == -1)
            {
                Console.WriteLine("Conta não encontrada");

            }
            if (indexParaSenhaLogin == -1)
            {
                Console.WriteLine("Conta não encontrada");

            }

            
        }

        // DEPOSITO
        static void DepositoUsuario(List<double> saldos)
        {
            
            Console.Write($"Valor para deposito R$: ");
            double valorDeposito = double.Parse(Console.ReadLine());
            Console.WriteLine($"Valor depositado R$: {valorDeposito:F2} ");

        }

        //SAQUE
        static void SaqueUsuario(List<double> saldos)
        {

            Console.Write($"Valor para saque R$: ");
            double valorSaque = double.Parse(Console.ReadLine());
            Console.WriteLine($"Valor sacado R$: {valorSaque:F2} ");

        }

        //TRANSFEFENCIA
        static void TransferenciaUsuario(List<double> saldos)
        {

            Console.Write($"Valor para transferir R$: ");
            double valorTransferencia = double.Parse(Console.ReadLine());
            
            Console.Write("Cpf do titular beneficiário: ");
            double cpfBeneficiario = double.Parse(Console.ReadLine());
            Console.WriteLine("Transferência realizada com sucesso!");
        }

        // MAIN
        public static void Main(string[] args)
        {
            
            Console.WriteLine("~~~~~~\t\t\tBEM VINDO(A) AO BYTE BANK!\t\t\t~~~~");
           
            Console.WriteLine();
            Console.WriteLine();


            List<string> cpfs = new List<string>();
            List<string> titulares = new List<string>();
            List<string> senhas = new List<string>();
            List<double> saldos = new List<double>();

            // LISTA USUARIO

            //List<double> saques = new List<double>();
            //List<double> transferencias = new List<double>();
            // List<double> total = new List<double>();





            int option;
            int optionTwo;
            do
            {
                ShowMenu();
                option = int.Parse(Console.ReadLine());
                Console.WriteLine("--------------------");

                switch (option)
                {
                    case 0:
                        Console.WriteLine("\t\t\tObrigado por utilizar o Byte Bank!");
                        break;
                    case 1:
                        RegistrarNovoUsuario(cpfs, titulares, senhas, saldos);

                        break;
                    case 2:
                        ListarTodasAsContas(cpfs, titulares, saldos);
                        break;
                    case 3:
                        DeletarUsuario(cpfs, titulares, senhas, saldos);
                        break;
                    case 4:
                        ApresentarUsuario(cpfs, titulares, saldos);
                        break;
                    case 5:
                        ApresentarValorAcumulado(saldos);
                        break;
                    case 6:
                        LoginUsuario(cpfs, senhas);
                        do
                        {
                            ShowMenuUsuario();
                            optionTwo = int.Parse(Console.ReadLine());
                            switch (optionTwo)
                            {
                                case 1:
                                    DepositoUsuario(saldos);
                                    break;
                                case 2:
                                    SaqueUsuario(saldos);
                                    break;
                                case 3:
                                    TransferenciaUsuario(saldos);
                                    break;
                                
                            }

                        } while (option != 0);

                        break;
                }

                Console.WriteLine("--------------------");

            } while (option != 0);


        }

    }
}