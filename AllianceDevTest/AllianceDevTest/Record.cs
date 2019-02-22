using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace AllianceDevTest
{

    public abstract class Record
    {
        public long Id = 1;

        public void Save()
        {
            //Create different file for each Record type
            var fileName = this.GetType().ToString() + ".json";

            var filePath = Environment.CurrentDirectory + "\\" + fileName;

            var records = new List<Record>();

            records.Add(this);

            if (!File.Exists(filePath))
                File.WriteAllText(filePath, JsonConvert.SerializeObject(records));
            else
            {
                AddRecord(filePath);
            }
        }

        public void AddRecord(string filePath)
        {
            var jsonString = File.ReadAllText(filePath);

            var records = JsonConvert.DeserializeObject<List<object>>(jsonString);

            this.Id = records.Count + 1;

            records.Add(this);

            File.WriteAllText(filePath, JsonConvert.SerializeObject(records));
        }

        public T Find<T>(int Id)
        {
            var fileName = this.GetType().ToString() + ".json";

            var filePath = Environment.CurrentDirectory + "\\" + fileName;

            var jsonString = File.ReadAllText(filePath);

            var recordArry = JsonConvert.DeserializeObject<JArray>(jsonString); 

            JObject jo = recordArry.Children<JObject>().FirstOrDefault(o => o["Id"].ToString() == Id.ToString());

            var record = jo.ToObject<T>();

            return record;
        }
    }
}
