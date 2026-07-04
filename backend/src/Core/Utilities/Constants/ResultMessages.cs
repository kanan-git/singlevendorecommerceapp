using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace Core.Utilities.Constants;

public static class ResultMessages
{
    #region Success
    // crud ops
    public static string Created = "Successfully added. [201]";
    public static string Readed = "Successfully fetched. [200]";
    public static string Updated = "Successfully updated. [200]";
    public static string Deleted = "Successfully removed. [200]";

    // save changes
    public static string Saved = "Successfully saved. [200]";

    // authentication
    public static string LoggedIn = "Successfully signed in. [200]";
    public static string Registered = "Successfully registered. [201]";
    #endregion

    #region Error
    // authentication
    public static string Unauthorized = "Authorization required. [401]";
    public static string Forbidden = "Permission denied. [403]";

    // data
    public static string NoMatchFound = "No matching record found. [404]";
    public static string AlreadyExist = "Resource already exists. [409]";

    // common
    public static string UnknownFail = "Something went wrong. [500]";
    #endregion
}
