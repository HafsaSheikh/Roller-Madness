using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SpawnObjectsEditedCode : MonoBehaviour
{
	GameController gameController;

	//public float xMinRange = -25.0f;
	//public float xMaxRange = 0.250f;
	//public float yMinRange = 0.013f;
	//public float yMaxRange = 25.0f;
	//public float zMinRange = -25.0f;
	//public float zMaxRange = 25.0f;
	//public GameObject spawnObjects;
	[SerializeField] GameObject enemyAgent;
	//private NavMeshTriangulation Triangulation;
	
	void Start()
    {
		//Triangulation = NavMesh.CalculateTriangulation();
		gameController = GameObject.Find("GameController").GetComponent<GameController>();
		
	StartCoroutine(Spawn());
	}
    //public void DoSpawnEnemy()
    //{
    //    int VertexIndex = Random.Range(0, Triangulation.vertices.Length);
    //    EnemyAgent enemyAgent = GameObject.Find("GameController").GetComponent<GameController>();
    //    NavMeshHit Hit;
    //    if (NavMesh.SamplePosition(Triangulation.vertices[VertexIndex], out Hit, 2f, -1))
    //    {
    //        GameObject na = (GameObject)Instantiate(enemyAgent, this.transform.position, Quaternion.identity);
    //        na.GetComponent<EnemyAgent>().DoSpawnEnemy();
    //        na.Warp(Hit.position);
    //    }
    //}
    IEnumerator Spawn() 
	{
		Debug.Log("Coroutine Called");
		//while (gameController.hasGameStarted)
		//{
			yield return new WaitForSeconds(0.5f);

			GameObject na = (GameObject)Instantiate(enemyAgent, this.transform.position, Quaternion.identity);
			na.GetComponent<EnemyAgent>().DoSpawnEnemy();
			//Debug.Log("DoSpawn Called");
			// actually spawn the game object
			//GameObject spawnedObject = Instantiate(spawnObjects, SpawnPosition(), transform.rotation) as GameObject;
			//enemyAgent.DoSpawnEnemy();
			// make the parent the spawner so hierarchy doesn't get super messy
			//spawnedObject.transform.parent = gameObject.transform;
		//}

        
	}

    //void MakeThingToSpawn()
    //{




    //    actually spawn the game object
    //   GameObject spawnedObject = Instantiate(spawnObjects, SpawnPosition(), transform.rotation) as GameObject;

    //    make the parent the spawner so hierarchy doesn't get super messy

    //    spawnedObject.transform.parent = gameObject.transform;
    //}

 //   public Vector3 SpawnPosition()
	//{
	//	Vector3 spawnPosition;

	//	// get a random position between the specified ranges
	//	spawnPosition.x = Random.Range(xMinRange, xMaxRange);
	//	spawnPosition.y = Random.Range(yMinRange, yMaxRange);
	//	spawnPosition.z = Random.Range(zMinRange, zMaxRange);
	//	return spawnPosition;
	//}		
}
