using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private int life = 4;
    [SerializeField] private GameObject drop;

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GetDamage()
    {
        life--;
        if(life<=0)
        {
            Instantiate(drop, transform.position, transform.rotation);
            DataManager.data.enemigosEliminados++;
            Destroy(gameObject);
        }
    }
}
