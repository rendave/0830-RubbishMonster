using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System;

public class SaveAndLoad : MonoBehaviour {

	void Awake(){
		loadData ();
	}

	void onDestroy(){
		saveData ();
	}

	public void saveData(){
		BinaryFormatter bf = new BinaryFormatter ();
		FileStream filePet = File.Create (Application.persistentDataPath + "/Pets.dat");
		bf.Serialize (filePet, Pets.pets);
		filePet.Close ();
	}

	public void loadData(){
		BinaryFormatter bf = new BinaryFormatter ();
		if(File.Exists(Application.persistentDataPath + "/Pets.dat")){
			FileStream filePet = File.Open(Application.persistentDataPath + "/Pets.dat",FileMode.Open);
			Pets.pets = (Pets)bf.Deserialize (filePet);
			filePet.Close ();
		}
	}
}
