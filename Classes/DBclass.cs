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
        public DBclass(string name)
        {
            connection = new MySqlConnection("server=localhost;user id=foodsDB_user;password=D@faul(t);database=foods;persistsecurityinfo=True");
            string[] tables = { "employee", "dishes", "halfstaff", "products" };
            if (DS == null)
                DS = new DataSet();
            Fill(name);
        }

        public void Fill(string table_name)
        {
            adapter = new MySqlDataAdapter("select * from " + table_name, connection);
            adapter.Fill(DS, table_name);

            
        }
        public void FillMenu_Dishes() 
        {
            string select_text = "select ds.dish_id, d.type_id, d.name, ds.name as dishname, ds.price "+ 
                                "from dishtype as d inner join menu as m "+
                                "on d.type_id = m.type_id "+
                                "inner join dishes as ds "+
                                "on m.just_id = ds.dish_id";
            adapter = new MySqlDataAdapter(select_text, connection);
            adapter.Fill(DS, "menu_dishes_v");
         }

        public DataRow[] GetDishesRow(int id)
        {
            DataRow[] rows = DS.Tables["menu_dishes_v"].Select("type_id = " + id);
            return rows;
 
        }
        
        
        
    }
}
