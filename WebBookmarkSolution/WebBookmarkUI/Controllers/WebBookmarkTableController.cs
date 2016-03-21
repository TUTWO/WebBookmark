﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Xml.Linq;
using WebBookmarkBo.Model;
using WebBookmarkService;
using WebBookmarkUI.Models;
using WebfolderBo.Service;

namespace WebBookmarkUI.Controllers
{
    public class WebBookmarkTableController : Controller
    {
        // GET: WebBookmarkTable
        public ActionResult Index(string strAllFolder = "", long showFolderID = 0)
        {
            WebBookmarkTableModel model = null;

            if (string.IsNullOrEmpty(strAllFolder) && showFolderID == 0)
            {
                var uid = UILoginHelper.GetUIDInCookie(Request);
                if (uid != default(long))
                {
                    var result = UserWebFolderBo.LoadWebfolderByUID(uid);
                    if (!result.IsSuccess)
                        return View();
                    model = new WebBookmarkTableModel();
                    model.AllWebFolderInfoList = new List<UIWebFolderInfo>();
                    foreach (var bizWebfolder in (result.Target as List<BizUserWebFolder>).OrderBy(folder => folder.ParentWebfolderID))
                    {
                        UIWebFolderInfo uiModel = ToUIModel(bizWebfolder);
                        model.AllWebFolderInfoList.Add(uiModel);
                    }
                    model.FirstWebFolderInfo = model.AllWebFolderInfoList.Find(folder => folder.ParentWebfolderID == 0);
                }
            }else
            {
                model = JsonConvert.DeserializeObject<WebBookmarkTableModel>(strAllFolder); ;
                model.FirstWebFolderInfo = model.AllWebFolderInfoList.Find(folder => folder.ParentWebfolderID == showFolderID);
            }
            return View(model);
        }

        private static UIWebFolderInfo ToUIModel(BizUserWebFolder bizWebfolder)
        {
            var uiModel = new UIWebFolderInfo();
            uiModel.ParentWebfolderID = bizWebfolder.ParentWebfolderID;
            uiModel.UserInfoID = bizWebfolder.UserInfoID;
            uiModel.UserWebFolderID = bizWebfolder.UserWebFolderID;
            uiModel.WebFolderName = bizWebfolder.WebFolderName;
            uiModel.Visible = bizWebfolder.Visible;
            //uiModel.IntroContent = bizWebfolder.IntroContent;
            //uiModel.IElementJSON = bizWebfolder.IElementJSON;
            uiModel.CreateTime = bizWebfolder.CreateTime;
            uiModel.ChildrenFolderList = new List<UIWebFolderInfo>();
            uiModel.UIBookmarkInfoList = new List<UIBookmarkInfo>();

            if (bizWebfolder.ChildrenFolderList!=null && bizWebfolder.ChildrenFolderList.Count!=0)
            {
                uiModel.ChildrenFolderList.AddRange(
                    bizWebfolder.ChildrenFolderList.
                    Select(childeren=>ToUIModel(childeren)));
            }

            if(bizWebfolder.BizBookmarkInfoList!=null && bizWebfolder.BizBookmarkInfoList.Count!=0)
            {
              

                foreach(var bookmark in bizWebfolder.BizBookmarkInfoList)
                {
                    var uiBookmarkInfo = new UIBookmarkInfo()
                    {
                        UserInfoID = bookmark.UserInfoID,
                        UserWebFolderID = bookmark.UserWebFolderID,
                        Host = bookmark.Host,
                        Href = bookmark.Href,
                        BookmarkName = bookmark.BookmarkName,
                        CreateTime = bookmark.CreateTime,
                        BookmarkInfoID = bookmark.BookmarkInfoID,
                    };

                    uiModel.UIBookmarkInfoList.Add(uiBookmarkInfo);
                } 
            }
            return uiModel;
        }


        public ActionResult ShowFolderInfo(string strAllFolder = "", long showFolderID = 0)
        {
            WebBookmarkTableModel model = null;
            try
            {
                model = JsonConvert.DeserializeObject<WebBookmarkTableModel>(strAllFolder); ;
                model.FirstWebFolderInfo = model.AllWebFolderInfoList.Find(folder => folder.ParentWebfolderID == showFolderID);
               

            }catch(Exception ex)
            {
                LogHelper.WriteException("ShowFolderInfo Exception", ex, new { WebBookmarkTableModel = model, ShowFolderID = showFolderID });
            }
            return View(model);
        }


        public ActionResult ImportWebBookmark()
        {
            return View();
        }

        

        public ActionResult ImportWebBookmarkToDB(string filePath)
        {
            BizResultInfo result = new BizResultInfo();

            if(string.IsNullOrEmpty(filePath))
            {
                result.IsSuccess = false;
                result.ErrorMessage = "先上传文件呀。";
            }
            long uid = UILoginHelper.GetUIDInCookie(Request);

            var path = Server.MapPath(filePath);

            result = ImportBookmarkHelper.ImportBookmarkDataToDB(path,uid);


            return Json(new BizResultInfo() { IsSuccess = true,SuccessMessage="保存成功耶，你可以到别的地方玩了。" });
        }

      


        public ActionResult UploadWebBookmarkFile()
        {
            var result = UploadFileHelper.UploadFileToUserImportFile(Request);
            if(result.IsSuccess)
            {
                BizUserWebBookmarkImportLog importLog = new BizUserWebBookmarkImportLog();
                importLog.CreateTime = DateTime.Now;
                importLog.UserInfoID = UILoginHelper.GetUIDInCookie(Request);
                importLog.Path = result.ResultID;
                importLog.FileName = result.ResultID;
                importLog.Save();
            }

            return Json(result);
        }

        public FileResult PreView(string path)
        {
            return File(path, "text/html");
        }

    }
}