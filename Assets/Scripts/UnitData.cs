using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "UnitData", menuName = "Unit Data")]
public class UnitData : ScriptableObject 
{
    [SerializeField] float defaultHealth=100;
    [SerializeField] float defaultMagic=100;

    private float health;
    private float magic;

    [HideInInspector] public GameObject myObject;

    public void ResetData()
    {
        myObject = null;

        health = defaultHealth;
        magic = defaultMagic;

    }
}
