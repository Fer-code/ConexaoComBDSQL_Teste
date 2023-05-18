using Azure;
using ConexaoComBDSQL_Teste;
using Microsoft.Data.SqlClient;
using System;
using System.ComponentModel;
using System.Data;

public class OperationsCargo
{
    Connection dbConnection = new Connection();

    //Método de leitura para tabela cargos
    public void Read(){
        dbConnection.Open();

        string query = "SELECT * FROM CargoTB"; 

        DataTable result = dbConnection.ExecuteQuery(query);

        foreach (DataRow row in result.Rows)
        {
            foreach (DataColumn col in result.Columns)
            {
                Console.Write(row[col] + "\t");
            }
            Console.WriteLine();
        }

        dbConnection.Close();

        Console.WriteLine("Pressione qualquer tecla para sair.");
        Console.ReadKey();
    }

    //Método de escrita para tabela cargos
    public void Write() {
        dbConnection.Open();

        Console.WriteLine("Insira o nome do cargo: ");
        string nomeC = Console.ReadLine();

        try
        {
            string query = "INSERT INTO CargoTB (NomeCargo) VALUES ('" + nomeC + "');";

            dbConnection.ExecuteNonQuery(query);

            Console.WriteLine("Operação realizada com sucesso!");
        }catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        dbConnection.Close();

    }

    //Método de atualizacao para tabela cargos
    public void Update()
    {
        dbConnection.Open();

        Console.WriteLine("ID do registro que deseja alterar o nome: ");
        int IDalter = int.Parse(Console.ReadLine());
        Console.WriteLine("Novo nome para o cargo: ");
        string novoNome = Console.ReadLine();

        try
        {
            string query = "UPDATE CargoTB SET NomeCargo = '"+novoNome+"' WHERE IDCargo="+IDalter+";";
            dbConnection.ExecuteNonQuery(query);

            Console.WriteLine("Operação realizada com sucesso");
        }catch(Exception ex) { Console.WriteLine(ex.Message);}
    }

    //Método de exclusao para tabela cargos
    public void Delete()
    {
        dbConnection.Open();

        Console.WriteLine("Insira o ID do cargo que será apagado: ");
        string IDCargo = Console.ReadLine();

        try
        {
            string query = "DELETE FROM CargoTB WHERE IDCargo = " + IDCargo;
            dbConnection.ExecuteNonQuery(query);

            Console.WriteLine("Operação realizada com sucesso");
        }catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        dbConnection.Close();
    }
}