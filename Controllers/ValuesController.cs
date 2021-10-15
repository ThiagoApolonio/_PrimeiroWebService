using _PrimeiroWebService.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using _PrimeiroWebService.Models;
using _PrimeiroWebService.Controllers;
using SAB_B1connection;


namespace _PrimeiroWebService.Controllers
{
    public class ValuesController : ApiController
    {


        // GET api/values
        public ItemModel Get(string ItemCode)
        {
            ItemController item = new ItemController();
            ServerConnections db = new ServerConnections();
            db.Connect();
            db.GetCompany();
            return item.GetItemModel(ItemCode);
        }


        // GET api/values/5
        public string Get(int id)
        {

            return "value";
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(string ItemCode)
        {
            CrudController CriarCampo = new CrudController("OITM");// criamos  um construtor para selecionar a tabela
            ItemModel novoItem = new ItemModel();
            novoItem.ItemName = "Teste";
            novoItem.ItemCode = ItemCode;
            CriarCampo.UpdateModel(novoItem);

        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
