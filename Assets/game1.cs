using UnityEngine;
using System.Collections;

public class game1 : MonoBehaviour {
	//文字を書く場所を指定
	public Rect zahyou = new Rect(0,0,100,50);
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
	//GUI更新イベントが有ると勝手に呼ばれる
	void OnGUI()
	{
		GUI.Label(zahyou,"にゃーん");   //文字を書く
	}
}