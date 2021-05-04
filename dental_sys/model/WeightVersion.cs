using System;
using System.ComponentModel;
using dental_sys.Constants;
using Newtonsoft.Json;

namespace dental_sys.model
{
    public class WeightVersionEntity
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("version")]
        public string Version { get; set; }
        [JsonProperty("url")]
        public string Url { get; set; }
        [JsonProperty("created_date")]
        public DateTime? CreatedDate { get; set; }
        [JsonProperty("class_version")]
        public string ClassVersionId { get; set; }
        [JsonProperty("is_active")]
        public bool IsActive { get; set; }
        [JsonProperty("log_path")]
        public string LogPath { get; set; }
        [JsonProperty("loss_function_path")]
        public string LossFunctionPath { get; set; }
    }

    public class WeightVersionModel
    {
        [DisplayName(WeightVersionHeaderConstant.No)]
        public string No { get; set; }
        [DisplayName(WeightVersionHeaderConstant.Id)]
        public string Id { get; set; }
        [DisplayName(WeightVersionHeaderConstant.Version)]
        public string Version { get; set; }
        [Browsable(false)]
        //[DisplayName(WeightVersionHeaderConstant.Url)]
        public string Url { get; set; }
        [Browsable(false)]
        public DateTime? CreatedDate { get; set; }

        [DisplayName(WeightVersionHeaderConstant.CreatedDate)]
        public string CreatedDateText => CreatedDate?.AddHours(7).ToString("dd/MM/yyyy HH:mm:ss");
        [Browsable(false)]
        public string ClassVersionId { get; set; }
        [Browsable(false)]
        public bool IsActive { get; set; }
        [Browsable(false)]
        public string LogPath { get; set; }
        [Browsable(false)]
        public string LossFunctionPath { get; set; }
        [DisplayName(WeightVersionHeaderConstant.Status)]
        public string Status { get; set; }
    }
}
