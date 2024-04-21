using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitsMovingState : UnitsBaseState
{
    public override void EnterState(UnitsStateManager unit)
    {
        Debug.Log("Moving State");
    }

    public override void UpdateState(UnitsStateManager unit)
    {
        float searchRadius = 3f; // Set this to the radius of your search area
        LayerMask enemyLayer = LayerMask.GetMask("EnemyUnit"); // Set this to the layer of your enemy units

        Collider2D enemyInRange = Physics2D.OverlapCircle(unit.transform.position, searchRadius, layerMask: enemyLayer);
        Debug.Log("Enemy in range: " + enemyLayer.value);
        if (enemyInRange != null)
        {
            Debug.Log("Enemy found: " + enemyInRange.gameObject.name);
            unit.TargetEnemy = enemyInRange.gameObject;
            unit.SwitchState(unit.ChasingState);
        }
    }

    public override void OnCollisionEnter2D(UnitsStateManager unit)
    {
        
    }
}

