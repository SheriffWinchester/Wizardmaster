using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyUnitsMovingState : EnemyUnitsBaseState
{
    public override void EnterState(EnemyUnitsStateManager unit)
    {
        Debug.Log("Moving State");
    }

    public override void UpdateState(EnemyUnitsStateManager unit, UnitsBaseData baseData)
    {
        Moving(unit, baseData);
        SearchingUnits(unit, baseData);
    }

    public override void OnCollisionEnter2D(EnemyUnitsStateManager unit)
    {
        
    }

    void Moving(EnemyUnitsStateManager unit, UnitsBaseData baseData)
    {
        unit.transform.Translate(-baseData.movingSpeed * Time.deltaTime, 0, 0);
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
            unit.SwitchState(unit.ChasingState);
        }
    }
}

