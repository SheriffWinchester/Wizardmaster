using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EnemyUnitsBaseState
{
    public UnitBaseData baseData;
    public abstract void EnterState(EnemyUnitsStateManager unit);
    public abstract void UpdateState(EnemyUnitsStateManager unit);
    public abstract void OnCollisionEnter2D(EnemyUnitsStateManager unit);

}
