using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
public class CoinCounter : MonoBehaviour {

    public GameObject scoreText;
    private AudioSource collectSound;
    public AudioClip collectSoundClip;
    int counter;
	// Use this for initialization
	void Start () {
        counter = 0;
        collectSound= SetUpSound(collectSoundClip);
    }

    // Update is called once per frame
    void Update () {
      
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.name.Equals("Coin"))
        {
            Destroy(other.gameObject);
            counter += 50;
            scoreText.GetComponent<Text>().text =""+counter;
            collectSound.Play();
        }

    }
    private AudioSource SetUpSound(AudioClip clip)
    {
        // create the new audio source component on the game object and set up its properties
        AudioSource source = gameObject.AddComponent<AudioSource>();
        source.clip = clip;
        source.volume = 1;
        source.loop = false;
        source.playOnAwake = false;

        // start the clip from a random point
        source.time = Random.Range(0f, clip.length);

        source.priority = 170;
        source.dopplerLevel = 0;
        return source;
    }
}
