using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "UnitData", menuName = "Unit Base Data")]
public class UnitBaseData : ScriptableObject 
{
    [SerializeField] public float defaultHealth=100;
    [SerializeField] public float defaultMagic=100;


    //public GameObject myObject;

    

}
