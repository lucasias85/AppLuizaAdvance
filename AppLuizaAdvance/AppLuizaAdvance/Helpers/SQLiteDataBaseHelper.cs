using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppLuizaAdvance.Helpers
{
    public class SQLiteDataBaseHelper
    {
        readonly SQLiteAsyncConnection _db;

        public SQLiteDataBaseHelper(string dbPath)
        {
            _db = new SQLiteAsyncConnection(dbPath);
            _db.CreateTableAsync<Models.TaxasModel>().Wait();
        }

        public Task<int> Insert(Models.TaxasModel model)
        {
            return _db.InsertAsync(model);
        }

        public Task<int> Update(Models.TaxasModel model)
        {
            return _db.UpdateAsync(model);
        }

        public Task<int> Delete(Models.TaxasModel model)
        {
            return _db.DeleteAsync(model);
        }

        public Task<Models.TaxasModel> GetById(int id)
        {
            return _db.Table<Models.TaxasModel>().FirstAsync(i => i.IdPromotora == id);
        }

        public Task<List<Models.TaxasModel>> GetAllRows()
        {
            return _db.Table<Models.TaxasModel>().OrderByDescending(i => i.IdPromotora).ToListAsync();
        }
    }
}
