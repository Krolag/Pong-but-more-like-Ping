using UnityEngine;
using UnityEditor.UIElements;
using TMPro;

public class PointsCounter : MonoBehaviour
{
    public BoxCollider2D LeftBoundry;
    public BoxCollider2D RightBoundry;

    public TextMeshProUGUI PlayerOnePoints;
    public TextMeshProUGUI PlayerTwoPoints;

    private int _achivedPointsOne;
    private int _achivedPointsTwo;

    private void Start()
    {
        StartCoroutine(GetComponent<BallMovement>().SpawnBall());
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider == RightBoundry)
        {
            _achivedPointsOne++;
            PlayerOnePoints.text = _achivedPointsOne.ToString();
            gameObject.GetComponent<BallMovement>().ChangeActiveState(false);
            StartCoroutine(GetComponent<BallMovement>().SpawnBall());
        }

        if (other.collider == LeftBoundry)
        {
            _achivedPointsTwo++;
            PlayerTwoPoints.text = _achivedPointsTwo.ToString();
            gameObject.GetComponent<BallMovement>().ChangeActiveState(false);
            StartCoroutine(GetComponent<BallMovement>().SpawnBall());
        }
    }
}