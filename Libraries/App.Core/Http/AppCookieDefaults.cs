﻿using System;
using System.Collections.Generic;
using System.Text;

namespace App.Core.Http
{
    /// <summary>
    /// Represents default values related to cookies
    /// </summary>
    public static partial class AppCookieDefaults
    {
        /// <summary>
        /// Gets the cookie name prefix
        /// </summary>
        public static string Prefix => ".App";

        /// <summary>
        /// Gets a cookie name of the antiforgery
        /// </summary>
        public static string AntiforgeryCookie => ".Antiforgery";

        /// <summary>
        /// Gets a cookie name of the session state
        /// </summary>
        public static string SessionCookie => ".Session";

        /// <summary>
        /// Gets a cookie name of the temp data
        /// </summary>
        public static string TempDataCookie => ".TempData";

        /// <summary>
        /// Gets a cookie name of the installation language
        /// </summary>
        public static string InstallationLanguageCookie => ".InstallationLanguage";

        /// <summary>
        /// Gets a cookie name of the authentication
        /// </summary>
        public static string AuthenticationCookie => ".Authentication";

        /// <summary>
        /// Gets a cookie name of the external authentication
        /// </summary>
        public static string ExternalAuthenticationCookie => ".ExternalAuthentication";

        /// <summary>
        /// Gets a cookie name of the Eu Cookie Law Warning
        /// </summary>
        public static string IgnoreEuCookieLawWarning => ".IgnoreEuCookieLawWarning";

    }
}
