using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using DemoServiceLayer.Models;
using DemoServiceLayer;
using System.Web.Http;
using DemoDataAccess;

namespace DemoWebService.Controllers
{
    public class DemoController : ApiController
    {
        private SupportService SupportService { get; set; }

        public DemoController()
        {
            SupportService = new SupportService();
        }

        [Route("api/demo")]
        [HttpGet]
        public IQueryable<FundCollectionDTO> GetAllFunds()
        {
            //Create instance of DTO
            FundCollectionDTO dto = new FundCollectionDTO();

            //Get IQueryable<FundCollection> entity
            var entity = SupportService.GetAllFunds();

            //Map IQueryable<FundCollection> to IQueryable<FundCollectionDTO> (could use Automapper here)
            var allFundRecords = from f in entity
                      select new FundCollectionDTO()
                      {
                          FundName = f.FundName,
                          FundInceptionDate = f.FundInceptionDate,
                          FundExpenseRatio = f.FundExpenseRatio
                      };

            //Return IQueryable
            return allFundRecords;
        }

        [Route("api/{fundID}/demo")]
        [HttpGet]
        public IQueryable<FundCollectionDTO> GetFund(int fundID)
        {
            //Create instance of DTO
            FundCollectionDTO dto = new FundCollectionDTO();

            //Get IQueryable<FundCollection> entity
            var entity = SupportService.GetAllFunds();

            //Map IQueryable<FundCollection> to IQueryable<FundCollectionDTO> (could use Automapper here)
            //Select one record based on ID
            var allFundRecords = from f in entity
                                 where f.ID == fundID
                                 select new FundCollectionDTO()
                                 {
                                     FundName = f.FundName,
                                     FundInceptionDate = f.FundInceptionDate,
                                     FundExpenseRatio = f.FundExpenseRatio
                                 };

            //Return IQueryable
            return allFundRecords;
        }

        
    }
}