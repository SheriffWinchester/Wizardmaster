using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarUI : MonoBehaviour
{
    [SerializeField] private Slider slider;
    public Unit1Controller unit;
    private float currentHealth;
    public UnitsBaseData unitsBaseData;
    // Update is called once per frame
    void Update()
    {
        currentHealth = unit.health;
        slider.value = currentHealth / unitsBaseData.defaultHealth;
        Debug.Log("Health: " + currentHealth);
        Debug.Log("Max Health: " + unitsBaseData.defaultHealth);
    }
}
