using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace Core.Utilities.Constants;

public static class ValidationMessages
{
    public static string RequiredField = "This field is required.";
    public static string MinSymbol(int value) => "At least, minimum "+value+" symbol needed.";
    public static string MaxSymbol(int value) => "Maximum "+value+" symbol can have.";
}
