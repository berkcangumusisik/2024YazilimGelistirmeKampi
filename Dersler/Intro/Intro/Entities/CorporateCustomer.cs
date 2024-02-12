using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.Entities;
public class CorporateCustomer : BaseCustomer // Kurumsal Müşteri
{

    public string CompanyName { get; set; }
    public string TaxNumber { get; set; }
}