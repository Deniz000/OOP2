using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class GercekMusteri:Customer
    {
        public string TcNumber { get; set; } //matematiksel işlem yoksa metinsel kullanılır
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
