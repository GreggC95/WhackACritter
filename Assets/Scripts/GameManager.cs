using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public List<GameObject> critterPrefabs;
    public float critterSpawnFreqency = 1.0f;
    public Score scoreDisplay;
    public Timer timer;


    private float lastCritterSpawn = 0;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        //check if it time to spawn the next critter
        float nextSpawnTime = lastCritterSpawn + critterSpawnFreqency;
        if (Time.time >= nextSpawnTime && timer.IsTimerRunning() == true)
        {
            // it is time!

            //Choose a random critter to spawn
            int critterIndex = Random.Range(0, critterPrefabs.Count);
            GameObject prefabToSpawn = critterPrefabs[critterIndex];

            //spawn the critter
            GameObject spawnedCritter = Instantiate(prefabToSpawn);

            // Get access to our Critter script
            Critter critterScript = spawnedCritter.GetComponent<Critter>();

            // Tell the critter script the score and timer objects
            critterScript.scoreDisplay = scoreDisplay;
            critterScript.timer = timer;

            // update the most recent critter spawn time to now
            lastCritterSpawn = Time.time;
        }

	}
}
