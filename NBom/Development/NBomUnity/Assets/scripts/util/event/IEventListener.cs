using System;

public abstract class IEventListener
{		
		public Action action;

		public IEventListener (Action action)
		{
				this.action = action;
		}

		public abstract bool EventTriggered ();

		public void Listen ()
		{
				if (EventTriggered ()) {
						action.Invoke ();
				}
		}				
}


