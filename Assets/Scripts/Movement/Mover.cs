using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Mover : MonoBehaviour
{
    [SerializeField]Transform target;
    NavMeshAgent agent;
    Camera cam;
    Ray last_ray;
    // Start is called before the first frame update
    void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
        cam = Camera.main;
    }
    void Start()
    {
        agent.SetDestination(target.position);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            CursorClick(); //按下鼠标左键保持不放，角色能跟随鼠标移动
        }
        
        UpdateAnimator(); //获取NavMesh中的速度，设置为Animator的混合参数


    }
    void CursorClick()//根据鼠标位置移动
    {
        last_ray = cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(last_ray, out hit))
            agent.SetDestination(hit.point);
    }
    //获取NavMesh中的速度，设置为Animator的混合参数
    void UpdateAnimator()
    {
        Vector3 localVelocity = transform.InverseTransformDirection(agent.velocity);//将NavMeshAgent的速度转换为本地坐标系下的速度
        //计算模长
        
        float speed = Mathf.Sqrt(localVelocity.x*localVelocity.x+localVelocity.z*localVelocity.z);
        GetComponent<Animator>().SetFloat("forwardSpeed", speed);

    }
}
