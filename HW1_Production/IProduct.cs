using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1_Production
{
    public interface IProduct
    {
        int Id { get; set; }
        int Cost { get; set; }
        int Revenue { get; set; }
        int SellPrice { get; set; }
    }
}
