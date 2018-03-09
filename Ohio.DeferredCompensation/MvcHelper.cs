/*
*  Copyright (c) 2018, TopCoder, Inc. All rights reserved.
*/
using Ohio.DeferredCompensation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace Ohio.DeferredCompensation
{
    /// <summary>
    /// The Helper class.
    /// </summary>
    ///
    /// <author>TCSCODER</author>
    /// <version>1.0</version>
    /// <copyright>Copyright (c) 2018, TopCoder, Inc. All rights reserved.</copyright>
    public static class MvcHelper
    {
        /// <summary>
        /// Creates JSON error result.
        /// </summary>
        /// <param name="message">The error message.</param>
        /// <returns>JSON result.</returns>
        public static JsonResult JsonErrorResult(string message)
        {
            return new JsonResult
            {
                Data = new { success = false, responseText = message },
                JsonRequestBehavior = JsonRequestBehavior.AllowGet
            };
        }

        /// <summary>
        /// Creates JSON success result.
        /// </summary>
        /// <param name="content">The content.</param>
        /// <returns>JSON result.</returns>
        public static JsonResult JsonSuccessResult(object content = null)
        {
            return new JsonResult
            {
                Data = new { success = true, content },
                JsonRequestBehavior = JsonRequestBehavior.AllowGet
            };
        }

        /// <summary>
        /// Gets the tab class.
        /// </summary>
        /// <param name="htmlHelper">The HTML helper.</param>
        /// <param name="tab">The tab.</param>
        /// <returns></returns>
        public static MvcHtmlString GetTabClass(this HtmlHelper htmlHelper, NavigationTab tab)
        {
            return new MvcHtmlString(htmlHelper.ViewBag.AtiveTab == tab ? $"class=\"active\"" : string.Empty);
        }

        /// <summary>
        /// Adds active classes if not logged in.
        /// </summary>
        /// <param name="htmlHelper">The HTML helper.</param>
        /// <param name="className">Name of the class.</param>
        /// <returns></returns>
        public static MvcHtmlString ClassIfNotLoggedIn(this HtmlHelper htmlHelper, string className)
        {
            return new MvcHtmlString(htmlHelper.ViewBag.IsLoggedIn != true ? className : string.Empty);
        }

        /// <summary>
        /// Actives the class if.
        /// </summary>
        /// <param name="htmlHelper">The HTML helper.</param>
        /// <param name="condition">if set to <c>true</c> [condition].</param>
        /// <returns></returns>
        public static MvcHtmlString ActiveClassIf(this HtmlHelper htmlHelper, bool condition)
        {
            return new MvcHtmlString(condition ? "active" : string.Empty);
        }

        /// <summary>
        /// Returns 'checked' MVC HTML string in case <paramref name="condition"/> is true,
        /// otherwise returns empty string.
        /// </summary>
        /// <param name="htmlHelper">The HTML helper.</param>
        /// <param name="condition">The condition value.</param>
        /// <returns>'checked' MVC HTML string in case <paramref name="condition"/> is true,
        /// otherwise returns empty string.</returns>
        public static MvcHtmlString CheckedIf(this HtmlHelper htmlHelper, bool condition)
        {
            return new MvcHtmlString(condition ? "checked" : string.Empty);
        }

        /// <summary>
        /// Creates class if condition is true.
        /// </summary>
        /// <param name="htmlHelper">The HTML helper.</param>
        /// <param name="className">Name of the class.</param>
        /// <param name="condition">if set to <c>true</c> [condition].</param>
        /// <returns></returns>
        public static MvcHtmlString ClassIf(this HtmlHelper htmlHelper, string className, bool condition)
        {
            return new MvcHtmlString(condition ? className : string.Empty);
        }

        /// <summary>
        /// Creates actions link if condition is true.
        /// </summary>
        /// <param name="urlHelper">The URL helper.</param>
        /// <param name="condition">if set to <c>true</c> [condition].</param>
        /// <param name="actionName">Name of the action.</param>
        /// <param name="controllerName">Name of the controller.</param>
        /// <returns></returns>
        public static MvcHtmlString ActionLinkIf(this UrlHelper urlHelper, bool condition,
            string actionName, string controllerName)
        {
            return new MvcHtmlString(condition ? urlHelper.Action(actionName, controllerName) : "javascript:;");
        }

        /// <summary>
        /// Creates custom text box.
        /// </summary>
        /// <param name="helper">The helper.</param>
        /// <param name="name">The name.</param>
        /// <param name="placeholder">The placeholder.</param>
        /// <param name="class">The class.</param>
        /// <param name="type">The type.</param>
        /// <returns></returns>
        public static MvcHtmlString CustomTextBox(this HtmlHelper helper,
            string name, string placeholder = null, string @class = null, string type = "text")
        {
            string element = $"<input class=\"{@class}\" data-val=\"true\" data-val-required type =\"{type}\""
                + $" name=\"{name}\" placeholder=\"{placeholder}\" title=\"{placeholder}\"/>";
            return new MvcHtmlString(element);
        }

        /// <summary>
        /// Creates the fake instructions.
        /// </summary>
        /// <param name="count">The count.</param>
        /// <returns></returns>
        internal static IList<string> CreateFakeInstructions(int count)
        {
            return Enumerable.Repeat(
                "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean euismod bibendum laoreet. " +
                "Proin gravida dolor sit amet lacus accumsalon et viverra justo commodo.", count).ToList();
        }

        /// <summary>
        /// Creates custom text box.
        /// </summary>
        /// <typeparam name="TModel">The type of the model.</typeparam>
        /// <typeparam name="TProperty">The type of the property.</typeparam>
        /// <param name="helper">The helper.</param>
        /// <param name="expression">The expression.</param>
        /// <param name="placeholder">The placeholder.</param>
        /// <param name="class">The class.</param>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public static MvcHtmlString CustomTextBoxFor<TModel, TProperty>(
            this HtmlHelper<TModel> helper, Expression<Func<TModel, TProperty>> expression,
            string placeholder = null, string @class = null, string id = null)
        {
            id = id ?? Guid.NewGuid().ToString();
            return helper.TextBoxFor(expression, new { id, @class, placeholder, title = placeholder });
        }

        /// <summary>
        /// Creates custom text area.
        /// </summary>
        /// <typeparam name="TModel">The type of the model.</typeparam>
        /// <typeparam name="TProperty">The type of the property.</typeparam>
        /// <param name="helper">The helper.</param>
        /// <param name="expression">The expression.</param>
        /// <param name="placeholder">The placeholder.</param>
        /// <param name="class">The class.</param>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public static MvcHtmlString CustomTextAreaFor<TModel, TProperty>(
            this HtmlHelper<TModel> helper, Expression<Func<TModel, TProperty>> expression,
            string placeholder, string @class = null, string id = null)
        {
            id = id ?? Guid.NewGuid().ToString();
            return helper.TextAreaFor(expression, new { id, @class, placeholder, title = placeholder });
        }

        /// <summary>
        /// Creates custom password box.
        /// </summary>
        /// <typeparam name="TModel">The type of the model.</typeparam>
        /// <typeparam name="TProperty">The type of the property.</typeparam>
        /// <param name="helper">The helper.</param>
        /// <param name="expression">The expression.</param>
        /// <param name="placeholder">The placeholder.</param>
        /// <param name="class">The class.</param>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public static MvcHtmlString CustomPasswordFor<TModel, TProperty>(this HtmlHelper<TModel> helper,
             Expression<Func<TModel, TProperty>> expression, string placeholder, string @class = null, string id = null)
        {
            id = id ?? Guid.NewGuid().ToString();
            return helper.PasswordFor(expression, new { id, @class, placeholder, title = placeholder });
        }

        /// <summary>
        /// Creates custom CheckBox.
        /// </summary>
        /// <param name="helper">The helper.</param>
        /// <param name="label">The label.</param>
        /// <param name="name">The name.</param>
        /// <param name="value">The value.</param>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public static MvcHtmlString CustomCheckBox(this HtmlHelper helper, string label,
             string name, bool? value, string id = null)
        {
            id = id ?? Guid.NewGuid().ToString();
            string checkedAttr = value == true ? "checked" : string.Empty;
            string checkboxEl = $"<input type=\"checkbox\" id=\"{id}\" name=\"{name}\" value=\"true\" {checkedAttr}/>";
            string labelEl = $"<label for=\"{id}\" class=\"tick-me\"><span>{label}</span></label>";
            string hiddenEl = $"<input type=\"hidden\" name=\"{name}\" value=\"false\" />";
            return new MvcHtmlString($"{checkboxEl}{labelEl}{hiddenEl}");
        }

        /// <summary>
        /// Creates custom 'select' element.
        /// </summary>
        /// <typeparam name="TModel">The type of the model.</typeparam>
        /// <typeparam name="TProperty">The type of the property.</typeparam>
        /// <param name="helper">The hmtl helper.</param>
        /// <param name="expression">The expression to get model property.</param>
        /// <param name="values">The select element values.</param>
        /// <param name="placeholder">The placeholder.</param>
        /// <param name="nullValue">The value to treat as a null value.</param>
        /// <param name="value">The current value.</param>
        /// <param name="class">The optional CSS class.</param>
        /// <param name="id">The optional 'id' property value.</param>
        /// <returns>The MVC Html string with the 'select' element.</returns>
        public static MvcHtmlString CustomSelectFor<TModel, TProperty>(
            this HtmlHelper<TModel> helper, Expression<Func<TModel, TProperty>> expression,
            IList<string> values, string placeholder, string nullValue = null, string value = null,
            string @class = null, string id = null)
        {
            id = id ?? Guid.NewGuid().ToString();
            var listItems = values.Select(x => new SelectListItem { Text = x, Value = x != nullValue ? x : null });
            var selectList = new SelectList(listItems, "Value", "Text", value ?? nullValue);
            return helper.DropDownListFor(expression, selectList, new { id, @class, placeholder, title = placeholder });
        }
    }
}