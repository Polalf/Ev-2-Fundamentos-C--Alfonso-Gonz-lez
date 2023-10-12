using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [SerializeField] private float radius = 2f;
    [SerializeField] private LayerMask itemMask;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Enemigos eliminados " +DataManager.data.enemigosEliminados);
            Debug.Log("Objetos recogidos " +DataManager.data.objRecogidos);

        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position,radius,itemMask);
            foreach (Collider2D collider in colliders)
            {
                DataManager.data.objRecogidos += 1;
                Destroy(collider.gameObject);
                //collider.gameObject.transform.position += transform.position * Time.deltaTime; 
            }
        }
    }
}
