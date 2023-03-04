using arena.core.attacker;
using arena.core.types;

namespace arena.core.attacker
{
  public class Solider : AttackerBase
  {
    public SoliderType type { get; set; }

    public override void move() { }
    public override void normal_attack() { }
    public override void healing() { }
    public override void death() { }
  }
}