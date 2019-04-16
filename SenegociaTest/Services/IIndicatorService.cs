using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SenegociaTest.Entities;

namespace SenegociaTest.Services
{
   public interface IIndicatorService
    {
       Indicator ConsultUFValue(DateTime date, string url);
    }
}
