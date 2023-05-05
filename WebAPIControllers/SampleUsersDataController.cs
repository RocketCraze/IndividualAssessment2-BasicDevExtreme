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
    using Newtonsoft.Json;
    using SampleData;

    [Route("api/[controller]")]
    public class SampleUsersDataController : Controller
    {

        [HttpGet]
        public object Get(DataSourceLoadOptions loadOptions)
        {
            return DataSourceLoader.Load(SampleUsersData.Users, loadOptions);
        }

        [HttpPost]
        public IActionResult Add(string values)
        {
            var newUser = new User();
            JsonConvert.PopulateObject(values, newUser);

            newUser.ID = SampleUsersData.Users.Count + 1;

            SampleUsersData.Users.Add(newUser);

            return Ok(newUser);
        }

        [HttpPut]
        public IActionResult Update(int key, string values)
        {
            var user = SampleUsersData.Users.FirstOrDefault(_ => _.ID == key);
            if (user == null)
                return NotFound();

            JsonConvert.PopulateObject(values, user);

            return Ok();
        }

        [HttpDelete]
        public void Delete(int key)
        {
            var user = SampleUsersData.Users.FirstOrDefault(_ => _.ID == key);
            if (user != null)
                SampleUsersData.Users.Remove(user);
        }
    }
}