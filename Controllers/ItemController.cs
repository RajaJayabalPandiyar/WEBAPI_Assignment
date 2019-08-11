using PurchaseOrderService.BusinessLayer;
using PurchaseOrderService.DataContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

//GIT Assignment
namespace WebAPIAssignment.Controllers
{
    public class ItemController : ApiController
    {
        PurchaseOrderBusinessLayer poBusinesssLayer = new PurchaseOrderBusinessLayer();

        [Route("searchItem")]
        [HttpGet]
        public IHttpActionResult Search(string supplierNo)
        {
            try
            {
            //Git Changes
                return Json(poBusinesssLayer.GetItemDetails(supplierNo));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [Route("addItem")]
        [HttpPost]
        public IHttpActionResult Post([FromBody]Item item)
        {
            try
            {
            //Git Changes
                return Json(new
                {
                    returnString = poBusinesssLayer.AddItemDetails(item)
                });
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [Route("updateItem")]
        [HttpPost]
        public IHttpActionResult Put([FromBody]Item item)
        {
            try
            {
            //Git Changes
                return Json(new
                {
                    returnString = poBusinesssLayer.UpdateItemDetails(item)
                });
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [Route("deleteItem")]
        [HttpPost]
        public IHttpActionResult Delete([FromBody]Item item)
        {
            try
            {
                return Json(new
                {
                    returnString = poBusinesssLayer.DeleteItemDetails(item)
                });
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
