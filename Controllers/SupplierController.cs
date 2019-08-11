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
    public class SupplierController : ApiController
    {
        PurchaseOrderBusinessLayer poBusinesssLayer = new PurchaseOrderBusinessLayer();

        [Route("searchSupplier")]
        [HttpGet]
        public IHttpActionResult Search(string supplierNo)
        {
            try
            {
                return Json(poBusinesssLayer.GetSupplierDetails(supplierNo));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [Route("addSupplier")]
        [HttpPost]
        public IHttpActionResult Post([FromBody]Supplier supplier)
        {
            try
            {
                return Json(new
                {
                    returnString = poBusinesssLayer.AddSupplierDetails(supplier)
                });
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [Route("updateSupplier")]
        [HttpPost]
        public IHttpActionResult Put([FromBody]Supplier supplier)
        {
            try
            {
                return Json(new
                {
                    returnString = poBusinesssLayer.UpdateSupplierDetails(supplier)
                });
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [Route("deleteSupplier")]
        [HttpPost]
        public IHttpActionResult Delete([FromBody]Supplier supplier)
        {
            try
            {
                return Json(new
                {
                    returnString = poBusinesssLayer.DeleteSupplierDetails(supplier)
                });
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
