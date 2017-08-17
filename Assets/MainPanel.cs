using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MainPanel : MonoBehaviour {

	public Button button_U_L;
	public Button button_U_R;
	public Button button_D_L;
	public Button button_D_R;

	public PopupPanel popupPanel;

	// Use this for initialization
	void Start () {
		button_U_L.Select();
		Button[] buttons = new [] { button_U_L, button_U_R, button_D_L, button_D_R };
		foreach(var button in buttons)
		{
			button.onClick.AddListener (()=>{
				popupPanel.gameObject.SetActive(true);
				popupPanel.centerButton.Select();
				popupPanel.onDisable.AddListener(()=>{
					button_U_L.Select();
				});
			});
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
