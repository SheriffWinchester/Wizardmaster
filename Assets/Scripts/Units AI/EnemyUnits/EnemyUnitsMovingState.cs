using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyUnitsMovingState : EnemyUnitsBaseState
{
    public override void EnterState(EnemyUnitsStateManager unit)
    {
        Debug.Log("Moving State");
    }

    public override void UpdateState(EnemyUnitsStateManager unit, UnitBaseData baseData)
    {
        Moving(unit, baseData);
        SearchingUnits(unit, baseData);
    }

    public override void OnCollisionEnter2D(EnemyUnitsStateManager unit)
    {
        
    }

    void Moving(EnemyUnitsStateManager unit, UnitBaseData baseData)
    {
        unit.transform.Translate(-baseData.movingSpeed * Time.deltaTime, 0, 0);
    }
    void SearchingUnits(EnemyUnitsStateManager unit, UnitBaseData baseData)
    {
        LayerMask enemyLayer = LayerMask.GetMask("PlayerUnit"); // Set this to the layer of your enemy units

        Collider2D enemyInRange = Physics2D.OverlapCircle(unit.transform.position, baseData.searchRadius, layerMask: enemyLayer);
        Debug.Log("Unit in range: " + enemyLayer.value);
        if (enemyInRange != null)
        {
            Debug.Log("Unit found: " + enemyInRange.gameObject.name);
            unit.TargetEnemy = enemyInRange.gameObject;
            unit.SwitchState(unit.ChasingState);
        }
    }
}

