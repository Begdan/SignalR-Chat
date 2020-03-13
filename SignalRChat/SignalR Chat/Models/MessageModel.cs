﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SignalR_Chat.Models
{
    public class MessageModel
    {
        public int Id { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Text { get; set; }

        public DateTime TimeSent { get; set; }

        public string UserID { get; set; }

        public virtual AppUserModel Sender { get; set; }

        public MessageModel()
        {
            TimeSent = DateTime.Now;
        }
    }
}
