using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    class DataAccess
    {
        static readonly string filePath;
        static Root root;

        //private constructor to avoid client applications to use constructor
        static DataAccess()
        {
            filePath = @"../../../Data/MainData.json";
            Load();
        }

        private static DataAccess instance;

        public static DataAccess Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DataAccess();
                }
                return instance;
            }
        }
        private static void Load()
        {
            try
            {
                if (!File.Exists(filePath))
                {
                    root = new Root();
                    using (var stream = File.Create(filePath))
                    {
                        string jsonString = "";
                        root = Root.FromJson(jsonString);
                    }
                }
                else
                {
                    using (var stream = File.OpenRead(filePath))
                    {

                        StreamReader reader = new StreamReader(stream);
                        string jsonString = reader.ReadToEnd();
                        root = Root.FromJson(jsonString);
                    }
                }
            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString());
            }
        }

        public List<Package> GetPackages()
        {
            return root.Packages;
        }

        public List<Package> GetPackagesOfKind(Role role)
        {
            var list = new List<Package>();
            foreach (var item in root.Packages)
            {
                if (item.Role == role)
                {
                    list.Add(item);
                }
            }
            return list;
        }

        public List<Package> GetX86()
        {
            List<Package> packages = new List<Package>();

            foreach (var item in root.Packages)
            {
                if (item.Installer.X8664 == null && item.Installer.X86 != null)
                    packages.Add(item);
            }
            return packages;
        }
        public List<Package> GetX64()
        {
            List<Package> packages = new List<Package>(root.Packages);
            return packages;
        }

        public List<Package> GetPackagesOfName(List<string> names)
        {
            return root.Packages.Where(item => names.Any(name => item.Name == name) == true).ToList();
        }

        public string GetFilePath()
        {
            return filePath;
        }

        public DateTime GetUpdateTime()
        {
            return root.UpdateDate;
        }
    }
}
