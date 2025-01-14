﻿using AutoMapper;
using Microsoft.EntityFrameworkCore;
using OnlineShop.DAL.Context;
using OnlineShop.DAL.Entities;

namespace OnlineShop.BAL.Services.Users
{
    public class UserServices : IUserServices
    {
        private readonly ShopDbContext _shopDbContext;
        private readonly IMapper _mapper;

        public UserServices(ShopDbContext shopDbContext, IMapper mapper)
        {
            _shopDbContext = shopDbContext;
            _mapper = mapper;
        }

        public async Task<IEnumerable<UserAccount>> GetAllUserAccountsAsync()
        {
            var dbuserAccounts = await _shopDbContext.UserAccounts.ToListAsync();
            var userAccounts = new List<UserAccount>();
            foreach (var item in dbuserAccounts)
            {
                var userAccount = new UserAccount
                {
                    DisplayName = item.DisplayName,
                    Email = item.Email,
                    UserAccountId = item.UserAccountId,
                };
                userAccounts.Add(userAccount);
            }
            return userAccounts;
        }

        public async Task<string> UpsertUserAccountAsync(string userId, UserAccount userAccount)
        {
            var euserAccount = await _shopDbContext.UserAccounts.FirstOrDefaultAsync(uc => uc.UserAccountId == userId);
            if (euserAccount is not null)
            {
                euserAccount.Email = userAccount.Email;
                euserAccount.DisplayName = userAccount.DisplayName;
                _shopDbContext.UserAccounts.Update(euserAccount);
            }
            else
            {
                userAccount.UserAccountId = userId;
                _shopDbContext.UserAccounts.Add(userAccount);
            }

            await _shopDbContext.SaveChangesAsync();
            return userId;
        }
    }
}
