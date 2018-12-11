using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Pets{
	public static Pets pets = new Pets();
	public string name{ set; get; }
	public int level{ set; get; }
	public double progress{ set; get;}

	private Pets(){
		name = "";
		level = 1;
		progress = 0;
	}
}
