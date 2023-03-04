using arena.core.attacker;
using arena.core.types;

namespace arena.core.building
{
  public class Building
  {
    public int range { get; set; }
    public TeamType team { get; set; }

    public Building() { }

    public virtual void attack() { }
  }

  public class MasterBuilding : Building
  {
    public override void attack()
    {
    }

    public void healing()
    {

    }
  }
}