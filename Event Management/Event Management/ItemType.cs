public class ItemType
{
	private string _name;
	private double _deposit;
	private double _costPerDay;

	public string Name
	{
		set
		{
			this._name = value;
		}
		get
		{
			return this._name;
		}
	}
	public double Deposit
	{
		set
		{
			this._deposit = value;
		}
		get
		{
			return this._deposit;
		}
	}
	public double CostPerDay
	{
		set
		{
			this._costPerDay = value;
		}
		get
		{
			return this._costPerDay;
		}
	}

	public override string ToString()
	{
		return "Item Name: " + this.Name + "\nDeposit Amount: " + this.Deposit + "\nCost Per Day: " + this.CostPerDay;
	}
}