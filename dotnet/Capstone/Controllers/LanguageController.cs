﻿using Capstone.DAO;
using Capstone.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Capstone.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LanguageController : ControllerBase
    {
        IExampleDao dao;

        string connectionString = "Server=.\\SQLEXPRESS;Database=final_capstone;Trusted_Connection=True;";

        public LanguageController()
        {
            dao = new ExampleSqlDao(connectionString);
        }

        [HttpGet]
        public IList<Example> GetLanguages()
        {
            return dao.GetLanguages();
        }
    }
}
