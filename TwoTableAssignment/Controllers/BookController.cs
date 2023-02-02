using TwoTableAssignment.ViewModel;
using System.Collections.Generic;
using TwoTableAssignment.Models;
using System.Web.Mvc;
using TwoTableAssignment.DataAccessLayer;

namespace TwoTableAssignment.Controllers
{
    public class BookController : Controller
    {
        public ActionResult GetBooks()
        {
            BookRecordsViewModel bookRecords = new BookRecordsViewModel();
            List<BookViewModel> bookViewModels = new List<BookViewModel>();
            BookBusinessLayer bookBal = new BookBusinessLayer();
            List<Book> books = bookBal.GetBooks();
            foreach (Book book in books)
            {
                BookViewModel evm = new BookViewModel();
                evm.BookId = book.BookId;
                evm.BookName = book.BookName;
               
            }
            bookRecords.MyBooks = bookViewModels;
            return View(bookRecords);
        }

        public ActionResult AddNew()
        {

            // return View("CreateBook");
            return View("CreateBook", new CreateBookViewModel());
        }

        public ActionResult SaveBook(Book e, string BtnSubmit)
        {
            switch (BtnSubmit)
            {
                case "SaveBook":
                    if (ModelState.IsValid)
                    {
                        BookBusinessLayer bookBal = new BookBusinessLayer();
                        bookBal.SaveBook(e);
                        return RedirectToAction("GetBooks");
                    }
                    
                    else
                    {
                        CreateBookViewModel vm = new CreateBookViewModel();
                        vm.BookId = e.BookId;
                        vm.BookName = e.BookName;
                        
                    }
                    return RedirectToAction("CreateBooks");
                case "Cancel":
                    return RedirectToAction("GetBooks");

            }
            return new EmptyResult();
        }
    }
}