using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System;


namespace Entity_1
{

    //     public class Test
    //     {
    //         static void Main(string[] args)
    //         {
    //             string connectionString = "server=localhost;database=test_maquina;user=root;password=GaBi2605*;";

    //             using (MySqlConnection conn = new MySqlConnection(connectionString))
    //             {
    //                 try
    //                 {
    //                     conn.Open();
    //                     Console.WriteLine("Conexão bem-sucedida!");
    //                 }
    //                 catch (Exception ex)
    //                 {
    //                     Console.WriteLine("Erro: " + ex.Message);
    //                 }
    //             }
    //             using System;
    // using MySql.Data.MySqlClient;

    class Program
    {
        static void Main()
        {
            // String de conexão com o MySQL
            string connectionString = "server=localhost;database=test_maquina;user=root;password=SENHA;";

            // Conexão com o banco de dados
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    Console.WriteLine("Conexão estabelecida com sucesso!");

                    // Comando SQL para inserção
                    string query = "INSERT INTO maquina (id_maquina, tipo, velocidade, hardDisk, placa, memoria, usuario) VALUES (@Id_maquina, @Tipo, @Velocidade, @HardDisk, @Placa_Rede, @Memoria_Ram, @Fk_Usuario)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Adicionando parâmetros
                        cmd.Parameters.AddWithValue("@Id_Maquina", 1);
                        cmd.Parameters.AddWithValue("@Tipo", "Desktop");
                        cmd.Parameters.AddWithValue("@Velocidade", 3);
                        cmd.Parameters.AddWithValue("@HardDisk", 500);
                        cmd.Parameters.AddWithValue("@Placa_Rede", 5);
                        cmd.Parameters.AddWithValue("@Memoria_Ram", 6);
                        cmd.Parameters.AddWithValue("Fk_Usuario", 1);


                        // Executando a inserção
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                            Console.WriteLine("Dados inseridos com sucesso!");
                        else
                            Console.WriteLine("Nenhum dado foi inserido.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro: " + ex.Message);
                }
            }
        }
    }
}