﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HiHe.Areas.Admin.Models;
using HiHe.Helpers;
using Model.EF;

namespace HiHe.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        private HiHeConText db = new HiHeConText();
        // GET: Admin/Login
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login(UserLoginModel user)
        {
            if(ModelState.IsValid)
            {
                var userContext = db.Users.SingleOrDefault(u => u.Username == user.Username);
                if(userContext == null)
                {
                    ModelState.AddModelError("", "Tài khoản không tồn tại");
                }
                else
                {
                    if(userContext.Password != GetMd5.Generate(user.Password))
                    {
                        ModelState.AddModelError("", "Password không đúng");
                    }
                    else
                    {
                        var UserSession = new UserLoginModel();
                        UserSession.Username = userContext.Username;
                        UserSession.Password = userContext.Password;
                        UserSession.Image = userContext.Avatar;
                        UserSession.Name = userContext.FullName;
                        Session.Add("userSession",UserSession);
                        return RedirectToAction("Index", "Home");
                    }
                }
            }
            return View(user);
        }
        public ActionResult Logout()
        {
            Session.Abandon();
            return RedirectToAction("Login");
        }
    }
}