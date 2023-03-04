using System.Collections;
using System.Collections.Generic;
using arena.core.types;

namespace arena.core.attacker
{
  public abstract class AttackerBase
  {
    public string name { get; set; }
    public TeamType team { get; set; }
    public int max_health { get; set; }
    public int health { get; set; }
    public int health_speed { get; set; }
    public int speed { get; set; }
    public int atk { get; set; }
    public int def { get; set; }
    public float atk_speed { get; set; }
    public AttackRange atk_range { get; set; }
    public float crit { get; set; }
    public float counter_effect { get; set; }
    public List<StatusType> statuses { get; set; }

    public AttackerBase() { }
    public abstract void move();
    public abstract void normal_attack();
    public abstract void healing();
    public abstract void death();
  }
}