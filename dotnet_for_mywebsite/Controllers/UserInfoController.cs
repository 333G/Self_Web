using dotNetcore_for_selfweb.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SelfWeb.DAL.UserInfoDAL;
using System;
using System.Collections.Generic;

namespace dotnet_for_mywebsite.Controllers
{
    public class UserInfoController : Controller
    {
        // GET: UserInfo
        public ActionResult Index()
        {
            return View();
        }

        // GET: UserInfo/Details
        public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult close()
        {
            return Content("Close", "关闭页面");
        }

        // GET: UserInfo/Create
        public ActionResult CreateUser()
        {
            return View();
        }

        // POST: UserInfo/Create
        [HttpGet]
        //[ValidateAntiForgeryToken]
        public ActionResult Create(List<UserInfoEntity> collection)
        {
            // TODO: Add insert logic here
            try
            {
                if (UserInfoDAL.Instance.Get(collection[0].F_UserId) != null)
                    return Content("Warning这个用户名已经注册啦qwq，请换一个吧");

                var info = UserInfoDAL.Instance.Create(collection[0]);
                return Json(info.ToString());
            }
            catch (Exception ex)
            {
                // return Content("Error", ex.ToString());
                return Json(ex);
            }
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Create(UserInfoEntity collection)
        {
            try
            {
                if (UserInfoDAL.Instance.Get(collection.F_UserId) != null)
                    return Content("Warning这个用户名已经注册啦qwq，请换一个吧");

                var info = UserInfoDAL.Instance.Create(collection);
                return Json(info.ToString());
            }
            catch (Exception ex)
            {
                return Json(ex);
            }
        }

        // GET: UserInfo/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UserInfo/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UserInfo/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UserInfo/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}