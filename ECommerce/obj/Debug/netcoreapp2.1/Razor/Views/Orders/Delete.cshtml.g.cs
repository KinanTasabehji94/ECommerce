#pragma checksum "E:\Asus\Share\New Ecommerce\ECommerce\ECommerce\Views\Orders\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "55b2a025ca78d8ffbe7b9a3d644ea2f097521bcb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_Delete), @"mvc.1.0.view", @"/Views/Orders/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Orders/Delete.cshtml", typeof(AspNetCore.Views_Orders_Delete))]
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
#line 1 "E:\Asus\Share\New Ecommerce\ECommerce\ECommerce\Views\Orders\Delete.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55b2a025ca78d8ffbe7b9a3d644ea2f097521bcb", @"/Views/Orders/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec470632cb3b1b75499bc0cdcc8d1831e35eecad", @"/Views/_ViewImports.cshtml")]
    public class Views_Orders_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ECommerce.Models.Order>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:160px; height:160px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-thumbnail"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CustomerOrders", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(136, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "E:\Asus\Share\New Ecommerce\ECommerce\ECommerce\Views\Orders\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(180, 110, true);
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Order</h4>\r\n    <br />\r\n\r\n");
            EndContext();
            BeginContext(305, 663, true);
            WriteLiteral(@"    <table class=""table table-bordered table-striped table-responsive"">
        <thead>
            <tr>
                <th colspan=""4"">
                    Order
                </th>
            </tr>
        </thead>
        <thead>
            <tr>
                <th>
                    Id
                </th>
                <th>
                    Date
                </th>
                <th>
                    Notes
                </th>
                <th>
                    Status
                </th>
            </tr>
        </thead>
        <tbody>
            <tr>
                <td>
                    ");
            EndContext();
            BeginContext(969, 8, false);
#line 44 "E:\Asus\Share\New Ecommerce\ECommerce\ECommerce\Views\Orders\Delete.cshtml"
               Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(977, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1045, 15, false);
#line 47 "E:\Asus\Share\New Ecommerce\ECommerce\ECommerce\Views\Orders\Delete.cshtml"
               Write(Model.OrderDate);

#line default
#line hidden
            EndContext();
            BeginContext(1060, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1128, 16, false);
#line 50 "E:\Asus\Share\New Ecommerce\ECommerce\ECommerce\Views\Orders\Delete.cshtml"
               Write(Model.OrderNotes);

#line default
#line hidden
            EndContext();
            BeginContext(1144, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1212, 17, false);
#line 53 "E:\Asus\Share\New Ecommerce\ECommerce\ECommerce\Views\Orders\Delete.cshtml"
               Write(Model.OrderStatus);

#line default
#line hidden
            EndContext();
            BeginContext(1229, 104, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n        </tbody>\r\n    </table>\r\n\r\n    <br />\r\n    <br />\r\n\r\n");
            EndContext();
            BeginContext(1359, 180, true);
            WriteLiteral("    <table class=\"table table-bordered table-striped table-responsive\">\r\n        <thead>\r\n            <tr>\r\n                <th colspan=\"5\">\r\n                    Service Provider: ");
            EndContext();
            BeginContext(1540, 35, false);
#line 67 "E:\Asus\Share\New Ecommerce\ECommerce\ECommerce\Views\Orders\Delete.cshtml"
                                 Write(Model.Service.Sprovider.CompanyName);

#line default
#line hidden
            EndContext();
            BeginContext(1575, 579, true);
            WriteLiteral(@"
                </th>
            </tr>
        </thead>
        <thead>
            <tr>
                <th>
                    Name
                </th>
                <th>
                    Phone Number
                </th>
                <th>
                    Email
                </th>
                <th>
                    Address
                </th>
                <th>
                    Image
                </th>
            </tr>
        </thead>
        <tbody>
            <tr>
                <td>
                    ");
            EndContext();
            BeginContext(2155, 37, false);
#line 93 "E:\Asus\Share\New Ecommerce\ECommerce\ECommerce\Views\Orders\Delete.cshtml"
               Write(Model.Service.Sprovider.User.FullName);

#line default
#line hidden
            EndContext();
            BeginContext(2192, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2260, 40, false);
#line 96 "E:\Asus\Share\New Ecommerce\ECommerce\ECommerce\Views\Orders\Delete.cshtml"
               Write(Model.Service.Sprovider.User.PhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(2300, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2368, 34, false);
#line 99 "E:\Asus\Share\New Ecommerce\ECommerce\ECommerce\Views\Orders\Delete.cshtml"
               Write(Model.Service.Sprovider.User.Email);

#line default
#line hidden
            EndContext();
            BeginContext(2402, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2470, 36, false);
#line 102 "E:\Asus\Share\New Ecommerce\ECommerce\ECommerce\Views\Orders\Delete.cshtml"
               Write(Model.Service.Sprovider.User.Address);

#line default
#line hidden
            EndContext();
            BeginContext(2506, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2573, 164, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "08126686e91840a0a5322febd214c417", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2583, "~/uploads/sprovider/", 2583, 20, true);
#line 105 "E:\Asus\Share\New Ecommerce\ECommerce\ECommerce\Views\Orders\Delete.cshtml"
AddHtmlAttributeValue("", 2603, Model.Service.Sprovider.Image, 2603, 30, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 105 "E:\Asus\Share\New Ecommerce\ECommerce\ECommerce\Views\Orders\Delete.cshtml"
AddHtmlAttributeValue("", 2640, Model.Service.Sprovider.CompanyName, 2640, 36, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2737, 104, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n        </tbody>\r\n    </table>\r\n\r\n    <br />\r\n    <br />\r\n\r\n");
            EndContext();
            BeginContext(2858, 681, true);
            WriteLiteral(@"    <table class=""table table-bordered table-striped table-responsive"">
        <thead>
            <tr>
                <th colspan=""4"">
                    Service
                </th>
            </tr>
        </thead>
        <thead>
            <tr>
                <th>
                    Name
                </th>
                <th>
                    Phone Number
                </th>
                <th>
                    ExpectedTime
                </th>
                <th>
                    Image
                </th>
            </tr>
        </thead>
        <tbody>
            <tr>
                <td>
                    ");
            EndContext();
            BeginContext(3540, 18, false);
#line 142 "E:\Asus\Share\New Ecommerce\ECommerce\ECommerce\Views\Orders\Delete.cshtml"
               Write(Model.Service.Name);

#line default
#line hidden
            EndContext();
            BeginContext(3558, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(3626, 25, false);
#line 145 "E:\Asus\Share\New Ecommerce\ECommerce\ECommerce\Views\Orders\Delete.cshtml"
               Write(Model.Service.Description);

#line default
#line hidden
            EndContext();
            BeginContext(3651, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(3719, 26, false);
#line 148 "E:\Asus\Share\New Ecommerce\ECommerce\ECommerce\Views\Orders\Delete.cshtml"
               Write(Model.Service.ExpectedTime);

#line default
#line hidden
            EndContext();
            BeginContext(3745, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(3812, 135, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "bd0319fadb7b487b8ab358d206041433", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3822, "~/uploads/service/", 3822, 18, true);
#line 151 "E:\Asus\Share\New Ecommerce\ECommerce\ECommerce\Views\Orders\Delete.cshtml"
AddHtmlAttributeValue("", 3840, Model.Service.Image, 3840, 20, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 151 "E:\Asus\Share\New Ecommerce\ECommerce\ECommerce\Views\Orders\Delete.cshtml"
AddHtmlAttributeValue("", 3867, Model.Service.Name, 3867, 19, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3947, 104, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n        </tbody>\r\n    </table>\r\n\r\n    <br />\r\n    <br />\r\n\r\n");
            EndContext();
            BeginContext(4069, 677, true);
            WriteLiteral(@"    <table class=""table table-bordered table-striped table-responsive"">
        <thead>
            <tr>
                <th colspan=""4"">
                    Customer
                </th>
            </tr>
        </thead>
        <thead>
            <tr>
                <th>
                    Name
                </th>
                <th>
                    Phone Number
                </th>
                <th>
                    Email
                </th>
                <th>
                    Address
                </th>
            </tr>
        </thead>
        <tbody>
            <tr>
                <td>
                    ");
            EndContext();
            BeginContext(4747, 23, false);
#line 188 "E:\Asus\Share\New Ecommerce\ECommerce\ECommerce\Views\Orders\Delete.cshtml"
               Write(Model.Customer.FullName);

#line default
#line hidden
            EndContext();
            BeginContext(4770, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(4838, 26, false);
#line 191 "E:\Asus\Share\New Ecommerce\ECommerce\ECommerce\Views\Orders\Delete.cshtml"
               Write(Model.Customer.PhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(4864, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(4932, 20, false);
#line 194 "E:\Asus\Share\New Ecommerce\ECommerce\ECommerce\Views\Orders\Delete.cshtml"
               Write(Model.Customer.Email);

#line default
#line hidden
            EndContext();
            BeginContext(4952, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(5020, 22, false);
#line 197 "E:\Asus\Share\New Ecommerce\ECommerce\ECommerce\Views\Orders\Delete.cshtml"
               Write(Model.Customer.Address);

#line default
#line hidden
            EndContext();
            BeginContext(5042, 84, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n        </tbody>\r\n    </table>\r\n\r\n\r\n    ");
            EndContext();
            BeginContext(5126, 267, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c170946e8b3467ebd87ac24b0dbc492", async() => {
                BeginContext(5152, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(5162, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4568a809ff9443f3aaa858c59234f82f", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#line 205 "E:\Asus\Share\New Ecommerce\ECommerce\ECommerce\Views\Orders\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5198, 83, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                EndContext();
                BeginContext(5281, 99, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "359bdb27c481477cbe3ad7b4c86e1b41", async() => {
                    BeginContext(5364, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-customerId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 207 "E:\Asus\Share\New Ecommerce\ECommerce\ECommerce\Views\Orders\Delete.cshtml"
                                                 WriteLiteral(UserManager.GetUserId(User));

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["customerId"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-customerId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["customerId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5380, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5393, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<ECommerce.Models.ApplicationUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ECommerce.Models.Order> Html { get; private set; }
    }
}
#pragma warning restore 1591
