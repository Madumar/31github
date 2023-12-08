using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace StoreManagement
{
    static class MyDataBase
    {
        public static List<Product> allProducts = new List<Product>();

        public static void ReadProducts()
        {
            allProducts.Clear();
            FileStream fs = new FileStream("Products.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                string[] splittedLine = line.Split(';');
                Product p = new Product(splittedLine[0], splittedLine[1]
                    , Convert.ToInt32(splittedLine[2]));
                allProducts.Add(p);
            }

            sr.Close();
            fs.Close();
        }

        public static void WriteProduct(Product p)
        {
            FileStream fs = new FileStream("Products.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine($"{p.getData()}");
            allProducts.Add(p);
            sw.Close();
            fs.Close();
        }


        public static void DeleteProduct(int index)
        {
            // A. Delete from the list
            allProducts.RemoveAt(index);

            // B. Re-Write the file
            FileStream fs = new FileStream("Products.txt", FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);

            for (int i = 0; i < allProducts.Count; i++)
            {
                sw.WriteLine($"{allProducts[i].getData()}");
            }
            sw.Close();
            fs.Close();
        }

        public static void DeleteProduct_Version2(int index)
        {
            // A. Delete from the list
            allProducts.RemoveAt(index);

            // B. Re-Write the file
            File.Delete("Products.txt");
            for (int i = 0; i < allProducts.Count; i++)
            {
                WriteProduct(allProducts[i]);
            }

        }
    }
}
