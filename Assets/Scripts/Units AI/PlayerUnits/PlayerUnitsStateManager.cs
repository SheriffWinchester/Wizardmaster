using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUnitsStateManager : MonoBehaviour
{
    public GameObject targetEnemy { get; set; }
    PlayerUnitsBaseState currentState;
    public UnitsBaseData baseData;
    public PlayerUnitsMovingState MovingState = new PlayerUnitsMovingState();
    public PlayerUnitsChasingState ChasingState = new PlayerUnitsChasingState();
    public PlayerUnitsAttackState AttackState = new PlayerUnitsAttackState();
    public Unit1Controller unit1Controller;

    void Start()
    {
        currentState = MovingState;
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
