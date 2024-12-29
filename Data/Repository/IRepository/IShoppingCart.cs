namespace YumBlazor.Data.Repository.IRepository;

public interface IShoppingCart
{
    public Task<bool> UpdateCartAsync(string userId, int productId, int updateBy);
    public Task<IEnumerable<ShoppingCart>> GetAllAsync(string? userId);
    public Task<bool> ClearCartAsync(string userId);

    public Task<int> GetTotalCartCartCountAsync(string? userId);
}
