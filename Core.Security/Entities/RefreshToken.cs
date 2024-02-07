﻿using Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Security.Entities;

public class RefreshToken: Entity<int>
{
    public int UserId { get; set; }
    public string Token { get; set; }
    public DateTime Expires { get; set; }
    public string CreatedByIp { get; set; }
    public DateTime Revoked { get; set; }
    public string RevekodByIp { get; set; }
    public string? ReplecedByToken { get; set; }
    public string? ReasonRevoked { get; set; }
    public virtual User User { get; set; }

    public RefreshToken()
    {
        Token = string.Empty;
        CreatedByIp = string.Empty;
    }

    public RefreshToken(int userId, string token, DateTime expires, string createdByIp)
    {
        UserId = userId;
        Token = token;
        Expires = expires;
        CreatedByIp = createdByIp;
    }
    public RefreshToken(int id,int userId, string token, DateTime expires, string createdByIp):base(id)
    {
        UserId = userId;
        Token = token;
        Expires = expires;
        CreatedByIp = createdByIp;
    }
}
