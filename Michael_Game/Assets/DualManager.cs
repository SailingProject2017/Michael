using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DualManager : MonoBehaviour {

    [SerializeField]
    GameObject gameObjects;
	// Use this for initialization
	void Start () {
        //PhotonNetwork.isMessageQueueRunning = true;
        GameObject gameObject = PhotonNetwork.Instantiate("Menber", new Vector3(0, 0, 0), Quaternion.Euler(Vector3.zero),0);

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
