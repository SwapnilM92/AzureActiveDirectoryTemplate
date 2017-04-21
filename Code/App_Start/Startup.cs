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
/// Developer    November 23, 2016          1.0.0.0      Call method to Validate token coming from browser

/// -------------------------------------------------------------------------------
/// Copyright (C) Microsoft
/// -------------------------------------------------------------------------------
#endregion
namespace MAQ.LDP.WebService
{
    #region using
    using Owin;
    using System;
    #endregion
    /// <summary>
    /// This file calls Configuration method and checks Bearer token
    /// </summary>
    public partial class Startup
    {
        /// <summary>
        /// This method is called automatically by .net runtime when application starts
        /// </summary>
        [ObsoleteAttribute("Use TokenValidationParameters.ValidAudience", false)]
        public static void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}