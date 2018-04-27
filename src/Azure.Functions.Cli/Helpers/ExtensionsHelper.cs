using Azure.Functions.Cli.Common;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Linq;
using Newtonsoft.Json;
using Microsoft.Azure.WebJobs.Script.Description;

namespace Azure.Functions.Cli.Helpers
{
    class ExtensionsHelper
    {
        public static async Task<string> EnsureExtensionsProjectExistsAsync(string extensionsDir = null)
        {
            var extensionsProj = Path.Combine(Environment.CurrentDirectory, "extensions.csproj");
            if (!FileSystemHelpers.FileExists(extensionsProj))
            {
                var assembly = typeof(ExtensionsHelper).Assembly;
                var extensionsProjText = string.Empty;
                using (Stream resource = assembly.GetManifestResourceStream(assembly.GetName().Name + ".ExtensionsProj.txt"))
                using (var reader = new StreamReader(resource))
                {
                    bindings.Add(binding.Type.ToLower());
                }
            }
            return bindings;
        }

        public static IEnumerable<ExtensionPackage> GetExtensionPackages()
        {
            Dictionary<string, ExtensionPackage> packages = new Dictionary<string, ExtensionPackage>();
            foreach (var binding in GetBindings())
            {
                if (Constants.BindingPackageMap.TryGetValue(binding, out ExtensionPackage package))
                {
                    packages.TryAdd(package.Name, package);
                }
            }
            return packages.Values;
        }
    }
}
