using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit1Main : MonoBehaviour
{
    public GameObject unitPrefab;
    public Unit1Data unitData;
    public float health;

    public void Start()
    {
        health = unitData.defaultHealth;
    }
    public GameObject CreateUnit(Unit1Data unit)
    {
        GameObject newUnit = Instantiate(unitPrefab, new Vector3(-4, 2, 0), Quaternion.identity);
        // Set the properties of the new unit using the properties of the Unit ScriptableObject
        // For example:
        // newUnit.GetComponent<UnitComponent>().health = unit.health;
        return newUnit;
    }

}
