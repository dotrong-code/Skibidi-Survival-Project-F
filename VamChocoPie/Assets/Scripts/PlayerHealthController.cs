using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthController : MonoBehaviour
{
    public static PlayerHealthController instance;

    private void Awake()
    {
        instance = this;
    }
    public float currentHealth, maxHealth;

    public Slider sliderHealth;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;

        sliderHealth.maxValue = maxHealth;
        sliderHealth.value = currentHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.T))
        {
            TakeDamage(10f);
        }
    }

    public void TakeDamage(float damageToTake)
    {
        currentHealth -= damageToTake;

        if (currentHealth <= 0)
        {
            gameObject.SetActive(false);

        }
        sliderHealth.value = currentHealth;
    }
}
