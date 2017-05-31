using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour 
{
    //Create a reference to the KeyPoofPrefab and Door
	public GameObject keyPoof;
	public Door doorOpen;

	//public Animation floatingKey;

	public AudioSource keyAudio;

	private bool KeyCollected = false;

	void Update()
	{
		//Not required, but for fun why not try adding a Key Floating Animation here :)
		//floatingKey.startPlayback();
	}

	public void OnKeyClicked()
	{
		//Audio
		keyAudio.Play();

        // Instatiate the KeyPoof Prefab where this key is located
		Instantiate(keyPoof, transform.position, Quaternion.Euler(-90,0,0));
        // Make sure the poof animates vertically
        // Call the Unlock() method on the Door
		doorOpen.Unlock();

        // Set the Key Collected Variable to true
		KeyCollected = true;
        // Destroy the key. Check the Unity documentation on how to use Destroy
		Destroy(gameObject, 0.7f);
    }		
}