#pragma checksum "E:\Asus\Share\New Ecommerce\ECommerce\ECommerce\Views\Orders\ServiceProviderOrders.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "caea13901029545ec015367fcd69f9fb92bc23e4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_ServiceProviderOrders), @"mvc.1.0.view", @"/Views/Orders/ServiceProviderOrders.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Orders/ServiceProviderOrders.cshtml", typeof(AspNetCore.Views_Orders_ServiceProviderOrders))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"caea13901029545ec015367fcd69f9fb92bc23e4", @"/Views/Orders/ServiceProviderOrders.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec470632cb3b1b75499bc0cdcc8d1831e35eecad", @"/Views/_ViewImports.cshtml")]
    public class Views_Orders_ServiceProviderOrders : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ECommerce.Models.Order>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(44, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\Asus\Share\New Ecommerce\ECommerce\ECommerce\Views\Orders\ServiceProviderOrders.cshtml"
  
    ViewData["Title"] = "ServiceProviderOrders";

#line default
#line hidden
            BeginContext(103, 199, true);
            WriteLiteral("<style>\r\n \r\n</style>\r\n<h2>Comming Orders</h2>\r\n<br />\r\n<table class=\"table table-striped table-bordered table-responsive\">\r\n    <thead class=\"table\">\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(303, 44, false);
#line 15 "E:\Asus\Share\New Ecommerce\ECommerce\ECommerce\Views\Orders\ServiceProviderOrders.cshtml"
           Write(Html.DisplayNameFor(model => model.Customer));

#line default
#line hidden
            EndContext();
            BeginContext(347, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(403, 45, false);
#line 18 "E:\Asus\Share\New Ecommerce\ECommerce\ECommerce\Views\Orders\ServiceProviderOrders.cshtml"
           Write(Html.DisplayNameFor(model => model.OrderDate));

#line default
#line hidden
            EndContext();
            BeginContext(448, 57, true);
            WriteLiteral("\r\n            </th>\r\n\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(506, 46, false);
#line 22 "E:\Asus\Share\New Ecommerce\ECommerce\ECommerce\Views\Orders\ServiceProviderOrders.cshtml"
           Write(Html.DisplayNameFor(model => model.OrderNotes));

#line default
#line hidden
            EndContext();
            BeginContext(552, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(608, 42, false);
#line 25 "E:\Asus\Share\New Ecommerce\ECommerce\ECommerce\Views\Orders\ServiceProviderOrders.cshtml"
           Write(Html.DisplayNameFor(model => model.Rating));

#line default
#line hidden
            EndContext();
            BeginContext(650, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(706, 47, false);
#line 28 "E:\Asus\Share\New Ecommerce\ECommerce\ECommerce\Views\Orders\ServiceProviderOrders.cshtml"
           Write(Html.DisplayNameFor(model => model.RatingNotes));

#line default
#line hidden
            EndContext();
            BeginContext(753, 57, true);
            WriteLiteral("\r\n            </th>\r\n\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(811, 47, false);
#line 32 "E:\Asus\Share\New Ecommerce\ECommerce\ECommerce\Views\Orders\ServiceProviderOrders.cshtml"
           Write(Html.DisplayNameFor(model => model.OrderStatus));

#line default
#line hidden
            EndContext();
            BeginContext(858, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 38 "E:\Asus\Share\New Ecommerce\ECommerce\ECommerce\Views\Orders\ServiceProviderOrders.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(993, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1042, 52, false);
#line 42 "E:\Asus\Share\New Ecommerce\ECommerce\ECommerce\Views\Orders\ServiceProviderOrders.cshtml"
           Write(Html.DisplayFor(modelItem => item.Customer.FullName));

#line default
#line hidden
            EndContext();
            BeginContext(1094, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1150, 44, false);
#line 45 "E:\Asus\Share\New Ecommerce\ECommerce\ECommerce\Views\Orders\ServiceProviderOrders.cshtml"
           Write(Html.DisplayFor(modelItem => item.OrderDate));

#line default
#line hidden
            EndContext();
            BeginContext(1194, 57, true);
            WriteLiteral("\r\n            </td>\r\n\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1252, 45, false);
#line 49 "E:\Asus\Share\New Ecommerce\ECommerce\ECommerce\Views\Orders\ServiceProviderOrders.cshtml"
           Write(Html.DisplayFor(modelItem => item.OrderNotes));

#line default
#line hidden
            EndContext();
            BeginContext(1297, 95, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <div style=\"margin: auto; width:50%;\">\r\n");
            EndContext();
#line 54 "E:\Asus\Share\New Ecommerce\ECommerce\ECommerce\Views\Orders\ServiceProviderOrders.cshtml"
                      
                        var counter = 0;
                        for (int i = 0; i < item.Rating; i += 20)
                        {
                            counter++;

#line default
#line hidden
            BeginContext(1637, 102, true);
            WriteLiteral("                            <i class=\"fa fa-star\" style=\"color:goldenrod; align-content:center\"></i>\r\n");
            EndContext();
#line 60 "E:\Asus\Share\New Ecommerce\ECommerce\ECommerce\Views\Orders\ServiceProviderOrders.cshtml"
                        }
                        for (int i = 0; i < 5 - counter; i++)
                        {

#line default
#line hidden
            BeginContext(1856, 56, true);
            WriteLiteral("                            <i class=\"fa fa-star\"></i>\r\n");
            EndContext();
#line 64 "E:\Asus\Share\New Ecommerce\ECommerce\ECommerce\Views\Orders\ServiceProviderOrders.cshtml"
                        }
                    

#line default
#line hidden
            BeginContext(1962, 77, true);
            WriteLiteral("                </div>\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2040, 46, false);
#line 69 "E:\Asus\Share\New Ecommerce\ECommerce\ECommerce\Views\Orders\ServiceProviderOrders.cshtml"
           Write(Html.DisplayFor(modelItem => item.RatingNotes));

#line default
#line hidden
            EndContext();
            BeginContext(2086, 41, true);
            WriteLiteral("\r\n            </td>\r\n\r\n            <td>\r\n");
            EndContext();
#line 73 "E:\Asus\Share\New Ecommerce\ECommerce\ECommerce\Views\Orders\ServiceProviderOrders.cshtml"
                 if (item.OrderStatus == "Opened")
                {

#line default
#line hidden
            BeginContext(2198, 56, true);
            WriteLiteral("                    <p class=\"btn btn-primary disabled\">");
            EndContext();
            BeginContext(2255, 16, false);
#line 75 "E:\Asus\Share\New Ecommerce\ECommerce\ECommerce\Views\Orders\ServiceProviderOrders.cshtml"
                                                   Write(item.OrderStatus);

#line default
#line hidden
            EndContext();
            BeginContext(2271, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 76 "E:\Asus\Share\New Ecommerce\ECommerce\ECommerce\Views\Orders\ServiceProviderOrders.cshtml"
                }
                else if (item.OrderStatus == "Closed")
                {

#line default
#line hidden
            BeginContext(2371, 56, true);
            WriteLiteral("                    <p class=\"btn btn-success disabled\">");
            EndContext();
            BeginContext(2428, 16, false);
#line 79 "E:\Asus\Share\New Ecommerce\ECommerce\ECommerce\Views\Orders\ServiceProviderOrders.cshtml"
                                                   Write(item.OrderStatus);

#line default
#line hidden
            EndContext();
            BeginContext(2444, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 80 "E:\Asus\Share\New Ecommerce\ECommerce\ECommerce\Views\Orders\ServiceProviderOrders.cshtml"
                }
                else if (item.OrderStatus == "Rejected")
                {

#line default
#line hidden
            BeginContext(2546, 55, true);
            WriteLiteral("                    <p class=\"btn btn-danger disabled\">");
            EndContext();
            BeginContext(2602, 16, false);
#line 83 "E:\Asus\Share\New Ecommerce\ECommerce\ECommerce\Views\Orders\ServiceProviderOrders.cshtml"
                                                  Write(item.OrderStatus);

#line default
#line hidden
            EndContext();
            BeginContext(2618, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 84 "E:\Asus\Share\New Ecommerce\ECommerce\ECommerce\Views\Orders\ServiceProviderOrders.cshtml"
                }

#line default
#line hidden
            BeginContext(2643, 37, true);
            WriteLiteral("            </td>\r\n            <td>\r\n");
            EndContext();
#line 87 "E:\Asus\Share\New Ecommerce\ECommerce\ECommerce\Views\Orders\ServiceProviderOrders.cshtml"
                 if (item.OrderStatus != "Closed")
                {

#line default
#line hidden
            BeginContext(2751, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(2771, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8ca46fe189c84466872bd3e8eedcb2ef", async() => {
                BeginContext(2816, 4, true);
                WriteLiteral("Edit");
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
#line 89 "E:\Asus\Share\New Ecommerce\ECommerce\ECommerce\Views\Orders\ServiceProviderOrders.cshtml"
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
            BeginContext(2824, 18, true);
            WriteLiteral("<span> | </span>\r\n");
            EndContext();
#line 90 "E:\Asus\Share\New Ecommerce\ECommerce\ECommerce\Views\Orders\ServiceProviderOrders.cshtml"
                }

#line default
#line hidden
            BeginContext(2861, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(2879, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1c96dca10ca64a459d16e5597ab1c9ff", async() => {
                BeginContext(2927, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 92 "E:\Asus\Share\New Ecommerce\ECommerce\ECommerce\Views\Orders\ServiceProviderOrders.cshtml"
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
            BeginContext(2938, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 95 "E:\Asus\Share\New Ecommerce\ECommerce\ECommerce\Views\Orders\ServiceProviderOrders.cshtml"
        }

#line default
#line hidden
            BeginContext(2985, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ECommerce.Models.Order>> Html { get; private set; }
    }
}
#pragma warning restore 1591
