using arena.core.attacker;
using arena.core.types;

namespace arena.core.attacker
{
  public class Hero : AttackerBase
  {
    public static int N_SKILLS { get; private set; } = 3;
    public HeroGroup group { get; set; }
    public HeroType type { get; set; }
    public HeroSkill[] skills { get; set; } = new HeroSkill[N_SKILLS];

    public override void move() { }
    public override void normal_attack() { }
    public override void healing() { }
    public override void death() { }

    public void skill_attack() { }
  }
}