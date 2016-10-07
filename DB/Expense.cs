using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace foodsDesktop.DB
{
    class ExpenseDB
    {
        public class Expense:DataTable
        {
            public Expense()
            {
            
                this.Columns.Add(new DataColumn("expense_id", typeof(int)));
                this.Columns.Add(new DataColumn("order_date", typeof(DateTime)));
                this.Columns.Add(new DataColumn("employee_id", typeof(int)));
                this.Columns.Add(new DataColumn("table", typeof(int)));
                this.Columns.Add(new DataColumn("status", typeof(int)));
                this.Columns.Add(new DataColumn("deleted", typeof(int)));
                
            }

        
        }
        public ExpenseDB(MySqlConnection connection)
        {
            command = new MySqlCommand();
            CreateAdapter(connection);
            expenseTable = new Expense();
        }
        public Expense expenseTable;
        MySqlCommand command;
        public MySqlDataAdapter expenseAdapter;
        private MySqlCommand CreateCommand(MySqlCommand command, string type)
        {
            string commandText = "";
            command.Parameters.Add(new MySqlParameter("expenseID", MySqlDbType.Int32));
            command.Parameters.Add(new MySqlParameter("orderDate", MySqlDbType.DateTime));
            command.Parameters.Add(new MySqlParameter("employeeID", MySqlDbType.Int32));
            command.Parameters.Add(new MySqlParameter("table", MySqlDbType.Int32));
            command.Parameters.Add(new MySqlParameter("status", MySqlDbType.Int32));
            command.Parameters.Add(new MySqlParameter("deleted", MySqlDbType.Int32));
            
            switch (type)
            {
                case "select":
                    commandText = "select expense_id, order_date, employee_id, table, status, deleted from expense";
                    break;
                case "update":
                    commandText = "update expense set  order_date=@orderDate , employee_id = @employeeID, table = @table, status=@status, deleted=@deleted where expense_id=@expenseID";
                    break;
                case "insert":
                    commandText = "insert into expense (order_date, employee_id, table, status, deleted) values (@orderDate, @employeeID, @table, @status, @deleted)";
                    break;
                case "delete":
                    commandText = "delete from expense where expense_id = @expenseID";
                    break;
            }
            command.CommandText = commandText;
            return command;
        }
        private void CreateAdapter(MySqlConnection connection)
        {
            expenseAdapter = new MySqlDataAdapter();
            expenseAdapter.SelectCommand = CreateCommand(new MySqlCommand(), "select");
            expenseAdapter.InsertCommand = CreateCommand(new MySqlCommand(), "insert");
            expenseAdapter.UpdateCommand = CreateCommand(new MySqlCommand(), "update");
            expenseAdapter.DeleteCommand = CreateCommand(new MySqlCommand(), "delete");

        }
    }
    
    
}
