using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kozyachaya_coursework
{
    public partial class Form2 : Form
    {
        private ProductInfo productInfo = new ProductInfo();
        
        private int remainingCalories = Form1.CaloriesNorm;
        private StringBuilder stringBuilder = new StringBuilder();
        private WorkWithFile workingWithFile = new WorkWithFile();

        public Form2()
        {
            InitializeComponent();
            productNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            productNameComboBox.KeyPress += (sender, e) => e.Handled = true;

            remainingCaloriesTextBox.Text = remainingCalories.ToString();
            eatenProductsTextBox.Text = workingWithFile.readFromFile();
        }

        private void productNameComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            string symbol = e.KeyChar.ToString();

        }
        private void addButton_Click(object sender, EventArgs e)
        {
            String productName = productNameComboBox.Text;
            String currentProduct;
            int productWeight = 0;
            int caloriesOfProduct = 0;

            if (productWeightTextBox.Text == "")
            {
                MessageBox.Show("Заполните все поля!", "Ошибка!");
            }
            else
            {
                productWeight = Convert.ToInt32(productWeightTextBox.Text);
            }

            foreach (KeyValuePair<string, int> keyValue in productInfo.ProductsInfoList)
            {
                if (keyValue.Key.Equals(productName))
                {
                    caloriesOfProduct = (keyValue.Value * productWeight) / 100;
                }
            }

            if (productWeight == 0)
            {
                MessageBox.Show("Пожалуйста, введите массу продукта", "Ошибка!");
                
            }

            if (productNameComboBox.Text != "")
            {
                remainingCalories -= caloriesOfProduct;
                stringBuilder.Append(productName + ", " + caloriesOfProduct + " калорий" + "\r\n");
                currentProduct = productName + ", " + caloriesOfProduct + " калорий";
                if (remainingCalories <= 0)
                {
                    MessageBox.Show("Вы истратили лимит калорий на сегодня", "Внимание!");

                }

                eatenProductsTextBox.Text = stringBuilder.ToString();
                remainingCaloriesTextBox.Text = remainingCalories.ToString();
                workingWithFile.writeIntoFile(currentProduct);
            }
        }

        private void productsInfoButton_Click(object sender, EventArgs e)
        {
            StringBuilder productsStringBuilder = new StringBuilder();
            foreach (KeyValuePair<string, int> keyValue in productInfo.ProductsInfoList)
            {
                productsStringBuilder.Append(keyValue.Key + ", " + keyValue.Value + " калорий" + "\r\n");
            }
            
            MessageBox.Show(productsStringBuilder.ToString(), "Список доступных продуктов");
        }

        private void productNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            string symbol = e.KeyChar.ToString();

            if (!Regex.Match(symbol, @"[а-яА-Я]").Success)
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Back)
                e.Handled = false;
        }

        private void productWeightTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            string symbol = e.KeyChar.ToString();

            if (!Regex.Match(symbol, @"[0-9]").Success)
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Back)
                e.Handled = false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            stringBuilder.Append(eatenProductsTextBox.Text);
        }

        private void eatenProductsTextBox_Click(object sender, EventArgs e)
        {
            eatenProductsTextBox.Text = "";
        }

    }
}
