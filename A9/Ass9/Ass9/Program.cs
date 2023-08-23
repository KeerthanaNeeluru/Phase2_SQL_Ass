
using System;
using System.Data.SqlClient;
using System.Data;
using System.Security.Cryptography;

namespace SQLDisconnect
{
    internal class Program
    {
        static SqlConnection con;
        static SqlCommand cmd;

        static SqlDataReader reader;
        static string constr = "server= LAPTOP-PNAP8MRF;database=Ass_9;trusted_connection=true;";

        public static void ExecutePlaceOrder (int cid,double tamt) {
            con = new SqlConnection(constr);


            con.Open();

            cmd = new SqlCommand();
            //insert 
            cmd.CommandText = "PlaceOrder"; ;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@cid", cid);
            cmd.Parameters.AddWithValue("@tamt", tamt);
            cmd.ExecuteNonQuery();
            Console.WriteLine("Order  added!!!");
        }
        static void Main(string[] args)
        {
            try
            {
                

                Console.WriteLine("Enter Customer Id");
                int Cid = int.Parse(Console.ReadLine());
                
                Console.WriteLine("Enter Total Amount of order");
                double Tamt= double.Parse(Console.ReadLine());
                ExecutePlaceOrder(Cid,Tamt);
               
               
            }
            catch (Exception e)
            {
                Console.WriteLine("Error!!!!" + e.Message);
            }
            finally
            {
                Console.WriteLine("End of Program!!!!");
                Console.ReadKey();
            }
        }
    }
}