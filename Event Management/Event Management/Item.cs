public class Item
{
	private string _number;
	private ItemType _itemType;
	private string _vendor;

	public string Number
	{
		set
		{
			this._number = value;
		}
		get
		{
			return this._number;
		}
	}
	public string Vendor
	{
		set
		{
			this._vendor = value;
		}
		get
		{
			return this._vendor;
		}
	}
	public ItemType ItemType
	{
		set
		{
			this._itemType = value;
		}
		get
		{
			return this._itemType;
		}
	}

	public override string ToString()
	{
		return "Item Details\nItem Number: " + this.Number + "\nVendor: " + this.Vendor + "\nItemType: \n" + this.ItemType;
	}
}