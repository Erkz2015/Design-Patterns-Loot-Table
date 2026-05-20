using UnityEngine;

public class ItemFactory
{
    public IItem CreateItem(string type)
    {
        switch (type)
        {
            case "weapon":
                return new Weapon();

            case "armor":
                return new Armor();

            case "gold":
                return new Gold();

            default:
                return null;
        }
    }
}
