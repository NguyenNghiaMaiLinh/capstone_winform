using System;
using System.ComponentModel;
using dental_sys.Constants;
using Newtonsoft.Json;

namespace dental_sys.model
{
    public class WeightEntity
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("version")]
        public string Version { get; set; }
        [JsonProperty("url")]
        public string Url { get; set; }
        [JsonProperty("created_date")]
        public DateTime CreatedDate { get; set; }
        [JsonProperty("class_version_id")]
        public string ClassVersionId { get; set; }
        [JsonProperty("is_active")]
        public bool IsActive { get; set; }
    }

    public class WeightModel
    {
        [DisplayName(WeightHeaderConstant.No)]
        public string No { get; set; }
        [DisplayName(WeightHeaderConstant.Id)]
        public string Id { get; set; }
        [DisplayName(WeightHeaderConstant.Version)]
        public string Version { get; set; }
        [DisplayName(WeightHeaderConstant.Url)]
        public string Url { get; set; }
        [Browsable(false)]
        public DateTime? CreatedDate { get; set; }

        [DisplayName(WeightHeaderConstant.CreatedDate)]
        public string CreatedDateText => CreatedDate?.ToString("dd/MM/yyyy HH:mm:ss");
        [DisplayName(WeightHeaderConstant.ClassVersionId)]
        public string ClassVersionId { get; set; }
        [Browsable(false)]
        public bool IsActive { get; set; }
        [DisplayName(WeightHeaderConstant.Status)]
        public string Status { get; set; }
    }
}
