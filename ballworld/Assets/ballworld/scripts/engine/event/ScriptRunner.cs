using UnityEngine;
using System.Collections;

public class ScriptRunner : MonoBehaviour {

    private GameEvent shutdownEvent;
    private static ScriptRunner instance;

    public string applicationQuitCommand = "APPLICATION.QUIT()";

    void Start()
    {
        ScriptRunner.instance = this;
        shutdownEvent = gameObject.AddComponent<ApplicationQuit>();
    }
	
    public void run(string code)
    {
        if (code.StartsWith(applicationQuitCommand))
        {
            shutdownEvent.happen();
        }
    }

    public static void Run(string code)
    {
        instance.run(code);
    }
}
