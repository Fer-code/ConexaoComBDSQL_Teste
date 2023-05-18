using Azure;
using ConexaoComBDSQL_Teste;
using Microsoft.Data.SqlClient;
using System;
using System.Data;

public class Menu{
    static void Main(string[] args)
    {
        OperationsCargo operationsC = new OperationsCargo();
        OperationsFunc operationsF = new OperationsFunc();
        bool sair = false;

        while (!sair)
        {
            Console.Clear();

            Console.WriteLine("-----------MENU-----------");
            Console.WriteLine("1 - CARGOS");
            Console.WriteLine("2 - FUNCIONARIOS");
            Console.WriteLine("3 - SAIR");
            Console.WriteLine("\n");
            Console.WriteLine("Insira o número da operaçao: ");

            switch (Console.ReadLine())
            {
                //CASE PARA CARGOS
                case "1":
                    Console.Clear();
                    Console.WriteLine("1 - Consultar.");
                    Console.WriteLine("2 - Cadastrar.");
                    Console.WriteLine("3 - Atualizar");
                    Console.WriteLine("4 - Deletar");
                    Console.WriteLine("Opcao: ");

                    switch (Console.ReadLine())
                    {
                        case "1":
                            Console.Clear();
                            operationsC.Read();


                            break;
                        case "2":
                            Console.Clear();
                            operationsC.Write();
                            Console.ReadLine();


                            break;
                        case "3":
                            Console.Clear();
                            operationsC.Read();
                            Console.WriteLine("\n");
                            operationsC.Update();
                            Console.ReadLine();


                            break;
                        case "4":
                            Console.Clear();
                            operationsC.Read();
                            Console.WriteLine("\n");
                            operationsC.Delete();

                            break;


                    }


                    break;

            
                //CASE PARA FUNCIONARIOS
                case "2":
                    Console.Clear();
                    Console.WriteLine("1 - Consultar.");
                    Console.WriteLine("2 - Cadastrar.");
                    Console.WriteLine("3 - Atualizar");
                    Console.WriteLine("4 - Deletar");

                    switch (Console.ReadLine())
                    {
                        case "1":
                            Console.Clear();
                            operationsF.Read();


                            break;
                        case "2":
                            Console.Clear();
                            operationsF.Write();
                            Console.ReadLine();

                            break;
                    }
                 break;

                //CASE PARA SAIR
                case "3":

                    sair = true;

                    break;

            }

        }
    }
}