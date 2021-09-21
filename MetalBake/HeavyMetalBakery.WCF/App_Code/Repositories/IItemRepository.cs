public interface IInventoryRepository
{
	Item GetItem(string itemId);
	bool Save(Item item);
	bool Exists(string itemId);
}