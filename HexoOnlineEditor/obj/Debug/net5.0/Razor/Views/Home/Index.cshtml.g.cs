#pragma checksum "D:\Disarray\乱七八糟\HexoOnlineEditor\HexoOnlineEditor\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b8a60d8f378dcfdcd6b3829ccc4ff1ffda47d29"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\Disarray\乱七八糟\HexoOnlineEditor\HexoOnlineEditor\Views\_ViewImports.cshtml"
using HexoOnlineEditor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Disarray\乱七八糟\HexoOnlineEditor\HexoOnlineEditor\Views\_ViewImports.cshtml"
using HexoOnlineEditor.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b8a60d8f378dcfdcd6b3829ccc4ff1ffda47d29", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95ce23ac2c6d79152b7c874fc3dbe5f1d5f3a863", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/main.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/Image/4.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:300px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/materialize/js/materialize.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6b8a60d8f378dcfdcd6b3829ccc4ff1ffda47d294839", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<nav>\r\n    <div class=\"nav-wrapper brown blue darken-2\">\r\n        <a href=\"javascript:void(0)\" class=\"brand-logo center\">");
#nullable restore
#line 6 "D:\Disarray\乱七八糟\HexoOnlineEditor\HexoOnlineEditor\Views\Home\Index.cshtml"
                                                          Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
        <a href=""javascript:void(0)"" data-target=""mobile-demo"" class=""sidenav-trigger""><i class=""material-icons"">&#xe5d2;</i></a>
        <a href=""javascript:void(0)"" class=""right"" style=""margin:0 30px 0 0"" id=""setting""><i class=""material-icons"">&#xe8b8;</i></a>
    </div>
</nav>
<ul class=""sidenav sidenav-fixed"" id=""mobile-demo"">
    <li>
        <div class=""user-view"">
            <div class=""background"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6b8a60d8f378dcfdcd6b3829ccc4ff1ffda47d296819", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
            <a href=""javascript:void(0)""><img class=""circle"" src=""https://gitee.com/Qinin/my-image/raw/master/2021/yingtao.jpg""></a>
            <a href=""javascript:void(0)""><span class=""white-text name"">果皮</span></a>
            <a href=""javascript:void(0)""><span class=""white-text email"">Q87888@88.com</span></a>
        </div>
    </li>
    <li>
        <div class=""row"">
            <div class=""col s9"">
                <input placeholder=""搜索"" id=""first_name"" type=""text"" class=""validate"">
            </div>
            <div class=""col s3"">
                <a href=""javascript:void(0)"" class=""btn-floating waves-effect waves-light red"" id=""search""><i class=""material-icons"">&#xe8b6;</i></a>
            </div>
        </div>
    </li>
    <li id=""uData""></li>
    <li id=""bData""></li>
</ul>


<main>
    <iframe src=""/Home/EditMarkDown"" style=""width:100%;"" border=""0"" id=""Farm""></iframe>
</main>

<div class=""row"" style=""position:absolute;right:20px;width:35%"" id=""caozuo"">");
            WriteLiteral(@"
    <div class=""col s7"" align=""right""><h5 class=""truncate"" style=""margin:10px 0 0 0"" id=""mdName""></h5><input type=""hidden"" id=""mdFile"" /></div>
    <div class=""col s5"" align=""right"">
        <button class=""btn-floating waves-effect waves-light deep-purple"" id=""fabu""><i class=""material-icons"">&#xe163;</i></button>
        <button class=""btn-floating waves-effect waves-light cyan"" id=""EditName""><i class=""material-icons"">&#xe3c9;</i></button>
        <button class=""btn-floating waves-effect waves-light pink accent-3"" id=""deleteMd""><i class=""material-icons"">&#xe872;</i></button>
    </div>
</div>


");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6b8a60d8f378dcfdcd6b3829ccc4ff1ffda47d299689", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script>
    $(document).ready(function () {
        $('.sidenav').sidenav();
        SetIframeHeight();
        $(""#setting"").click(function () {
            $.get(""/Home/GetSetting"", function (data) {
                layer.open({
                    type: 1,
                    content: data,
                    resize: false,
                    area: ['600px', '400px'],
                    shade: 0.5,
                    title: false
                });
            })
        })
        $(""#deleteMd"").click(function () {
            var mdName = $(""#mdName"").html();
            if (mdName == """") return;
            layer.confirm('确定删除文件【' + mdName + '】?', { icon: 3, title: '提示' }, function (index) {

                var LoadIndex = layer.load(1, { shade: 0.6 });

                var mdpath = $(""#mdFile"").val();
                $.post(""/Home/DeleteMarkDown"", { MdPath: mdpath }, function (data) {
                    if (data.status) {
                        layer.close(LoadIndex");
            WriteLiteral(@");
                        $(""#mdFile"").val("""");
                        $(""#mdName"").html("""");
                        $(""#Farm"").attr(""src"", ""/Home/EditMarkDown"");
                        GetBlogData();
                        GetUserData();
                        layer.msg(data.msg, { icon: 1 });
                    } else {
                        layer.msg(data.msg, { icon: 2 });
                    }

                },""json"")

                layer.close(index);
            });
        })
        $(""#search"").click(function () {
            var index = layer.load(1, { shade: 0.6 });
            var STxt = $(""#first_name"").val();
            $.get(""/Home/GetBlogMd?SearchTxt="" + STxt, function (data) {
                $(""#bData"").html(data);
            })
            $.get(""/Home/GetUserMd?SearchTxt="" + STxt, function (data) {
                $(""#uData"").html(data);
                layer.close(index);
            })
        })
        $(""#EditName"").click(function () {
     ");
            WriteLiteral("       var mdName = $(\"#mdFile\").val();\r\n            if (mdName == \"\") return;\r\n\r\n            var PathList = mdName.split(\'");
#nullable restore
#line 109 "D:\Disarray\乱七八糟\HexoOnlineEditor\HexoOnlineEditor\Views\Home\Index.cshtml"
                                    Write(ViewBag.Split);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"');
            var md = PathList[PathList.length - 1].replace('.md', '');

            layer.prompt({
                formType: 0,
                title: '重命名',
                value: md,
                area: ['400px', '250px'] //自定义文本域宽高
            }, function (value, index, elem) {

                var LoadIndex = layer.load(1, { shade: 0.6 });
                $.post(""/Home/EditMarkDownName"", { MdName: value, MdPath: mdName }, function (data) {
                    layer.close(index);
                    if (data.status) {
                        layer.close(LoadIndex);
                        $(""#mdFile"").val("""");
                        $(""#mdName"").html("""");
                        $(""#Farm"").attr(""src"", ""/Home/EditMarkDown"");
                        GetBlogData();
                        GetUserData();
                        layer.msg(data.msg, { icon: 1 });
                    } else {
                        layer.msg(data.msg, { icon: 2 });
                    }
           ");
            WriteLiteral(@"     }, ""json"")
            });
        })

        $(""#fabu"").click(function () {
            var mdName = $(""#mdName"").html();
            if (mdName == """") return;
            layer.confirm('确定将文件发布到博客文档【' + mdName + '】?', { icon: 3, title: '提示' }, function (index) {

                var LoadIndex = layer.load(1, { shade: 0.6 });
                var mdpath = $(""#mdFile"").val();
                $.post(""/Home/PublishByBlog"", { MdPath: mdpath }, function (data) {
                    if (data.status) {
                        layer.close(LoadIndex);
                        GetBlogData();
                        layer.msg(data.msg, { icon: 1 });
                    } else {
                        layer.msg(data.msg, { icon: 2 });
                    }

                }, ""json"")

                layer.close(index);
            });
        })

        GetBlogData();
        GetUserData();
        
    });

    function GetMdByEdit(mdName,mdType)
    {
        var PathList = mdNa");
            WriteLiteral("me.split(\'");
#nullable restore
#line 166 "D:\Disarray\乱七八糟\HexoOnlineEditor\HexoOnlineEditor\Views\Home\Index.cshtml"
                                Write(ViewBag.Split);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"');
        var md = PathList[PathList.length - 1];
        $(""#mdFile"").val(mdName);
        $(""#mdName"").html(md);
        //开始编辑

        mdName = mdName.replace(/\%/g, ""%25"");
        mdName = mdName.replace(/\#/g, ""%23"");
        mdName = mdName.replace(/\&/g, ""%26"");
        mdName = mdName.replace(/\+/g, ""%2B"");
        mdName = mdName.replace(/\=/g, ""%3D"");

        $(""#Farm"").attr(""src"", ""/Home/EditMarkDown?MdPath="" + mdName + ""&MdType="" + mdType);

    }
    function blogAdd() {
        layer.prompt({
            formType: 0,
            title: '新增博客文档，请输入文件名',
            area: ['300px', '200px'] //自定义文本域宽高
        }, function (value, index, elem) {
            $.post(""/Home/AddNewMarkDown"", { MdName: value, MdType: ""BlogMd"" }, function (data) {
                layer.close(index);
                if (data.status) {
                    layer.msg(data.msg, { icon: 1 });
                    GetBlogData();
                } else {
                    layer.msg(data.msg, { ico");
            WriteLiteral(@"n: 2 });
                }
            },""json"")
        });
    }
    function userAdd() {
        layer.prompt({
            formType: 0,
            title: '新增个人文档，请输入文件名',
            area: ['300px', '200px'] //自定义文本域宽高
        }, function (value, index, elem) {
            $.post(""/Home/AddNewMarkDown"", { MdName: value, MdType: ""UserMd"" }, function (data) {
                layer.close(index);
                if (data.status) {
                    layer.msg(data.msg, { icon: 1 });
                    GetUserData();
                } else {
                    layer.msg(data.msg, { icon: 2 });
                }
            }, ""json"")
        });
    }
    function GetBlogData() {
        $.get(""/Home/GetBlogMd"", function (data) {
            $(""#bData"").html(data);
        })
    }
    function GetUserData() {
        $.get(""/Home/GetUserMd"", function (data) {
            $(""#uData"").html(data);
        })
    }
    function GetUserTxt(mdName) {
        var PathList = mdNam");
            WriteLiteral(@"e.split('\\');
        var md = PathList[PathList.length - 1];
        $(""#mdFile"").val(mdName);
        $(""#mdName"").html(md);
    }

    function SetIframeHeight() {
        var heightNum = ((document.body.scrollWidth / 16) * 9) - 180;
        if (heightNum < 900) heightNum = 900;
        $(""#Farm"").css(""height"", heightNum + ""px"")
        $(""#caozuo"").css(""top"", (heightNum + 10) + ""px"");
    }
    
</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
