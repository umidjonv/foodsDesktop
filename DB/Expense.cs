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
                this.TableName = "expense";            
                this.Columns.Add(new DataColumn("expense_id", typeof(int)));
                this.Columns.Add(new DataColumn("order_date", typeof(DateTime)));
                this.Columns.Add(new DataColumn("employee_id", typeof(int)));
                this.Columns.Add(new DataColumn("table", typeof(int)));
                this.Columns.Add(new DataColumn("status", typeof(int)));
                this.Columns.Add(new DataColumn("deleted", typeof(int)));
                this.Columns[0].AutoIncrement = true;
                this.Columns[0].AutoIncrementSeed = 1;
                this.Columns[0].AutoIncrementStep = 1;
            }

        
        }
        public ExpenseDB(MySqlConnection db_connection)
        {
            command = new MySqlCommand();
            connection = db_connection;
            CreateAdapter();
            expenseTable = new Expense();
        }
        public Expense expenseTable;
        MySqlCommand command;
        MySqlConnection connection;
        public MySqlDataAdapter expenseAdapter;
        private MySqlCommand CreateCommand(MySqlCommand command, string type)
        {
            string commandText = "";
            command.Parameters.Add(new MySqlParameter("@expenseID", MySqlDbType.Int32, 0, "expense_id"));
            command.Parameters.Add(new MySqlParameter("@orderDate", MySqlDbType.DateTime, 0, "order_date"));
            command.Parameters.Add(new MySqlParameter("@employeeID", MySqlDbType.Int32, 0, "employee_id"));
            command.Parameters.Add(new MySqlParameter("@table", MySqlDbType.Int32, 0, "table"));
            command.Parameters.Add(new MySqlParameter("@status", MySqlDbType.Int32, 0, "status"));
            command.Parameters.Add(new MySqlParameter("@deleted", MySqlDbType.Int32, 0, "deleted"));
            
            switch (type)
            {
                case "select":
                    commandText = "select expense_id, order_date, employee_id, `table`, `status`, deleted from expense";
                    break;
                case "update":
                    commandText = "update expense set  order_date=@orderDate , employee_id = @employeeID, `table` = @table, `status`=@status, deleted=@deleted where expense_id=@expenseID";
                    break;
                case "insert":
                    commandText = "insert into expense (order_date, employee_id, `table`, `status`, deleted) values (@orderDate, @employeeID, @table, @status, @deleted)";
                    break;
                case "delete":
                    commandText = "delete from expense where expense_id = @expenseID";
                    break;
            }
            command.CommandText = commandText;
            command.Connection = connection;
            return command;
        }
        private void CreateAdapter()
        {
            expenseAdapter = new MySqlDataAdapter();
            expenseAdapter.SelectCommand = CreateCommand(new MySqlCommand(), "select");
            expenseAdapter.InsertCommand = CreateCommand(new MySqlCommand(), "insert");
            expenseAdapter.UpdateCommand = CreateCommand(new MySqlCommand(), "update");
            expenseAdapter.DeleteCommand = CreateCommand(new MySqlCommand(), "delete");

        }
    }
    
    
}
