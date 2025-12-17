using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Routing; // Make sure you include this

namespace Routing.CustomConstraints
{
    public class Months : IRouteConstraint
    {
        public bool Match(HttpContext? httpContext,
            IRouter? route, string routeKey,
            RouteValueDictionary values,
            RouteDirection routeDirection)
        {
            // Check if key exists
            if (!values.ContainsKey(routeKey))
            {
                return false;
            }

            // Convert value to string
            string? monthvalue = Convert.ToString(values[routeKey]);

            // Regex without space + ignore case
            Regex regex = new Regex("^(apr|jul|jan)$", RegexOptions.IgnoreCase);

            return monthvalue != null && regex.IsMatch(monthvalue);
        }
    }
}
