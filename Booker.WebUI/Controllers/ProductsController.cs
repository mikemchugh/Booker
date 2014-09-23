using Booker.Domain.Entities;
using Booker.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Booker.WebUI.Controllers
{
    public class ProductsController : Controller
    {
        IProductsRepository repository;

        public ProductsController(IProductsRepository productsRepository)
        {
            this.repository = productsRepository;
        }

        // GET: Products
        public ActionResult Index()
        {
            var products = repository.Products;
            return View(products);
        }

        // GET: Products/Details/5
        public ActionResult Details(int id)
        {
            Product product = repository.GetProduct(id);
            return View(product);
        }

        // GET: Products/Create
        public ActionResult Create()
        {
            Product product = new Product();
            return View(product);
        }

        // POST: Products/Create
        [HttpPost]
        public ActionResult Create(Product product)
        {
            try
            {
                repository.SaveProduct(product);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Products/Edit/5
        public ActionResult Edit(int id)
        {
            Product product = repository.GetProduct(id);
            return View(product);
        }

        // POST: Products/Edit/5
        [HttpPost]
        public ActionResult Edit(Product product)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Products/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Products/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
