using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations.Sql;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A8
{
    internal class Program
    {
        static Ass_8Entities db;
        static Employee emp;
        static Product p;
        static Order o;
        static void Main(string[] args)
        {
            Console.WriteLine("Select Table\n1.Employee\t2.Products\t3.Orders");
            int t = int.Parse(Console.ReadLine());
            switch (t)
            {
                case 1:
                    Console.WriteLine("Select operation \n1.Insert\t2.Read\t3.Update\t4.Delete");
                    int eop = int.Parse(Console.ReadLine());
                    switch (eop)
                    {
                        case 1:
                            try
                            {
                                db = new Ass_8Entities();
                                Employee emp = new Employee();
                                Console.WriteLine("Enter Id");
                                emp.EmpId = int.Parse(Console.ReadLine());
                                Console.WriteLine("Enter FirstName");
                                emp.FirstName = Console.ReadLine();
                                Console.WriteLine("Enter LastName");
                                emp.LastName = Console.ReadLine();
                                Console.WriteLine("Enter BirthDate");
                                emp.BirthDate = DateTime.Parse(Console.ReadLine());
                                Console.WriteLine("Enter Salary");
                                emp.Salary = decimal.Parse(Console.ReadLine());
                                db.Employees.Add(emp);
                                db.SaveChanges();
                                Console.WriteLine("Employee added !!!!!");

                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }


                            break;
                        case 2:
                            try
                            {
                                db = new Ass_8Entities();
                                foreach (Employee e in db.Employees)
                                {
                                    Console.WriteLine("EmpId : " + e.EmpId);
                                    Console.WriteLine("FirstName : " + e.FirstName);
                                    Console.WriteLine("LastName : " + e.LastName);
                                    Console.WriteLine("BirthDate : " + e.BirthDate);
                                    Console.WriteLine("Salary : " + e.Salary);

                                    Console.WriteLine("-----------------------------------------------");
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }
                            break;
                        case 3:
                            try
                            {
                                db = new Ass_8Entities();
                                Console.WriteLine("Enter Id to update details");
                                int id = int.Parse(Console.ReadLine());
                                emp = db.Employees.SingleOrDefault(e => e.EmpId == id);
                                if (emp == null)
                                {
                                    Console.WriteLine($"No such id {id} exist in Day_8 database");
                                }
                                else
                                {
                                    Console.WriteLine("Enter new FirstName");
                                    emp.FirstName = Console.ReadLine();
                                    Console.WriteLine("Enter new LastName");
                                    emp.LastName = Console.ReadLine();
                                    Console.WriteLine("Enter new BirthDate");
                                    emp.BirthDate = DateTime.Parse(Console.ReadLine());
                                    Console.WriteLine("Enter Salary");
                                    emp.Salary = decimal.Parse(Console.ReadLine());

                                    db.SaveChanges();
                                    Console.WriteLine("Record updated!!!!!");
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }
                            break;
                        case 4:
                            try
                            {
                                db = new Ass_8Entities();
                                Console.WriteLine("Enter Id to delete details");
                                int id = int.Parse(Console.ReadLine());
                                emp = db.Employees.SingleOrDefault(e => e.EmpId == id);
                                if (emp == null)
                                {
                                    Console.WriteLine($"No such id {id} exist in  database");
                                }
                                else
                                {
                                    db.Employees.Remove(emp);
                                    db.SaveChanges();
                                    Console.WriteLine("Employee record deleted");
                                }

                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }
                            break;
                    }
                    break;
                case 2:
                    Console.WriteLine("Select operation \n1.Insert\t2.Read\t3.Update\t4.Delete");
                    int pop = int.Parse(Console.ReadLine());
                    switch (pop)
                    {
                        case 1:
                            try
                            {
                                db = new Ass_8Entities();
                                Product p = new Product();
                                Console.WriteLine("Enter Product Id");
                                p.ProdId = int.Parse(Console.ReadLine());
                                Console.WriteLine("Enter Product Name");
                                p.ProdName = Console.ReadLine();
                                Console.WriteLine("Enter Product Description");
                                p.Describe = Console.ReadLine();
                                Console.WriteLine("Enter Price");
                                p.Price = decimal.Parse(Console.ReadLine());
                                Console.WriteLine("Enter Release Date");
                                p.ReleaseDate = DateTime.Parse(Console.ReadLine());
                                db.Products.Add(p);
                                db.SaveChanges();
                                Console.WriteLine("Product added !!!!!");

                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }

                            break;
                        case 2:
                            try
                            {
                                db = new Ass_8Entities();
                                foreach (Product p in db.Products)
                                {
                                    Console.WriteLine("ProdId : " + p.ProdId);
                                    Console.WriteLine("ProdName : " + p.ProdName);
                                    Console.WriteLine("Describe : " + p.Describe);
                                    Console.WriteLine("Price : " + p.Price);
                                    Console.WriteLine("ReleaseDate : " + p.ReleaseDate);

                                    Console.WriteLine("-----------------------------------------------");
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }
                            break;
                        case 3:
                            try
                            {
                                db = new Ass_8Entities();
                                Console.WriteLine("Enter product Id to update details");
                                int id = int.Parse(Console.ReadLine());
                                p = db.Products.SingleOrDefault(e => e.ProdId == id);
                                if (p == null)
                                {
                                    Console.WriteLine($"No such  product with id {id} exist in Day_8 database");
                                }
                                else
                                {
                                    Console.WriteLine("Enter Product Name");
                                    p.ProdName = Console.ReadLine();
                                    Console.WriteLine("Enter Product Description");
                                    p.Describe = Console.ReadLine();
                                    Console.WriteLine("Enter Price");
                                    p.Price = decimal.Parse(Console.ReadLine());
                                    Console.WriteLine("Enter Release Date");
                                    p.ReleaseDate = DateTime.Parse(Console.ReadLine());

                                    db.SaveChanges();
                                    Console.WriteLine("Record updated!!!!!");
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }
                            break;
                        case 4:
                            try
                            {
                                db = new Ass_8Entities();
                                Console.WriteLine("Enter Id to delete details");
                                int id = int.Parse(Console.ReadLine());
                                p = db.Products.SingleOrDefault(e => e.ProdId == id);
                                if (p == null)
                                {
                                    Console.WriteLine($"No such id {id} exist in Day_8 database");
                                }
                                else
                                {
                                    db.Products.Remove(p);
                                    db.SaveChanges();
                                    Console.WriteLine("product record deleted");
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }
                            break;
                    }
                    break;
                case 3:
                    Console.WriteLine("Select operation \n1.Insert\t2.Read\t3.Update\t4.Delete");
                    int oop = int.Parse(Console.ReadLine());
                    switch (oop)
                    {
                        case 1:
                            try
                            {
                                db = new Ass_8Entities();
                                Order o = new Order();
                                Console.WriteLine("Enter Order Id");
                                o.OrderId = int.Parse(Console.ReadLine());
                                Console.WriteLine("Enter OderDate");
                                o.OrderDate = DateTime.Parse(Console.ReadLine());
                                Console.WriteLine("Enter Quantity");
                                o.Quantity = int.Parse(Console.ReadLine());
                                Console.WriteLine("Enter Discount");
                                o.Discount = double.Parse(Console.ReadLine());
                                Console.WriteLine("Enter whether order is shipped(1) or not(0)");
                                o.isShipped = bool.Parse(Console.ReadLine());
                                db.Orders.Add(o);
                                db.SaveChanges();
                                Console.WriteLine("order added !!!!!");

                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }

                            break;
                        case 2:
                            try
                            {
                                foreach (Order o in db.Orders)
                                {
                                    db = new Ass_8Entities();
                                    Console.WriteLine("OrderId : " + o.OrderId);
                                    Console.WriteLine("OrderDate : " + o.OrderDate);
                                    Console.WriteLine("Quantity : " + o.Quantity);
                                    Console.WriteLine("Discount : " + o.Discount);
                                    Console.WriteLine("isShipped : " + o.isShipped);

                                    Console.WriteLine("-----------------------------------------------");
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }
                            break;
                        case 3:
                            try
                            {
                                db = new Ass_8Entities();
                                Console.WriteLine("Enter Order Id to update details");
                                int id = int.Parse(Console.ReadLine());
                                o = db.Orders.SingleOrDefault(e => e.OrderId == id);
                                if (o == null)
                                {
                                    Console.WriteLine($"No such  order with id {id} exist in Day_8 database");
                                }
                                else
                                {
                                    Console.WriteLine("Enter OderDate");
                                    o.OrderDate = DateTime.Parse(Console.ReadLine());
                                    Console.WriteLine("Enter Quantity");
                                    o.Quantity = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Enter Discount");
                                    o.Discount = double.Parse(Console.ReadLine());
                                    Console.WriteLine("Enter whether order is shipped(1) or not(0)");
                                    o.isShipped = bool.Parse(Console.ReadLine());
                                    db.Orders.Add(o);
                                    db.SaveChanges();
                                    Console.WriteLine("Record updated!!!!!");
                                }
                            }

                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }
                            break;
                        case 4:
                            try
                            {
                                db = new Ass_8Entities();
                                Console.WriteLine("Enter Id to delete details");
                                int id = int.Parse(Console.ReadLine());
                                o = db.Orders.SingleOrDefault(e => e.OrderId == id);
                                if (o == null)
                                {
                                    Console.WriteLine($"No such id {id} exist in Day_8 database");
                                }
                                else
                                {
                                    db.Orders.Remove(o);
                                    db.SaveChanges();
                                    Console.WriteLine("order record deleted");
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }
                            break;
                    }
                    break;
            }
        }
    }
}
