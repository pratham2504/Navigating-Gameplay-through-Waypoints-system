using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour 
{
	//Create a reference to the CoinPoofPrefab
	public GameObject coinPoof;

	public AudioSource coinAudio;

    public void OnCoinClicked() {

		//Audio
		coinAudio.Play();

        // Instantiate the CoinPoof Prefab where this coin is located
		Instantiate (coinPoof, transform.position, Quaternion.Euler (-90, 0, 0));
        // Make sure the poof animates vertically
        // Destroy this coin. Check the Unity documentation on how to use Destroy
		Destroy(gameObject, 0.5f);
    }

}
