using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExperienceLevelController : MonoBehaviour
{
    public static ExperienceLevelController instance;
    public int currentExperience;
    // Start is called before the first frame update

    public ExpPickup pickup;

    public List<int> expLevels;
    public int currentLevel =1, levelCount = 100;

    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        while (expLevels.Count < levelCount)
        {
            expLevels.Add(Mathf.CeilToInt(expLevels[expLevels.Count-1] * 1.1f));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GetExperience(int amountToGet)
    {
        currentExperience += amountToGet;

        if(currentExperience >= expLevels[currentLevel])
        {
            LevelUp();
        }
        UIController.instance.UpdateExperience(currentExperience, expLevels[currentLevel],currentLevel);
    } 

    public void SpawnExp(Vector3 position, int expValue)
    {
        Instantiate(pickup, position, Quaternion.identity).expValue = expValue;
    }

    void LevelUp()
    {
        currentExperience -= expLevels[currentLevel];
        currentLevel++;

        if(currentLevel >= expLevels.Count)
        {
            currentLevel = expLevels.Count - 1;
        }
        PlayerController.instance.activeWeapon.LevelUp();
    }
}
