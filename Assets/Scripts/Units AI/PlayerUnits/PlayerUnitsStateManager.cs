using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUnitsStateManager : MonoBehaviour
{
    public Unit1Data unitData;
    public GameObject TargetEnemy { get; set; }
    PlayerUnitsBaseState currentState;
    public PlayerUnitsMovingState MovingState = new PlayerUnitsMovingState();
    public PlayerUnitsChasingState ChasingState = new PlayerUnitsChasingState();
    public PlayerUnitsAttackState AttackState = new PlayerUnitsAttackState();

    void Start()
    {
        currentState = MovingState;
        currentState.EnterState(this);
    }

    void Update()
    {
        currentState.UpdateState(this);
    }

    public void SwitchState(PlayerUnitsBaseState state)
    {
        currentState = state;
        currentState.EnterState(this);
    }
}
