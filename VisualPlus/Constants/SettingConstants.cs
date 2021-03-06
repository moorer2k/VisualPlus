﻿#region Namespace

using System;
using System.Diagnostics;
using System.Reflection;

#endregion

namespace VisualPlus.Constants
{
    public class SettingConstants
    {
        #region Variables

        public static readonly string ComponentUpdateMethodName = "UpdateTheme";
        public static readonly int MaximumAlpha = 255;
        public static readonly int MaximumBorderSize = 24;
        public static readonly int MaximumCheckBoxBorderRounding = 12;
        public static readonly int MaximumCheckBoxSize = 11;
        public static readonly int MaximumRounding = 30;
        public static readonly int MinimumAlpha = 1;
        public static readonly int MinimumBorderSize = 1;
        public static readonly int MinimumCheckBoxBorderRounding = 1;
        public static readonly int MinimumCheckBoxSize = 3;
        public static readonly int MinimumRounding = 1;
        public static readonly string ProductName = Assembly.GetExecutingAssembly().GetName().Name;
        public static readonly string ProjectURL = FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).LegalTrademarks;
        public static readonly string TemplatesFolder = Environment.GetFolderPath(Environment.SpecialFolder.Templates) + @"\VisualPlus Themes\";
        public static readonly string TemplatesFilePath = TemplatesFolder + @"DefaultTheme.xml";
        public static readonly string ThemeAuthor = "Unknown";
        public static readonly string ThemeExtensionSupportedFileFilter = "Theme|*.xml";
        public static readonly string ThemeName = "Unnamed";
        public static readonly string ThemeResourceLocation = "VisualPlus.Resources.Themes.";

        #endregion

        #region Methods

        public const string DefaultCategoryText = "VisualExtension";
        public const float EndPoint = 1.0F;
        public const float StartPoint = 0.0F;

        #endregion
    }
}