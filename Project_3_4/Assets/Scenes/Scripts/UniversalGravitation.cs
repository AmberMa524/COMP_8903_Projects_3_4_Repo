using UnityEngine;
using System.Collections;

public class UniversalGravitation : MonoBehaviour
{

	private PhysicsEngine[] physicsEngineArray;

	/* -------------------- PART 2 ------------------------------------*/
	//Define the private constant for the G (gravitational coeeficient):
	private const float gc = 0.000000000066743f;

	// Use this for initialization
	void Start()
	{
		physicsEngineArray = GameObject.FindObjectsOfType<PhysicsEngine>();
	}

	void FixedUpdate()
	{
		CalculateGravity();
	}

	/* -------------------- PART 2 ------------------------------------*/
	void CalculateGravity()
	{
		// for each object in physicsEngineArray:
		//CODE: foreach (PhysicsEngine ObjectA in physicsEngineArray) {

		foreach (PhysicsEngine ObjectA in physicsEngineArray)
		{
			foreach (PhysicsEngine ObjectB in physicsEngineArray)
			{
				if (ObjectA != ObjectB) {
					Vector3 r = ObjectB.velocityVector - ObjectA.velocityVector;
					Vector3 rsquared = new Vector3(Mathf.Pow(2, r.x), Mathf.Pow(2, r.y), Mathf.Pow(2, r.z));
					float massproduct = gc*ObjectA.mass*ObjectB.mass;
					Vector3 gravityMagnitude = new Vector3(massproduct/rsquared.x, massproduct/rsquared.y, massproduct/rsquared.z);
					//Vector3 gravityFeltVector = gravityMagnitude * offset.normalized;
					Vector3 gravityFeltVector = gravityMagnitude.normalized;
					ObjectA.AddForce(gravityFeltVector);
				}
			}
		}

		// for each object in the physicsEngineArray:
		//CODE: foreach (PhysicsEngine ObjectB in physicsEngineArray)	{

		// Now we have two objects A and B; we can calulcate the Fg.
		//Eliminate duplicatation: if ObjectA is not Object B
		//Eliminate gravity on itself: If objectA=!this
		//CODE: .....


		// Find the (r) distance between Object A and Object B:
		//CODE: ...


		// Find (r^2) distance to the power of two; use Mathf.Pow: 
		//CODE: ...


		// Find (Fg) magnitude of the gravity force; 
		// CODE: gravityMagnitude = ....


		// Normalizing the gravity; Just uncomment the line below:
		//CODE: Vector3 gravityFeltVector = gravityMagnitude * offset.normalized;

		// Add the force to the list of the forces on physicsEngine for object A; 
		// Note that you need to take care of the negative sign (downward acceleration) manually:
		//CODE: ...

	}
}