using System;
using System.Collections.Generic;
using System.Linq;

namespace Wheeling
{
    public class WheelingProperties
    {
        private Dictionary<string, string> properties;
        private string filename ="..\\..\\support\\wheeling.properties";

        public WheelingProperties(string file)
        {
            filename = file;
            Reload(filename);
        }
        public WheelingProperties()
        {
            Reload(filename);
        }
        public string Get(string field, string defValue)
        {
            return Get(field) ?? defValue;
        }
        public string Get(string field)
        {
            return (properties.ContainsKey(field)) ? (properties[field]) : (null);
        }
        public void Set(string field, Object value)
        {
            if (!properties.ContainsKey(field))
                properties.Add(field, value.ToString());
            else
                properties[field] = value.ToString();
        }
        public void Save()
        {
            Save(this.filename);
        }
        public void Save(string filename)
        {
            this.filename = filename;

            if (!System.IO.File.Exists(filename))
                System.IO.File.Create(filename);

            System.IO.StreamWriter file = new System.IO.StreamWriter(filename);

            foreach (string prop in properties.Keys.ToArray())
                if (!string.IsNullOrWhiteSpace(properties[prop]))
                    file.WriteLine(prop + "=" + properties[prop]);

            file.Close();
        }
        public void Reload()
        {
            Reload(this.filename);
        }
        public void Reload(string filename)
        {
            this.filename = filename;
            properties = new Dictionary<string, string>();

            if (System.IO.File.Exists(filename))
                LoadFromFile(filename);
            else
                System.IO.File.Create(filename);
        }
        private void LoadFromFile(string file)
        {
            foreach (string line in System.IO.File.ReadAllLines(file))
            {
                if ((!string.IsNullOrEmpty(line)) &&
                    (!line.StartsWith(";")) &&
                    (!line.StartsWith("#")) &&
                    (!line.StartsWith("'")) &&
                    (line.Contains('=')))
                {
                    int index = line.IndexOf('=');
                    string key = line.Substring(0, index).Trim();
                    string value = line.Substring(index + 1).Trim();

                    if ((value.StartsWith("\"") && value.EndsWith("\"")) || (value.StartsWith("'") && value.EndsWith("'")))
                        value = value.Substring(1, value.Length - 2);

                    try
                    {
                        properties.Add(key, value);
                    }
                    catch { }
                }
            }
        }
    }
}
