﻿using SAERP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SAERP.Controllers
{
    public class TransporteController : Controller
    {
        // GET: Triagem
        public ActionResult Index()
        {
            return View();
        }

        // GET: Triagem/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Triagem/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Triagem/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Triagem/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Triagem/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
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

        // GET: Triagem/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Triagem/Delete/5
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

        [HttpGet]
        public List<FF08Model> CarregaVeiculos()
        {
            List<FF08Model> listaCaminhao = null;

            return listaCaminhao;
        }
    }
}
