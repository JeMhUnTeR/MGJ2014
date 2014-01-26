using UnityEngine;
using System.Collections;

public class PlayerColorManager : MonoBehaviour {

	public Material PlayerMat;

	public enum PlayerColor { // so this shouldn't be here
		Red,
		Green,
		Blue
	}

	void Update () {
		// change player color based on outside variable player color
		// where the hell will the player color state come from
	}
}
