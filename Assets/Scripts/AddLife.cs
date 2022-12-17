using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddLife : MonoBehaviour
{
    LifePlayer playerLife;
    public int cantidadLife; //La cantidad de vida que me quitará
    public float damaTime;
    float currentDamaTime;

    void Start()
    {
        playerLife = GameObject.FindWithTag("Player").GetComponent<LifePlayer>();

    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            currentDamaTime += Time.deltaTime;
            if (currentDamaTime > damaTime)
            {
                playerLife.vida += cantidadLife;
                currentDamaTime = 0.0f;
                Debug.Log("Toma vida");
                Destroy(gameObject);
            }
        }
    }
}
