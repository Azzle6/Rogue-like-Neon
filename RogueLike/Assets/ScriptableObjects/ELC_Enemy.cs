using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Enemy", menuName = "ScriptableObjects/EnemyScriptableObject", order = 1)]
public class ELC_Enemy : ScriptableObject
{
<<<<<<< HEAD
    public string enemyName;
    public float maxHeal;
    public float strenght;
    public float speed;
    public float moneyToDropWhenHit;
    public float moneyToDropWhenDead;

    public bool followPlayer;
    public bool fleePlayer;
    public bool stayAtDistance;
    public float distanceToStay;


    public bool fireBullets;
    public GameObject bullet;

    public bool instantiateSomethingAtDeath;
    public GameObject thingToInstanciate;

    public bool dashOnPlayer;
    public float dashSpeed;
    public float dashTime;
    public float attackCooldown;


=======
    public float maxHeal;
    public float strenght;
    public float speed;
    public bool followPlayer;
    public bool fleePlayer;
    public bool stayAtDistance;
    public float distance;
    public bool fireBullets;
    public bool instantiateEnemyAtDeath;
    public bool dash;
>>>>>>> MainBranch
    public Sprite sprite;
    public MonoBehaviour AIScript;
    public Animator Animator;
}