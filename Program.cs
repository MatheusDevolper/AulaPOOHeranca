using System;
using AulaPOO_Heranca.classes;

namespace AulaPOO_Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            PessoaFisica usuarioFisico = new PessoaFisica();
            PessoaJuridica usuarioEmpresa = new PessoaJuridica();
            
            string menu;
            do{
                System.Console.WriteLine("MENU DE ACESSO");
                System.Console.WriteLine("ESCOLHA O SEU PERFIL\n");

                System.Console.WriteLine("[ 1 ] - Pessoa Fisíca");
                System.Console.WriteLine("[ 2 ] - Pessoa Jurídica");
                System.Console.WriteLine("[ 0 ] - Efetuar Logoff");
                menu = Console.ReadLine();

                

                switch (menu)
                {
                    case "1":
                        Console.Clear();
                        usuarioFisico.nome = "Cliente";
                        Console.WriteLine(usuarioFisico.DarBoasVindas(usuarioFisico.nome));

                        Console.WriteLine($"{usuarioFisico.nome}, por favor, digite o seu cpf:");
                        usuarioFisico.cpf = Console.ReadLine();                        

                        
                        Console.WriteLine($"\nO CPF: {usuarioFisico.cpf} é válido!\n");
                       

                        break;
                    case "2":
                        Console.Clear();
                        usuarioEmpresa.nome = "Cliente.LTDA";
                        System.Console.WriteLine(usuarioEmpresa.DarBoasVindas(usuarioEmpresa.nome));

                        System.Console.WriteLine($"\n{usuarioEmpresa.nome}, por favor, digite o seu CNPJ: ");
                        usuarioEmpresa.cnpj = Console.ReadLine();

                        usuarioEmpresa.inscricaoEstadual = "123.456.69";

                        System.Console.WriteLine($"O CNPJ: {usuarioEmpresa.cnpj} é referente à Inscrição Estadual: {usuarioEmpresa.inscricaoEstadual}\n");
                        
                        break;

                    default:
                        break;
                }

            }while(menu !="0");
            
                      

        }
    }
}
