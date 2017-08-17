using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Events;

public class PopupPanel : MonoBehaviour {

	public Button centerButton;
	public UnityEvent onDisable;

//	void OnEnable() {
//		centerButton.Select ();
//	}

	void OnDisable() {
		onDisable.Invoke ();
	}
	// Use this for initialization
	void Start () {
		centerButton.onClick.AddListener (() => {
			gameObject.SetActive (false);
		});
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
