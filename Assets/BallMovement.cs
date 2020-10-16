using System;
using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;

public class BallMovement : MonoBehaviour
{
    public Rigidbody2D Rig;

    public GameObject Countdown;
    
    public float BounceForce;

    public bool IsInMainMenu = false;

    private void Awake()
    {
        if (IsInMainMenu)
        {
            Rig.AddForce(new Vector2(BounceForce * 2, BounceForce * 2));
        }
    }

    public IEnumerator SpawnBall()
    {
        gameObject.transform.position = new Vector3(0, 0, 0);
        ChangeActiveState(true);
        
        Countdown.SetActive(true);
        
        yield return new WaitForSeconds(3);

        int randomX = 0, randomY = 0;
        for (int i = 0; i < 2; i++)
        {
            var value = Random.Range(-100f, 100f);
            if (i == 0 && value > 0)
                randomX = 1;
            else if (i == 0)
                randomX = -1;

            if (i == 1 && value > 0)
                randomY = 1;
            else if (i == 1)
                randomY = -1;
        }
        
        Rig.AddForce(new Vector2(BounceForce * randomX, BounceForce * randomY));
        Countdown.SetActive(false);
    }

    public void ChangeActiveState(bool state)
    {
        var childObj = gameObject.transform.GetChild(0).gameObject;
        childObj.SetActive(state);
        if (!state)
        {
            Rig.velocity = Vector2.zero;
            Rig.angularVelocity = 0;
        }
    }
}