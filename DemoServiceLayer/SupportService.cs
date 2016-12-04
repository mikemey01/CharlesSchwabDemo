using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DemoDataAccess;
using DemoServiceLayer.Models;

namespace DemoServiceLayer
{
    public class SupportService
    {

        private ServiceDbContext db;

        public SupportService()
        {
            db = new ServiceDbContext();
        }

        public FundCollectionDTO GetFundCollections()
        {
            FundCollectionDTO dto = new FundCollectionDTO();

            List<FundCollectionDTO> fundCollectionList = new List<FundCollectionDTO>();
            var entity = db.FundCollection.Find();
            

            return dto;
        }
    }
}
