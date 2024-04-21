using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class UnitsBaseState
{
    public abstract void EnterState(UnitsStateManager unit);
    public abstract void UpdateState(UnitsStateManager unit);
    public abstract void OnCollisionEnter2D(UnitsStateManager unit);

}
