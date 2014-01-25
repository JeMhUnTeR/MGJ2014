using UnityEngine;
using System.Collections;


[RequireComponent(typeof(SkinnedMeshRenderer))]
public class DisintegratePlayer : MonoBehaviour {

	void Update () {
		if (Input.GetKeyDown(KeyCode.Q)) Disintegrate();
	}

	void Disintegrate () {
		particleSystem.Play();
		float alpha = Mathf.Lerp(renderer.material.color.a, renderer.material.color.a, 5 * Time.deltaTime);
		renderer.material.color = new Vector4 (renderer.material.color.r, renderer.material.color.g, renderer.material.color.b, alpha);
	}
}
