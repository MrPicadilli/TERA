using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{  
    public static Player instance;

    public int currentHealth;
    public int maxHealth = 3;

    private void Awake() {
        instance = this;
    }

    private void Start() {
        currentHealth = maxHealth;

    }
}
