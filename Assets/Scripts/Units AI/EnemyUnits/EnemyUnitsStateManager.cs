using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyUnitsStateManager : MonoBehaviour
{
    public GameObject targetUnit { get; set; }
    EnemyUnitsBaseState currentState;
    public UnitsBaseData baseData;
    public EnemyUnitsMovingState MovingState = new EnemyUnitsMovingState();
    public EnemyUnitsChasingState ChasingState = new EnemyUnitsChasingState();
    public EnemyUnitsAttackState AttackState = new EnemyUnitsAttackState();
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

    public void SwitchState(EnemyUnitsBaseState state)
    {
        currentState = state;
        currentState.EnterState(this);
    }
}
