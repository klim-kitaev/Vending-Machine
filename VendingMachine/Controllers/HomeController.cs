using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VendingMachine.Models;

namespace VendingMachine.Controllers
{
    public class HomeController : Controller
    {

        //Кошелек VM для сдачи
        static VMWallet vwWallet;
        //Кошелек пользователя
        static Wallet userWallet;
        //Ассортимент VM
        static ProductCatalog productCatalog;

        public ActionResult Index()
        {
            //Начальная инициализация
            vwWallet = new VMWallet(new Dictionary<FaceValueTypes, int>{
                {FaceValueTypes.One,100},
                {FaceValueTypes.Two,100},
                {FaceValueTypes.Five,100},
                {FaceValueTypes.Ten,100}
            });

            userWallet = new Wallet(new Dictionary<FaceValueTypes, int>
            {
                {FaceValueTypes.One,10},
                {FaceValueTypes.Two,30},
                {FaceValueTypes.Five,20},
                {FaceValueTypes.Ten,15}
            });

            productCatalog=new ProductCatalog(new Dictionary<ProductTypes,int>
                {
                    {ProductTypes.Tea,10},
                    {ProductTypes.Coffee,20},
                    {ProductTypes.MilkCoffee,20},
                    {ProductTypes.Juice,15}
                });

            return View();
        }

        public ActionResult GetVMWallet()
        {
            return View(vwWallet.GetSorted());
        }

        public ActionResult GetUserWallet()
        {
            return View(userWallet.GetSorted());
        }

        public ActionResult GetProductCatatalog()
        {
            return View(productCatalog.GetSorted());
        }

    }
}
