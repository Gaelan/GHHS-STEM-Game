using UnityEngine;

using System.Collections;



public class LivingEntity : MonoBehaviour, IDamageable {

	 //int Score = 0;

	public float startingHealth;
	protected float health;
	protected bool dead;

	public event System.Action OnDeath;
	protected virtual void Start() {// this is saying heath = stating heath so if you dont have a living entity
		health = startingHealth;	//you can still have heath
	}


	public void TakeHit(float damage, RaycastHit hit) {
		// Do some stuff here with hit var
		TakeDamage (damage);
	}
		
	public void TakeDamage(float damage) {
		health -= damage;
		if (health <= 0 && !dead) {
			Die();
		}
	}
	protected void Die() {
		dead = true;
		if (OnDeath != null) {
			OnDeath();
		}
		//Score + 1;   // here is where you can keep trak of how many deaths there has been.
		GameObject.Destroy (gameObject);

	}

}