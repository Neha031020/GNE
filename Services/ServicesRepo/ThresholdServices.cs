using DataAccess.Entity;
using DataAccess.IDataAcces;
using Services.ServicesInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.ServicesRepo
{
    public class ThresholdServices : IThresholdServices
    {
        private readonly IThreshold _threshold;
        public ThresholdServices(IThreshold threshold)
        {
            _threshold = threshold;
        }
        public async Task<List<Threshold>> GetListOfThreshold()
        {
            var ListOFThreshold=await _threshold.GetAllThresholdList();
            return ListOFThreshold;
        }
    }
}
