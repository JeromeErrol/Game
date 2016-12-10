
public class Sword : Weapon
{
    public Hitbox hitbox;

    public override void released()
    {
        hitbox.force = force;
    }
}
