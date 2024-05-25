using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyUnitsMovingState : EnemyUnitsBaseState
{
    public override void EnterState(EnemyUnitsStateManager unit)
    {
        Debug.Log("Moving State");
    }

    public override void UpdateState(EnemyUnitsStateManager unit)
    {
        Moving(unit);
        SearchingUnits(unit);
    }

    public override void OnCollisionEnter2D(EnemyUnitsStateManager unit)
    {
        
    }

    void Moving(EnemyUnitsStateManager unit)
    {
        unit.transform.Translate(-baseData.movingSpeed * Time.deltaTime, 0, 0);
    }
    void SearchingUnits(EnemyUnitsStateManager unit)
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

