using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Item Improve Size")]
public class Item_ImproveSize : Item
{
    [SerializeField] float newSize;

    public override void Upgrade(SpaceShipMoviment spaceShip)
    {
        base.Upgrade(spaceShip);
        spaceShip.transform.localScale = Vector3.one * newSize;
    }

    public override float ReturnMainValue()
    {
        return newSize;
    }
}
