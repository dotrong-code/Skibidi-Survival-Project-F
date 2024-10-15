using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class UIController : MonoBehaviour
{
    public static UIController instance;
    // Start is called before the first frame update

    private void Awake()
    {
        instance = this;
    }

    public Slider explvlSlider;
    public TMP_Text explvlText;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateExperience(int currentExp, int levelExp, int currentLvl)
    {
        explvlSlider.maxValue = levelExp;
        explvlSlider.value = currentExp;
        explvlText.text = "Level:" + currentLvl;
    }
}
