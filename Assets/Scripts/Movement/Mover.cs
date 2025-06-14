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
            CursorClick(); //�������������ֲ��ţ���ɫ�ܸ�������ƶ�
        }
        
        UpdateAnimator(); //��ȡNavMesh�е��ٶȣ�����ΪAnimator�Ļ�ϲ���


    }
    void CursorClick()//�������λ���ƶ�
    {
        last_ray = cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(last_ray, out hit))
            agent.SetDestination(hit.point);
    }
    //��ȡNavMesh�е��ٶȣ�����ΪAnimator�Ļ�ϲ���
    void UpdateAnimator()
    {
        Vector3 localVelocity = transform.InverseTransformDirection(agent.velocity);//��NavMeshAgent���ٶ�ת��Ϊ��������ϵ�µ��ٶ�
        //����ģ��
        
        float speed = Mathf.Sqrt(localVelocity.x*localVelocity.x+localVelocity.z*localVelocity.z);
        GetComponent<Animator>().SetFloat("forwardSpeed", speed);

    }
}
