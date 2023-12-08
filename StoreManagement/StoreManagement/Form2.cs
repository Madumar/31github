using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace StoreManagement
{
    public partial class Form2 : Form
    {
        //List<Product> myProducts = new List<Product>();
        int indexToShow = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }

        private void ShowProduct()
        {
            int productCount = MyDataBase.allProducts.Count;
            if (productCount > 0)
            {
                lblCount.Text = $"{indexToShow + 1}/{MyDataBase.allProducts.Count}";
                lblName.Text = MyDataBase.allProducts[indexToShow].Name;
                lblProducer.Text = MyDataBase.allProducts[indexToShow].Producer;
                lblQuantity.Text = MyDataBase.allProducts[indexToShow].Quantity.ToString();
            }


            if (indexToShow >= MyDataBase.allProducts.Count-1)
            {
                button1.Enabled = false;
            }
            if (indexToShow == 0)
            {
                btnBack.Enabled = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            indexToShow++;
            ShowProduct();
            btnBack.Enabled = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            indexToShow--;
            ShowProduct();
            button1.Enabled = true;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //FileStream fs = new FileStream("Products.txt", FileMode.Open, FileAccess.Read);
            //StreamReader sr = new StreamReader(fs);

            //while (!sr.EndOfStream)
            //{
            //    string line = sr.ReadLine();
            //    string[] splittedLine = line.Split(';');
            //    Product p = new Product(splittedLine[0], splittedLine[1]
            //        , Convert.ToInt32(splittedLine[2]));
            //    myProducts.Add(p);
            //}

            //sr.Close();
            //fs.Close();

            MyDataBase.ReadProducts();
            ShowProduct();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MyDataBase.DeleteProduct(indexToShow);
            ShowProduct();
        }
    }
}
