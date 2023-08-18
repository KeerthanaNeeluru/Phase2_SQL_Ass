using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLConnect
{
    internal class Program
    {
        static SqlConnection con;
        static SqlCommand cmd;
        static SqlDataReader reader;
        static string constr = "server= LAPTOP-PNAP8MRF;database=ProductInventory;trusted_connection=true;";

        static void Main(string[] args)
        {
            try
            {
                con = new SqlConnection(constr);
               
                cmd = new SqlCommand();

                Console.WriteLine("Select operation\n1.View all products\t2.Add a product\t3.Update Product Quantity\t4.Remove a product");
                int op = int.Parse(Console.ReadLine());
                switch (op)
                {

                    case 1:
                        cmd = new SqlCommand("Select * from Products", con);
                        con.Open();
                        reader = cmd.ExecuteReader();
                        Console.WriteLine("ProdustID\tProduct name\tPrice\tQuantity\tMfDate\tExpDate");
                        while (reader.Read())
                        {
                            Console.Write(reader["ProductId"] + "\t");
                            Console.Write(reader["ProductName"] + "\t\t");
                            Console.Write(reader["Price"] + "\t\t");
                            Console.Write(reader["Quantity"] + "\t\t");
                            Console.Write(reader["MfDate"] + "\t\t");
                            Console.Write(reader["ExpDate"] + "\t\t");
                            Console.WriteLine("\n");
                        }
                       
                        break;
                    case 2:
                        cmd = new SqlCommand()
                        {
                            CommandText = "insert into Products(ProductId,ProductName,Price,Quantity,MfDate,ExpDate) values (@id,@name,@price,@qty,@mfdate,@edate)",
                            Connection = con
                        };
                        Console.Write("Enter Product id :\t");
                        cmd.Parameters.AddWithValue("@id",int.Parse(Console.ReadLine()));
                        Console.Write("Enter Product name :\t");
                        cmd.Parameters.AddWithValue("@name", Console.ReadLine() );
                        Console.Write("Enter Product Price :\t");
                        cmd.Parameters.AddWithValue("@price", double.Parse(Console.ReadLine()));
                        Console.Write("Enter Product quantity :\t");
                        cmd.Parameters.AddWithValue("@qty", int.Parse(Console.ReadLine()));
                        Console.Write("Enter Product Manufacture date :\t");
                        cmd.Parameters.AddWithValue("@mfdate", DateTime.Parse(Console.ReadLine()));
                        Console.Write("Enter Product Expiry date :\t");
                        cmd.Parameters.AddWithValue("@edate", DateTime.Parse(Console.ReadLine()));
                        con.Open();
                        int nor = cmd.ExecuteNonQuery();
                        if (nor >= 1)
                        {
                            Console.WriteLine("Record inserted");
                        }
                        
                        break;
                    case 3:
                        
                        cmd = new SqlCommand()
                        {
                            CommandText = "select * from Products where ProductId=@id ",
                            Connection = con
                        };

                        con.Open();
                        
                            cmd.CommandText = "update Products set Quantity=@qty where ProductId=@id ";
                            Console.WriteLine("Enter Id to Update");
                            cmd.Parameters.AddWithValue("@id", int.Parse(Console.ReadLine()));

                            Console.Write("Enter Product quantity :\t");
                            cmd.Parameters.AddWithValue("@qty", int.Parse(Console.ReadLine()));
                            
                           int n= cmd.ExecuteNonQuery();
                        if (n >= 1)
                        {


                            Console.WriteLine("Record updated!!!!");
                        }
                        else
                        {
                            Console.WriteLine($" there is no product with id ");
                        }
                        break;
                    case 4:
                        cmd = new SqlCommand()
                        {
                            CommandText = "delete from Products where ProductId=@id",
                            Connection = con
                        };
                        Console.WriteLine("Enter product id to delete");
                        cmd.Parameters.AddWithValue("@id", int.Parse(Console.ReadLine()));
                        con.Open();
                        int no = cmd.ExecuteNonQuery();
                        if (no >= 1)
                        {
                            Console.WriteLine("Record Deleted");
                        }
                        break;

                    default:
                        Console.WriteLine("Invalid selection of operation");
                        break;
                }
              
                

            }
            catch (Exception e)
            {
                Console.WriteLine("Error!!!!!" + e.Message);
            }
            finally
            {
               con.Close();
                Console.ReadKey();
            }

        }
    }
}
