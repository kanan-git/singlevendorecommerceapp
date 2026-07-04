using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace Core.Utilities.Constants;

public static class StaticDirectories
{
    public static string FilesRootDir = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot");

    public static string ProductImagePath = FilesRootDir + "/images/products/";
    public static string BrandLogoPath = FilesRootDir + "/images/brands/";
    public static string UserProfilePath = FilesRootDir + "/images/profiles/";
    public static string InvoiceFilePath = FilesRootDir + "/docs/invoices/";
    public static string DefaultPdfsPath = FilesRootDir + "/docs/management/";
}
