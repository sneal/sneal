﻿using System;
using System.Collections.Specialized;

namespace Sneal.Core.Web
{
    /// <summary>
    /// Represents an HTTP request.
    /// </summary>
    public interface IHttpRequest
    {
        /// <summary>
        /// Gets a combined collection of QueryString, Form, ServerVariables, and Cookies items.
        /// </summary>
        NameValueCollection Params { get; set; }

        /// <summary>
        /// Gets a collection of HTTP headers.
        /// </summary>
        NameValueCollection Headers { get; set; }

        /// <summary>
        /// Gets the collection of HTTP query string variables.
        /// </summary>
        NameValueCollection QueryString { get; set; }

        /// <summary>
        /// Gets the collection of HTTP form string variables.
        /// </summary>
        NameValueCollection Form { get; set; }

        /// <summary>
        /// Gets information about the URL of the current request.
        /// </summary>
        Uri Url { get; set; }

        /// <summary>
        /// Gets the ASP.NET application's virtual application root path on the server.
        /// </summary>
        string ApplicationPath { get; set; }

        /// <summary>
        /// Gets the physical file system path of the currently executing server 
        /// application's root directory.
        /// </summary>
        string PhysicalApplicationPath { get; set; }

        /// <summary>
        /// Gets a value indicating whether the request is from the local computer.
        /// </summary>
        bool IsLocal { get; set; }

        /// <summary>
        /// Maps the specified virtual path to a physical path.
        /// </summary>
        /// <param name="virtualPath">
        /// The virtual path (absolute or relative) for the current request.
        /// </param>
        /// <returns>The physical path on the server specified by virtualPath.</returns>
        string MapPath(string virtualPath);
    }
}
