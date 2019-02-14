using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
		ItemType itemType = new ItemType();
		Item item = new Item();
		Console.WriteLine("Enter the Item Number");
		item.Number = Console.ReadLine();
		Console.WriteLine("Enter the Vendor Name");
		item.Vendor = Console.ReadLine();
		Console.WriteLine("Enter the Item Type Name");
		itemType.Name = Console.ReadLine();
		Console.WriteLine("Enter the Deposit Amount");
		itemType.Deposit = double.Parse(Console.ReadLine());
		Console.WriteLine("Enter the Cost per day of the Item Type");
		itemType.CostPerDay = double.Parse(Console.ReadLine());
		item.ItemType = itemType;
		Console.WriteLine(item);
    }
}
