using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scout : SpaceShip
{
    public void BuildShip() // the values can only be called upon in a constructor
    {
        shipName = "Scout";
        laserPower = 2;
        shieldPower = 2;
    }
    public override void Shoot(SpaceShip targetShip)
    {
        Debug.Log($"{shipName} shoots a laser at: {targetShip.shipName}");
        base.Shoot(targetShip);
    }
}