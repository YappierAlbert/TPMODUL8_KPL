﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using tpmodul8_103022300148;

namespace tpmodul8_103022300148
{
    class CovidConfig
    {
        public string satuan_suhu { get; set; }
        public int batas_hari_demam { get; set; }
        public string pesan_ditolak { get; set; }
        public string pesan_diterima { get; set; }

        public CovidConfig() { }

        public CovidConfig readJson()
        {
            String jsonString = File.ReadAllText("D:\\Kuliah\\KPL\\covid_config.json");
            var options = new JsonSerializerOptions
            {
                IncludeFields = true
            };
            CovidConfig json = JsonSerializer.Deserialize<CovidConfig>(jsonString, options);
            return json;
        }
        public void ubahSatuan(CovidConfig json)
        {
            if (json.satuan_suhu.Equals("Celcius")){
                json.satuan_suhu = "Fahrenheit";
            }else
            {
                json.satuan_suhu = "Celcius";
            }
        }
    }
}

