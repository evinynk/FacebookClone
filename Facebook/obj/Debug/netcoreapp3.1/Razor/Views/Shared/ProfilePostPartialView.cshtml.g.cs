#pragma checksum "C:\Users\evin\Desktop\githuba atılan projeler\FacebookPrj\Facebook\Views\Shared\ProfilePostPartialView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f8afd0cf2bc4c7f45acb5fdccd559d14dae6051e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_ProfilePostPartialView), @"mvc.1.0.view", @"/Views/Shared/ProfilePostPartialView.cshtml")]
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
#line 1 "C:\Users\evin\Desktop\githuba atılan projeler\FacebookPrj\Facebook\Views\_ViewImports.cshtml"
using Facebook;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\evin\Desktop\githuba atılan projeler\FacebookPrj\Facebook\Views\_ViewImports.cshtml"
using Facebook.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\evin\Desktop\githuba atılan projeler\FacebookPrj\Facebook\Views\Shared\ProfilePostPartialView.cshtml"
using Common.Dtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\evin\Desktop\githuba atılan projeler\FacebookPrj\Facebook\Views\Shared\ProfilePostPartialView.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8afd0cf2bc4c7f45acb5fdccd559d14dae6051e", @"/Views/Shared/ProfilePostPartialView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2137e316df431bf9283f69ddeec2fedb56558b2f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_ProfilePostPartialView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PostDto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Profile Icon"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("border-radius: 5%; width:450px;  text-align:center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\evin\Desktop\githuba atılan projeler\FacebookPrj\Facebook\Views\Shared\ProfilePostPartialView.cshtml"
 foreach (var post in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"wall-post\" id=\"post-1\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f8afd0cf2bc4c7f45acb5fdccd559d14dae6051e5051", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 178, "~/img/", 178, 6, true);
#nullable restore
#line 8 "C:\Users\evin\Desktop\githuba atılan projeler\FacebookPrj\Facebook\Views\Shared\ProfilePostPartialView.cshtml"
AddHtmlAttributeValue("", 184, post.ProfilPhoto, 184, 17, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        <span class=\"post-caption\">\r\n            <p><b><a href=\"#\">");
#nullable restore
#line 10 "C:\Users\evin\Desktop\githuba atılan projeler\FacebookPrj\Facebook\Views\Shared\ProfilePostPartialView.cshtml"
                         Write(post.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></p>\r\n            <p class=\"faded-gray-font\">");
#nullable restore
#line 11 "C:\Users\evin\Desktop\githuba atılan projeler\FacebookPrj\Facebook\Views\Shared\ProfilePostPartialView.cshtml"
                                   Write(DateTime.Now.Minute-post.CreatedDate.Minute+"m");

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </span>\r\n\r\n        <span");
            BeginWriteAttribute("class", " class=\"", 442, "\"", 450, 0);
            EndWriteAttribute();
            WriteLiteral("> <p style=\" font-size:12px; font-family:sans-serif; \">");
#nullable restore
#line 14 "C:\Users\evin\Desktop\githuba atılan projeler\FacebookPrj\Facebook\Views\Shared\ProfilePostPartialView.cshtml"
                                                                        Write(post.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p> </span>\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 20 "C:\Users\evin\Desktop\githuba atılan projeler\FacebookPrj\Facebook\Views\Shared\ProfilePostPartialView.cshtml"
         if (post.Image != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div style=\"margin-top:auto\" class=\"post__image\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f8afd0cf2bc4c7f45acb5fdccd559d14dae6051e8309", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 971, "~/img/", 971, 6, true);
#nullable restore
#line 23 "C:\Users\evin\Desktop\githuba atılan projeler\FacebookPrj\Facebook\Views\Shared\ProfilePostPartialView.cshtml"
AddHtmlAttributeValue("", 977, post.Image, 977, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n            </div>\r\n");
#nullable restore
#line 26 "C:\Users\evin\Desktop\githuba atılan projeler\FacebookPrj\Facebook\Views\Shared\ProfilePostPartialView.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""btn-group btn-group-justified comment-buttons blue-font"">
                    <a role=""button"" class=""btn btn-default btn-md ""><span class=""glyphicon glyphicon-thumbs-up"" aria-hidden=""true""></span> Like</a>
                    <a role=""button"" class=""btn btn-default btn-md""> <span class=""glyphicon glyphicon-comment"" aria-hidden=""true""></span> Comment</a>
                    <a role=""button"" class=""btn btn-default btn-md""> <span class=""glyphicon glyphicon-share-alt"" aria-hidden=""true""></span> Share </a>
                </div>
");
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 60 "C:\Users\evin\Desktop\githuba atılan projeler\FacebookPrj\Facebook\Views\Shared\ProfilePostPartialView.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    \r\n<script src=\"https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js\"></script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PostDto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
