using Newtonsoft.Json;
using System;
using System.ComponentModel;
using dental_sys.Constants;

namespace dental_sys.model
{
    public class ClassVersionEntity
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("version")]
        public string Version { get; set; }
        [JsonProperty("commit_hash")]
        public string CommitHash { get; set; }
        [JsonProperty("created_date")]
        public DateTime? CreatedDate { get; set; }
    }

    public class ClassVersionModel
    {
        [DisplayName(ClassVersionHeaderConstant.No)]
        public string No { get; set; }
        [DisplayName(ClassVersionHeaderConstant.Id)]
        public string Id { get; set; }
        [DisplayName(ClassVersionHeaderConstant.Version)]
        public string Version { get; set; }
        [DisplayName(ClassVersionHeaderConstant.CommitHash)]
        public string CommitHash { get; set; }
        [Browsable(false)]
        public DateTime? CreatedDate { get; set; }

        [DisplayName(ClassVersionHeaderConstant.CreatedDate)]
        public string CreatedDateText => CreatedDate?.ToString("dd/MM/yyyy HH:mm:ss");
    }
}
