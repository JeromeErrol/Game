using System;

public class TimedEvent:IEventListener
{
		public float time;
		public float totalTime;
		public bool loop;

		public TimedEvent (Action action, float totalTime, bool loop):base(action)
		{
				this.totalTime = totalTime;
				this.loop = loop;
				this.time = 0;
		}

		public override bool EventTriggered ()
		{
				time++;
				if (time > totalTime) {
						if (loop) {
								time = 0;
						}
						return true;
				}
				return false;					
		}
}

