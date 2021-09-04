using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Novo Item", menuName = "Item")]
public class Item : ScriptableObject
{
    [SerializeField] string itemName;
    [SerializeField] int price;
    [SerializeField] Sprite icon;

    public virtual void Upgrade(SpaceShipMoviment spaceShip)
    {
        Debug.Log("Item used!");
    }

    public virtual float ReturnMainValue()
    {
        return -1;
    }

    public int GetPrice()
    {
        return price;
    }

    public string GetItemName()
    {
        return itemName;
    }

    public Sprite GetSprite()
    {
        return icon;
    }
}
