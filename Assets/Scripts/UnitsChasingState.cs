using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitsChasingState : UnitsBaseState
{
    public override void EnterState(UnitsStateManager unit)
    {
        Debug.Log("Chasing State");
    }

    public override void UpdateState(UnitsStateManager unit)
    {
        if (unit.TargetEnemy != null)
        {
            float speed = 5f; // Set this to your unit's speed
            Vector3 direction = (unit.TargetEnemy.transform.position - unit.transform.position).normalized;
            unit.transform.position += direction * speed * Time.deltaTime;
        }
        else
        {
            // If there's no target enemy, you might want to switch back to a default state
            unit.SwitchState(unit.MovingState);
        }
    }

    public override void OnCollisionEnter2D(UnitsStateManager unit)
    {
        
    }
}

