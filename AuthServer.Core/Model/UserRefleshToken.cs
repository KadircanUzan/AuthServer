﻿
namespace AuthServer.Core.Model
{
    public class UserRefleshToken
    {
        public string UserId { get; set; }
        public string Code { get; set; }
        public DateTime Expiration { get; set; }
    }
}
