#pragma checksum "D:\Code Academy\Teaching\Groupes\P222\Lessons\75.23.12.2021\Codes\azen\azen\Views\Shop\Cart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e93c890380fa83b86dd0cfd457bb46c3b59b00c6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shop_Cart), @"mvc.1.0.view", @"/Views/Shop/Cart.cshtml")]
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
#line 1 "D:\Code Academy\Teaching\Groupes\P222\Lessons\75.23.12.2021\Codes\azen\azen\Views\_ViewImports.cshtml"
using azen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Code Academy\Teaching\Groupes\P222\Lessons\75.23.12.2021\Codes\azen\azen\Views\_ViewImports.cshtml"
using azen.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Code Academy\Teaching\Groupes\P222\Lessons\75.23.12.2021\Codes\azen\azen\Views\_ViewImports.cshtml"
using azen.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Code Academy\Teaching\Groupes\P222\Lessons\75.23.12.2021\Codes\azen\azen\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Code Academy\Teaching\Groupes\P222\Lessons\75.23.12.2021\Codes\azen\azen\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Code Academy\Teaching\Groupes\P222\Lessons\75.23.12.2021\Codes\azen\azen\Views\_ViewImports.cshtml"
using azen.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e93c890380fa83b86dd0cfd457bb46c3b59b00c6", @"/Views/Shop/Cart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce09aa79235bba9d3756fe18caadde6fc53ebdab", @"/Views/_ViewImports.cshtml")]
    public class Views_Shop_Cart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ColorToSizeToProduct>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("attachment-woocommerce_thumbnail size-woocommerce_thumbnail"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("woocommerce-cart-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "shop", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "checkout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("checkout-button button alt wc-forward"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""site page-content"">

    <div class=""breadcrumb-contact-us breadcrumb-section section-box"">
        <div class=""container breadcrumb-inner"">
            <div class=""breadcrumbs-wrapper"">
                <ul class=""phys-breadcrumb"">
                    <li><a href=""index.html"" class=""home"">Home</a></li>
                    <li><a href=""shop.html"" class=""home"">Shop</a></li>
                    <li>Cart</li>
                </ul>
            </div>
        </div>
    </div>
    <div class=""content-area"">
        <div class=""container"">
            <div class=""row"">
                <div class=""site-main col-sm-12 full-width"">

                    <div class=""entry-content"">
                        <div class=""woocommerce"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e93c890380fa83b86dd0cfd457bb46c3b59b00c67945", async() => {
                WriteLiteral(@"

                                <table class=""shop_table shop_table_responsive cart woocommerce-cart-form__contents"">
                                    <thead>
                                        <tr>
                                            <th class=""product-remove"">&nbsp;</th>
                                            <th class=""product-thumbnail"">&nbsp;</th>
                                            <th class=""product-name"">Product</th>
                                            <th class=""product-price"">Price</th>
                                            <th class=""product-quantity"">Quantity</th>
                                            <th class=""product-subtotal"">Subtotal</th>
                                        </tr>
                                    </thead>
                                    <tbody>

");
#nullable restore
#line 37 "D:\Code Academy\Teaching\Groupes\P222\Lessons\75.23.12.2021\Codes\azen\azen\Views\Shop\Cart.cshtml"
                                         foreach (var item in Model)
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                            <tr class=""woocommerce-cart-form__cart-item cart_item"">

                                                <td class=""product-remove"">
                                                    <a href=""#"" class=""remove"">×</a>
                                                </td>

                                                <td class=""product-thumbnail"">
                                                    <a href=""simple-product.html"">
                                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e93c890380fa83b86dd0cfd457bb46c3b59b00c69964", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 2417, "~/images/product/", 2417, 17, true);
#nullable restore
#line 47 "D:\Code Academy\Teaching\Groupes\P222\Lessons\75.23.12.2021\Codes\azen\azen\Views\Shop\Cart.cshtml"
AddHtmlAttributeValue("", 2434, item.SizeToProduct.Product.ProductImages.FirstOrDefault().Name, 2434, 63, false);

#line default
#line hidden
#nullable disable
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
                WriteLiteral(@"
                                                    </a>
                                                </td>

                                                <td class=""product-name"" data-title=""Product"">
                                                    <a href=""simple-product.html"">");
#nullable restore
#line 54 "D:\Code Academy\Teaching\Groupes\P222\Lessons\75.23.12.2021\Codes\azen\azen\Views\Shop\Cart.cshtml"
                                                                             Write(item.SizeToProduct.Product.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</a>
                                                </td>

                                                <td class=""product-price"" data-title=""Price"">
                                                    <span class=""woocommerce-Price-amount amount"">
                                                        <span class=""woocommerce-Price-currencySymbol"">$</span>");
#nullable restore
#line 59 "D:\Code Academy\Teaching\Groupes\P222\Lessons\75.23.12.2021\Codes\azen\azen\Views\Shop\Cart.cshtml"
                                                                                                          Write(item.SizeToProduct.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                                    </span>
                                                </td>

                                                <td class=""product-quantity"" data-title=""Quantity"">
                                                    <div class=""btn-group"">
                                                        <button type=""button"" class=""prev btn "">-</button>
                                                        <button type=""button"" class=""show-number btn "">1</button>
                                                        <button type=""button"" class=""next btn "">+</button>
                                                    </div>
                                                </td>

                                                <td class=""product-subtotal"" data-title=""Subtotal"">
                                                    <span class=""woocommerce-Price-amount amount"">
                                                        <span class=""woocomme");
                WriteLiteral("rce-Price-currencySymbol\">$</span>");
#nullable restore
#line 73 "D:\Code Academy\Teaching\Groupes\P222\Lessons\75.23.12.2021\Codes\azen\azen\Views\Shop\Cart.cshtml"
                                                                                                           Write(item.SizeToProduct.Price*1);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                                    </span>\r\n                                                </td>\r\n                                            </tr>\r\n");
#nullable restore
#line 77 "D:\Code Academy\Teaching\Groupes\P222\Lessons\75.23.12.2021\Codes\azen\azen\Views\Shop\Cart.cshtml"
                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                        <tr>
                                            <td colspan=""6"" class=""actions"">

                                                <div class=""coupon"">
                                                    <label for=""coupon_code"">Coupon:</label>
                                                    <input type=""text"" name=""coupon_code"" class=""input-text""
                                                           id=""coupon_code""");
                BeginWriteAttribute("value", " value=\"", 5195, "\"", 5203, 0);
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""Coupon code"">
                                                    <button type=""submit"" class=""button"" name=""apply_coupon""
                                                            value=""Apply coupon"">
                                                        Apply coupon
                                                    </button>
                                                </div>

                                                <button type=""submit"" class=""button"" name=""update_cart""
                                                        value=""Update cart""");
                BeginWriteAttribute("disabled", " disabled=\"", 5797, "\"", 5808, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                                    Update cart
                                                </button>


                                                <input type=""hidden"" id=""woocommerce-cart-nonce""
                                                       name=""woocommerce-cart-nonce"" value=""4b591cdf2c""><input type=""hidden"" name=""_wp_http_referer"" value=""/cart/"">
                                            </td>
                                        </tr>
                                    </tbody>
                                </table>
                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            <div class=""cart-collaterals"">
                                <div class=""cart_totals "">
                                    <h2>Cart totals</h2>
                                    <table class=""shop_table shop_table_responsive"">
                                        <tbody>
                                            <tr class=""cart-subtotal"">
                                                <th>Subtotal</th>
                                                <td data-title=""Subtotal"">
                                                    <span class=""woocommerce-Price-amount amount"">
                                                        <span class=""woocommerce-Price-currencySymbol"">$</span>");
#nullable restore
#line 114 "D:\Code Academy\Teaching\Groupes\P222\Lessons\75.23.12.2021\Codes\azen\azen\Views\Shop\Cart.cshtml"
                                                                                                          Write(Model.Sum(p => p.SizeToProduct.Price * 1));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                    </span>
                                                </td>
                                            </tr>
                                            <tr class=""cart-subtotal"">
                                                <th>Shipping</th>
                                                <td data-title=""Subtotal"">
                                                    <span class=""woocommerce-Price-amount amount"">
");
#nullable restore
#line 122 "D:\Code Academy\Teaching\Groupes\P222\Lessons\75.23.12.2021\Codes\azen\azen\Views\Shop\Cart.cshtml"
                                                         if (Model.Sum(p => p.SizeToProduct.Price * 1) < 100)
                                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                            <span class=\"woocommerce-Price-currencySymbol\">$10</span>\r\n");
#nullable restore
#line 125 "D:\Code Academy\Teaching\Groupes\P222\Lessons\75.23.12.2021\Codes\azen\azen\Views\Shop\Cart.cshtml"
                                                        }
                                                        else
                                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                            <span class=\"woocommerce-Price-currencySymbol\">Free</span>\r\n");
#nullable restore
#line 129 "D:\Code Academy\Teaching\Groupes\P222\Lessons\75.23.12.2021\Codes\azen\azen\Views\Shop\Cart.cshtml"
                                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                    </span>
                                                </td>
                                            </tr>
                                            <tr class=""order-total"">
                                                <th>Total</th>
                                                <td data-title=""Total"">
                                                    <strong>
                                                        <span class=""woocommerce-Price-amount amount"">
");
#nullable restore
#line 138 "D:\Code Academy\Teaching\Groupes\P222\Lessons\75.23.12.2021\Codes\azen\azen\Views\Shop\Cart.cshtml"
                                                             if (Model.Sum(p => p.SizeToProduct.Price * 1) < 100)
                                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                <span class=\"woocommerce-Price-currencySymbol\">$");
#nullable restore
#line 140 "D:\Code Academy\Teaching\Groupes\P222\Lessons\75.23.12.2021\Codes\azen\azen\Views\Shop\Cart.cshtml"
                                                                                                            Write(Model.Sum(p => p.SizeToProduct.Price * 1)+10);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 141 "D:\Code Academy\Teaching\Groupes\P222\Lessons\75.23.12.2021\Codes\azen\azen\Views\Shop\Cart.cshtml"
                                                            }
                                                            else
                                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                <span class=\"woocommerce-Price-currencySymbol\">$");
#nullable restore
#line 144 "D:\Code Academy\Teaching\Groupes\P222\Lessons\75.23.12.2021\Codes\azen\azen\Views\Shop\Cart.cshtml"
                                                                                                           Write(Model.Sum(p => p.SizeToProduct.Price * 1));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 145 "D:\Code Academy\Teaching\Groupes\P222\Lessons\75.23.12.2021\Codes\azen\azen\Views\Shop\Cart.cshtml"
                                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                        </span>
                                                    </strong>
                                                </td>
                                            </tr>
                                        </tbody>
                                    </table>
                                    <div class=""wc-proceed-to-checkout"">
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e93c890380fa83b86dd0cfd457bb46c3b59b00c624383", async() => {
                WriteLiteral("\r\n                                            Proceed to checkout\r\n                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                    </div>


                                </div>
                            </div>
                        </div>
                    </div><!-- .entry-content -->
                </div>
            </div>
        </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ColorToSizeToProduct>> Html { get; private set; }
    }
}
#pragma warning restore 1591
