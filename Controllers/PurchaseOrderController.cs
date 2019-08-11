using PurchaseOrderService.BusinessLayer;
using PurchaseOrderService.DataContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPIAssignment.Controllers
{
    public class PurchaseOrderController : ApiController
    {
        PurchaseOrderBusinessLayer poBusinesssLayer = new PurchaseOrderBusinessLayer();

        [Route("searchPurchaseOrder")]
        [HttpGet]
        public IHttpActionResult Search(string purchaseOrderNo)
        {
            try
            {
                var suppliers = poBusinesssLayer.GetPurchaseOrder(purchaseOrderNo);

                return Json(suppliers);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [Route("addPurchaseOrder")]
        [HttpPost]
        public IHttpActionResult Post([FromBody]PurchaseOrder purchaseOrder)
        {
            return Json(new
            {
                returnString = poBusinesssLayer.AddPurchaseOrder(purchaseOrder)
            });

        }

        [Route("updatePurchaseOrder")]
        [HttpPost]
        public IHttpActionResult Put([FromBody]PurchaseOrder purchaseOrder)
        {
            var returnString = poBusinesssLayer.UpdatePurchaseOrder(purchaseOrder);

            return Json(new
            {
                returnString = returnString
            });

        }

        [Route("deletePurchaseOrder")]
        [HttpPost]
        public IHttpActionResult Delete([FromBody]PurchaseOrder purchaseOrder)
        {
            var returnString = poBusinesssLayer.DeletePurchaseOrder(purchaseOrder);

            return Json(new
            {
                returnString = returnString
            });
        }
    }
}
