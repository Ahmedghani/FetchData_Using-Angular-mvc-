using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AngularwithAsp.Controllers
{
    public class DataController : Controller
    {
        //
        // GET: /Data/
         public JsonResult GetData()
        {
            EmployeeMaster emp = null;
            {
                using(EmployeeEntities empEn=new EmployeeEntities())
                {
                    emp = empEn.EmployeeMaster.OrderByDescending(a => a.EmployeeId).Take(2).FirstOrDefault();
                }
            }
            return new JsonResult { Data = emp, JsonRequestBehavior = JsonRequestBehavior.AllowGet };

        }
	}
}