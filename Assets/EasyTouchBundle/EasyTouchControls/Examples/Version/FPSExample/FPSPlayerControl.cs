using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FPSPlayerControl : MonoBehaviour {
    
	public ParticleSystem shellParticle;
	public GameObject muzzleEffect;
	public GameObject impactEffect;

	//private bool inJump = false;
	//private float jumpStart;

	private bool inFire = false;
	private bool inReload = false;
	private Animator anim;
    

	void Awake(){
		anim = GetComponentInChildren<Animator>();
	}

	void Update(){
        
		// UTurn

		// Jump
		/*
		if (ETCInput.GetButtonDown("Jump")){
			inJump = true;
			jumpStart = transform.position.y;
		}

		if (inJump && transform.position.y - jumpStart <3f){
			GetComponent<CharacterController>().Move( Vector3.up * 0.5f);
		}
		else{
			inJump = false;
		}*/

		//armo
	}
	
	public void MoveStart(){
		anim.SetBool("Move",true);
	}

	public void MoveStop(){
		anim.SetBool("Move",false);
	}
    
	public void TouchPadSwipe(bool value){
		ETCInput.SetControlSwipeIn("FreeLookTouchPad",value);
	}

	IEnumerator Flash(){
		yield return new WaitForSeconds(0.08f);
		muzzleEffect.SetActive( false);

    }
    
}
