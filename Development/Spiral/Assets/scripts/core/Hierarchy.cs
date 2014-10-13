using UnityEngine;
using System.Collections;

public class Hierarchy 
{
	public static Hierarchy instance;
	public GameObject center;
	public GameObject patrol01;
	public GameObject patrol02;
	public GameObject patrol03;
	public GameObject patrol04;
	public GameObject patrol05;
	public GameObject patrol06;
	public GameObject patrol07;
	public GameObject patrol08;
	public GameObject patrol09;
	public GameObject patrol10;
	public GameObject patrol11;
	public GameObject patrol12;
	public GameObject patrol13;

	public Hierarchy(){
		instance = this;
		center = GameObject.Find ("Center");
		patrol01 = GameObject.Find("Patrol01");
		patrol02 = GameObject.Find("Patrol02");
		patrol03 = GameObject.Find("Patrol03");
		patrol04 = GameObject.Find("Patrol04");
		patrol05 = GameObject.Find("Patrol05");
		patrol06 = GameObject.Find("Patrol06");
		patrol07 = GameObject.Find("Patrol07");
		patrol08 = GameObject.Find("Patrol08");
		patrol09 = GameObject.Find("Patrol09");
		patrol10 = GameObject.Find("Patrol10");
		patrol11 = GameObject.Find("Patrol11");
		patrol12 = GameObject.Find("Patrol12");
		patrol13 = GameObject.Find("Patrol13");
	}		
}

