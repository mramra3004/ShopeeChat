﻿using ShopeeChat.CoreAPI.RestClientShopee.Models;
using System.Collections.Generic;

namespace ShopeeChat.Demo.WebApplication.Models
{
    public class ConversationsViewModel
    {
        public List<ConversationResponse> ConversationResponses { get; set; }

        public List<ConversationDetailsResponse> ConversationDetailsResponses { get; set; }

        public string AvatarCustomer { get; set; }
        public string NameCustomer { get; set; }
        public int CustomerId { get; set; }
        public string AvatarSeller { get; set; }
        public string NameSeller { get; set; }
        public int SellerId { get; set; }
    }
}