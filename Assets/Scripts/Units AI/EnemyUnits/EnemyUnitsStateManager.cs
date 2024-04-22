using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyUnitsStateManager : MonoBehaviour
{
    public GameObject TargetEnemy { get; set; }
    EnemyUnitsBaseState currentState;
    public EnemyUnitsMovingState MovingState = new EnemyUnitsMovingState();
    public EnemyUnitsChasingState ChasingState = new EnemyUnitsChasingState();
    public EnemyUnitsAttackState AttackState = new EnemyUnitsAttackState();

    void Start()
    {
        currentState = MovingState;
        currentState.EnterState(this);
    }

    void Update()
    {
        currentState.UpdateState(this);
    }

    public void SwitchState(EnemyUnitsBaseState state)
    {
        currentState = state;
        currentState.EnterState(this);
    }
}
