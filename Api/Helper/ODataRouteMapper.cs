using Microsoft.OData.Edm;
using Microsoft.OData.ModelBuilder;

namespace Prohix.Api.Helper
{
    public static class ODataRouteMapper
    {
        public static IEdmModel GetEdmModel()
        {
            var odataBuilder = new ODataConventionModelBuilder();
            odataBuilder.EnableLowerCamelCase();

            //odataBuilder.EntitySet<Hospital>("Hospitals");
            return odataBuilder.GetEdmModel();
        }
    }
}
