#region Page Summary
/// *****************************************************************
///
/// Project:        LDPv2
/// Solution:       MAQ.LDP
///
/// Author:  MAQ Software
/// Date:    December 01, 2016
/// Description: Allows ADAL authentication and return current user name
///
/// Change History:
/// Name            Date                    Version        Description
/// -------------------------------------------------------------------------------
/// Developer    December 01, 2016          1.0.0.0      Allows ADAL authentication and return current user name
/// -------------------------------------------------------------------------------
/// Copyright (C) MAQ Software
/// -------------------------------------------------------------------------------
#endregion

namespace MAQ.LDP.WebService
{
    #region using
    using System.Web.Http;
    using System.Web.Http.Description;
    #endregion
    /// <summary>
    /// This file validates user and returns current user name 
    /// </summary>
    [Authorize]
    public class PingController : ApiController
    {
        /// <summary>
        /// Returns current user name
        /// </summary>
        [HttpGet]
        [Route("api/Ping")]
        [ResponseType(typeof(string))]
        public IHttpActionResult Ping()
        {
            if(!string.IsNullOrWhiteSpace(User.Identity.Name))
            { 
            return Ok(User.Identity.Name);
            }
            else
            {
                return Ok("User name is empty");
            }
        }
    }
}
