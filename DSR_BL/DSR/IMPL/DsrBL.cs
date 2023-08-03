using DSR_DL.DSR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTILITY.DTO;

namespace DSR_BL.DSR.IMPL
{
    public class DsrBL:IDsrBL
    {
        private IDsrDL _dsrDl;
    
        public DsrBL(IDsrDL dsrDl)
        {
            this._dsrDl = dsrDl;          
        }

       public List<DSRDataModel> GetDSRData()
        {
            return _dsrDl.GetDSRData();
        }
    }
}
