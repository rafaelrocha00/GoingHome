using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Item Improve Defense")]
public class Item_ImproveDefense : Item
{
    [SerializeField] int newDefense;
    [SerializeField] int visualHuskIndex;

    public override void Upgrade(SpaceShipMoviment spaceShip)
    {
        base.Upgrade(spaceShip);
        spaceShip.GetComponent<PlayerStatus>().ImproveDefense(newDefense);
        spaceShip.GetComponent<SpaceShipVisualParts>().ChangeHusk(visualHuskIndex);
    }

    public override float ReturnMainValue()
    {
        return newDefense;
    }
}