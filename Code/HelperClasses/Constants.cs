#region Page Summary
/// *****************************************************************
///
/// Project:        LDPv2
/// Solution:       MAQ.LDP
///
/// Author:  MAQ Software
/// Date:    December 01, 2016
/// Description: A class used to declare all the constants value.
///
/// Change History:
/// Name            Date                    Version        Description
/// -------------------------------------------------------------------------------
/// Developer    December 01, 2016          1.0.0.0       A class used to declare all the constants value.
/// -------------------------------------------------------------------------------
/// Copyright (C) MAQ Software
/// -------------------------------------------------------------------------------
#endregion

namespace MAQ.LDP.WebService
{

    #region Using
    using System;
    using System.Configuration;
    using System.Globalization;
    #endregion
    internal static class Constants
    {

        /// <summary>
        /// Display message on Get Method
        /// </summary>
        internal const string GET_MESSAGE = "You requested a Get Message";
        /// <summary>
        /// Display message on Post Method
        /// </summary>
        internal const string POST_MESSAGE = "You requested a Post Message";

        /// <summary>
        /// String Semi colon
        /// </summary>
        internal const string SEMICOLON = ";";       

        #region Azure Application details
        internal static readonly string AUDIENCE = ConfigurationManager.AppSettings["ida:Audience"];
        internal static readonly string TENANT = ConfigurationManager.AppSettings["ida:Tenant"];
        #endregion
    }
}