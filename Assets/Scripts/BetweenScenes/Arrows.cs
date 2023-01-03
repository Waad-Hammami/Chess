using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Arrows : MonoBehaviour
{
	public bool IsOpen;
	public Animator animator;
	// Start is called before the first frame update
	public void RightRoom()
	{
		if (animator.GetBool("IsOpen2") == true)
		{
			animator.SetBool("IsOpen2", false);
		}
		else
		{
			animator.SetBool("IsOpen", true);
		}
		
	}
	public void UpRoomBack()
	{
		animator.SetBool("IsOpen1", false);
	}
	public void UpRoom()
	{
		animator.SetBool("IsOpen1", true);
	}

	public void LeftRoom()
	{ if (animator.GetBool("IsOpen") == true )
		{
			animator.SetBool("IsOpen", false);
		}
		else
		{
			animator.SetBool("IsOpen2", true);
		}
	}

	
}
