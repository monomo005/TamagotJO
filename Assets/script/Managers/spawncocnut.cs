using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawncocnut : MonoBehaviour
{
public string spawnPointTag = "sometag";
	public bool alwaysSpawn = true;
	public float Timez = 10.0f;
	
	public List<GameObject> prefabsToSpawn;
	
    // Start is called before the first frame update
	public void spawncoco()
    {
        GameObject[] spawnPoints = GameObject.FindGameObjectsWithTag(spawnPointTag);
		foreach(GameObject spawnPoint in spawnPoints){
			int randomPrefab = Random.Range(0, prefabsToSpawn.Count);
			if(alwaysSpawn){
				GameObject pts = Instantiate(prefabsToSpawn[randomPrefab]);
				pts.transform.position = spawnPoint.transform.position;
				alwaysSpawn = false;
			}else{
				int spawnOrNot = Random.Range(0, 2);
				if(spawnOrNot == 0){
					GameObject pts = Instantiate(prefabsToSpawn[randomPrefab]);
					pts.transform.position = spawnPoint.transform.position;
				alwaysSpawn = false;
				}
			}
		}
    }
	void update()
{
		if(Timez > 0)
	{
		Timez-=Time.deltaTime;
		if(Timez <= 0)
		{
			
			alwaysSpawn = true;
			Timez += 10.0f;
			Debug.Log("RunTimeOnly");
		}
	}
}
	
}
