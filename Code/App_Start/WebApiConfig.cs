#region Page Summary
/// *****************************************************************
///
/// Project:        LDPv2
/// Solution:       MAQ.LDP
///
/// Author:  MAQ Software
/// Date:    November 23, 2016
/// Description: Allows ADAL authentication and return current user name
///
/// Change History:
/// Name            Date                    Version        Description
/// -------------------------------------------------------------------------------
/// Developer    November 23, 2016          1.0.0.0      Register configuration object and configure routing parameters

/// -------------------------------------------------------------------------------
/// Copyright (C) Microsoft
/// -------------------------------------------------------------------------------
#endregion
namespace MAQ.LDP.WebService
{
    #region using
    using System;
    using System.Web.Http;
    #endregion
    /// <summary>
    /// This file configures Web API and services
    /// </summary>
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            // Web API routes
            PassThroughNonNull(config).MapHttpAttributeRoutes();
            PassThroughNonNull(config).Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
        // Null check method  
        private static HttpConfiguration PassThroughNonNull(HttpConfiguration config)
        {
            if (null == config)
                throw new ArgumentNullException("config");
            return config;
        }
    }
}
