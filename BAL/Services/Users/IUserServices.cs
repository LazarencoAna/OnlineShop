namespace OnlineShop.BAL.Services.Users
{
    public interface IUserServices
    {
        Task<int> AddUserAsync(int id);
    }
}
