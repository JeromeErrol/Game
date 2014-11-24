using NUnit.Framework;
using System;
using System.Collections;
using GameUtil2D;

namespace Testing
{
		[TestFixture()]
		public class MathUtil2DTest
		{
				[Test()]	
				public void RoundOff_OneToZero ()
				{
						Assert.AreEqual (0, Math2DUtil.RoundOff (1, 10));
				}
		
				[Test()]	
				public void RoundOff_NineToTen ()
				{
						Assert.AreEqual (10, Math2DUtil.RoundOff (9, 10));
				}
		}


}

