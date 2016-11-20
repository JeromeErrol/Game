using UnityEngine;

public class GameUtil
{    
    public static T Get<T>(Transform transform)
    {
        T type = transform.GetComponent<T>();
        
        if(type == null)
        {
            for (int i = 0; i < transform.childCount; i++)
            {
                type = Get<T>(transform.GetChild(i));
                if (type != null)
                {
                    return type;
                }
            }
        }      
        return default(T);
    }
}

