using TwoTableAssignment.ViewModel;
using System.Collections.Generic;
using TwoTableAssignment.Models;
using System.Web.Mvc;
using TwoTableAssignment.DataAccessLayer;

namespace TwoTableAssignment.Controllers
{
    public class BuyerController : Controller
    {
        public ActionResult GetBuyers()
        {
            BuyerRecordsViewModel BuyerRecords = new BuyerRecordsViewModel();
            List<BuyerViewModel> BuyerViewModels = new List<BuyerViewModel>();
            BuyerBusinessLayer BuyerBal = new BuyerBusinessLayer();
            List<Buyer> Buyers = BuyerBal.GetBuyer();
            foreach (Buyer Buyer in Buyers)
            {
                BuyerViewModel evm = new BuyerViewModel();
                evm.BuyerId = Buyer.BuyerId;
                evm.BuyerName = Buyer.BuyerName;

            }
            BuyerRecords.MyBuyers = BuyerViewModels;
            return View(BuyerRecords);
        }

        public ActionResult AddNew()
        {

            // return View("CreateBuyer");
            return View("CreateBuyer", new CreateBuyerViewModel());
        }

        public ActionResult SaveBuyer(Buyer e, string BtnSubmit)
        {
            switch (BtnSubmit)
            {
                case "SaveBuyer":
                    if (ModelState.IsValid)
                    {
                        BuyerBusinessLayer BuyerBal = new BuyerBusinessLayer();
                        BuyerBal.SaveBuyer(e);
                        return RedirectToAction("GetBuyers");
                    }

                    else
                    {
                        CreateBuyerViewModel vm = new CreateBuyerViewModel();
                        vm.BuyerId = e.BuyerId;
                        vm.BuyerName = e.BuyerName;

                    }
                    return RedirectToAction("CreateBuyers");
                case "Cancel":
                    return RedirectToAction("GetBuyers");

            }
            return new EmptyResult();
        }
    }
}