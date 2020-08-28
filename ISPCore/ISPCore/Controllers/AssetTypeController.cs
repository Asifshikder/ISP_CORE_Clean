using System;
using System.Web;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using ISPCore.Domain.Entities;
using ISPCore.Persistence;
using ISPCore.Web.Helper;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Configuration;
using System.Net.Http.Headers;

namespace ISPCore.Web.Controllers
{
    public class AssetTypeController : Controller
    {
       
        APIClient api = new APIClient();
        public DBContext _context;
        public AssetTypeController(DBContext context)
        {
            _context = context;
        }

        public async Task<ActionResult> index()
        {
            List<AssetType> assetTypes = new List<AssetType>();
            HttpClient client = api.Initial();
            HttpResponseMessage message = await client.GetAsync("api/AssetType/");
            if (message.IsSuccessStatusCode)
            {
                var results = message.Content.ReadAsStringAsync().Result;
                assetTypes = JsonConvert.DeserializeObject<List<AssetType>>(results);
            }
            return View(assetTypes);
        }
    }
}