using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeLife : MonoBehaviour
{
    LifePlayer playerVida;
    public int cantidad; //La cantidad de vida que me quitará
    public float currentDamageTime;
    void Start()
    {
        playerVida = GameObject.FindWithTag("Player").GetComponent<LifePlayer>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            currentDamageTime += Time.deltaTime;

            if (currentDamageTime >= 0.01)
             {
                 playerVida.vida -= cantidad;
                Destroy(gameObject);
            }
            else if (currentDamageTime >= 0.09f)
            {
                currentDamageTime = 0.0f;
            }
        }
    }
}
