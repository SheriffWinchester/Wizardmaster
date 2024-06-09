using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyUnitsAttackState : EnemyUnitsBaseState
{
    // void OnEnable()
    // {
    //     EventManager.Attack += 
    // }
    // void OnDisable()
    // {
    //     EventManager.Attack -= 
    // }

    public float attackDelay = 1.0f; // Time delay between spawns
    private float nextAttackTime;
    public override void EnterState(EnemyUnitsStateManager unit)
    {
       Debug.Log("Attack State");
    }

    public override void UpdateState(EnemyUnitsStateManager unit, UnitsBaseData baseData)
    {
        if (Time.time > nextAttackTime)
        {
            unit.targetUnit.GetComponent<PlayerUnitsStateManager>().unit1Controller.health -= 10;
            nextAttackTime = Time.time + attackDelay;
        }
        if (unit.targetUnit == null)
        {
            unit.SwitchState(unit.MovingState);
        }
    }

    void SearchingUnits(EnemyUnitsStateManager unit, UnitsBaseData baseData)
    {
        LayerMask unitLayer = LayerMask.GetMask("PlayerUnit"); // Set this to the layer of your enemy units

        Collider2D unitInRange = Physics2D.OverlapCircle(unit.transform.position, baseData.searchRadius, layerMask: unitLayer);
        Debug.Log("Unit in range: " + unitLayer.value);
        if (unitInRange != null)
        {
            Debug.Log("Unit found: " + unitInRange.gameObject.name);
            unit.targetUnit = unitInRange.gameObject;
            unit.SwitchState(unit.MovingState);
        }
    }

    public override void OnCollisionEnter2D(EnemyUnitsStateManager unit)
    {
    
    }

    void Attack()
    {

    }
}

