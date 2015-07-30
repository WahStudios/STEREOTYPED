using UnityEngine;
using System.Collections;

public class RandomLevelGenerator : MonoBehaviour {

	public GameObject[] section;
	public int maxSections = 10;
	public int maxRandomSections = 10;
	public Transform[] sectionEndPoint;
	Transform previousEndPoint;
	public Transform startingPoint;
	public GameObject player;

	int n = 0;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		int r;
		if(n <= maxSections)
		{
			if(previousEndPoint == null)
			{
				previousEndPoint = startingPoint;

			}
			r = Random.Range(0, maxRandomSections);
			GameObject thisSection;
			thisSection = (GameObject)Instantiate(section[r], previousEndPoint.position, previousEndPoint.rotation);
			RandomRoad randomRoad = thisSection.GetComponent<RandomRoad>();
			previousEndPoint = randomRoad.endPoint;
			if(n == 0)
			{
				player.transform.position = randomRoad.playerSpawnPoint.position;
			}
			if(n ==maxSections)
			{
				randomRoad.exitDoor.SetActive(true);
			}
		
			n++;
		}

	}
}
