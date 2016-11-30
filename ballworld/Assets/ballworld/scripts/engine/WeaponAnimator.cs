
public class WeaponAnimator : Anim
{
    public void idle()
    {
        state = 0;   
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