public interface IUnits
{
   public void MoveUnit();
   public void SearchUnit();
   public void ChaseUnit();
   public void AttackUnit();
}

public enum UnitState
{
    Moving,
    Chasing,
    Attack
}
