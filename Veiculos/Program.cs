VeiculoDAO vdao = new VeiculoDAO();



int op = 0;
string ops = "";

do
{
    Console.WriteLine(@"Digite 1 para Cadastrar um novo Veiculo
Digite 2 para Listar os Veiculos Cadastrados
Digite 3 para Buscar e Excluir uma placa
Digite 4 para Buscar a placa");
    op = Convert.ToInt32(Console.ReadLine());

    switch (op)
    {
        case 1:

            Console.WriteLine("Digite a Placa do Veiculo");
            string placa = Console.ReadLine();
            Veiculo v = new Veiculo(placa);

            Console.WriteLine("Digite o Numer do Motor:");
            v._NMotor = Console.ReadLine();
            Console.WriteLine("Digite o NIV do Veiculo");
            v._NIV = Console.ReadLine();
            Console.WriteLine("Digite o Renavan do Veiculo");
            v._Renavan = Console.ReadLine();
            Console.WriteLine("Digite o Modelo do Veiculo:");
            v._Modelo = Console.ReadLine();
            Console.WriteLine("Digite a Marca do Veiculo:");
            v._Marca = Console.ReadLine();

            vdao.Cadastrar(v);

            break;

        case 2:

            List<Veiculo> veiculos = vdao.ListarTodos();

            foreach (var vv in veiculos)
            {
                Console.WriteLine("=======");
                Console.WriteLine(vv._Placa);
                Console.WriteLine(vv._NMotor);
                Console.WriteLine(vv._NIV);
                Console.WriteLine(vv._Renavan);
                Console.WriteLine(vv._Modelo);
                Console.WriteLine(vv._Marca);
            }
            break;
        case 3:
            Console.WriteLine("Digite a placa que deseja cancelar:");
            string placaa = Console.ReadLine();
            vdao.Remover(placaa);
            
        break;
        case 4:
            Console.WriteLine("Digite a placa que deseja Pesquisar:");
            string placaaa = Console.ReadLine();
            Veiculo veiculoo = vdao.Pesquisa(placaaa);
            Console.WriteLine(veiculoo._Placa);
            Console.WriteLine(veiculoo._NMotor);
            Console.WriteLine(veiculoo._NIV);
            Console.WriteLine(veiculoo._Renavan);
            Console.WriteLine(veiculoo._Modelo);
            Console.WriteLine(veiculoo._Placa);


            break;

            break;
        default:
        break;
    }
    

    Console.WriteLine("Digite s para sair");
    ops = Console.ReadLine();

    ops.ToLower();
} while (ops != "s");

