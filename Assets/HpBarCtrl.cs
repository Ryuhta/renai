using UnityEngine;
using System.Collections;
using UnityEngine.UI; // ←※これを忘れずに入れる

public class HpBarCtrl: MonoBehaviour {

	Slider _slider;
	void Start () {
		// スライダーを取得する
		_slider = GameObject.Find("Slider").GetComponent<Slider>();
	}

	float _hp = 0;
	void Update () {
		// HP上昇
		_hp += 0.01f;
		if(_hp > 1) {
			// 最大を超えたら0に戻す
			_hp = 0;
		}

		// HPゲージに値を設定
		_slider.value = _hp;
	}
}