using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUnitsChasingState : PlayerUnitsBaseState
{
    public override void EnterState(PlayerUnitsStateManager unit)
    {
        Debug.Log("Chasing State");
    }

    public override void UpdateState(PlayerUnitsStateManager unit)
    {
        if (unit.TargetEnemy != null)
        {
            Vector3 direction = (unit.TargetEnemy.transform.position - unit.transform.position).normalized;
            unit.transform.position += direction * baseData.movingSpeed * Time.deltaTime;
        }
        else
        {
            // If there's no target enemy, you might want to switch back to a default state
            unit.SwitchState(unit.MovingState);
        }
    }

    public override void OnCollisionEnter2D(PlayerUnitsStateManager unit)
    {
        
    }
}

