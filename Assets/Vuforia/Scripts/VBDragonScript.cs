using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using UnityStandardAssets.CrossPlatformInput;
public class VBDragonScript : MonoBehaviour, IVirtualButtonEventHandler {
	private GameObject VButtonObject;
	private GameObject dragon;
	private Animation dragonAnimation;
	// Use this for initialization
	void Start () {
		VButtonObject = GameObject.Find ("VirtualButtonDragon");
		VButtonObject.GetComponent<VirtualButtonBehaviour> ().RegisterEventHandler(this);

		dragon = GameObject.Find ("Mountain Dragon");
		dragonAnimation = dragon.GetComponent<Animation> ();

	}

	public void OnButtonPressed(VirtualButtonAbstractBehaviour vb){
		dragonAnimation.Play ("4leg3HitComboTailAttack");
		Debug.Log ("Pressed");
	}
	public void OnButtonReleased(VirtualButtonAbstractBehaviour vb){
//		dragonAnimation.Stop ();
		Debug.Log ("UNPRESSED");
	}
}
