using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitsStateManager : MonoBehaviour
{
    public GameObject TargetEnemy { get; set; }
    UnitsBaseState currentState;
    public UnitsMovingState MovingState = new UnitsMovingState();
    public UnitsChasingState ChasingState = new UnitsChasingState();
    public UnitsAttackState AttackState = new UnitsAttackState();

    void Start()
    {
        currentState = MovingState;
        currentState.EnterState(this);
    }

    void Update()
    {
        currentState.UpdateState(this);
    }

    public void SwitchState(UnitsBaseState state)
    {
        currentState = state;
        currentState.EnterState(this);
    }
}
