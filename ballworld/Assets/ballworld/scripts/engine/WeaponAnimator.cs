
public class WeaponAnimator : Anim
{

    public void idle()
    {
        state = 0;     
     //   animator.Play("sword-idle");  
    }

    public void drawn()
    {
        state = 1;
   //     animator.Play("sword-drawn");
    }

    public void releasing()
    {
            state = 2;
        if (!animator.GetCurrentAnimatorStateInfo(0).IsName("sword-attacking"))
        {
            //Do something if this particular state is palying
          //  animator.Play("sword-attacking");
        }
       
    }
}