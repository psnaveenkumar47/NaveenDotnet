using System;
using System.Collections.Generic;
using System.Linq;
using TwoTableAssignment.DataAccessLayer;
using TwoTableAssignment.ViewModel;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.Mvc;
using System.Data.Entity;
using TwoTableAssignment.Models;

namespace TwoTableAssignment.Models
{
    public class BuyerBusinessLayer
    {
        BooksDataLayer salesDal;
        public BuyerBusinessLayer()
        {
            salesDal = new BooksDataLayer();
        }
        public List<Buyer> GetBuyer()
        {
            return salesDal.Buyers.ToList();
        }
        public Book SaveBuyer(Book e)
        {
            salesDal.Buyers.Add(e);
            salesDal.SaveChanges();
            return e;
        }



    }
}