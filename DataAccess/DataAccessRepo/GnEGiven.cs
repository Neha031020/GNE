using DataAccess.Entity;
using DataAccess.IDataAcces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DataAccessRepo
{
    public class GnEGiven : IGnEGiven
    {
        //public Task<string> GetFormCode()
        //{
        //    string FormCode = $"GE-000000000";
        //    GiverModel.FormCode = FormCode;
        //}
        public Task<string> GetFormCode()
        {
            throw new NotImplementedException();
        }
    }
}
//string code = $"GE-{form.CreationDate.ToString("yyyyMMdd")}-{form.Id.ToString().PadLeft(9, '0')}";
//form.Code = code;