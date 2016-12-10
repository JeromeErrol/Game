using UnityEngine;

public class ApplicationQuit : GameEvent {
    public override void happen()
    {
        Debug.Log("APPLICATION.QUITTING");
        Application.Quit();
    }
}
