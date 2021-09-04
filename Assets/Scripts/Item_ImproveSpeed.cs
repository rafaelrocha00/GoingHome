using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Item Improve Speed")]
public class Item_ImproveSpeed : Item
{
    [SerializeField] float newSpeed;
    [SerializeField] float newMaxSpeed;
    [SerializeField] int visualPropulsionIndex;

    public override void Upgrade(SpaceShipMoviment spaceShip)
    {
        base.Upgrade(spaceShip);
        spaceShip.ImproveSpeed(newSpeed);
        spaceShip.ImproveMaxSpeed(newMaxSpeed);
        spaceShip.GetComponent<SpaceShipVisualParts>().ChangePropulsion(visualPropulsionIndex);
    }

    public override float ReturnMainValue()
    {
        return newSpeed;
    }
}
