﻿namespace JobFinder.Model.Utils
{
    public class AppSettings
    {
        public const string AppSetting = "AppSettings";
        public string ClientUrl { get; set; } = string.Empty;
        public string AZURE_STORAGE_CONNECTION_STRING { get; set; } = string.Empty;
        public string JwtSecretKey { get; set; } = string.Empty;
    }
}

