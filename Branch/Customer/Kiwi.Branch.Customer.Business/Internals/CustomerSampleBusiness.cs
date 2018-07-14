using Kiwi.Branch.Backbone.Customer;
using Kiwi.Foundation.Backbone.ORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiwi.Branch.Customer.Business.Internals
{
    internal class CustomerSampleBusiness : ICustomerSampleBusiness
    {
        private readonly IRepository _sampleRepository;
        public CustomerSampleBusiness(IRepository sampleRepository)
        {
            _sampleRepository = sampleRepository;
        }
    }
}
