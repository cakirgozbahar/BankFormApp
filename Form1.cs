using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BankProject
{
    public partial class Form1 : Form
    {
        private Form parent;
        Bank bnk;
        public Form1(Form parent)
        {
            bnk = new Bank();
            this.parent = parent;
            InitializeComponent();
            selectData();
        }

        public DataSet makeDBOperations(string query)
        {
            DataSet dataSet = null;
            try
            {
                SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\90535\source\repos\HelloWorld\BankProject\Database1.mdf;Integrated Security=True");
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, connection);

                connection.Open();

                dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet, "Table");
                connection.Close();
            }
            catch
            {
                dataSet = null;
            }

            return dataSet;
        }

        private void btncreate_Click(object sender, EventArgs e)
        {
            Address address = new Address(txtAddress.Text);
            ID id = new ID(txtID.Text);

            Customer cs = new Customer(txtName.Text, txtCustomerID.Text, id, address);
            
            bool result = bnk.addCustomer(cs);
            
            MessageBox.Show("Customer " + txtCustomerID.Text + " has been inserted.", "Adding Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);


            txtName.Text = "";
            txtCustomerID.Text = "";
            txtID.Text = "";
            txtAddress.Text = "";
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show("Are you sure to delete!", "Deleting", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                bool result = bnk.deleteCustomer(cbxDeleteCustomer.SelectedItem.ToString());

                if (result)
                {
                    cbxDeleteCustomer.Items.RemoveAt(cbxDeleteCustomer.SelectedIndex);
                    MessageBox.Show("This customer has been deleted!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("This customer couldn't be deleted!", "Not Deleted", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (cbxDeleteCustomer.Items.Count != 0)
                    cbxDeleteCustomer.SelectedIndex = 0;
            }
        }
        private void btnAddLoan_Click(object sender, EventArgs e)
        {
            
            Loan loan = new Loan(float.Parse(txtTime.Text), Convert.ToDouble(txtInterestRate.Text) , Convert.ToDouble(txtPresentValue.Text));
            if (radioButton1.Checked == true)
            {
                loan.accumulated_value = loan.CompoundInterest(Convert.ToDouble(txtTime.Text), Convert.ToDouble(txtInterestRate.Text) , Convert.ToDouble(txtPresentValue.Text));
            }
            else
            {
                loan.accumulated_value = loan.SimpleInterest(Convert.ToDouble(txtTime.Text), Convert.ToDouble(txtInterestRate.Text), Convert.ToDouble(txtPresentValue.Text));
            }
            bnk.addLoan(loan, Convert.ToInt32(cbxAddLoanToCustomer.SelectedItem.ToString()));
            MessageBox.Show("Loan added to customer " + txtCustomerID.Text + " .", "Adding Loan", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtTime.Text = " ";
            txtInterestRate.Text = " ";
            txtPresentValue.Text = " ";
        }


        private void btnDltLoan_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure to delete!", "Deleting", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                bool result = bnk.deleteLoan(Convert.ToInt32(cbxDltLoanFromCs.SelectedItem.ToString()), cbxDltCsLoans.SelectedItem.ToString());

                if (result)
                {
                    cbxDltCsLoans.Items.RemoveAt(cbxDltCsLoans.SelectedIndex);

                    if (cbxDltCsLoans.Items.Count > 0)
                        cbxDltCsLoans.SelectedIndex = 0;
                    else
                        cbxDltCsLoans.Text = "";

                    MessageBox.Show("This loan has been deleted!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                    MessageBox.Show("This loan couldn't be deleted!", "Not Deleted", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

            private void tbcBank_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbcBank.SelectedIndex == 1)
            {
                cbxDeleteCustomer.Items.Clear();

                DataSet ds = bnk.getAllCustomers();

                int len = ds.Tables[0].Rows.Count;

                for (int i = 0; i < len; i++)
                {
                    cbxDeleteCustomer.Items.Add(ds.Tables[0].Rows[i]["CustomerId"].ToString());
                }

                if (cbxDeleteCustomer.Items.Count != 0)
                    cbxDeleteCustomer.SelectedIndex = 0;
            }
            else if (tbcBank.SelectedIndex == 2)
            {

                comboBox1.Items.Clear();

                DataSet ds = bnk.getAllCustomers();

                int len = ds.Tables[0].Rows.Count;

                for (int i = 0; i < len; i++)
                {
                    comboBox1.Items.Add(ds.Tables[0].Rows[i]["CustomerId"].ToString());
                }

                if (comboBox1.Items.Count > 0)
                    comboBox1.SelectedIndex = 0;


            }
            else if (tbcBank.SelectedIndex == 3)
            {
                cbxAddLoanToCustomer.Items.Clear();
                DataSet ds =bnk.getAllCustomers();

                int len = ds.Tables[0].Rows.Count;

                for (int i = 0; i < len; i++)
                {
                    cbxAddLoanToCustomer.Items.Add(ds.Tables[0].Rows[i]["CustomerId"].ToString());
                }
                if (cbxAddLoanToCustomer.Items.Count != 0)
                    cbxAddLoanToCustomer.SelectedIndex = 0;
            }
            else if (tbcBank.SelectedIndex == 4)
            {
                cbxDltLoanFromCs.Items.Clear();

                DataSet ds =bnk.getAllCustomerID();
                int len = ds.Tables[0].Rows.Count;
              

                for (int i = 0; i < len; i++)
                {
                  cbxDltLoanFromCs.Items.Add(ds.Tables[0].Rows[i]["CustomerId"].ToString());
                }
                if (cbxDltLoanFromCs.Items.Count != 0)
                    cbxDltLoanFromCs.SelectedIndex = 0;
              
            }
            else if (tbcBank.SelectedIndex == 5)
            {
       

            }
            else if (tbcBank.SelectedIndex == 6)
            {
                cbxUpdateCustomer.Items.Clear();

                DataSet ds = bnk.getAllCustomers();

                int len = ds.Tables[0].Rows.Count;

                for (int i = 0; i < len; i++)
                {
                    cbxUpdateCustomer.Items.Add(ds.Tables[0].Rows[i]["CustomerId"].ToString());
                }

                if (cbxUpdateCustomer.Items.Count != 0)
                    cbxUpdateCustomer.SelectedIndex = 0;

            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bool result = bnk.updateCustomer(txtNewAddress.Text, Convert.ToInt32( cbxUpdateCustomer.SelectedItem.ToString()));

            if (result)
            {
                dgvUpdateCustomer.DataSource = bnk.listCustomerInfo(Convert.ToInt32(cbxUpdateCustomer.SelectedItem.ToString())).Tables[0];
                MessageBox.Show("This customer has been update!", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("This customer couldn't be update!", "Not Updated", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            txtNewAddress.Text = " ";
        }

        private void dgvCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            DataSet ds = bnk.listLoanOfCustomer(Convert.ToInt32(comboBox1.SelectedItem.ToString()));
            dgvCustomers.DataSource = ds.Tables[0];
           

        }

        public void selectData()
        {
            DataSet ds = makeDBOperations("select CustomerId, Accumulated_Value from LoanTable");
            crtLoan.DataSource = ds;

            
        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.parent.Visible = true;
        }

        private void cbxDltLoanFromCs_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxDltCsLoans.Items.Clear();

            DataSet ds = bnk.getLoansOfCustomer(Convert.ToInt32(cbxDltLoanFromCs.SelectedItem.ToString()));

            int len2 = ds.Tables[0].Rows.Count;

            for (int i = 0; i < len2; i++)
            {
                cbxDltCsLoans.Items.Add(ds.Tables[0].Rows[i]["Accumulated_Value"].ToString());
            }
            if (cbxDltCsLoans.Items.Count != 0)
            {
                cbxDltCsLoans.Enabled = true;
                cbxDltCsLoans.SelectedIndex = 0;
            }
                

        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled =!char.IsLetter(e.KeyChar)   && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar);
    
        }

        private void cbxUpdateCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = bnk.listCustomerInfo(Convert.ToInt32(cbxUpdateCustomer.SelectedItem.ToString()));
            dgvUpdateCustomer.DataSource = ds.Tables[0];
        }
    }
}
