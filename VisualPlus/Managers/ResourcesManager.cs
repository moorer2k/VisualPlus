﻿#region Namespace

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

using VisualPlus.Structure;

#endregion

namespace VisualPlus.Managers
{
    public class ResourcesManager
    {
        #region Methods

        /// <summary>Retrieve the resource names from the file.</summary>
        /// <param name="file">The file path.</param>
        /// <returns>The <see cref="string" />.</returns>
        public static List<string> GetResourceNames(string file)
        {
            Assembly _assembly = AssemblyManager.LoadAssembly(file);
            return _assembly.GetManifestResourceNames().ToList();
        }

        /// <summary>Read the resource from the file.</summary>
        /// <param name="file">The file path.</param>
        /// <param name="resource">The resource name.</param>
        /// <returns>The <see cref="string" />.</returns>
        public static string ReadResource(string file, string resource)
        {
            Assembly _assembly = AssemblyManager.LoadAssembly(file);

            try
            {
                string result;
                using (Stream stream = _assembly.GetManifestResourceStream(resource))
                using
                    (StreamReader reader = new StreamReader(stream))
                {
                    result = reader.ReadToEnd();
                }

                return result;
            }
            catch (ArgumentNullException e)
            {
                // Value cannot be null.Parameter name: stream'
                // The embedded resource cannot be found. Set type to 'Embedded Resource'.
                ConsoleEx.WriteDebug(e);
            }
            catch (Exception e)
            {
                ConsoleEx.WriteDebug(e);
            }

            return null;
        }

        #endregion
    }
}