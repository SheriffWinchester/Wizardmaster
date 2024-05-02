using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit1 : MonoBehaviour
{
    public UnitData unitData;

    private void OnEnable()
    {
        unitData.myObject = gameObject;
    }

    void Update()
    {
        
    }

    private void OnDisable()
    {
        unitData.ResetData();
    }

}
