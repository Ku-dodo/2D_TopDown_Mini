using JetBrains.Annotations;
using System.IO.Pipes;
using UnityEngine;

public class InteractionRayCast : MonoBehaviour
{
    private Vector2 prevPosition;
    private Vector2 rayDirection;
    public GameObject _interactiveObj;
    public float minDistance;
    private void Start()
    {
        //콜라이더 내부에서 레이가 시작되고 바로 충돌되지 않기 위한 설정 3D는 그냥 발사되지만 2D는 설정해줘야한다.
        Physics2D.queriesStartInColliders = false;
        prevPosition = transform.position;
        rayDirection = transform.right;
    }
    void Update()
    {
        Vector2 currPosition = transform.position;
       
        
        if (Mathf.Abs(currPosition.x -  prevPosition.x) >= minDistance || Mathf.Abs(currPosition.y- prevPosition.y) >= minDistance)
        {
            rayDirection = transform.GetComponent<Rigidbody2D>().velocity.normalized;
            prevPosition = currPosition;
        }

        RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, rayDirection, 3);

        if (hitInfo.collider != null)
        {
            _interactiveObj = hitInfo.collider.gameObject;

            Debug.DrawLine(transform.position, hitInfo.point, Color.red);
        }
        else
        {
            _interactiveObj = null;

            Debug.DrawLine(transform.position, transform.position + new Vector3(rayDirection.x, rayDirection.y, 0).normalized * 3, Color.green);
        }
    }
}
