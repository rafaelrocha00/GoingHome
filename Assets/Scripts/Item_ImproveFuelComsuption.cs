using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Item Improve Fuel Comsuption")]
public class Item_ImproveFuelComsuption : Item
{
    [SerializeField] int newMaxFuel;

    public override void Upgrade(SpaceShipMoviment spaceShip)
    {
        base.Upgrade(spaceShip);
        spaceShip.ImproveMaxFuel(newMaxFuel);
    }

    public override float ReturnMainValue()
    {
        return newMaxFuel;
    }
}
