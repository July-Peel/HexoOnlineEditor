using HexoOnlineEditor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace HexoOnlineEditor.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        ///  主页面
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// 设置页面
        /// </summary>
        /// <returns></returns>
        public PartialViewResult GetSetting()
        {
            string BPath = HelpData.GetXmlNote("BlogPath");
            string UPath = HelpData.GetXmlNote("UserPath");

            ViewBag.BPath = BPath;
            ViewBag.UPath = UPath;

            return PartialView("/Views/Shared/SettingPage.cshtml");
        }
        [HttpPost]
        public JsonResult SetSetting()
        {
            try
            {
                string BPath = Request.Form["BPath"].ToString() ?? "";
                string UPath = Request.Form["UPath"].ToString() ?? "";

                if (!Directory.Exists(BPath) || !Directory.Exists(UPath))
                {
                    throw new Exception("没有这个目录");
                }

                bool success1 = HelpData.SetXmlNote("BlogPath", BPath);
                bool success2 = HelpData.SetXmlNote("UserPath", UPath);


                if (!success1 && !success1) throw new Exception("编辑失败");

                return Json(new MessAge() { Status = true, Msg = "编辑成功" });

            }
            catch (Exception ex)
            {
                return Json(new MessAge() { Status = false, Msg = ex.Message });
            }
        }

        public PartialViewResult GetBlogMd()
        {
            try
            {
                string SearchText = Request.Query["SearchTxt"].ToString() ?? "";

                string BPath = HelpData.GetXmlNote("BlogPath");
                List<string> files = new List<string>();

                if (Directory.Exists(BPath))
                {
                    files = Directory.GetFiles(BPath, "*.md").ToList();

                    if (!string.IsNullOrEmpty(SearchText))
                    {
                        files = files.Where(a => a.Contains(SearchText)).ToList();
                    }

                }

                List<MdFileData> mdList = new List<MdFileData>();

                files.ForEach(a =>
                {
                    FileInfo fi = new FileInfo(a);

                    mdList.Add(new MdFileData()
                    {
                        MdName = Path.GetFileNameWithoutExtension(a),
                        MdPath = a,
                        UpdateTime = fi.LastWriteTime
                    });
                });

                int pagecount = 1;//页码
                int pagesize = 20;//每页数量

                ViewBag.Md = mdList.OrderByDescending(a => a.UpdateTime).Skip((pagecount - 1) * pagesize).Take(pagesize).ToList();

                ViewBag.Name = "博客文档";

                return PartialView("/Views/Shared/MdFileList.cshtml");
            }
            catch
            {

                return PartialView("/Views/Shared/Error.cshtml");
            }
        }
        public PartialViewResult GetUserMd()
        {
            try
            {
                string SearchText = Request.Query["SearchTxt"].ToString() ?? "";
                string BPath = HelpData.GetXmlNote("UserPath");
                List<string> files = new List<string>();

                if (Directory.Exists(BPath))
                {
                    files = Directory.GetFiles(BPath, "*.md").ToList();

                    if (!string.IsNullOrEmpty(SearchText))
                    {
                        files = files.Where(a => a.Contains(SearchText)).ToList();
                    }
                }


                List<MdFileData> mdList = new List<MdFileData>();

                files.ForEach(a =>
                {
                    FileInfo fi = new FileInfo(a);

                    mdList.Add(new MdFileData()
                    {
                        MdName = Path.GetFileNameWithoutExtension(a),
                        MdPath = a,
                        UpdateTime = fi.LastWriteTime
                    });
                });

                int pagecount = 1;//页码
                int pagesize = 20;//每页数量

                ViewBag.Md = mdList.OrderByDescending(a => a.UpdateTime).Skip((pagecount - 1) * pagesize).Take(pagesize).ToList();

                ViewBag.Name = "个人文档";

                return PartialView("/Views/Shared/MdFileList.cshtml");
            }
            catch
            {

                return PartialView("/Views/Shared/Error.cshtml");
            }
        }
        public IActionResult EditMarkDown()
        {
            string MdPath = Request.Query["MdPath"].ToString() ?? "";
            string MdType = Request.Query["MdType"].ToString() ?? "";


            string MdText = string.Empty;
            if (System.IO.File.Exists(MdPath))
            {
                MdText = System.IO.File.ReadAllText(MdPath);
            }
            ViewBag.MdText = MdText;
            ViewBag.MdPath = MdPath;
            ViewBag.MdType = MdType;

            return View();
        }
        [HttpPost]
        public JsonResult SaveMarkDown()
        {
            try
            {
                string MdPath = Request.Form["MdPath"].ToString() ?? "";//文件路径
                string MdText = Request.Form["MdText"].ToString() ?? "";//文件内容
                string MdType = Request.Form["MdType"].ToString() ?? "";//文件类型
                if (string.IsNullOrEmpty(MdText)) throw new Exception("内容不能为空");

                string msgTxt = "保存成功";

                if (MdType == "博客文档")
                {
                    //博客文档
                    System.IO.File.WriteAllText(MdPath, MdText);
                }
                else
                {
                    //个人文档

                    if (string.IsNullOrEmpty(MdPath))
                    {
                        //新建
                        string UPath = Path.Combine(HelpData.GetXmlNote("UserPath"), $"文档[{DateTime.Now.ToString("yy-MM-dd-HH-mm")}].md");
                        System.IO.File.WriteAllText(UPath, MdText);
                        msgTxt = UPath;
                    }
                    else
                    {
                        //已有
                        System.IO.File.WriteAllText(MdPath, MdText);
                    }
                }
                return Json(new MessAge() { Status = true, Msg = msgTxt });
            }
            catch (Exception ex)
            {
                return Json(new MessAge() { Status = false, Msg = ex.Message });
            }
        }
        [HttpPost]
        public JsonResult AddNewMarkDown()
        {
            try
            {
                string MdName = Request.Form["MdName"].ToString() ?? "";
                string MdType = Request.Form["MdType"].ToString() ?? "";

                if (string.IsNullOrEmpty(MdName) || string.IsNullOrEmpty(MdType))
                {
                    throw new Exception("数据有误");
                }

                if (MdType == "BlogMd")
                {
                    string BPath = HelpData.GetXmlNote("BlogPath");
                    
                }
                else
                {
                    string UPath = HelpData.GetXmlNote("UserPath");
                    string MdPath = Path.Combine(UPath, MdName + ".md");
                    System.IO.File.WriteAllText(MdPath, "");
                }

                return Json(new MessAge() { Status = true, Msg = "新建成功" });

            }
            catch (Exception ex)
            {
                return Json(new MessAge() { Status = false, Msg = ex.Message });
            }
        }
        public JsonResult DeleteMarkDown()
        {
            try
            {
                string MdPath = Request.Form["MdPath"].ToString() ?? "";

                if (System.IO.File.Exists(MdPath))
                {
                    System.IO.File.Delete(MdPath);
                }
                return Json(new MessAge() { Status = true, Msg = "删除成功" });
            }
            catch (Exception ex)
            {
                return Json(new MessAge() { Status = false, Msg = ex.Message });
            }
        }
    }
}
