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
            string pwd = Request.Cookies["pwd"]?.ToString() ?? "";
            if (pwd == HelpData.GetMD5("123Cool"))
            {
                string Title = HelpData.GetXmlNote("Title");
                string Split = HelpData.GetXmlNote("Split");
                ViewBag.Title = Title;
                ViewBag.Split = Split;
                return View();
            }
            else
            {
                return Redirect("/Login/Index");
            }
        }
        /// <summary>
        /// 设置页面
        /// </summary>
        /// <returns></returns>
        public PartialViewResult GetSetting()
        {
            string BlogPath = HelpData.GetXmlNote("BlogPath");
            string UserPath = HelpData.GetXmlNote("UserPath");

            string Title = HelpData.GetXmlNote("Title");
            string Split = HelpData.GetXmlNote("Split");
            string PassWord = HelpData.GetXmlNote("PassWord");

            ViewBag.BlogPath = BlogPath;
            ViewBag.UserPath = UserPath;
            ViewBag.Title = Title;
            ViewBag.Split = Split;
            ViewBag.PassWord = PassWord;

            return PartialView("/Views/Shared/SettingPage.cshtml");
        }
        [HttpPost]
        public JsonResult SetSetting()
        {
            try
            {
                string BPath = Request.Form["BPath"].ToString() ?? "";
                string UPath = Request.Form["UPath"].ToString() ?? "";


                string Title = Request.Form["Title"].ToString() ?? "";
                string Split = Request.Form["Split"].ToString() ?? "";
                string PassWord = Request.Form["PassWord"].ToString() ?? "";

                if (!Directory.Exists(BPath) || !Directory.Exists(UPath))
                {
                    throw new Exception("没有这个目录");
                }

                bool success1 = HelpData.SetXmlNote("BlogPath", BPath);
                bool success2 = HelpData.SetXmlNote("UserPath", UPath);
                bool success3 = HelpData.SetXmlNote("Title", Title);
                bool success4 = HelpData.SetXmlNote("Split", Split);
                bool success5 = HelpData.SetXmlNote("PassWord", PassWord);

                if (!success1 || !success2 || !success3 || !success4 || !success5) throw new Exception("编辑失败");

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
        [HttpPost]
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
        [HttpPost]
        public JsonResult EditMarkDownName()
        {
            try
            {
                string NewName = Request.Form["MdName"].ToString() ?? "";
                string MdPath = Request.Form["MdPath"].ToString() ?? "";
                if (string.IsNullOrEmpty(NewName) || string.IsNullOrEmpty(MdPath)) throw new Exception("数据有误");

                if (!System.IO.File.Exists(MdPath)) throw new Exception("文件不存在");

                if (!NewName.Contains(".md")) NewName += ".md";

                string MdTxt = System.IO.File.ReadAllText(MdPath);
                System.IO.File.Delete(MdPath);
                string newPath = Path.Combine(Path.GetDirectoryName(MdPath), NewName);
                System.IO.File.WriteAllText(newPath, MdTxt);

                return Json(new MessAge() { Status = true, Msg = "重命名成功" });

            }
            catch (Exception ex)
            {
                return Json(new MessAge() { Status = false, Msg = ex.Message });
            }
        }
        [HttpPost]
        public JsonResult GetTianGou()
        {
            try
            {
                string tiangouTxt = HelpData.Get("https://api.oick.cn/dog/api.php");

                return Json(new MessAge() { Status = true, Msg = tiangouTxt });
            }
            catch (Exception ex)
            {
                return Json(new MessAge() { Status = false, Msg = ex.Message });
            }
        }
        [HttpPost]
        public JsonResult PublishByBlog()
        {
            try
            {
                string mdPath = Request.Form["MdPath"].ToString() ?? "";
                if (string.IsNullOrEmpty(mdPath) || !System.IO.File.Exists(mdPath)) throw new Exception("数据有误");

                string BPath = HelpData.GetXmlNote("BlogPath");
                string newName = Path.Combine(BPath, Path.GetFileName(mdPath));

                System.IO.File.Copy(mdPath, newName);

                return Json(new MessAge() { Status = true, Msg = "已复制到博客文档" });
            }
            catch (Exception ex)
            {
                return Json(new MessAge() { Status = false, Msg = ex.Message });
            }
        }
    }
}
