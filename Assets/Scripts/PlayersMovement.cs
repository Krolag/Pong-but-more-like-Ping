using UnityEngine;

public class PlayersMovement : MonoBehaviour
{
    public Transform PlayerOne;
    public Transform PlayerTwo;

    public float PlayerSpeed;

    // Update is called once per frame
    private void Update()
    {
        // PLAYER ONE INPUT
        if (Input.GetKey(KeyCode.W) && PlayerOne.transform.position.y <= 4.06f)
            PlayerOne.transform.Translate(PlayerSpeed * Time.deltaTime * Vector3.up);
        if (Input.GetKey(KeyCode.S) && PlayerOne.transform.position.y >= -4.06f)
            PlayerOne.transform.Translate(PlayerSpeed * Time.deltaTime * Vector3.down);

        // PLAYER TWO INPUT
        if (Input.GetKey(KeyCode.UpArrow) && PlayerTwo.transform.position.y <= 4.06f)
            PlayerTwo.transform.Translate(PlayerSpeed * Time.deltaTime * Vector3.up);
        if (Input.GetKey(KeyCode.DownArrow) && PlayerTwo.transform.position.y >= -4.06f)
            PlayerTwo.transform.Translate(PlayerSpeed * Time.deltaTime * Vector3.down);
    }
}