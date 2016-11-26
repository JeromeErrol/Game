
public class WeaponAnimator : Anim
{

    public void idle()
    {
        state = 0;
      //  animator.Play("sword-idle");  
    }

    public void drawn()
    {
        state = 1;
    }

    public void releasing()
    {
        state = 2;
    }
}