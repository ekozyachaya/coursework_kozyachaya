namespace kozyachaya_coursework
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.productWeightTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.productsInfoButton = new System.Windows.Forms.Button();
            this.remainingCaloriesTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.eatenProductsTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.productNameComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(31, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выберите название продукта:";
            // 
            // productWeightTextBox
            // 
            this.productWeightTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productWeightTextBox.Location = new System.Drawing.Point(74, 178);
            this.productWeightTextBox.Name = "productWeightTextBox";
            this.productWeightTextBox.Size = new System.Drawing.Size(192, 21);
            this.productWeightTextBox.TabIndex = 5;
            this.productWeightTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.productWeightTextBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(40, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Введите массу продукта(г):\r\n";
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addButton.Location = new System.Drawing.Point(59, 248);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(222, 38);
            this.addButton.TabIndex = 11;
            this.addButton.Text = "Добавить продукт";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // productsInfoButton
            // 
            this.productsInfoButton.Font = new System.Drawing.Font("Segoe Script", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productsInfoButton.Location = new System.Drawing.Point(16, 304);
            this.productsInfoButton.Name = "productsInfoButton";
            this.productsInfoButton.Size = new System.Drawing.Size(310, 38);
            this.productsInfoButton.TabIndex = 12;
            this.productsInfoButton.Text = "Информация о продуктах";
            this.productsInfoButton.UseVisualStyleBackColor = true;
            this.productsInfoButton.Click += new System.EventHandler(this.productsInfoButton_Click);
            // 
            // remainingCaloriesTextBox
            // 
            this.remainingCaloriesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.remainingCaloriesTextBox.Location = new System.Drawing.Point(472, 364);
            this.remainingCaloriesTextBox.Name = "remainingCaloriesTextBox";
            this.remainingCaloriesTextBox.ReadOnly = true;
            this.remainingCaloriesTextBox.Size = new System.Drawing.Size(221, 21);
            this.remainingCaloriesTextBox.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(432, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(294, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Осталось употребить калорий:";
            // 
            // eatenProductsTextBox
            // 
            this.eatenProductsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eatenProductsTextBox.Location = new System.Drawing.Point(472, 67);
            this.eatenProductsTextBox.Multiline = true;
            this.eatenProductsTextBox.Name = "eatenProductsTextBox";
            this.eatenProductsTextBox.ReadOnly = true;
            this.eatenProductsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.eatenProductsTextBox.Size = new System.Drawing.Size(221, 266);
            this.eatenProductsTextBox.TabIndex = 16;
            this.eatenProductsTextBox.Click += new System.EventHandler(this.eatenProductsTextBox_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(415, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(340, 27);
            this.label4.TabIndex = 15;
            this.label4.Text = "Употребленные продукты за сегодня:";
            // 
            // productNameComboBox
            // 
            this.productNameComboBox.FormattingEnabled = true;
            this.productNameComboBox.Items.AddRange(new object[] {
            "абрикос",
            "авокадо",
            "алыча",
            "ананас",
            "апельсин",
            "арбуз",
            "баклажан",
            "банан",
            "баранина",
            "батон",
            "белый гриб",
            "бобы",
            "брусника",
            "булгур",
            "вареная колбаса диетическая",
            "вареная колбаса докторская",
            "варено-копченая колбаса",
            "варенье грушевое",
            "варенье малиновое",
            "варенье яблочное",
            "ветчина",
            "виноград",
            "вишня",
            "говядина",
            "голубика",
            "горбуша",
            "горошек зеленый",
            "гранат",
            "грейпфрут",
            "гречка",
            "груша",
            "гусь",
            "драже шоколадное",
            "ежевика",
            "земляника",
            "изюм кишмиш",
            "изюм с косточкой",
            "икра красная",
            "икра черная",
            "индейка",
            "инжир",
            "йогурт 1,5% жирности",
            "кабачок",
            "кальмар",
            "камбала",
            "капуста белокачанная",
            "капуста краснокачанная",
            "карась",
            "карп",
            "картофель",
            "кета",
            "кефир 1% жирности",
            "кефир 3,2% жирности",
            "киви",
            "киноа",
            "козинак арахисовый",
            "козинак кунжутный",
            "козинак подсолнечный",
            "конфеты молочные",
            "конфеты шоколадные",
            "краб",
            "креветка",
            "кролик",
            "крыжовник",
            "кукурзные палочки сладкие",
            "кукурузная крупа",
            "курага",
            "курица",
            "лапша яичная",
            "лимон",
            "лисички",
            "лосось",
            "лук зеленый",
            "лук порей",
            "лук репчатый",
            "макароны из муки высшего сорта",
            "макароны из муки первого сорта",
            "малина",
            "мандарин",
            "манная крупа",
            "мармелад",
            "мармелад жевательный",
            "марципан",
            "масло растительное",
            "масло сливочное",
            "масса творожная",
            "минтай",
            "мойва",
            "молоко 1,5 % жирности",
            "молоко 3,2% жирности",
            "молоко коровье цельное",
            "молоко обезжиренное",
            "молоко сгущенное",
            "молоко сгущенное с сахаром",
            "молоко сухое цельное",
            "морковь",
            "мороженое сливочное",
            "овес ",
            "овсяное печенье",
            "овсяные хлопья",
            "огурец",
            "палтус",
            "пастила яблочная",
            "перец зеленый сладкий",
            "перец красный сладкий",
            "перловая крупа",
            "персик",
            "персик сушеный",
            "петрушка",
            "печень трески",
            "печенье",
            "пирожное Картошка",
            "пирожное Эклер",
            "подберезовики",
            "подосиновики",
            "полба",
            "помидор",
            "простокваша",
            "пряник Тульский",
            "пшеничная крупа",
            "пшеничная мука высшего сорта",
            "пшеничная мука первого сорта",
            "пшено",
            "редис",
            "редька",
            "репа",
            "ржаная мука",
            "рис",
            "рисовая мука",
            "ряженка",
            "салат листовой",
            "сардельки свиные",
            "сахар",
            "свекла",
            "свинина",
            "сельдь",
            "семга",
            "скумбрия",
            "слива",
            "сливки 10% жирности",
            "сливки 20% жирности",
            "слоеные ушки",
            "сметана 10% жирности",
            "сметана 20% жирности",
            "сметана 30% жирности",
            "смородина белая",
            "смородина красная",
            "смородина черная",
            "сосиски куриные",
            "соя",
            "сыр голландский",
            "сыр колбасный",
            "сыр Ламбер",
            "сыр Пармезан",
            "сыр плавленый",
            "сыр российский",
            "сыр швейцарский",
            "сыроежки",
            "сырок творожный",
            "творог 10% жирности",
            "творог 5% жирности",
            "творог обезжиренный",
            "телятина",
            "тунец",
            "утка",
            "фасоль",
            "финики",
            "халва",
            "хек",
            "хлеб черный",
            "хурма",
            "черешня",
            "черника",
            "чернослив",
            "чеснок",
            "чечевица",
            "шампиньоны",
            "шоколад белый",
            "шоколад молочный",
            "шоколад темный",
            "шоколадная паста",
            "шпинат",
            "щавель",
            "щука",
            "яблоко",
            "яйцо куриное",
            "яйцо перепелиное",
            "ячневая крупа"});
            this.productNameComboBox.Location = new System.Drawing.Point(74, 104);
            this.productNameComboBox.Name = "productNameComboBox";
            this.productNameComboBox.Size = new System.Drawing.Size(192, 21);
            this.productNameComboBox.Sorted = true;
            this.productNameComboBox.TabIndex = 17;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.productNameComboBox);
            this.Controls.Add(this.eatenProductsTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.remainingCaloriesTextBox);
            this.Controls.Add(this.productsInfoButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.productWeightTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "CalTrack";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox productWeightTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button productsInfoButton;
        private System.Windows.Forms.TextBox remainingCaloriesTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox eatenProductsTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox productNameComboBox;
    }
}