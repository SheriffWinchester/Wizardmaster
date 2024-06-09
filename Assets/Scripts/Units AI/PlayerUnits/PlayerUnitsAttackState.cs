using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUnitsAttackState : PlayerUnitsBaseState
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
    public override void EnterState(PlayerUnitsStateManager unit)
    {
       Debug.Log("Attack State");
    }

    public override void UpdateState(PlayerUnitsStateManager unit, UnitsBaseData baseData)
    {
        if (Time.time > nextAttackTime)
        {
            unit.targetEnemy.GetComponent<EnemyUnitsStateManager>().unit1Controller.health -= 10;
            nextAttackTime = Time.time + attackDelay;
        }
        if (unit.targetEnemy == null)
        {
            unit.SwitchState(unit.MovingState);
        }
    }

    void SearchingUnits(PlayerUnitsStateManager unit, UnitsBaseData baseData)
    {
        LayerMask enemyLayer = LayerMask.GetMask("EnemyUnit"); // Set this to the layer of your enemy units

        Collider2D enemyInRange = Physics2D.OverlapCircle(unit.transform.position, baseData.searchRadius, layerMask: enemyLayer);
        Debug.Log("Enemy in range: " + enemyLayer.value);
        if (enemyInRange != null)
        {
            Debug.Log("Enemy found: " + enemyInRange.gameObject.name);
            unit.targetEnemy = enemyInRange.gameObject;
            unit.SwitchState(unit.MovingState);
        }
    }

    public override void OnCollisionEnter2D(PlayerUnitsStateManager unit)
    {
    
    }

    void Attack()
    {

    }
}

