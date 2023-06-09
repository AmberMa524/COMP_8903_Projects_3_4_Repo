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
				if (ObjectA != ObjectB && ObjectA != this) {
					Vector3 offset = ObjectB.transform.position - ObjectA.transform.position;
					float r = offset.magnitude;
					float rsquared = Mathf.Pow(r, 2);
					float massproduct = gc*ObjectA.mass*ObjectB.mass;
					float gravityMagnitude = massproduct / rsquared;
					Vector3 gravityFeltVector = gravityMagnitude * offset.normalized;
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