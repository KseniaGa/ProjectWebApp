#pragma checksum "C:\Users\User\source\repos\ProjectWebApp\ProjectWebApp\Views\Logistics\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "79f7b035815d54cf08453b78c74d86dad9fabe94"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Logistics_Index), @"mvc.1.0.view", @"/Views/Logistics/Index.cshtml")]
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
#line 1 "C:\Users\User\source\repos\ProjectWebApp\ProjectWebApp\Views\_ViewImports.cshtml"
using ProjectWebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\User\source\repos\ProjectWebApp\ProjectWebApp\Views\Logistics\Index.cshtml"
using ProjectWebApp.Models.Logistics;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\source\repos\ProjectWebApp\ProjectWebApp\Views\Logistics\Index.cshtml"
using ProjectWebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79f7b035815d54cf08453b78c74d86dad9fabe94", @"/Views/Logistics/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"771972434ccc2479eca7aebeef0a6a25a5d7fa00", @"/Views/_ViewImports.cshtml")]
    public class Views_Logistics_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LogisticsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\User\source\repos\ProjectWebApp\ProjectWebApp\Views\Logistics\Index.cshtml"
  
	ViewData["Title"] = "Index";
	Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 style=\"text-align:center;\"> PROFITS:  ");
#nullable restore
#line 9 "C:\Users\User\source\repos\ProjectWebApp\ProjectWebApp\Views\Logistics\Index.cshtml"
                                     Write(Html.DisplayFor(modelItem => Model.sumProfits));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h1>\r\n<h1 style=\"text-align:center;\"> EXPENSES:  ");
#nullable restore
#line 10 "C:\Users\User\source\repos\ProjectWebApp\ProjectWebApp\Views\Logistics\Index.cshtml"
                                      Write(Html.DisplayFor(modelItem => Model.sumExenses));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h1>\r\n<h1 style=\"text-align:center;\"> BUDGET:  ");
#nullable restore
#line 11 "C:\Users\User\source\repos\ProjectWebApp\ProjectWebApp\Views\Logistics\Index.cshtml"
                                    Write(Html.DisplayFor(modelItem => Model.budget));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </h1>

<table class=""table"">
	<thead>
		<tr>
			<th>
				Item
			</th>
			<th>
				Quantity
			</th>
			<th>
				Price Per Item
			</th>
			<th>
				Purpose
			</th>
			<th>
				Unit
			</th>
			<th>
				Project
			</th>
			<th>
				Overall Price
			</th>

			<th></th>
		</tr>
	</thead>
	<tbody>
");
#nullable restore
#line 42 "C:\Users\User\source\repos\ProjectWebApp\ProjectWebApp\Views\Logistics\Index.cshtml"
         foreach (var item in Model.Expenses)
		{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<tr>\r\n\t\t\t\t<td>\r\n\t\t\t\t\t");
#nullable restore
#line 46 "C:\Users\User\source\repos\ProjectWebApp\ProjectWebApp\Views\Logistics\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Item));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</td>\r\n\t\t\t\t<td>\r\n\t\t\t\t\t");
#nullable restore
#line 49 "C:\Users\User\source\repos\ProjectWebApp\ProjectWebApp\Views\Logistics\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</td>\r\n\t\t\t\t<td>\r\n\t\t\t\t\t");
#nullable restore
#line 52 "C:\Users\User\source\repos\ProjectWebApp\ProjectWebApp\Views\Logistics\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.PricePerItem));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</td>\r\n\t\t\t\t<td>\r\n\t\t\t\t\t");
#nullable restore
#line 55 "C:\Users\User\source\repos\ProjectWebApp\ProjectWebApp\Views\Logistics\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Purpose));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</td>\r\n\t\t\t\t<td>\r\n\t\t\t\t\t");
#nullable restore
#line 58 "C:\Users\User\source\repos\ProjectWebApp\ProjectWebApp\Views\Logistics\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Unit));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</td>\r\n\t\t\t\t<td>\r\n\t\t\t\t\t");
#nullable restore
#line 61 "C:\Users\User\source\repos\ProjectWebApp\ProjectWebApp\Views\Logistics\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Project.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</td>\r\n\r\n\t\t\t\t<td>\r\n\t\t\t\t\t");
#nullable restore
#line 65 "C:\Users\User\source\repos\ProjectWebApp\ProjectWebApp\Views\Logistics\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.OverallPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</td>\r\n\r\n\t\t\t</tr>\r\n");
#nullable restore
#line 69 "C:\Users\User\source\repos\ProjectWebApp\ProjectWebApp\Views\Logistics\Index.cshtml"
		}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t</tbody>\r\n</table>\r\n\r\n\r\n\r\n\r\n<table class=\"table\">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t<th>\r\n\t\t\t\tResource\r\n\t\t\t</th>\r\n\t\t\t<th>\r\n\t\t\t\tAmount\r\n\t\t\t</th>\r\n\t\t\t<th>\r\n\t\t\t\tProject\r\n\t\t\t</th>\r\n\t\t\t<th></th>\r\n\t\t</tr>\r\n\t</thead>\r\n\t<tbody>\r\n");
#nullable restore
#line 92 "C:\Users\User\source\repos\ProjectWebApp\ProjectWebApp\Views\Logistics\Index.cshtml"
         foreach (var item in Model.Profits)
		{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<tr>\r\n\t\t\t\t<td>\r\n\t\t\t\t\t");
#nullable restore
#line 96 "C:\Users\User\source\repos\ProjectWebApp\ProjectWebApp\Views\Logistics\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Resource));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</td>\r\n\t\t\t\t<td>\r\n\t\t\t\t\t");
#nullable restore
#line 99 "C:\Users\User\source\repos\ProjectWebApp\ProjectWebApp\Views\Logistics\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Amount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</td>\r\n\t\t\t\t<td>\r\n\t\t\t\t\t");
#nullable restore
#line 102 "C:\Users\User\source\repos\ProjectWebApp\ProjectWebApp\Views\Logistics\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Project.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</td>\r\n\r\n\t\t\t</tr>\r\n");
#nullable restore
#line 106 "C:\Users\User\source\repos\ProjectWebApp\ProjectWebApp\Views\Logistics\Index.cshtml"
		}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t</tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LogisticsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
