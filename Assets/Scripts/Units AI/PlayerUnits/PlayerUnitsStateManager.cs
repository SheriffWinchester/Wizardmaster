using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUnitsStateManager : MonoBehaviour
{
    public GameObject TargetEnemy { get; set; }
    PlayerUnitsBaseState currentState;
    public UnitBaseData baseData;
    public static PlayerUnitsMovingState MovingState;
    public static PlayerUnitsChasingState ChasingState;
    public static PlayerUnitsAttackState AttackState;

    void Start()
    {
        currentState = PlayerUnitsStateManager.MovingState;
        currentState.EnterState(this);
    }

    void Update()
    {
        currentState.UpdateState(this, baseData);
    }

    public void SwitchState(PlayerUnitsBaseState state)
    {
        currentState = state;
        currentState.EnterState(this);
    }
}
