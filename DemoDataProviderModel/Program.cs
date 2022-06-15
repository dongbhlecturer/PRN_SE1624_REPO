using System;
using System.IO;
using System.Data.Common;//ADO.NET 
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace Prn.Se1624;
public class Program
{
    public static void Main()
    {
        IEnumerable<Product> products = GetAllProducts();
       
        foreach (Product product in products)
        {
            Console.WriteLine(product);
        }
        Console.ReadLine();
    }

    //read data from Appsettings.json 

    private static string GetConnectionString()
    {
        IConfiguration config = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("AppSettings.json",true,true)
            .Build();

        return config["ConnectionStrings:FptEduDB"];
    }

    public static List<Product>? GetAllProducts()
    {
        List<Product> products = new List<Product>();
        string vSQL = "select * from products";
      


            //1. init providers
            DbProviderFactory factory = SqlClientFactory.Instance;
            //2. init connection to database SQL server
            using DbConnection? conn = factory.CreateConnection();
            if (conn is null)
            {
                Console.WriteLine("Init connection fail...");
                return null;
            }
            conn.ConnectionString = GetConnectionString();
            conn.Open();
            //3. execute command (sql)
            using DbCommand cmd = conn.CreateCommand();
            if (cmd is null)
            {
                Console.WriteLine("Init connection fail(Command)...");
                return null;
            }
            cmd.CommandText = vSQL;
            cmd.Connection = conn;
            //4. read data from command
            using DbDataReader? reader = cmd.ExecuteReader();
            //5. add to list & return
            if (reader != null & reader.HasRows)
            {
                while (reader.Read())
                {
                    Product p = new Product();
                    p.ProductId = (int)reader["ProductId"];
                    p.ProductName = (string)reader["ProductName"];
                    p.UnitPrice = Convert.ToDouble(reader["UnitPrice"]);
                    products.Add(p);
                }
            }

            return products;
        
    }
}