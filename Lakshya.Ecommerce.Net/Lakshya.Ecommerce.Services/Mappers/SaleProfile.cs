using AutoMapper;
using Lakshya.Ecommerce.Repositories.Entities;
using Lakshya.Ecommerce.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lakshya.Ecommerce.Services.Mappers
{
  public class SaleProfile : Profile
  {
    public SaleProfile()
    {
      CreateMap<Sale, SaleModel>();
    }
  }
}
