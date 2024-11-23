using UnityEngine;

public class PingPongMovement : MonoBehaviour
{
    // 起点和终点位置
    public Vector3 pointA = new Vector3(0, 0, 0);
    public Vector3 pointB = new Vector3(5, 0, 0);

    // 控制物体移动速度
    public float speed = 2.0f;

    // 用于控制物体是否运动
    public bool isMoving = false;

    // 目标位置
    private Vector3 target;

    void Start()
    {
        // 初始化目标位置为B点
        target = pointB;
    }

    void Update()
    {
        // 如果isMoving为true，物体在A和B之间来回移动
        if (isMoving)
        {
            MoveBetweenPoints();
        }
    }

    // 移动物体在点A和点B之间
    private void MoveBetweenPoints()
    {
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);

        // 如果到达目标点，则切换目标点
        if (Vector3.Distance(transform.position, target) < 0.01f)
        {
            target = target == pointA ? pointB : pointA;
        }
    }

    // 方法用于设置当前位置为Point A
    public void SetPositionToA()
    {
        pointA = transform.position;
    }

    // 方法用于设置当前位置为Point B
    public void SetPositionToB()
    {
        pointB = transform.position;
    }
}
