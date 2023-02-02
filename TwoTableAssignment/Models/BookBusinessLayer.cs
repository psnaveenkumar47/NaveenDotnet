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
    public class BookBusinessLayer
    {
        BooksDataLayer salesDal;
        public BookBusinessLayer()
        {
            salesDal = new BooksDataLayer();
        }
        public List<Book> GetBooks()
        {
            return salesDal.Books.ToList();
        }
        public Book SaveBook(Book e)
        {
            salesDal.Books.Add(e);
            salesDal.SaveChanges();
            return e;
        }

       
        
    }
}