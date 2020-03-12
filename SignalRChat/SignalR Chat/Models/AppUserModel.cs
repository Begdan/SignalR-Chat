using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalR_Chat.Models
{
    public class AppUserModel : IdentityUser
    {
        public AppUserModel()
        {
            Messages = new HashSet<MessageModel>();
        }

        public virtual ICollection<MessageModel> Messages { get; set; }
    }
}
