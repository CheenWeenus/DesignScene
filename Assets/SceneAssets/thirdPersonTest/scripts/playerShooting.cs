using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Animations;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;
using TMPro;

public class playerShooting : MonoBehaviour
{
    public playerSO playerStats;
    public TextMeshProUGUI textObj;
    public GameObject bullet;
    public Transform orientation;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Test Text" + textObj);
        playerStats.bulletCount = 3;
        textObj.text = "" + playerStats.bulletCount;
    }

    // Update is called once per frame
    void Update()
    {
        textObj.text = "" + playerStats.bulletCount;
    }

    void OnFire()
    {
        if (playerStats.bulletCount > 0 && Time.timeScale != 0) {
            Debug.Log("firing - bullets: " + playerStats.bulletCount);

            GameObject bulletInstance = Instantiate(bullet, transform.position + 2.0f * orientation.forward, Quaternion.identity);
            Rigidbody bulletRB = bulletInstance.GetComponent<Rigidbody>();

            bulletRB.velocity = orientation.forward * playerStats.bulletSpeed;
            playerStats.bulletCount--;
            //textObj.text = playerStats.bulletCount.ToString();
        }
        else
        {
            Debug.Log("No ammo");
        }
    }

    void OnReload()
    {
        if(playerStats.bulletCount == playerStats.maxBulletCount)
        {
            Debug.Log("Ammo Full");
        }
        else
        {
            Debug.Log("Reload - bullets: " + playerStats.bulletCount);
            playerStats.bulletCount = playerStats.maxBulletCount;
        }
    }
}
