using System;
using System.Collections.Generic;

namespace Game
{
	public class Program
	{
		public void Main()
		{
			public Player player;
			
			while (true) //Player setup
			{
				Console.Write("Enter player name: ");
				player.name = Console.ReadLine();
			}
		}
	}

	public class Player()
	{
		public string name;
		public int baseHealth;
		public int currentHealth;
		public List<Item> inventory;
		public int gold;
	}

	public class Item
	{
		public string name;
		public int sellValue;
		public bool sellable;
	}

	public class Generic : Item
	{
		public Generic(string _name, int _sellValue, bool _sellable)
		{
			name = _name;
			sellValue = _sellValue;
			sellable = _sellable;
		}
	}

	public class Weapon : Item
	{
		public Weapon(string _name, int _sellValue, bool _sellable, int _damage)
		{
			name = _name;
			sellValue = _sellValue;
			sellable = _sellable;
			damage = _damage;
		}

		public int damage;
	}

	public class Consumable : Item
	{
		public Consumable(string _name, int _sellValue, bool _sellable, int _healthIncrease)
		{
			name = _name;
			sellValue = _sellValue;
			sellable = _sellable;
			healthIncrease = _healthIncrease;
		}

		public int healthIncrease;
	}
}
