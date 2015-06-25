using UnityEngine;
using System.Collections;

public class SpecialEffect : MonoBehaviour {
	
	private DragMask dragMask;
	public Vector2 posParticle;
	public ParticleSystem starmove;
	
	void Start () {

		dragMask = (DragMask)GameObject.Find ("mask").GetComponent (typeof(DragMask));
		starmove.Pause ();
	}
	
	void Update () {

		posParticle = new Vector2 (3.6f,3f);

		if (dragMask.animationParticle == true) {

			starmove.Play ();
			transform.Rotate (Vector3.forward);
			iTween.MoveTo(gameObject,posParticle, 7f);
		}
	}
}


