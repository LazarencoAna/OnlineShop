namespace OnlineShop.BAL.Services.Users
{
    public interface IUserServices
    {
        Task<string> AddUserAsync(string id);
    }
}
