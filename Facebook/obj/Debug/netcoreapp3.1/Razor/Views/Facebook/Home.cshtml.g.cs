#pragma checksum "C:\Users\evin\Desktop\githuba atılan projeler\FacebookPrj\Facebook\Views\Facebook\Home.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7efa64f000493d75e4c699e79c946c24eee99328"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Facebook_Home), @"mvc.1.0.view", @"/Views/Facebook/Home.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7efa64f000493d75e4c699e79c946c24eee99328", @"/Views/Facebook/Home.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2137e316df431bf9283f69ddeec2fedb56558b2f", @"/Views/_ViewImports.cshtml")]
    public class Views_Facebook_Home : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/home.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/js/bootstrap.bundle.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/home.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "PostPopUp", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "PartialViewForChat", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\evin\Desktop\githuba atılan projeler\FacebookPrj\Facebook\Views\Facebook\Home.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7efa64f000493d75e4c699e79c946c24eee993285866", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"" />
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"" />
    <meta http-equiv=""X-UA-Compatible"" content=""ie=edge"" />
    <title>Facebook </title>
    <link rel=""shortcut icon"" href=""images/favicon.png"" type=""image/x-icon"">
    <script src=""https://kit.fontawesome.com/8cd25ea642.js"" crossorigin=""anonymous""></script>
    <link href=""https://fonts.googleapis.com/css?family=Lato:400,700""
          rel=""stylesheet"" />
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7efa64f000493d75e4c699e79c946c24eee993286625", async() => {
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
                WriteLiteral(@"
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css""
          integrity=""sha384-JcKb8q3iqJ61gNV9KGb8thSsNjpSL0n8PARn9HuZOnIxN0hoP+VmmDGMN5t9UJ0Z"" crossorigin=""anonymous"">
    <script src=""https://kit.fontawesome.com/8cd25ea642.js"" crossorigin=""anonymous""></script>
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7efa64f000493d75e4c699e79c946c24eee993288233", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <link href=\"https://unpkg.com/material-components-web@latest/dist/material-components-web.min.css\" rel=\"stylesheet\">\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7efa64f000493d75e4c699e79c946c24eee993289460", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n    <link href=\"https://unpkg.com/material-components-web@latest/dist/material-components-web.min.css\" rel=\"stylesheet\">\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7efa64f000493d75e4c699e79c946c24eee9932811399", async() => {
                WriteLiteral(@"
    <div class=""layout"">
        <header class=""header"">
            <div class=""search p-10"">
                <svg aria-hidden=""true""
                     focusable=""false""
                     data-prefix=""fab""
                     data-icon=""facebook""
                     role=""img""
                     xmlns=""http://www.w3.org/2000/svg""
                     viewBox=""0 0 512 512""
                     class=""logo-facebook"">
                    <path d=""M504 256C504 119 393 8 256 8S8 119 8 256c0 123.78 90.69 226.38 209.25 245V327.69h-63V256h63v-54.64c0-62.15 37-96.48 93.67-96.48 27.14 0 55.52 4.84 55.52 4.84v61h-31.28c-30.8 0-40.41 19.12-40.41 38.73V256h68.78l-11 71.69h-57.78V501C413.31 482.38 504 379.78 504 256z""");
                BeginWriteAttribute("class", "\r\n                          class=\"", 2137, "\"", 2172, 0);
                EndWriteAttribute();
                WriteLiteral(@"></path>
                </svg>
                <div class=""search__container"">
                    <svg aria-hidden=""true""
                         focusable=""false""
                         data-prefix=""fas""
                         data-icon=""search""
                         role=""img""
                         xmlns=""http://www.w3.org/2000/svg""
                         viewBox=""0 0 512 512""
                         class=""svg-inline--fa fa-search fa-w-16 fa-fw"">
                        <path fill=""currentColor""
                              d=""M505 442.7L405.3 343c-4.5-4.5-10.6-7-17-7H372c27.6-35.3 44-79.7 44-128C416 93.1 322.9 0 208 0S0 93.1 0 208s93.1 208 208 208c48.3 0 92.7-16.4 128-44v16.3c0 6.4 2.5 12.5 7 17l99.7 99.7c9.4 9.4 24.6 9.4 33.9 0l28.3-28.3c9.4-9.4 9.4-24.6.1-34zM208 336c-70.7 0-128-57.2-128-128 0-70.7 57.2-128 128-128 70.7 0 128 57.2 128 128 0 70.7-57.2 128-128 128z""");
                BeginWriteAttribute("class", "\r\n                              class=\"", 3084, "\"", 3123, 0);
                EndWriteAttribute();
                WriteLiteral("></path>\r\n                    </svg>\r\n                    <input class=\"search__input\" id=\"SearchProfile\"\r\n                           placeholder=\" Search Facebook\"\r\n                           type=\"text\" />\r\n");
                WriteLiteral("                    <button id=\"search-button\" type=\"submit\" class=\"btn btn-default\"><span class=\"glyphicon glyphicon-search\" aria-hidden=\"true\"  onclick=\"ProfileSearch()\"></span></button>\r\n");
                WriteLiteral("                </div>\r\n            </div>\r\n            <div class=\"navbar p-10\">\r\n                <ul class=\"icons\">\r\n                    <li class=\"icons__item active\">\r\n                        <img src=\"./images/svg/home.svg\"");
                BeginWriteAttribute("alt", " alt=\"", 3996, "\"", 4002, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    </li>\r\n                    <li class=\"icons__item\">\r\n                        <img src=\"./images/svg/notification.svg\"");
                BeginWriteAttribute("alt", " alt=\"", 4145, "\"", 4151, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    </li>\r\n                    <li class=\"icons__item\">\r\n                        <img src=\"./images/svg/video.svg\"");
                BeginWriteAttribute("alt", " alt=\"", 4287, "\"", 4293, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    </li>\r\n                    <li class=\"icons__item\">\r\n                        <img src=\"https://dummyimage.com/35X35/ddd/ddd.jpg\"\r\n                             class=\"radius blur\"");
                BeginWriteAttribute("alt", "\r\n                             alt=\"", 4497, "\"", 4533, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    </li>\r\n                    <li class=\"icons__item\">\r\n                        <img src=\"./images/svg/store.svg\"");
                BeginWriteAttribute("alt", " alt=\"", 4669, "\"", 4675, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    </li>\r\n                    <li class=\"icons__item\">\r\n                        <img src=\"./images/svg/people.svg\"");
                BeginWriteAttribute("alt", " alt=\"", 4812, "\"", 4818, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    </li>\r\n                    <li class=\"icons__item\">\r\n                        <img src=\"./images/svg/chat.svg\"");
                BeginWriteAttribute("alt", " alt=\"", 4953, "\"", 4959, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    </li>\r\n                </ul>\r\n            </div>\r\n            <div class=\"settings text-right p-10\">\r\n                <img class=\"menu\" src=\"./images/svg/menu.svg\"");
                BeginWriteAttribute("alt", " alt=\"", 5148, "\"", 5154, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                <img class=\"svg-settings\" src=\"./images/svg/settings.svg\"");
                BeginWriteAttribute("alt", " alt=\"", 5233, "\"", 5239, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
            </div>
        </header>
        <sidebar class=""sidebar p-10"">
            <div class=""sidebar__header"">
                <h2>Home</h2>
                <a href=""#"">Create</a>
            </div>
            <div class=""sidebar__content"">
                <div class=""option"">
                    <img src=""https://dummyimage.com/35X35/ddd/ddd.jpg""
                         class=""option__img br-5 blur""
                         alt=""logo"" />
                    <div>Not-So-Secret Family Recipes</div>
                </div>
                <div class=""option"">
                    <img src=""https://dummyimage.com/35X35/ddd/ddd.jpg""
                         class=""option__img br-5 blur""
                         alt=""logo"" />
                    <div>Red Table Talk Group</div>
                </div>
                <div class=""option"">
                    <img src=""https://dummyimage.com/35X35/ddd/ddd.jpg""
                         class=""option__img radius blur""
                 ");
                WriteLiteral(@"        alt=""logo"" />
                    <div>Events</div>
                </div>
                <div class=""option"">
                    <img src=""https://dummyimage.com/35X35/ddd/ddd.jpg""
                         class=""option__img radius blur""
                         alt=""logo"" />
                    <div>Saved</div>
                </div>
                <div class=""option"">
                    <img src=""https://dummyimage.com/35X35/ddd/ddd.jpg""
                         class=""option__img radius blur""
                         alt=""logo"" />
                    <div>Gaming</div>
                </div>
                <div class=""option"">
                    <img src=""https://dummyimage.com/35X35/ddd/ddd.jpg""
                         class=""option__img radius blur""
                         alt=""logo"" />
                    <div>Fundraisers</div>
                </div>
                <div class=""option"">
                    <img src=""https://dummyimage.com/35X35/ddd/ddd.jpg""
       ");
                WriteLiteral(@"                  class=""option__img radius blur""
                         alt=""logo"" />
                    <div>Memories</div>
                </div>
                <div class=""option"">
                    <img src=""https://dummyimage.com/35X35/ddd/ddd.jpg""
                         class=""option__img radius blur""
                         alt=""logo"" />
                    <div>Help & Support</div>
                </div>
                <div class=""option"">
                    <img src=""https://dummyimage.com/35X35/ddd/ddd.jpg""
                         class=""option__img radius blur""
                         alt=""logo"" />
                    <div>Settings & Privacy</div>
                </div>
                <div class=""option"">
                    <img src=""https://dummyimage.com/35X35/ddd/ddd.jpg""
                         class=""option__img radius blur""
                         alt=""logo"" />
                    <div>See More</div>
                </div>
                <div class=""co");
                WriteLiteral(@"l-2"" style=""text-align: center;"">
                    <i class=""fas fa-chevron-down"" data-target=""#LogutPopupMenu"" data-toggle=""modal"" aria-hidden=""true""></i>
                </div>
            </div>
            <div class=""sidebar__footer"">
                Privacy · Terms · Advertising · Adchoices · Cookies · More facebook ©
                2019
            </div>
        </sidebar>
        <main class=""content scroll"">
            <div class=""content__header"">
                <h3>Stories</h3>
                <a href=""#"">See all</a>
            </div>
            <div class=""stories scroll"">
                <div class=""storie"">
                    <div class=""circle"">+</div>
                    <h4 class=""no-margin"">Add to Story</h4>
                </div>
                <div class=""storie"">
                    <img src=""https://dummyimage.com/40X40/ddd/ddd.jpg""
                         class=""radius blur""
                         width=""40px""
                         height=""40px""");
                BeginWriteAttribute("alt", "\r\n                         alt=\"", 9334, "\"", 9366, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                    <h4 class=""no-margin"">Tom Russo</h4>
                </div>
                <div class=""storie"">
                    <img src=""https://dummyimage.com/40X40/ddd/ddd.jpg""
                         class=""radius blur""
                         width=""40px""
                         height=""40px""");
                BeginWriteAttribute("alt", "\r\n                         alt=\"", 9688, "\"", 9720, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                    <h4 class=""no-margin"">Anna Becklund</h4>
                </div>
                <div class=""storie"">
                    <img src=""https://dummyimage.com/40X40/ddd/ddd.jpg""
                         class=""radius blur""
                         width=""40px""
                         height=""40px""");
                BeginWriteAttribute("alt", "\r\n                         alt=\"", 10046, "\"", 10078, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                    <h4 class=""no-margin"">Dennis Han</h4>
                </div>
                <div class=""storie"">
                    <img src=""https://dummyimage.com/40X40/ddd/ddd.jpg""
                         class=""radius blur""
                         width=""40px""
                         height=""40px""");
                BeginWriteAttribute("alt", "\r\n                         alt=\"", 10401, "\"", 10433, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                    <h4 class=""no-margin"">Cynthia Lopez</h4>
                </div>
                <div class=""storie"">
                    <div class=""circle""></div>
                    <h4 class=""no-margin"">Dennis Han</h4>
                </div>
                <div class=""storie"">
                    <div class=""circle""></div>
                    <h4 class=""no-margin"">Cynthia Lopez</h4>
                </div>
            </div>
            <div class=""posts"">
                <div class=""add__post p-10"">
                   
                    <input type=""text"" class=""form-control rounded-pill wrapper"" id=""PostText"" placeholder=""Ne düşünüyorsun?"" aria-describedby=""basic-addon2"">
                    <button type=""button"" data-target=""#postImage"" data-toggle=""modal"" class=""btn btn-primary"" style=""color:gray; width:40%; height:50%"">Add Photo</button>
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7efa64f000493d75e4c699e79c946c24eee9932824082", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                    <button type=""button"" onclick=""Post()"" class=""btn btn-primary"" style=""color:gray; width:40%; height:50%;"">Send</button>
                    <img src=""https://dummyimage.com/40X40/ddd/ddd.jpg""
                         alt=""my-image""
                         class=""radius"" />

                </div>
              
                <div id=""PostPartial"">

                </div>

            </div>
        </main>
        <div class=""contacts p-10"">
            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7efa64f000493d75e4c699e79c946c24eee9932825771", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            <h3>Suggested</h3>\r\n            <div class=\"suggested\">\r\n                <div class=\"group\">\r\n                    <img src=\"https://dummyimage.com/350X200/ddd/ddd.jpg\"\r\n                         class=\"group__image\"");
                BeginWriteAttribute("alt", "\r\n                         alt=\"", 12129, "\"", 12161, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                    <div class=""group__link"">
                        <h4><span>👪</span> Groups</h4>
                        <p>New ways to find and join communities</p>
                        <a class=""group__button"" href=""#"">Find Your Groups</a>
                    </div>
                </div>
                <div class=""group__footer"">
                    <img class=""radius""
                         src=""https://dummyimage.com/20X20/ddd/ddd.jpg""");
                BeginWriteAttribute("alt", "\r\n                         alt=\"", 12630, "\"", 12662, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                    <p class=""group__friends"">Henri and 9 friends joined Groups</p>
                </div>
            </div>
            <div class=""contacts__header"">
                <h3>Contacts</h3>
                <div>...</div>
            </div>
            <div class=""contacts_list"">
                <div class=""contacts_friend"">
                    <img src=""https://dummyimage.com/35x35/ddd/ddd.jpg""
                         alt=""my-image""
                         class=""radius"" />
                    <p>Dennis Han</p>
                </div>
                <div class=""contacts_friend"">
                    <img src=""https://dummyimage.com/35x35/ddd/ddd.jpg""
                         alt=""my-image""
                         class=""radius"" />
                    <p>Dennis Han</p>
                </div>
                <div class=""contacts_friend"">
                    <img src=""https://dummyimage.com/35x35/ddd/ddd.jpg""
                         alt=""my-image""
                     ");
                WriteLiteral(@"    class=""radius"" />
                    <p>Dennis Han</p>
                </div>
                <div class=""contacts_friend"">
                    <img src=""https://dummyimage.com/35x35/ddd/ddd.jpg""
                         alt=""my-image""
                         class=""radius"" />
                    <p>Dennis Han</p>
                </div>
                 <div class=""contacts_friend"">
                  <img
                    src=""https://dummyimage.com/35x35/ddd/ddd.jpg""
                    alt=""my-image""
                    class=""radius""
                  />
                  <p>Dennis Han</p>
                </div>
                <div class=""contacts_friend"">
                  <img
                    src=""https://dummyimage.com/35x35/ddd/ddd.jpg""
                    alt=""my-image""
                    class=""radius""
                  />
                  <p>Dennis Han</p>
                </div> 
            </div>
        </div>
    </div>
    <svg style=""width:0;height:0");
                WriteLiteral(@";position:absolute;""
         aria-hidden=""true""
         focusable=""false"">
        <linearGradient id=""my-cool-gradient"" x2=""1"" y2=""1"">
            <stop offset=""0%"" stop-color=""#4683ee"" />
            <stop offset=""50%"" stop-color=""#0071ff"" />
            <stop offset=""100%"" stop-color=""#00d4ff"" />
        </linearGradient>
    </svg>
    <script src=""./js/main.js""></script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</html>


<div class=""modal"" tabindex=""-1"" id=""LogutPopupMenu"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title""></h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>

            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                <a href=""/Account/SignUp"" role=""button"" class=""btn btn-primary"">log out</a>
");
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n<script src=\"https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js\"></script>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7efa64f000493d75e4c699e79c946c24eee9932832227", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
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
