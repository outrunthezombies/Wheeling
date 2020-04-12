using System;
using System.Collections.Generic;
using System.Linq;

namespace Wheeling
{
    public class WheelingProperties
    {
        private Dictionary<String, String> properties;
        private String filename =".\\wheeling.properties";

        public WheelingProperties(String file)
        {
            filename = file;
            Reload(filename);
        }
        public WheelingProperties()
        {
            Reload(filename);
        }
        public String Get(String field, String defValue)
        {
            return Get(field) ?? defValue;
        }
        public String Get(String field)
        {
            return (properties.ContainsKey(field)) ? (properties[field]) : (null);
        }
        public void Set(String field, Object value)
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
        public void Save(String filename)
        {
            this.filename = filename;

            if (!System.IO.File.Exists(filename))
                System.IO.File.Create(filename);

            System.IO.StreamWriter file = new System.IO.StreamWriter(filename);

            foreach (String prop in properties.Keys.ToArray())
                if (!String.IsNullOrWhiteSpace(properties[prop]))
                    file.WriteLine(prop + "=" + properties[prop]);

            file.Close();
        }
        public void Reload()
        {
            Reload(this.filename);
        }
        public void Reload(String filename)
        {
            this.filename = filename;
            properties = new Dictionary<String, String>();

            if (System.IO.File.Exists(filename))
                LoadFromFile(filename);
            else
                System.IO.File.Create(filename);
        }
        private void LoadFromFile(String file)
        {
            foreach (String line in System.IO.File.ReadAllLines(file))
            {
                if ((!String.IsNullOrEmpty(line)) &&
                    (!line.StartsWith(";")) &&
                    (!line.StartsWith("#")) &&
                    (!line.StartsWith("'")) &&
                    (line.Contains('=')))
                {
                    int index = line.IndexOf('=');
                    String key = line.Substring(0, index).Trim();
                    String value = line.Substring(index + 1).Trim();

                    if ((value.StartsWith("\"") && value.EndsWith("\"")) ||
                        (value.StartsWith("'") && value.EndsWith("'")))
                    {
                        value = value.Substring(1, value.Length - 2);
                    }

                    try
                    {
                        //ignore dublicates
                        properties.Add(key, value);
                    }
                    catch { }
                }
            }
        }
    }
}
