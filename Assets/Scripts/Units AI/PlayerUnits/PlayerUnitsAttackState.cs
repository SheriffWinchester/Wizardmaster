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
    public override void EnterState(PlayerUnitsStateManager unit)
    {
       Debug.Log("Attack State");
    }

    public override void UpdateState(PlayerUnitsStateManager unit)
    {
        
    }

    public override void OnCollisionEnter2D(PlayerUnitsStateManager unit)
    {
    
    }

    void Attack()
    {

    }
}

