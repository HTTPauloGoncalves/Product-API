﻿namespace Minha_primeira_API.DTOs
{
    public class UpdateUsersRequest
    {
        public required string Email { get; set; }
        public required string Password { get; set; }
    }
}
