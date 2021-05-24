using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShip : CosmicFight
{
    public string shipName;
    public int laserPower;
    public int shieldPower;
    public SpaceShip BuildShip(string shipName, int laserPower, int shieldPower)
    {
        return null;
    }
    virtual public void Shoot(SpaceShip targetShip) { targetShip.shieldPower -= laserPower; }
    public bool isAlive() { return shieldPower > 0; }
}

// BuildShip(Scout scout) ?