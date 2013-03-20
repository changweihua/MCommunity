using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MCommunity.Filters.Authorizes;

namespace MCommunity.Areas.Admin.Controllers
{
    [CheckLogin(Order = 1)]
    [SimpleAuthorize(Order = 3)]
    public class BaseController : Controller
    {
        //Order决定Attribute的执行顺序
    }
}
