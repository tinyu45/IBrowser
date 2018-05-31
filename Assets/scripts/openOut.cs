using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class openOut : MonoBehaviour {

	public InputField address;
	public Button open;

	// Use this for initialization
	void Start () {
		open.onClick.AddListener(delegate {
			this.Open(address.text.Trim());
		});
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	/***
	 * 打开网页
	 *
	 *
	 ***/
	public void Open(string address)
	{
		Application.OpenURL (address);		
	}


	//跳转至浏览器打开
	//跳转至浏览器打开
	//跳转至浏览器打开
	//跳转至浏览器打开
	//跳转至浏览器打开
	//跳转至浏览器打开
}
