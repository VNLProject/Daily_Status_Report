using DSR_BL.DSR.IMPL;
using DSR_BL.DSR;

namespace DSRApi.Utility
{
    public static class Utility
    {
       public static void MapDependency(WebApplicationBuilder builder)
        {
            builder.Services.AddScoped<IDsrBL, DsrBL>();
            builder.Services.AddScoped<DSR_DL.DSR.IDsrDL, DSR_DL.DSR.IMPL.DsrDL>();
        }
    }
}
