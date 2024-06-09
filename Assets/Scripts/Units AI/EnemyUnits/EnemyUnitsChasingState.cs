using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyUnitsChasingState : EnemyUnitsBaseState
{
    public override void EnterState(EnemyUnitsStateManager unit)
    {
        Debug.Log("Chasing State");
    }

    public override void UpdateState(EnemyUnitsStateManager unit, UnitsBaseData baseData)
    {
        if (unit.targetUnit != null)
        {
            Vector3 direction = (unit.targetUnit.transform.position - unit.transform.position).normalized;
            unit.transform.position += direction * baseData.movingSpeed * Time.deltaTime;

            SearchAndAttack(unit, baseData);
        }
        else
        {
            // If there's no target enemy, you might want to switch back to a default state
            unit.SwitchState(unit.MovingState);
        }
    }

    void SearchAndAttack(EnemyUnitsStateManager unit, UnitsBaseData baseData)
    {
        LayerMask unitLayer = LayerMask.GetMask("PlayerUnit"); // Set this to the layer of your enemy units

        Collider2D unitInRange = Physics2D.OverlapCircle(unit.transform.position, baseData.searchAttackRadius, layerMask: unitLayer);
        Debug.Log("Unit in range: " + unitLayer.value);
        if (unitInRange != null)
        {
            Debug.Log("Unit found: " + unitInRange.gameObject.name);
            unit.targetUnit = unitInRange.gameObject;
            unit.SwitchState(unit.AttackState);
        }
    }

    public override void OnCollisionEnter2D(EnemyUnitsStateManager unit)
    {
        
    }
}

