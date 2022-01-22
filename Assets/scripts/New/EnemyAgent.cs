using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAgent : MonoBehaviour
{
    NavMeshAgent enemy;
    Transform player;
    GameController gameController;
    private NavMeshTriangulation Triangulation;


    void Start()
    {
        gameController = GameObject.Find("GameController").GetComponent<GameController>();
        Triangulation = NavMesh.CalculateTriangulation();
        enemy = GetComponent<NavMeshAgent>();
        //enemy = GameObject.FindGameObjectWithTag("Enemy").GetComponent<NavMeshAgent>();
        // if no target specified, assume the player
        if (player == null)
        {

            if (GameObject.FindWithTag("Player") != null)
            {
                player = GameObject.FindWithTag("Player").GetComponent<Transform>();
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (gameController.hasGameStarted)
            enemy.SetDestination(player.position);
        else
            enemy.isStopped = true;
    }

    public void DoSpawnEnemy()
    {
        Debug.Log("I'm in Do spawn");
        int VertexIndex = Random.Range(0, Triangulation.vertices.Length);
        //EnemyAgent enemyAgent = GameObject.Find("GameController").GetComponent<GameController>();
        NavMeshHit Hit;
        if (NavMesh.SamplePosition(Triangulation.vertices[VertexIndex], out Hit, 2f, -1))
        {
            enemy.Warp(Hit.position);
            Debug.Log("Spawned");
        }
    }
    
}
