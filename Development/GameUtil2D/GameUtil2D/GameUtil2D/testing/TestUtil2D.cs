using UnityEngine;
using System.Collections.Generic;
using System;

namespace GameUtil2D
{
		public static class TestUtil2D
		{
				private static List<TestResult> tests = new List<TestResult> ();

				public static void ClearResults ()
				{
						tests.Clear ();
				}

				public static int TestCount {
						get {
								return tests.Count;
						}
				}

				public static void OutputResults ()
				{
						Console.Write ("Hello world");
				}

				public static void AssertTrue (string testName, bool value)
				{
						TestResult result = new TestResult (testName, false, testName + " expected true");
						tests.Add (result);
				}

				public static void AssertEquals (string testName, float expected, float actual)
				{
						TestResult result = new TestResult (testName, expected == actual, "Expected:" + expected + " Actual:" + actual);
						tests.Add (result);
				}

				public static List<TestResult> FailedTests {
						get {
								return GetTests (false);			
						}
				}

				public static List<TestResult> SuccessfulTests {
						get {
								return GetTests (true);			
						}
				}

				public static List<TestResult> GetTests (bool pass)
				{
						List<TestResult> testResults = new List<TestResult> (); 
						foreach (TestResult test in tests) {
								if (test.result == pass) {
										testResults.Add (test);
								}
						}
						return testResults;	
				}
		}		
}

