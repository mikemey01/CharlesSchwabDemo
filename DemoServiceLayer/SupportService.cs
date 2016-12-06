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

        public List<FundCollectionDTO> GetFundCollections()
        {
            FundCollectionDTO dto = new FundCollectionDTO();

            List<FundCollectionDTO> fundCollectionList = new List<FundCollectionDTO>();
            IQueryable<FundCollection> iq = db.FundCollection;

            fundCollectionList = Mapper.Map <List<FundCollection>, List<FundCollectionDTO>>(iq.ToList());
                
            return fundCollectionList;
        }

        public IQueryable<FundCollection> GetAllFunds()
        {
            var entity = db.FundCollection;
            //var test = Mapper.Map<IQueryable<FundCollection>, IQueryable<FundCollectionDTO>>(entity);

            return entity;
        }

        protected void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
        }


    }
}
