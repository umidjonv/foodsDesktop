using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace foodsDesktop.Classes
{
    class DBclass
    {
        MySqlConnection connection;
        MySqlDataAdapter adapter;
        public static DB.ExpenseDB ExpenseDB{ get; set; }
        public static DataSet DS { get; set; }

        //public DBclass()
        //{
        //    connection = new MySqlConnection("server=localhost;user id=foodsDB_user;password=D@faul(t);database=foods;persistsecurityinfo=True");
        //    string[] tables = { "employee", "dishes", "halfstaff", "products" };
        //    if (DS == null)
        //        DS = new DataSet();
        //    foreach(string tableName in tables)
        //    Fill(tableName);
        //}
        string conStr = "server=localhost;user id=foodsDB_user;password=D@faul(t);database=foods;persistsecurityinfo=True";
        public DBclass(string name)
        {
            connection = new MySqlConnection(conStr);
            //server=MYSQL5011.SmarterASP.NET;user id=a11a35_foods;database=db_a11a35_foods;password=Azizbek@1989;persistsecurityinfo=True;
            string[] tables = { "employee", "dishes", "halfstaff", "products" };
            if (DS == null)
                DS = new DataSet();
            Fill(name);
        }
        public DBclass()
        {
            connection = new MySqlConnection(conStr);
            if (DS == null)
                DS = new DataSet();
        }
        public void Fill(string table_name)
        {
            adapter = new MySqlDataAdapter("select * from " + table_name, connection);
            DataTable dt = new DataTable(table_name);
            adapter.Fill(dt);
            if (!DS.Tables.Contains(table_name))
            {
                DS.Tables.Add(dt);
            }
            //else
            //{
            //    DS.Tables.Remove(table_name);
            //    DS.Tables.Add(table_name);
            //}

            
        }


        public void FillExpense()
        {
            adapter = new MySqlDataAdapter("select * from expense where `status` = 1", connection);
            DB.ExpenseDB.Expense dt;
            if (!DS.Tables.Contains("expense"))
            {
                dt = new DB.ExpenseDB.Expense();
                DS.Tables.Add(((DataTable)dt));
            }
            else 
            {
                dt = (DB.ExpenseDB.Expense)DS.Tables["expense"];
            }
            
            
            adapter.Fill(dt); 
        }
        public void FillOrders(int expense_id)
        {
            adapter = new MySqlDataAdapter("select * from orders where expense_id = "+expense_id, connection);
            DataTable dt = DS.Tables["expense"];

            adapter.Fill(dt); 
 
        }
        public void FillMenu_Dishes() 
        {
            string select_text = "select ds.dish_id, d.type_id, m.type,  d.name, ds.name as dishname, ds.price "+ 
                                "from dishtype as d inner join menu as m "+
                                "on d.type_id = m.type_id "+
                                "inner join dishes as ds "+
                                "on m.just_id = ds.dish_id";
            adapter = new MySqlDataAdapter(select_text, connection);
            if (!DS.Tables.Contains("menu_dishes_v"))
            adapter.Fill(DS, "menu_dishes_v");
         }

        public DataRow[] GetDishesRow(int id)
        {
            DataRow[] rows = DS.Tables["menu_dishes_v"].Select("type_id = " + id);
            return rows;
 
        }

        public void CreateExpenseTable()
        {
            DB.ExpenseDB exp = new DB.ExpenseDB(connection);
            if(!DS.Tables.Contains("expense"))
            DS.Tables.Add(exp.expenseTable);
            
            //table.Columns.Add(new DataColumn(""))
 
        }
        public void CreateOrdersTable()
        {
            DB.OrdersDB ord = new DB.OrdersDB(connection);
            if (!DS.Tables.Contains("orders"))
            DS.Tables.Add(ord.OrdersTable);

            //table.Columns.Add(new DataColumn(""))

        }
        /// <summary>
        /// Update insert delete expense
        /// </summary>
        /// <returns>Last ID was inserted</returns>
        public int UIDExpense()
        {
            DB.ExpenseDB exp = new DB.ExpenseDB(connection);
            exp.expenseTable = (DB.ExpenseDB.Expense) DS.Tables["expense"];
            exp.expenseAdapter.Update(exp.expenseTable);
            MySqlCommand command = new MySqlCommand();
            command.Connection = exp.expenseAdapter.InsertCommand.Connection;
            command.CommandText = "select max(expense_id) from expense";
            command.Connection.Open();
            int id = (int)command.ExecuteScalar();
            
            
            if (command.Connection.State == ConnectionState.Open)
                command.Connection.Close();
            return id;
        }

        /// <summary>
        /// Update insert delete orders
        /// </summary>
        public void UIDOrders(int exp)
        {
            
            DB.OrdersDB ord = new DB.OrdersDB(connection);
            ord.OrdersTable = (DB.OrdersDB.Orders)DS.Tables["orders"];
            
            ord.OrdersAdapter.Update(ord.OrdersTable);
            ord.OrdersTable.AcceptChanges();
            DataRow[] rows = ord.OrdersTable.Select("expense_id = " + exp);
            foreach(DataRow dr in rows)
            ord.OrdersTable.Rows.Remove(dr);
            
            ord.OrdersAdapter.SelectCommand.CommandText = "select order_id, expense_id, just_id, `type`, `count`, `status`, refuse, deleted, notificate from orders where expense_id = "+exp;
            ord.OrdersAdapter.Fill(ord.OrdersTable);
            
        }
        
        
    }
}
