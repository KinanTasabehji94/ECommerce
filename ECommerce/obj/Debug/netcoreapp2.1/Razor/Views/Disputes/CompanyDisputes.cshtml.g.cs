#pragma checksum "E:\Asus\Share\New Ecommerce\ECommerce\ECommerce\Views\Disputes\CompanyDisputes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf5646c1bf1166e18cdf7169b9afc3494dc1ef59"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Disputes_CompanyDisputes), @"mvc.1.0.view", @"/Views/Disputes/CompanyDisputes.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Disputes/CompanyDisputes.cshtml", typeof(AspNetCore.Views_Disputes_CompanyDisputes))]
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
#line 1 "E:\Asus\Share\New Ecommerce\ECommerce\ECommerce\Views\_ViewImports.cshtml"
using ECommerce;

#line default
#line hidden
#line 2 "E:\Asus\Share\New Ecommerce\ECommerce\ECommerce\Views\_ViewImports.cshtml"
using ECommerce.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf5646c1bf1166e18cdf7169b9afc3494dc1ef59", @"/Views/Disputes/CompanyDisputes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec470632cb3b1b75499bc0cdcc8d1831e35eecad", @"/Views/_ViewImports.cshtml")]
    public class Views_Disputes_CompanyDisputes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ECommerce.Models.Dispute>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(46, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\Asus\Share\New Ecommerce\ECommerce\ECommerce\Views\Disputes\CompanyDisputes.cshtml"
  
    ViewData["Title"] = "CompanyDisputes";

#line default
#line hidden
            BeginContext(99, 232, true);
            WriteLiteral("\r\n<h2>Company Disputes</h2>\r\n\r\n<br />\r\n<table class=\"table table-striped table-bordered table-responsive\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                Order Id\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(332, 46, false);
#line 17 "E:\Asus\Share\New Ecommerce\ECommerce\ECommerce\Views\Disputes\CompanyDisputes.cshtml"
           Write(Html.DisplayNameFor(model => model.OpenedDate));

#line default
#line hidden
            EndContext();
            BeginContext(378, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(434, 45, false);
#line 20 "E:\Asus\Share\New Ecommerce\ECommerce\ECommerce\Views\Disputes\CompanyDisputes.cshtml"
           Write(Html.DisplayNameFor(model => model.Complaint));

#line default
#line hidden
            EndContext();
            BeginContext(479, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(535, 43, false);
#line 23 "E:\Asus\Share\New Ecommerce\ECommerce\ECommerce\Views\Disputes\CompanyDisputes.cshtml"
           Write(Html.DisplayNameFor(model => model.Arbiter));

#line default
#line hidden
            EndContext();
            BeginContext(578, 123, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                Customer Name\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(702, 42, false);
#line 29 "E:\Asus\Share\New Ecommerce\ECommerce\ECommerce\Views\Disputes\CompanyDisputes.cshtml"
           Write(Html.DisplayNameFor(model => model.Result));

#line default
#line hidden
            EndContext();
            BeginContext(744, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(800, 42, false);
#line 32 "E:\Asus\Share\New Ecommerce\ECommerce\ECommerce\Views\Disputes\CompanyDisputes.cshtml"
           Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(842, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 38 "E:\Asus\Share\New Ecommerce\ECommerce\ECommerce\Views\Disputes\CompanyDisputes.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(977, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1038, 43, false);
#line 42 "E:\Asus\Share\New Ecommerce\ECommerce\ECommerce\Views\Disputes\CompanyDisputes.cshtml"
               Write(Html.DisplayFor(modelItem => item.Order.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1081, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1149, 45, false);
#line 45 "E:\Asus\Share\New Ecommerce\ECommerce\ECommerce\Views\Disputes\CompanyDisputes.cshtml"
               Write(Html.DisplayFor(modelItem => item.OpenedDate));

#line default
#line hidden
            EndContext();
            BeginContext(1194, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1262, 44, false);
#line 48 "E:\Asus\Share\New Ecommerce\ECommerce\ECommerce\Views\Disputes\CompanyDisputes.cshtml"
               Write(Html.DisplayFor(modelItem => item.Complaint));

#line default
#line hidden
            EndContext();
            BeginContext(1306, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1374, 51, false);
#line 51 "E:\Asus\Share\New Ecommerce\ECommerce\ECommerce\Views\Disputes\CompanyDisputes.cshtml"
               Write(Html.DisplayFor(modelItem => item.Arbiter.FullName));

#line default
#line hidden
            EndContext();
            BeginContext(1425, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1493, 58, false);
#line 54 "E:\Asus\Share\New Ecommerce\ECommerce\ECommerce\Views\Disputes\CompanyDisputes.cshtml"
               Write(Html.DisplayFor(modelItem => item.Order.Customer.FullName));

#line default
#line hidden
            EndContext();
            BeginContext(1551, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1619, 41, false);
#line 57 "E:\Asus\Share\New Ecommerce\ECommerce\ECommerce\Views\Disputes\CompanyDisputes.cshtml"
               Write(Html.DisplayFor(modelItem => item.Result));

#line default
#line hidden
            EndContext();
            BeginContext(1660, 47, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
            EndContext();
#line 60 "E:\Asus\Share\New Ecommerce\ECommerce\ECommerce\Views\Disputes\CompanyDisputes.cshtml"
                     if (item.Status == "Opened")
                    {

#line default
#line hidden
            BeginContext(1781, 60, true);
            WriteLiteral("                        <p class=\"btn btn-primary disabled\">");
            EndContext();
            BeginContext(1842, 11, false);
#line 62 "E:\Asus\Share\New Ecommerce\ECommerce\ECommerce\Views\Disputes\CompanyDisputes.cshtml"
                                                       Write(item.Status);

#line default
#line hidden
            EndContext();
            BeginContext(1853, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 63 "E:\Asus\Share\New Ecommerce\ECommerce\ECommerce\Views\Disputes\CompanyDisputes.cshtml"
                    }
                    else if (item.Status == "Closed")
                    {

#line default
#line hidden
            BeginContext(1960, 60, true);
            WriteLiteral("                        <p class=\"btn btn-success disabled\">");
            EndContext();
            BeginContext(2021, 11, false);
#line 66 "E:\Asus\Share\New Ecommerce\ECommerce\ECommerce\Views\Disputes\CompanyDisputes.cshtml"
                                                       Write(item.Status);

#line default
#line hidden
            EndContext();
            BeginContext(2032, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 67 "E:\Asus\Share\New Ecommerce\ECommerce\ECommerce\Views\Disputes\CompanyDisputes.cshtml"
                    }
                    else if (item.Status == "OnProgress")
                    {

#line default
#line hidden
            BeginContext(2143, 60, true);
            WriteLiteral("                        <p class=\"btn btn-warning disabled\">");
            EndContext();
            BeginContext(2204, 11, false);
#line 70 "E:\Asus\Share\New Ecommerce\ECommerce\ECommerce\Views\Disputes\CompanyDisputes.cshtml"
                                                       Write(item.Status);

#line default
#line hidden
            EndContext();
            BeginContext(2215, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 71 "E:\Asus\Share\New Ecommerce\ECommerce\ECommerce\Views\Disputes\CompanyDisputes.cshtml"
                    }

#line default
#line hidden
            BeginContext(2244, 45, true);
            WriteLiteral("                </td>\r\n                <td>\r\n");
            EndContext();
            BeginContext(2370, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(2390, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "66c821d738c8497f96189a3f0f2e2d9d", async() => {
                BeginContext(2438, 7, true);
                WriteLiteral("Details");
                EndContext();
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
#line 75 "E:\Asus\Share\New Ecommerce\ECommerce\ECommerce\Views\Disputes\CompanyDisputes.cshtml"
                                              WriteLiteral(item.Id);

#line default
#line hidden
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
            EndContext();
            BeginContext(2449, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(2534, 42, true);
            WriteLiteral("                </td>\r\n            </tr>\r\n");
            EndContext();
#line 79 "E:\Asus\Share\New Ecommerce\ECommerce\ECommerce\Views\Disputes\CompanyDisputes.cshtml"
        }

#line default
#line hidden
            BeginContext(2587, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ECommerce.Models.Dispute>> Html { get; private set; }
    }
}
#pragma warning restore 1591
