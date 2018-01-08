using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using dotNetcore_for_selfweb.Models;

namespace dotNetcore_for_selfweb.Controllers
{
    public class UserInfoModelsController : Controller
    {
        private readonly dotNetcore_for_selfwebContext _context;

        public UserInfoModelsController(dotNetcore_for_selfwebContext context)
        {
            _context = context;
        }

        // GET: UserInfoModels
        public async Task<IActionResult> Index()
        {
            return View(await _context.UserInfoModel.ToListAsync());
        }

        // GET: UserInfoModels/Details/5
        public async Task<IActionResult> Details(string F_UserId)
        {
            if (F_UserId == null)
            {
                return NotFound();
            }

            var userInfoModel = await _context.UserInfoModel
                .SingleOrDefaultAsync(m => m.F_UserId == F_UserId);
            if (userInfoModel == null)
            {
                return NotFound();
            }

            return View(userInfoModel);
        }

        // GET: UserInfoModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: UserInfoModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("F_ID,id,F_UserId,F_UserName,F_Psd,F_Contact,F_Mail")] UserInfoModel userInfoModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(userInfoModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(userInfoModel);
        }

        // GET: UserInfoModels/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userInfoModel = await _context.UserInfoModel.SingleOrDefaultAsync(m => m.id == id);
            if (userInfoModel == null)
            {
                return NotFound();
            }
            return View(userInfoModel);
        }

        // POST: UserInfoModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("F_ID,id,F_UserId,F_UserName,F_Psd,F_Contact,F_Mail")] UserInfoModel userInfoModel)
        {
            if (id != userInfoModel.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(userInfoModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserInfoModelExists(userInfoModel.id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(userInfoModel);
        }

        // GET: UserInfoModels/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userInfoModel = await _context.UserInfoModel
                .SingleOrDefaultAsync(m => m.id == id);
            if (userInfoModel == null)
            {
                return NotFound();
            }

            return View(userInfoModel);
        }

        // POST: UserInfoModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var userInfoModel = await _context.UserInfoModel.SingleOrDefaultAsync(m => m.id == id);
            _context.UserInfoModel.Remove(userInfoModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserInfoModelExists(long id)
        {
            return _context.UserInfoModel.Any(e => e.id == id);
        }
    }
}
