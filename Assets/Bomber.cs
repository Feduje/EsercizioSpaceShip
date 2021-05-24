using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomber : SpaceShip
{
     public void BuildShip()
    {
        shipName = "Bomber";
        laserPower = 10;
        shieldPower = 10;
    }
    public override void Shoot(SpaceShip targetShip)
    {
        Debug.Log($"{shipName} bombards: {targetShip.shipName}");
        base.Shoot(targetShip);
    }
}