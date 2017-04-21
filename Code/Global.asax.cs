#region Page Summary
/// *****************************************************************
///
/// Project:        LDPv2
/// Solution:       MAQ.LDP
///
/// Author:  MAQ Software
/// Date:    November 23, 2016
/// Description: Configure application parameters
///
/// Change History:
/// Name            Date                    Version        Description
/// -------------------------------------------------------------------------------
/// MAQ Software    November 23, 2016          1.0.0.0      Configure application parameters

/// -------------------------------------------------------------------------------
/// Copyright (C) Microsoft
/// -------------------------------------------------------------------------------
#endregion

namespace MAQ.LDP.WebService
{
    #region using
    using System.Web.Http;
    #endregion
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
