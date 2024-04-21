using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit1 : MonoBehaviour, IUnits
{
    public UnitState unitState;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (unitState)
        {
            case UnitState.Moving:
                MoveUnit();
                break;

            case UnitState.Chasing:
                ChaseUnit();
                break;

            case UnitState.Attack:
                AttackUnit();
                break;
        }
    }
    public void MoveUnit()
    {
        
    }
    public void SearchUnit()
    {

    }
    public void ChaseUnit()
    {

    }
    public void AttackUnit()
    {

    }

}

// public enum UnitState
// {
//     Moving,
//     Chasing,
//     Attack
// }
