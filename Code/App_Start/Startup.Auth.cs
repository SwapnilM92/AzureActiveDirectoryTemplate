#region Page Summary
/// *****************************************************************
///
/// Project:        LDPv2
/// Solution:       MAQ.LDP
///
/// Author:  MAQ Software
/// Date:    November 23, 2016
/// Description: Validate token coming from browser
///
/// Change History:
/// Name            Date                    Version        Description
/// -------------------------------------------------------------------------------
/// Developer    November 23, 2016          1.0.0.0      Validate token coming from browser

/// -------------------------------------------------------------------------------
/// Copyright (C) Microsoft
/// -----
#endregion
namespace MAQ.LDP.WebService
{
    #region using
    using Microsoft.Owin.Security.ActiveDirectory;
    using Owin;
    using System;
    #endregion
    /// <summary>
    /// This file checks bearer token coming from browser
    /// </summary>
    public sealed partial class Startup
    {
        private Startup() { }
        /// <summary>
        /// This method validates bearer token 
        /// </summary>
        [ObsoleteAttribute("Use TokenValidationParameters.ValidAudience", false)]
        public static void ConfigureAuth(IAppBuilder app)
        {
            app.UseWindowsAzureActiveDirectoryBearerAuthentication(
                new WindowsAzureActiveDirectoryBearerAuthenticationOptions
                {
                    Audience = Constants.AUDIENCE,
                    Tenant = Constants.TENANT,
                });
        }
    }
}