using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUnitsChasingState : PlayerUnitsBaseState
{
    public override void EnterState(PlayerUnitsStateManager unit)
    {
        Debug.Log("Chasing State");
    }

    public override void UpdateState(PlayerUnitsStateManager unit, UnitsBaseData baseData)
    {
        if (unit.targetEnemy != null)
        {
            Vector3 direction = (unit.targetEnemy.transform.position - unit.transform.position).normalized;
            unit.transform.position += direction * baseData.movingSpeed * Time.deltaTime;

            SearchAndAttack(unit, baseData);
        }
        else
        {
            // If there's no target enemy, you might want to switch back to a default state
            unit.SwitchState(unit.MovingState);
        }
    }

    void SearchAndAttack(PlayerUnitsStateManager unit, UnitsBaseData baseData)
    {
        LayerMask enemyLayer = LayerMask.GetMask("EnemyUnit"); // Set this to the layer of your enemy units

        Collider2D enemyInRange = Physics2D.OverlapCircle(unit.transform.position, baseData.searchAttackRadius, layerMask: enemyLayer);
        Debug.Log("Enemy in range: " + enemyLayer.value);
        if (enemyInRange != null)
        {
            Debug.Log("Enemy found: " + enemyInRange.gameObject.name);
            unit.targetEnemy = enemyInRange.gameObject;
            unit.SwitchState(unit.AttackState);
        }
    }

    public override void OnCollisionEnter2D(PlayerUnitsStateManager unit)
    {
        
    }
}

