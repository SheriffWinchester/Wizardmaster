using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUnitsMovingState : PlayerUnitsBaseState
{
    public override void EnterState(PlayerUnitsStateManager unit)
    {
        Debug.Log("Moving State");
    }

    public override void UpdateState(PlayerUnitsStateManager unit, UnitBaseData baseData)
    {
        Moving(unit, baseData);
        SearchingUnits(unit, baseData);
    }

    public override void OnCollisionEnter2D(PlayerUnitsStateManager unit)
    {
        
    }

    void Moving(PlayerUnitsStateManager unit, UnitBaseData baseData)
    {
        unit.transform.Translate(baseData.movingSpeed * Time.deltaTime, 0, 0);
    }

    void SearchingUnits(PlayerUnitsStateManager unit, UnitBaseData baseData)
    {
        LayerMask enemyLayer = LayerMask.GetMask("EnemyUnit"); // Set this to the layer of your enemy units

        Collider2D enemyInRange = Physics2D.OverlapCircle(unit.transform.position, baseData.searchRadius, layerMask: enemyLayer);
        Debug.Log("Enemy in range: " + enemyLayer.value);
        if (enemyInRange != null)
        {
            Debug.Log("Enemy found: " + enemyInRange.gameObject.name);
            unit.TargetEnemy = enemyInRange.gameObject;
            unit.SwitchState(unit.ChasingState);
        }
    }
}

