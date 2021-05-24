using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interceptor : SpaceShip
{
    public void BuildShip()
    {
        shipName = "Interceptor";
        laserPower = 5;
        shieldPower = 5;
    }
    public override void Shoot(SpaceShip targetShip)
    {
        Debug.Log($"{shipName} fires a missle at: {targetShip.shipName}");
        base.Shoot(targetShip);
    }
}