using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseAccess
{
    public class SqlCrud
    {
        LoadAndSaveAccessDb db = new LoadAndSaveAccessDb();
        private string _conn;
        public SqlCrud(string connectionString)
        {
            _conn= connectionString;
        }
       public List<StuffModel> ReadAllStuff()
        {
            string query = "Select * from Products";
            return db.LoadData<StuffModel, dynamic>(_conn, query, new { });
        }
        public void CreateProduct(StuffModel model)
        {
            string query = "insert into Products(pName,pId,BuyPrice,SellPrice,Explaination) Values(@ProductName, @ProductId, @BuyPrice, @SellPrice, @Explaination)";
           // db.SaveData<StuffModel>(_conn,query, { })
        }
    }

}
