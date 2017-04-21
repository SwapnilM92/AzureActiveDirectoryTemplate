#region Page Summary
/// *****************************************************************
///
/// Project:        LDPv2
/// Solution:       MAQ.LDP
///
/// Author:  MAQ Software
/// Date:    November 23, 2016
/// Description: Allows ADAL authentication and returns Get and Post messages.
///
/// Change History:
/// Name            Date                    Version        Description
/// -------------------------------------------------------------------------------
/// Developer    November 23, 2016          1.0.0.0        Allows ADAL authentication and returns Get and Post messages. 
/// -------------------------------------------------------------------------------
/// Copyright (C) MAQ Software
/// -------------------------------------------------------------------------------
#endregion
#region MIT License
/*MIT License

Copyright(c) 2017 MAQ Software

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sub license, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.*/
#endregion

namespace MAQ.LDP.WebService
{

    #region Using
    using System.Web.Http;
    using System.Web.Http.Description;
    #endregion
    /// <summary>
    /// This file is used to test the Get and Post controller.
    /// </summary>
    [Authorize]
    public class DataController : ApiController
    {

        /// <summary>
        /// Returns an Get message
        /// </summary>
        [Route("api/Get")]
        [ResponseType(typeof(string))]
        [HttpGet]
       
        public IHttpActionResult Get()
        {
            return Ok<string>(Constants.GET_MESSAGE);
        }

        /// <summary>
        /// Returns a Post message
        /// </summary>
        [HttpPost]
        [Route("api/Post")]
        [ResponseType(typeof(string))]
        public IHttpActionResult Post()
        {
            return Ok<string>(Constants.POST_MESSAGE);
        }
    }
}
