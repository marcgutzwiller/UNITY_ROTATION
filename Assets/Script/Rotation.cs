using UnityEngine;

public class Rotation : MonoBehaviour
{
	public bool rotateConstantly;
	public bool rotateOnlyOnXaxis;
	public bool rotateOnlyOnYaxis;
	public bool rotateOnlyOnZaxis;
	public bool rotateInAnyAxis;
	
	public float rotationSpeed = 10;
	
	void Update()
	{
		if (rotateConstantly)
		{
			transform.Rotate(Vector3.down*rotationSpeed);
		}
	}

	void OnMouseDrag()
    {
	    if (rotateOnlyOnYaxis)
	    {
		    transform.Rotate(Vector3.down*Input.GetAxis("Mouse X")*rotationSpeed, Space.World);
	    }
	    if (rotateOnlyOnXaxis)
	    {
		    transform.Rotate(Vector3.right*Input.GetAxis("Mouse Y")*rotationSpeed, Space.World);
	    }
	    if (rotateOnlyOnZaxis)
	    {
		    transform.Rotate(Vector3.forward*Input.GetAxis("Mouse Y")*rotationSpeed, Space.World);
	    }

	    if (rotateInAnyAxis)
	    {
		    float xPosition = Input.GetAxis("Mouse X")*rotationSpeed*-1;
		    float yPosition = Input.GetAxis("Mouse Y")*rotationSpeed;

		    transform.Rotate(yPosition,xPosition,0,Space.World);	    
	    }
    }
	public void OnMouseDown()
    {
	    transform.Rotate(Vector3.down*90);
    }
}


