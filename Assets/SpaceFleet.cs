using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceFleet : SpaceShip
{
    private string fleetName;
    List<SpaceShip> spaceShips = new List<SpaceShip>();

    public void BuildFleet(string fleetName, int fleetSize)
    {
        for (int i = 0; i < fleetSize; i++)//Add as many ships as fleetSize
        {
            spaceShips.Add(BuildShip("testShip", 2, 2));//Make the ships in the fleet random
        }
    }
    public SpaceShip GetRandomShip()
    {
        int randomNumber = Random.Range(0, spaceShips.Count + 1);
        return spaceShips[randomNumber];
    }

    public bool IsFleetAlive()
    {
        if(spaceShips.Count > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}