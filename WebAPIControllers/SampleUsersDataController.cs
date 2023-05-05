namespace WebAPIControllers
{
    using IndividualAssessment2_BasicDevExtreme.Models;

    using DevExtreme.AspNet.Data;
    using DevExtreme.AspNet.Mvc;

    using Microsoft.AspNetCore.Mvc;

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Net.Http;


    [Route("api/[controller]")]
    public class SampleUsersDataController : Controller
    {

        [HttpGet]
        public object Get(DataSourceLoadOptions loadOptions)
        {
            return DataSourceLoader.Load(SampleUsersData.Users, loadOptions);
        }

    }
}