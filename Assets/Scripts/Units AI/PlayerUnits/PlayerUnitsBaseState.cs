using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayerUnitsBaseState
{
    public UnitBaseData baseData;
    public abstract void EnterState(PlayerUnitsStateManager unit);
    public abstract void UpdateState(PlayerUnitsStateManager unit);
    public abstract void OnCollisionEnter2D(PlayerUnitsStateManager unit);

}
