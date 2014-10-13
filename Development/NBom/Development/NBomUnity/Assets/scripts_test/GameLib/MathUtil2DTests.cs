using UnityEngine;
using System.Collections;
using GameUtil2D;
using System;
using System.Collections.Generic;

public class MathUtil2DTests : MonoBehaviour
{
	float lineX;
	float lineY;
	float width = 300;
	float height = 30;

	float NextLine{
		get{
			float value = lineY;
			lineY += height;
			return value;
		}
	}

	void OnGUI(){
		lineX = 0;
		lineY = 0;

		if (GUI.Button (new Rect (0, NextLine, 120, 30), "Run Tests")) {
			RunAllTests();
		}	
		int testCount = TestUtil2D.TestCount;
		List<TestResult> passed = TestUtil2D.SuccessfulTests;
		List<TestResult> failed = TestUtil2D.FailedTests;
		WriteLine ("Passed:" + passed.Count + "/" + testCount);
		WriteLine ("Failed:" + failed.Count + "/" + testCount);

		foreach (TestResult result in failed) {
			WriteLine(result.testName + ": " + result.message);
		}
	}

	void WriteLine(string message){
		GUI.Box (new Rect (lineX, NextLine, width, height),	message);
	}

	public void RunAllTests(){
		TestUtil2D.ClearResults();
		RoundOff_NineToTen ();
		RoundOff_OneToZero ();
		RoundOff_NineToTen ();
		RoundOff_FourToFive ();
		RoundOff_SixToFive ();
		RoundOff_EightToTen ();
		RoundOff_ZeroToZero ();
		RoundOff_FiveToFive ();
		RoundOff_MinusOneToZero ();
		RoundOff_MinusFourToMinusFive ();
		RoundOff_MinusSixToMinusFive ();
		RoundOff_TwelveToTen ();
		RoundOff_MinusTwentyNineToThirty ();
	}
	
	public void RoundOff_OneToZero(){
		TestUtil2D.AssertEquals ("RoundOff_OneToZero", 0, MathUtil2D.RoundOff (1, 10));
	}

	public void RoundOff_NineToTen(){
		TestUtil2D.AssertEquals ("RoundOff_NineToTen", 10, MathUtil2D.RoundOff  (9, 10));
	}

	public void RoundOff_FourToFive(){
		TestUtil2D.AssertEquals ("RoundOff_FourToFive", 5, MathUtil2D.RoundOff  (4, 5));
	}

	public void RoundOff_SixToFive(){
		TestUtil2D.AssertEquals ("RoundOff_FourToFive", 5, MathUtil2D.RoundOff  (6, 5));
	}

	public void RoundOff_EightToTen(){
		TestUtil2D.AssertEquals ("RoundOff_FourToFive", 10, MathUtil2D.RoundOff  (8, 5));
	}

	public void RoundOff_ZeroToZero(){
		TestUtil2D.AssertEquals ("RoundOff_FourToFive", 0, MathUtil2D.RoundOff  (0, 5));
	}

	public void RoundOff_FiveToFive(){
		TestUtil2D.AssertEquals ("RoundOff_FourToFive", 5, MathUtil2D.RoundOff  (5, 5));
	}

	public void RoundOff_MinusOneToZero(){
		TestUtil2D.AssertEquals ("RoundOff_FourToFive", 0, MathUtil2D.RoundOff  (-1, 5));
	}

	public void RoundOff_MinusFourToMinusFive(){
		TestUtil2D.AssertEquals ("RoundOff_FourToFive", -5, MathUtil2D.RoundOff  (-4, 5));
	}

	public void RoundOff_MinusSixToMinusFive(){
		TestUtil2D.AssertEquals ("RoundOff_FourToFive", -5, MathUtil2D.RoundOff  (-6, 5));
	}

	public void RoundOff_TwelveToTen(){
		TestUtil2D.AssertEquals ("RoundOff_FourToFive", 10, MathUtil2D.RoundOff  (12, 5));
	}

	public void RoundOff_MinusTwentyNineToThirty(){
		TestUtil2D.AssertEquals ("RoundOff_FourToFive", -30, MathUtil2D.RoundOff  (-29, 5));
	}
}

