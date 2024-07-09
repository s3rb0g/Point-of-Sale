using Microsoft.SqlServer.Server;
using Project.Forms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Project.Classes
{
    
    internal class DatabaseClass
    {
        private string _fname;

        private ArrayList id = new ArrayList();
        private ArrayList itemName = new ArrayList();
        private ArrayList price = new ArrayList();
        private ArrayList quantity = new ArrayList();

        private SqlConnection sqlConnect;
        private SqlCommand sqlCommand;
        private SqlDataReader sqlReader;
        private SqlDataAdapter sqlAdapter;

        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Ranie Gobres\\Desktop\\CRUD\\Project\\Project\\Database\\Database.mdf\";Integrated Security=True";

        public void Store_Account(int id, string fullname, string username, string password, string gender, string birthday)
        {
            sqlConnect = new SqlConnection(connectionString);
            sqlConnect.Open();

            sqlCommand = new SqlCommand("INSERT INTO Accounts VALUES(@Id, @Fullname, " +
                "@Username, @Password, @Gender, @Birthday)", sqlConnect);

            sqlCommand.Parameters.AddWithValue("@Id", id);
            sqlCommand.Parameters.AddWithValue("@Fullname", fullname);
            sqlCommand.Parameters.AddWithValue("@Username", username);
            sqlCommand.Parameters.AddWithValue("@Password", password);
            sqlCommand.Parameters.AddWithValue("@Gender", gender);
            sqlCommand.Parameters.AddWithValue("@Birthday", birthday);

            sqlCommand.ExecuteNonQuery();
            sqlConnect.Close();

        }

        public bool Verifiy_Account(string username, string password)
        {
            connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Ranie Gobres\\Desktop\\CRUD\\Project\\Project\\Database\\Database.mdf\";Integrated Security=True";
            sqlConnect = new SqlConnection(connectionString);
            sqlConnect.Open();

            sqlCommand = new SqlCommand("SELECT Fullname FROM Accounts WHERE Username = @username AND Password = @password", sqlConnect);

            sqlCommand.Parameters.AddWithValue("@username", username);
            sqlCommand.Parameters.AddWithValue("@password", password);

            SqlDataReader sqlReader = sqlCommand.ExecuteReader();

            if (sqlReader.Read())
            {
                _fname = sqlReader.GetValue(0).ToString();
                return true;
            }
            else
            {
                return false;
            }

        }

        public string getUsername()
        {
            return _fname;
        }

        public void setQuantity()
        {
            sqlConnect = new SqlConnection(connectionString);
            sqlConnect.Open();

            SqlCommand command = new SqlCommand("SELECT Quantity FROM Items", sqlConnect);

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                quantity.Add(reader["Quantity"]);
            }
            reader.Close();
            sqlConnect.Close();
        }

        public int getQuantity(int index)
        {
            return (int)quantity[index];
        }

        public void setName()
        {
            sqlConnect = new SqlConnection(connectionString);
            sqlConnect.Open();

            SqlCommand command = new SqlCommand("SELECT [Item Name] FROM Items", sqlConnect);

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                itemName.Add(reader["Item Name"].ToString());
            }
            reader.Close();
            sqlConnect.Close();
        }

        public string getName(int index)
        {
            return (string)itemName[index];
        }

        public void setId()
        {
            sqlConnect = new SqlConnection(connectionString);
            sqlConnect.Open();

            SqlCommand command = new SqlCommand("SELECT Id FROM Items", sqlConnect);

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                id.Add(reader["Id"]);
            }
            reader.Close();
            sqlConnect.Close();
        }

        public int getId(int index)
        {
            return (int)id[index];
        }

        public void setPrice()
        {
            sqlConnect = new SqlConnection(connectionString);
            sqlConnect.Open();

            SqlCommand command = new SqlCommand("SELECT Price FROM Items", sqlConnect);

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                price.Add(reader["Price"]);
            }
            reader.Close();
            sqlConnect.Close();
        }

        public decimal getPrice(int index)
        {
            return Convert.ToDecimal(price[index]);
        }

        public void Store_Records(int id, string custName, string itmName,decimal purchased, decimal total)
        {
            sqlConnect = new SqlConnection(connectionString);
            sqlConnect.Open();

            sqlCommand = new SqlCommand("INSERT INTO Records ([Id], [Customer Name], [Item Name], [Purchased], [Total]) VALUES (@Id, @CustomerName, @ItemName, @Purchased, @Total)", sqlConnect);

            sqlCommand.Parameters.AddWithValue("@Id", id);
            sqlCommand.Parameters.AddWithValue("@CustomerName", custName);
            sqlCommand.Parameters.AddWithValue("@ItemName", itmName);
            sqlCommand.Parameters.AddWithValue("@Purchased", purchased);
            sqlCommand.Parameters.AddWithValue("@Total", total);

            sqlCommand.ExecuteNonQuery();
            sqlConnect.Close();
        }


        public void updateQuantity(int id, int quanty)
        {       
            sqlConnect = new SqlConnection(connectionString);
            sqlConnect.Open();

            sqlCommand = new SqlCommand("SELECT Quantity FROM Items WHERE id = @Id", sqlConnect);

            sqlCommand.Parameters.AddWithValue("@Id", id);

            SqlDataReader sqlReader = sqlCommand.ExecuteReader();

            if (sqlReader.Read())
            {
                int quantity = (int)sqlReader.GetValue(0);
                quantity -= quanty;

                sqlCommand = new SqlCommand("UPDATE Items SET quantity = @Quantity WHERE id = @Id", sqlConnect);

                sqlCommand.Parameters.AddWithValue("@Quantity", quantity);
                sqlCommand.Parameters.AddWithValue("@Id", id);
                
                sqlReader.Close();
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();

            }
           

        }

        private ArrayList accountId = new ArrayList();
        public void setAccountId()
        {
            sqlConnect = new SqlConnection(connectionString);
            sqlConnect.Open();

            SqlCommand command = new SqlCommand("SELECT [Id] FROM Accounts", sqlConnect);

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                accountId.Add(reader["Id"]);
            }
            reader.Close();
            sqlConnect.Close();
        }

        public int getAccountId(int index)
        {
            return (int)accountId[index];
        }


        private ArrayList accountName = new ArrayList();
        public void setAccountName()
        {
            sqlConnect = new SqlConnection(connectionString);
            sqlConnect.Open();

            SqlCommand command = new SqlCommand("SELECT [Fullname] FROM Accounts", sqlConnect);

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                accountName.Add(reader["Fullname"].ToString());
            }
            reader.Close();
            sqlConnect.Close();
        }

        public string getAccountName(int index)
        {
            return (string)accountName[index];
        }

        private ArrayList accountUsername = new ArrayList();
        public void setAccountUsername()
        {
            sqlConnect = new SqlConnection(connectionString);
            sqlConnect.Open();

            SqlCommand command = new SqlCommand("SELECT [Username] FROM Accounts", sqlConnect);

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                accountUsername.Add(reader["Username"].ToString());
            }
            reader.Close();
            sqlConnect.Close();
        }

        public string getAccountUssername(int index)
        {
            return (string)accountUsername[index];
        }

        private ArrayList accountPassword = new ArrayList();
        public void setAccountPassword()
        {
            sqlConnect = new SqlConnection(connectionString);
            sqlConnect.Open();

            SqlCommand command = new SqlCommand("SELECT [Password] FROM Accounts", sqlConnect);

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                accountPassword.Add(reader["Password"].ToString());
            }
            reader.Close();
            sqlConnect.Close();
        }

        public string getAccountPassword(int index)
        {
            return (string)accountPassword[index];
        }

        private ArrayList accountGender = new ArrayList();
        public void setAccountGender()
        {
            sqlConnect = new SqlConnection(connectionString);
            sqlConnect.Open();

            SqlCommand command = new SqlCommand("SELECT [Gender] FROM Accounts", sqlConnect);

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                accountGender.Add(reader["Gender"].ToString());
            }
            reader.Close();
            sqlConnect.Close();
        }

        public string getAccountGender(int index)
        {
            return (string)accountGender[index];
        }

        private ArrayList accountBirthday = new ArrayList();
        public void setAccountBirthday()
        {
            sqlConnect = new SqlConnection(connectionString);
            sqlConnect.Open();

            SqlCommand command = new SqlCommand("SELECT [Birthday] FROM Accounts", sqlConnect);

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                accountBirthday.Add(reader["Birthday"].ToString());
            }
            reader.Close();
            sqlConnect.Close();
        }

        public string getAccountBirthday(int index)
        {
            return (string)accountBirthday[index];
        }


        private ArrayList recordId = new ArrayList();
        public void setRecordId()
        {
            sqlConnect = new SqlConnection(connectionString);
            sqlConnect.Open();

            SqlCommand command = new SqlCommand("SELECT [Id] FROM Records", sqlConnect);

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                recordId.Add(reader["Id"]);
            }
            reader.Close();
            sqlConnect.Close();
        }

        public int getRecordId(int index)
        {
            return (int)recordId[index];
        }

        private ArrayList recordCustomerName = new ArrayList();
        public void setRecordCustomerName()
        {
            sqlConnect = new SqlConnection(connectionString);
            sqlConnect.Open();

            SqlCommand command = new SqlCommand("SELECT [Customer Name] FROM Records", sqlConnect);

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                recordCustomerName.Add(reader["Customer Name"].ToString());
            }
            reader.Close();
            sqlConnect.Close();
        }

        public string getRecordCustomerName(int index)
        {
            return (string)recordCustomerName[index];
        }

        private ArrayList recordItemName = new ArrayList();
        public void setRecordItemName()
        {
            sqlConnect = new SqlConnection(connectionString);
            sqlConnect.Open();

            SqlCommand command = new SqlCommand("SELECT [Item Name] FROM Records", sqlConnect);

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                recordItemName.Add(reader["Item Name"].ToString());
            }
            reader.Close();
            sqlConnect.Close();
        }

        public string getRecordItemName(int index)
        {
            return (string)recordItemName[index];
        }

        private ArrayList recordPurchased = new ArrayList();
        public void setRecordPurchase()
        {
            sqlConnect = new SqlConnection(connectionString);
            sqlConnect.Open();

            SqlCommand command = new SqlCommand("SELECT [Purchased] FROM Records", sqlConnect);

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                recordPurchased.Add(reader["Purchased"]);
            }
            reader.Close();
            sqlConnect.Close();
        }

        public int getRecordPurchased(int index)
        {
            return Convert.ToInt32(recordPurchased[index]);
        }

        private ArrayList recordTotal = new ArrayList();
        public void setRecordTotal()
        {
            sqlConnect = new SqlConnection(connectionString);
            sqlConnect.Open();

            SqlCommand command = new SqlCommand("SELECT [Total] FROM Records", sqlConnect);

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                recordTotal.Add(reader["Total"]);
            }
            reader.Close();
            sqlConnect.Close();
        }

        public int getRecordTotal(int index)
        {
            return Convert.ToInt32(recordTotal[index]);
        }


        public void removeElements()
        {
            accountId.Clear();
            accountName.Clear();
            accountUsername.Clear();
            accountPassword.Clear();
            accountGender.Clear();
            accountBirthday.Clear();

            id.Clear();
            itemName.Clear();
            price.Clear();
            quantity.Clear();

            recordId.Clear();
            recordCustomerName.Clear(); 
            recordItemName.Clear();
            recordPurchased.Clear();
            recordTotal.Clear();

        }

        public int rangeAccounts()
        {
            return accountId.Count;
        }

        public int rangeItems()
        {
            return id.Count;
        }

        public int rangeRecords()
        {
            return recordId.Count;
        }

        public void updateItems(int id, int price, int quantity)
        {
            sqlConnect = new SqlConnection(connectionString);
            sqlConnect.Open();

            sqlCommand = new SqlCommand("SELECT Price, Quantity FROM Items WHERE id = @Id", sqlConnect);

            sqlCommand.Parameters.AddWithValue("@Id", id);

            SqlDataReader sqlReader = sqlCommand.ExecuteReader();

            if (sqlReader.Read())
            {

                sqlCommand = new SqlCommand("UPDATE Items SET price = @Price, quantity = @Quantity WHERE id = @Id", sqlConnect);

                sqlCommand.Parameters.AddWithValue("@Price", price);
                sqlCommand.Parameters.AddWithValue("@Quantity", quantity);
                sqlCommand.Parameters.AddWithValue("@Id", id);

                sqlReader.Close();
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();

            }
        }

        public void deleteAccount(int id)
        {
            sqlConnect = new SqlConnection(connectionString);
            sqlConnect.Open();

            sqlCommand = new SqlCommand("DELETE FROM accounts where id = @Id", sqlConnect);

            sqlCommand.Parameters.AddWithValue("@Id", id);

            sqlCommand.ExecuteNonQuery();
            sqlConnect.Close();
        }

        
        public void delete_records()
        {
            sqlConnect = new SqlConnection(connectionString);
            sqlConnect.Open();

            sqlCommand = new SqlCommand("DELETE FROM Records", sqlConnect);

            sqlCommand.ExecuteNonQuery();
            sqlConnect.Close();
        }
        




    }
}
