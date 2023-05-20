using System.Collections;
using UnityEngine;
using UnityEngine.AI;
public class enemyshoot : MonoBehaviour
{
    public float damage =  1f;
    public float range = 10f;
    public float lookradius = 20f;
    public float attackradius = 10f;
    public float enemydamage = 1;

    Transform target1;
    NavMeshAgent agent;
    float attackcooldown = 2;
    float lastattacktime = 0;

    void Start()
    {

        target1 = manegerp.instance.player.transform;
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        float distance = Vector3.Distance(target1.position, transform.position);

        if (distance <= lookradius)
        {
            agent.SetDestination(target1.position);
            FaceTarget1();
            if (distance <= attackradius)
            {

               if (distance <= agent.stoppingDistance)
                {
                    if (Time.time - lastattacktime > attackcooldown)
                    {

                        lastattacktime = Time.time;
                        
                        attack();

                    }
                }

                
            }

        }

        void FaceTarget1()
        {
            Vector3 direction = (target1.position - transform.position).normalized;
            Quaternion lookrotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
            transform.rotation = Quaternion.Slerp(transform.rotation, lookrotation, Time.deltaTime * 5f);
        }



        void OnDrawGizmosSelected()
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(transform.position, lookradius);
        }
        void attack()
        {
            target1.GetComponent<plaeyerhelth>().playertakesdamage(enemydamage);



        }



    }




}

