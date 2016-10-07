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
    class OrdersDB
    {
        public class Orders : DataTable
        {
            public Orders()
            {
                this.TableName = "orders";
                this.Columns.Add(new DataColumn("order_id", typeof(int)));
                this.Columns.Add(new DataColumn("expense_id", typeof(int)));
                this.Columns.Add(new DataColumn("employee_id", typeof(int)));
                this.Columns.Add(new DataColumn("just_id", typeof(int)));
                this.Columns.Add(new DataColumn("type", typeof(int)));
                this.Columns.Add(new DataColumn("count", typeof(int)));
                this.Columns.Add(new DataColumn("status", typeof(int)));
                this.Columns.Add(new DataColumn("refuse", typeof(int)));
                this.Columns.Add(new DataColumn("deleted", typeof(int)));
                this.Columns.Add(new DataColumn("notificate", typeof(int)));

            }


        }
        public OrdersDB(MySqlConnection connection)
        {
            command = new MySqlCommand();
            CreateAdapter(connection);
            OrdersTable = new Orders();
        }
        public Orders OrdersTable;
        MySqlCommand command;
        public MySqlDataAdapter OrdersAdapter;
        private MySqlCommand CreateCommand(MySqlCommand command, string type)
        {
            string commandText = "";
            command.Parameters.Add(new MySqlParameter("orderID", MySqlDbType.Int32));
            command.Parameters.Add(new MySqlParameter("expense_id", MySqlDbType.Int32));
            command.Parameters.Add(new MySqlParameter("just_id", MySqlDbType.Int32));
            command.Parameters.Add(new MySqlParameter("type", MySqlDbType.Int32));
            command.Parameters.Add(new MySqlParameter("count", MySqlDbType.Int32));
            command.Parameters.Add(new MySqlParameter("status", MySqlDbType.Int32));
            command.Parameters.Add(new MySqlParameter("refuse", MySqlDbType.Int32));
            command.Parameters.Add(new MySqlParameter("deleted", MySqlDbType.Int32));
            command.Parameters.Add(new MySqlParameter("notificate", MySqlDbType.Int32));

            switch (type)
            {
                case "select":
                    commandText = "select order_id, expense_id, just_id, type, count, status, refuse, deleted, notificate from orders";
                    break;
                case "update":
                    commandText = "update orders set expense_id= @expense_id, just_id=@just_id, type=@type, count=@count, status=@status, refuse=@refuse, deleted=@deleted, notificate=@notificate where order_id=@orderID";
                    break;
                case "insert":
                    commandText = "insert into orders (expense_id, just_id, type, count, status, refuse, deleted, notificate) values (@expense_id, @just_id, @type, @count, @status, @refuse, @deleted, @notificate)";
                    break;
                case "delete":
                    commandText = "delete from orders where order_id = @orderID";
                    break;
            }
            command.CommandText = commandText;
            return command;
        }
        private void CreateAdapter(MySqlConnection connection)
        {
            OrdersAdapter = new MySqlDataAdapter();
            OrdersAdapter.SelectCommand = CreateCommand(new MySqlCommand(), "select");
            OrdersAdapter.InsertCommand = CreateCommand(new MySqlCommand(), "insert");
            OrdersAdapter.UpdateCommand = CreateCommand(new MySqlCommand(), "update");
            OrdersAdapter.DeleteCommand = CreateCommand(new MySqlCommand(), "delete");


        }
    }
}
