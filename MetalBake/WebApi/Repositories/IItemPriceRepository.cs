using WebApi;

namespace WebApi {
	public interface IItemPriceRepository
	{
		ItemPrice Get(string itemId);

		System.Collections.Generic.List<ItemPrice> GetAll();
	}
}