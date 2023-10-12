using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayShot : MonoBehaviour
{
    [SerializeField] private float maxDist = 5;
    [SerializeField] private LayerMask enemyMask;
    
    void Update()
    {
        RaycastHit2D hit;
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 dir = mousePos - transform.position;
            dir = dir.normalized;

            hit = Physics2D.Raycast(transform.position, dir,maxDist,enemyMask);
            Debug.Log("Piu");
            //Debug.Log(hit ? true : false);
            if (hit/*.collider.CompareTag("Enemy")*/)
            {
                Debug.Log("Le dia al malo " + hit.collider.name);
                hit.collider.GetComponent<Enemy>().GetDamage();
            }
            Debug.DrawRay(transform.position, dir * maxDist , Color.green, 0.1f);
            
        } 
    }
}
