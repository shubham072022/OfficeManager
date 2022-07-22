﻿using OfficeManager.Application.Common.Models;

namespace OfficeManager.Application.Common.Interfaces
{
    public interface IIdentityService
    {
        Task<string> GetUserNameAsync(Guid userId);

        Task<bool> IsInRoleAsync(Guid userId, string role);

        Task<bool> AuthorizeAsync(Guid userId, string policyName);
    }
}
