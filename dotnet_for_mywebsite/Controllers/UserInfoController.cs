using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using dotNetcore_for_selfweb.Entity;
using SelfWeb.DAL;
using SelfWeb.DAL.UserInfoDAL;

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
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateUser(List< UserInfoEntity> collection)
        {

            // TODO: Add insert logic here
            try
            {
                if (UserInfoDAL.Instance.Get(collection[0].F_UserId) != null)
                    return Content("Warning", "这个用户名已经注册啦qwq，请换一个吧");

                var info = UserInfoDAL.Instance.Create(collection[0]);
                return Content("Success", info.ToString());
            }
            catch (Exception ex)
            {
                SerializableError error = new SerializableError();
                return Content("Error", ex.ToString());
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