using AutoMapper;
using OnlineShop.DAL.Context;

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

        public async Task<int> AddUserAsync(int id)
        {
            _shopDbContext.Users.Add(new DAL.Entities.User() { UserId = id });
            await _shopDbContext.SaveChangesAsync();
            return id;
        }
    }
}
