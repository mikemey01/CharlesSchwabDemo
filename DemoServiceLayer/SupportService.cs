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
        public SupportService()
        {

        }

        public FundCollectionDTO GetFundCollections()
        {
            FundCollectionDTO dto = new FundCollectionDTO();

            return dto;
        }
    }
}
