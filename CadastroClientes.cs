using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class CadastroClientes : Form
    {
        public CadastroClientes(IContainer components, TextBox idTextBox, Label label1, TextBox nameTextBox, Label label2, Label label3, TextBox addressTextBox, Label label4, Label label5, Label label6, Label label7, TextBox districtTextBox, TextBox cityTextBox, TextBox ufTextBox, Label mobileTextBox, Label label9, TextBox textBox9, Button searchBtn, Button saveBtn, Button updateBtn, Button deleteBtn, MaskedTextBox phoneTextBox, MaskedTextBox postalZipTextBox)
        {
            InitializeComponent();
            this.components = components;
            IdTextBox = idTextBox;
            this.label1 = label1;
            NameTextBox = nameTextBox;
            this.label2 = label2;
            this.label3 = label3;
            AddressTextBox = addressTextBox;
            this.label4 = label4;
            this.label5 = label5;
            this.label6 = label6;
            this.label7 = label7;
            DistrictTextBox = districtTextBox;
            CityTextBox = cityTextBox;
            UfTextBox = ufTextBox;
            MobileTextBox = mobileTextBox;
            this.label9 = label9;
            this.textBox9 = textBox9;
            SearchBtn = searchBtn;
            SaveBtn = saveBtn;
            UpdateBtn = updateBtn;
            DeleteBtn = deleteBtn;
            PhoneTextBox = phoneTextBox;
            PostalZipTextBox = postalZipTextBox;
        }

        readonly SqlConnection SqlConnection = null;
        private string ConnectionString = @"Server=.\sqlexpress;Database=bdcadastro;Trusted_Connection=True;";
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            string SQLQuery = "INSERT INTO CLIENTE (NOME, ENDERECO, CEP, BAIRRO, CIDADE, UF, TELEFONE) " + $"VALUES ('{NameTextBox.Text}', '{AddressTextBox.Text}', '{PostalZipTextBox.Text}', '{DistrictTextBox.Text}', '{CityTextBox.Text}', '{UfTextBox.Text}', '{MobileTextBox.Text}') " ;
            SqlConnection Connection = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand(SQLQuery, Connection);
            cmd.CommandType = CommandType.Text;
            Connection.Open();
            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Cadastro realizado com sucesso");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
            }
            finally
            {
                Connection.Close();
            }

            PhoneTextBox.Text = "";
            PostalZipTextBox.Text = "";
            MobileTextBox.Text = "";
            UfTextBox.Text = "";
            CityTextBox.Text = "";
            DistrictTextBox.Text = "";
            AddressTextBox.Text = "";
            NameTextBox.Text = "";
            IdTextBox.Text = "";
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
