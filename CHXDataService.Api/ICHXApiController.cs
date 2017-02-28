using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHXDataService.Api
{
    public abstract class ICHXApiController
    {
        public abstract ICHXApiModel GetModel(string modelName);
    }
}
