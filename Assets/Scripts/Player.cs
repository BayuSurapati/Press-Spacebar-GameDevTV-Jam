using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player instance;

    public GameObject playerBullet;
    public int playerHealth;
    Rigidbody2D playerRigidbody;
    Animator playerAnimator;

    bool isFire;
    bool isAlive = true;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody2D>();
        playerAnimator = GetComponent<Animator>();

        isFire = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayerShoot()
    {
        if (isFire)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {

            }
        }
    }
}
