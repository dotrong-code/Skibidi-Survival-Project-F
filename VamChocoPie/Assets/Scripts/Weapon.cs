using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{

    public List<WeaponStats> stats;
    public int weaponLevel;

    [HideInInspector]
    public bool statsUpdated;
    // Start is called before the first frame update
    public void LevelUp()
    {
        if(weaponLevel < stats.Count - 1)
        {
            weaponLevel++;

            statsUpdated = true;
        }
    }
    
}
[System.Serializable]
public class WeaponStats
{
    public float speed, damage, range, timeBetweenAttacks, amount, duration;
    
}
