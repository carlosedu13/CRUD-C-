﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class CadastroClientes : Form
    {
        public CadastroClientes() => InitializeComponent();

        public CadastroClientes(IContainer components, TextBox idTextBox, Label label1, TextBox nameTextBox, Label label2, Label label3, TextBox addressTextBox, TextBox postalZipTextBox, Label label4, Label label5, Label label6, Label label7, TextBox districtTextBox, TextBox cityTextBox, TextBox ufTextBox, TextBox textBox8, Label mobileTextBox, Label label9, TextBox textBox9, Button searchBtn, Button saveBtn, Button updateBtn, Button deleteBtn)
        {
            this.components = components;
            IdTextBox = idTextBox;
            this.label1 = label1;
            NameTextBox = nameTextBox;
            this.label2 = label2;
            this.label3 = label3;
            AddressTextBox = addressTextBox;
            PostalZipTextBox = postalZipTextBox;
            this.label4 = label4;
            this.label5 = label5;
            this.label6 = label6;
            this.label7 = label7;
            DistrictTextBox = districtTextBox;
            CityTextBox = cityTextBox;
            UfTextBox = ufTextBox;
            this.textBox8 = textBox8;
            MobileTextBox = mobileTextBox;
            this.label9 = label9;
            this.textBox9 = textBox9;
            SearchBtn = searchBtn;
            SaveBtn = saveBtn;
            UpdateBtn = updateBtn;
            DeleteBtn = deleteBtn;
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {

        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {

        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
