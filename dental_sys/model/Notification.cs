﻿using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.Drawing;
using dental_sys.Constants;

namespace dental_sys.model
{
    public class NotificationEntity
    {
        [JsonProperty("id")]
        public int? Id { get; set; }
        [JsonProperty("message")]
        public string Message { get; set; }
        [JsonProperty("created_date")]
        public DateTime? CreatedDate { get; set; }
        [JsonProperty("is_read")]
        public bool? IsRead { get; set; }  
        [JsonProperty("user_id")]
        public int? UserId { get; set; }
    }

    public class NotificationModel
    {
        [DisplayName(NotificationHeaderConstant.No)]
        public string No { get; set; }
        [Browsable(false)]
        public string Id { get; set; }
        [DisplayName(NotificationHeaderConstant.Message)]
        public string Message { get; set; }
        [Browsable(false)]
        public DateTime? CreatedDate { get; set; }

        [DisplayName(NotificationHeaderConstant.CreatedDate)]
        public string CreatedDateText => CreatedDate?.ToString("dd/MM/yyyy HH:mm:ss");
        [Browsable(false)]
        public bool IsRead { get; set; }
        [DisplayName(NotificationHeaderConstant.Read)]
        public Bitmap Read => IsRead ? new Bitmap(Properties.Resources.read, new Size(32, 32)) : new Bitmap(Properties.Resources.unread, new Size(32, 32));
    }

    public class CountUnreadEntity
    {
        [JsonProperty("total")]
        public int? Total { get; set; }

    }
}