using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AXD_PlayerAttack : MonoBehaviour
{

    private enum AttackType { Gash, Thrust}
    public Transform attackPoint;
    public ELC_PlayerMoves player;
    public int Damage;
    [Header ("Attack Settings")]
    [Range (0,5)]
    public float areaRadius;
    public float attackRate;
    public float nextAttackTime;

    void Start()
    {
        nextAttackTime = Time.time;
    }
    void Update()
    {
        attackPoint.position = (transform.position + player.getPlayerMoves().normalized);
        Debug.Log("Attaquer ? "+(Time.time >= nextAttackTime));
        if (Time.time >= nextAttackTime)
        {
            if (Input.GetAxisRaw("Gash") != 0)
            {
                Debug.Log("Gash : " + player.getPlayerMoves().ToString());
                Attack(AttackType.Gash);
            }
            else if (Input.GetAxisRaw("Thrust") != 0)
            {
                Debug.Log("Thrust : " + player.getPlayerMoves().ToString());
                this.Attack(AttackType.Thrust);
            }
            
        }
    }

    private void Attack(AttackType type)
    {
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position,areaRadius);
        foreach(Collider2D enemy in hitEnemies)
        {
            enemy.GetComponent<AXD_Enemy>().GetHit(Damage);
        }
        nextAttackTime = Time.time + 1f / attackRate;
    }


    private void OnDrawGizmosSelected()
    {
        if (attackPoint != null)
            Gizmos.DrawWireSphere(attackPoint.position, areaRadius);
    }
}
