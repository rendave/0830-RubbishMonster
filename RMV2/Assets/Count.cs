using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Count : MonoBehaviour {
	public float currentCount { get; set; }
	public float maxCount { get; set; }

	public Button claim;
	public Text max;
	public Slider countBar;
	public Text setCurrent;
	public Text counter;

	// Use this for initialization
	void Start () {
		currentCount = float.Parse(setCurrent.text);
		maxCount = float.Parse (max.text);
		countBar.value = CalculateExp();

		claim.enabled = false;
		counter.text = currentCount+"/"+maxCount;
		checkComplete ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.X))
			addExp(1);
	}

	float CalculateExp()
	{
		return currentCount / maxCount;
	}

	void addExp(float value)
	{
		if (currentCount < maxCount) {
			currentCount += value;
			countBar.value = CalculateExp();
			counter.text = currentCount+"/"+maxCount;

			checkComplete ();
		}
	}

	void checkComplete() {
		if (currentCount == maxCount)
			claimReward();
	}

	void claimReward()
	{
		claim.enabled = true;
		Debug.Log("You can now claim your reward!");

	}
}
