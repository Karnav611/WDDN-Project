#pragma checksum "D:\WDDN\Project\OnlineMovieBuyingRentingSystem\OnlineMovieBuyingRentingSystem\Views\Home\WebshowPurchasePage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "90473e31539c55227b036c6b4e1e24951dc7f28e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_WebshowPurchasePage), @"mvc.1.0.view", @"/Views/Home/WebshowPurchasePage.cshtml")]
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
#line 1 "D:\WDDN\Project\OnlineMovieBuyingRentingSystem\OnlineMovieBuyingRentingSystem\Views\_ViewImports.cshtml"
using OnlineMovieBuyingRentingSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\WDDN\Project\OnlineMovieBuyingRentingSystem\OnlineMovieBuyingRentingSystem\Views\_ViewImports.cshtml"
using OnlineMovieBuyingRentingSystem.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90473e31539c55227b036c6b4e1e24951dc7f28e", @"/Views/Home/WebshowPurchasePage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bec8d2f216e428e28c557469747994b097c4883e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_WebshowPurchasePage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OnlineMovieBuyingRentingSystem.Models.WebSeries>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "WebshowDownload", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\WDDN\Project\OnlineMovieBuyingRentingSystem\OnlineMovieBuyingRentingSystem\Views\Home\WebshowPurchasePage.cshtml"
  
    ViewData["Title"] = "Buy";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h2>Purchase</h2>\r\n<br>\r\n<br>\r\n\r\n<div style=\"width:700px\">\r\n    <h3> Amount: ₹ ");
#nullable restore
#line 12 "D:\WDDN\Project\OnlineMovieBuyingRentingSystem\OnlineMovieBuyingRentingSystem\Views\Home\WebshowPurchasePage.cshtml"
              Write(Model.PurchasePrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </h3> <br>
    <div class=""form-group row"">
        <label for=""cardnumber"" class=""col-sm-2 col-form-label"">Enter Card number</label>
        <div class=""col-sm-10"">
            <input type=""text"" class=""form-control"" id=""cardnumbedr"" placeholder=""Card Number"" required>
        </div>
    </div>
    <div class=""form-group row"">
        <label for=""inputPassword3"" class=""col-sm-2 col-form-label"">Password</label>
        <div class=""col-sm-10"">
            <input type=""password"" class=""form-control"" id=""inputPassword3"" placeholder=""Password"" required>
        </div>
    </div>
    <br>
    <div class=""form-group row"">
        <label for=""cvv"" class=""col-sm-2 col-form-label"">CVV</label>
        <div class=""col-sm-10"">
            <input type=""password"" class=""form-control"" id=""cvv"" placeholder=""CVV"" required>
        </div>
    </div>
    <br><br>
    <div class=""form-group row"" style=""margin-left: 3rem"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "90473e31539c55227b036c6b4e1e24951dc7f28e5191", async() => {
                WriteLiteral("<input type=\"button\" class=\"btn btn-primary\" value=\"Confirm\" />");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 34 "D:\WDDN\Project\OnlineMovieBuyingRentingSystem\OnlineMovieBuyingRentingSystem\Views\Home\WebshowPurchasePage.cshtml"
                                          WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OnlineMovieBuyingRentingSystem.Models.WebSeries> Html { get; private set; }
    }
}
#pragma warning restore 1591
