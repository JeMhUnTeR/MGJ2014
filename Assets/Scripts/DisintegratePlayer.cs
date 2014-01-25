using UnityEngine;
using System.Collections;


[RequireComponent(typeof(SkinnedMeshRenderer))]
public class DisintegratePlayer : MonoBehaviour {

	private bool disintegrating = false;

	void Update () {
		if (Input.GetKeyDown(KeyCode.Q)) Disintegrate();
		if (disintegrating) {
			float alpha = Mathf.Lerp(renderer.material.color.a, 0f, 2 * Time.deltaTime);
			renderer.material.color = new Vector4 (renderer.material.color.r, renderer.material.color.g, renderer.material.color.b, alpha);
		}
	}

	void Disintegrate () {
		if (particleSystem) particleSystem.Play();
		disintegrating = true;
	}
}
