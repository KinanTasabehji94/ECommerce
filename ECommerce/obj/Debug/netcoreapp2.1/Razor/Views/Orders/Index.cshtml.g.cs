#pragma checksum "E:\Asus\Share\New Ecommerce\ECommerce\ECommerce\Views\Orders\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc9e491a63a2c24d415a32cd05ec9d3aba36bdca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_Index), @"mvc.1.0.view", @"/Views/Orders/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Orders/Index.cshtml", typeof(AspNetCore.Views_Orders_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc9e491a63a2c24d415a32cd05ec9d3aba36bdca", @"/Views/Orders/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec470632cb3b1b75499bc0cdcc8d1831e35eecad", @"/Views/_ViewImports.cshtml")]
    public class Views_Orders_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ECommerce.Models.Order>>
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
            BeginContext(44, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\Asus\Share\New Ecommerce\ECommerce\ECommerce\Views\Orders\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(87, 152, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n\r\n<table class=\"table table-striped table-bordered table-responsive\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(240, 65, false);
#line 14 "E:\Asus\Share\New Ecommerce\ECommerce\ECommerce\Views\Orders\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Service.Sprovider.CompanyName));

#line default
#line hidden
            EndContext();
            BeginContext(305, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(361, 43, false);
#line 17 "E:\Asus\Share\New Ecommerce\ECommerce\ECommerce\Views\Orders\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Service));

#line default
#line hidden
            EndContext();
            BeginContext(404, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(460, 45, false);
#line 20 "E:\Asus\Share\New Ecommerce\ECommerce\ECommerce\Views\Orders\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.OrderDate));

#line default
#line hidden
            EndContext();
            BeginContext(505, 67, true);
            WriteLiteral("\r\n            </th>\r\n            <th width=\"18%\">\r\n                ");
            EndContext();
            BeginContext(573, 42, false);
#line 23 "E:\Asus\Share\New Ecommerce\ECommerce\ECommerce\Views\Orders\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Rating));

#line default
#line hidden
            EndContext();
            BeginContext(615, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(671, 47, false);
#line 26 "E:\Asus\Share\New Ecommerce\ECommerce\ECommerce\Views\Orders\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.OrderStatus));

#line default
#line hidden
            EndContext();
            BeginContext(718, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 32 "E:\Asus\Share\New Ecommerce\ECommerce\ECommerce\Views\Orders\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(853, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(914, 64, false);
#line 36 "E:\Asus\Share\New Ecommerce\ECommerce\ECommerce\Views\Orders\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Service.Sprovider.CompanyName));

#line default
#line hidden
            EndContext();
            BeginContext(978, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1046, 47, false);
#line 39 "E:\Asus\Share\New Ecommerce\ECommerce\ECommerce\Views\Orders\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Service.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1093, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1161, 44, false);
#line 42 "E:\Asus\Share\New Ecommerce\ECommerce\ECommerce\Views\Orders\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.OrderDate));

#line default
#line hidden
            EndContext();
            BeginContext(1205, 107, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <div style=\"margin: auto; width:50%;\">\r\n");
            EndContext();
#line 47 "E:\Asus\Share\New Ecommerce\ECommerce\ECommerce\Views\Orders\Index.cshtml"
                          
                            var counter = 0;
                            for (int i = 0; i < item.Rating; i += 20)
                            {
                                counter++;

#line default
#line hidden
            BeginContext(1581, 106, true);
            WriteLiteral("                                <i class=\"fa fa-star\" style=\"color:goldenrod; align-content:center\"></i>\r\n");
            EndContext();
#line 53 "E:\Asus\Share\New Ecommerce\ECommerce\ECommerce\Views\Orders\Index.cshtml"
                            }
                            for (int i = 0; i < 5 - counter; i++)
                            {

#line default
#line hidden
            BeginContext(1816, 60, true);
            WriteLiteral("                                <i class=\"fa fa-star\"></i>\r\n");
            EndContext();
#line 57 "E:\Asus\Share\New Ecommerce\ECommerce\ECommerce\Views\Orders\Index.cshtml"
                            }
                        

#line default
#line hidden
            BeginContext(1934, 73, true);
            WriteLiteral("                    </div>\r\n                </td>\r\n                <td>\r\n");
            EndContext();
#line 62 "E:\Asus\Share\New Ecommerce\ECommerce\ECommerce\Views\Orders\Index.cshtml"
                     if (item.OrderStatus == "Opened")
                    {

#line default
#line hidden
            BeginContext(2086, 60, true);
            WriteLiteral("                        <p class=\"btn btn-primary disabled\">");
            EndContext();
            BeginContext(2147, 16, false);
#line 64 "E:\Asus\Share\New Ecommerce\ECommerce\ECommerce\Views\Orders\Index.cshtml"
                                                       Write(item.OrderStatus);

#line default
#line hidden
            EndContext();
            BeginContext(2163, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 65 "E:\Asus\Share\New Ecommerce\ECommerce\ECommerce\Views\Orders\Index.cshtml"
                    }
                    else if (item.OrderStatus == "Closed")
                    {

#line default
#line hidden
            BeginContext(2275, 60, true);
            WriteLiteral("                        <p class=\"btn btn-success disabled\">");
            EndContext();
            BeginContext(2336, 16, false);
#line 68 "E:\Asus\Share\New Ecommerce\ECommerce\ECommerce\Views\Orders\Index.cshtml"
                                                       Write(item.OrderStatus);

#line default
#line hidden
            EndContext();
            BeginContext(2352, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 69 "E:\Asus\Share\New Ecommerce\ECommerce\ECommerce\Views\Orders\Index.cshtml"
                    }
                    else if (item.OrderStatus == "Rejected")
                    {

#line default
#line hidden
            BeginContext(2466, 59, true);
            WriteLiteral("                        <p class=\"btn btn-danger disabled\">");
            EndContext();
            BeginContext(2526, 16, false);
#line 72 "E:\Asus\Share\New Ecommerce\ECommerce\ECommerce\Views\Orders\Index.cshtml"
                                                      Write(item.OrderStatus);

#line default
#line hidden
            EndContext();
            BeginContext(2542, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 73 "E:\Asus\Share\New Ecommerce\ECommerce\ECommerce\Views\Orders\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(2571, 65, true);
            WriteLiteral("                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2636, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ea92f3846642439990999ee0cb666664", async() => {
                BeginContext(2684, 7, true);
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
#line 76 "E:\Asus\Share\New Ecommerce\ECommerce\ECommerce\Views\Orders\Index.cshtml"
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
            BeginContext(2695, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 79 "E:\Asus\Share\New Ecommerce\ECommerce\ECommerce\Views\Orders\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(2750, 24, true);
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
