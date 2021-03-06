﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using DemoServiceLayer.Models;
using DemoServiceLayer;
using System.Web.Http;
using DemoDataAccess;
using System.Net.Http;
using Newtonsoft.Json;

namespace DemoWebService.Controllers
{
    public class DemoController : ApiController
    {
        private SupportService SupportService { get; set; }

        public DemoController()
        {
            SupportService = new SupportService();
        }

        //GET
        [Route("api/demo")]
        [HttpGet]
        public HttpResponseMessage GetAllFunds()
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
            return Request.CreateResponse(System.Net.HttpStatusCode.OK, allFundRecords);
        }

        //GET
        [Route("api/{fundID}/demo")]
        [HttpGet]
        public HttpResponseMessage GetFund(int fundID)
        {
            //Create instance of DTO
            FundCollectionDTO dto = new FundCollectionDTO();

            //Get IQueryable<FundCollection> entity
            var entity = SupportService.GetAllFunds();

            //Map IQueryable<FundCollection> to IQueryable<FundCollectionDTO> (could use Automapper here)
            //Select one record based on ID
            var oneRecord = from f in entity
                                 where f.ID == fundID
                                 select new FundCollectionDTO()
                                 {
                                     FundName = f.FundName,
                                     FundInceptionDate = f.FundInceptionDate,
                                     FundExpenseRatio = f.FundExpenseRatio
                                 };

            //Return IQueryable
            return Request.CreateResponse(System.Net.HttpStatusCode.OK, oneRecord);
        }

    }
}