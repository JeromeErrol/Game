
public class Bow : Weapon {

    public Arrow arrow;

    public override void released()
    {
        Arrow releasedArrow = Instantiate(arrow);
        releasedArrow.transform.parent = ArrowPool.instance.transform;
        releasedArrow.transform.position = transform.position;
        releasedArrow.transform.rotation = transform.rotation;
        releasedArrow.GetComponent<Hitbox>().owner = transform.parent.gameObject;
    }
}
