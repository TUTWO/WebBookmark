﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebfolderBo.Model;
using WebfolderBo.Service;
using WebfolderUI.Models;

namespace WebfolderUI.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index(string uid="")
        {
            UIUserInfo uiUserInfo = null;
            if(string.IsNullOrEmpty(uid))
                return View(uiUserInfo);

            var result= UserInfoBo.GetUserInfoByUID(uid.ConvertToPlainLong());
            if(result.IsSuccess)
            {
                BizUserInfo bizUserInfo = result.Target as BizUserInfo;
                if(bizUserInfo==null || bizUserInfo.UserInfoID ==0)
                 return   View(uiUserInfo);
                uiUserInfo = new UIUserInfo();
                uiUserInfo.UserEmail = bizUserInfo.UserEmail;
                uiUserInfo.UserName = bizUserInfo.UserName;
                uiUserInfo.LoginName = bizUserInfo.UserLoginName;
            }
            return View(uiUserInfo);
        }


        public ActionResult UserLogin(UIUserInfo uiUserInfo)
        {
            var rsp = UserInfoBo.UserLogin(string.IsNullOrEmpty(uiUserInfo.UserEmail) ? 
                uiUserInfo.LoginName : uiUserInfo.UserEmail, 
                uiUserInfo.Password);
            return Json(rsp);

        }
    }
}