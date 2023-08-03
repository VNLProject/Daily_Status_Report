using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTILITY.DTO;

namespace DSR_BL.DSR
{
    public interface IDsrBL
    {
       List<DSRDataModel> GetDSRData();
    }
}
