using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProject
{
    internal class Bank
    {
        public List<Customer> customers { get; set; }

        public Bank()
        {
            customers = new List<Customer>();
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
        

        
        public bool addCustomer(Customer cs)
        {

            DataSet ds = makeDBOperations("insert into CustomerTable( Name, ID, Address) values('" + cs.name + "','" + cs.ıd.getID() + "', '" + cs.Address.getText() + "')");
            if (ds != null )
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool deleteCustomer(string idnumber)
        {
            DataSet ds = makeDBOperations("delete from CustomerTable where CustomerId = '" + idnumber + "'");

            if (ds != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public DataSet getAllCustomers()
        {
            return makeDBOperations("select * from CustomerTable");
        }
        public DataSet getAllCustomerID()
        {
            return makeDBOperations("select CustomerId from CustomerTable");
        }
        public DataSet getAllLoan()
        {
            return makeDBOperations("select Accumulated_Value from LoanTable");
        }

        public bool updateCustomer(string ads, int customerid)
        {
            DataSet ds = makeDBOperations("update CustomerTable set Address = '" + ads + "' where CustomerId = '" + customerid + "'");

            if (ds != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }  
        public bool addLoan(Loan loan, int number)
        {
            DataSet ds = makeDBOperations("insert into LoanTable(Accumulated_Value, Present_Value, Time, Interest, CustomerId) values('" + loan.accumulated_value + "', '" + loan.present_value + "','" + loan.time + "', '" + loan.i + "','"+ number +"')");
            if (ds != null )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool deleteLoan(int number, string loan)
        {
            DataSet ds = makeDBOperations("delete from LoanTable where CustomerId = '" + number + "' and Accumulated_Value ='" + loan + "'");
            if (ds != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public DataSet listLoanOfCustomer(int number)
        {
            return makeDBOperations("select Accumulated_Value, Present_Value, Time, Interest from CLView where CustomerId = '" + number + "'");
        }
        public DataSet listCustomerInfo(int number)
        {
            return makeDBOperations("select ID, Name, Address from CustomerView where CustomerId = '"+number+"'");
        }

        public DataSet getLoansOfCustomer(int number)
        {
            return makeDBOperations("select * from LoanTable where CustomerId = '" + number + "'");
        }

    }
}
