using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Item Improve Defense")]
public class Item_ImproveDefense : Item
{
    [SerializeField] int newDefense;
    [SerializeField] int visualHuskIndex = -1;

    public override void Upgrade(SpaceShipMoviment spaceShip)
    {
        base.Upgrade(spaceShip);
        spaceShip.GetComponent<PlayerStatus>().ImproveDefense(newDefense);
        if (visualHuskIndex == -1) return;
        spaceShip.GetComponent<SpaceShipVisualParts>().ChangeHusk(visualHuskIndex);
    }

    public override float ReturnMainValue()
    {
        return newDefense;
    }
}