using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "UnitData", menuName = "Unit Base Data")]
// This class is used to store the basic properties of all units
// Check Wizard object for correct references
public class UnitBaseData : ScriptableObject 
{
    [SerializeField] public float defaultHealth=100;
    [SerializeField] public float defaultMagic=100;

    public GameObject CreateUnit(GameObject unitPrefab)
    {
        GameObject newUnit = Instantiate(unitPrefab, new Vector3(-4, 2, 0), Quaternion.identity);
        return newUnit;
    }
}
