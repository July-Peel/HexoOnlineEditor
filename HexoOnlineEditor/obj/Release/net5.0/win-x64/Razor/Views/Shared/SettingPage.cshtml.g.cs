#pragma checksum "D:\Disarray\乱七八糟\HexoOnlineEditor\HexoOnlineEditor\Views\Shared\SettingPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d20eae6118649a9dc353348738aa5607f602308"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_SettingPage), @"mvc.1.0.view", @"/Views/Shared/SettingPage.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d20eae6118649a9dc353348738aa5607f602308", @"/Views/Shared/SettingPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95ce23ac2c6d79152b7c874fc3dbe5f1d5f3a863", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_SettingPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Disarray\乱七八糟\HexoOnlineEditor\HexoOnlineEditor\Views\Shared\SettingPage.cshtml"
  
    Layout = "_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h5 style=\"margin:30px\">设置</h5>\r\n<div class=\"divider\"></div>\r\n<div class=\"container\">\r\n    <div class=\"input-field col s12\">\r\n        <b>标题</b>\r\n        <input id=\"Title\" type=\"text\" class=\"validate\"");
            BeginWriteAttribute("value", " value=\"", 238, "\"", 260, 1);
#nullable restore
#line 9 "D:\Disarray\乱七八糟\HexoOnlineEditor\HexoOnlineEditor\Views\Shared\SettingPage.cshtml"
WriteAttributeValue("", 246, ViewBag.Title, 246, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    </div>\r\n    <div class=\"input-field col s12\">\r\n        <b>博客文档目录</b>\r\n        <input id=\"BPath\" type=\"text\" class=\"validate\"");
            BeginWriteAttribute("value", " value=\"", 392, "\"", 417, 1);
#nullable restore
#line 13 "D:\Disarray\乱七八糟\HexoOnlineEditor\HexoOnlineEditor\Views\Shared\SettingPage.cshtml"
WriteAttributeValue("", 400, ViewBag.BlogPath, 400, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    </div>\r\n    <div class=\"input-field col s12\">\r\n        <b>杂项文档目录</b>\r\n        <input id=\"UPath\" type=\"text\" class=\"validate\"");
            BeginWriteAttribute("value", " value=\"", 549, "\"", 574, 1);
#nullable restore
#line 17 "D:\Disarray\乱七八糟\HexoOnlineEditor\HexoOnlineEditor\Views\Shared\SettingPage.cshtml"
WriteAttributeValue("", 557, ViewBag.UserPath, 557, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    </div>\r\n    <div class=\"input-field col s12\">\r\n        <b>文件分隔符</b>\r\n        <input id=\"Split\" type=\"text\" class=\"validate\"");
            BeginWriteAttribute("value", " value=\"", 705, "\"", 727, 1);
#nullable restore
#line 21 "D:\Disarray\乱七八糟\HexoOnlineEditor\HexoOnlineEditor\Views\Shared\SettingPage.cshtml"
WriteAttributeValue("", 713, ViewBag.Split, 713, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    </div>\r\n    <div class=\"input-field col s12\">\r\n        <b>密码</b>\r\n        <input id=\"PassWord\" type=\"text\" class=\"validate\"");
            BeginWriteAttribute("value", " value=\"", 858, "\"", 883, 1);
#nullable restore
#line 25 "D:\Disarray\乱七八糟\HexoOnlineEditor\HexoOnlineEditor\Views\Shared\SettingPage.cshtml"
WriteAttributeValue("", 866, ViewBag.PassWord, 866, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
    </div>
    <div class=""col m12"" align=""right"">
        <button class=""waves-effect waves-light btn"" style=""margin:30px"" id=""sub"">确定</button>
    </div>
</div>
<script>
    $(function () {
        $(""#sub"").click(function () {
            var bPath = $(""#BPath"").val();
            var uPath = $(""#UPath"").val();
            var Title = $(""#Title"").val();
            var Split = $(""#Split"").val();
            var PassWord = $(""#PassWord"").val();
            if (bPath == """" || uPath == """" || Title == """" || Split == """" || PassWord=="""") {
                layer.msg(""数据有误"", { icon: 2 });
                return;
            }
            $.post(""/Home/SetSetting"", { BPath: bPath, UPath: uPath, Title: Title, Split: Split, PassWord: PassWord }, function (data) {
                if (data.status) {

                    layer.msg(data.msg, { icon: 1, time: 2500 }, function () {
                        layer.closeAll();
                    })

                } else {
                    laye");
            WriteLiteral("r.msg(data.msg, { icon: 2 });\r\n                }\r\n            },\"json\")\r\n        })\r\n    })\r\n</script>");
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
