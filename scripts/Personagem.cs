using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personagem : MonoBehaviour
{
    public Rigidbody rb;
    float vel;
    float rotX = 0f;
    float sensiblidade = 1f;
    Ray raio;
    RaycastHit hit;
    Vector3 pulo = new Vector3(0, 3f,0);
    public GameObject botao;

    void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.Locked;
        rb = GetComponent<Rigidbody>();
    }


    void Update()
    {

        //Movimentação
        if(Input.GetKey(KeyCode.LeftShift)){
            vel = 15f;
        }else{
            vel = 10f;
        }

        if(Input.GetKey(KeyCode.D)){
            transform.Translate(vel * Time.deltaTime, 0, 0);
        }else if(Input.GetKey(KeyCode.A)){
            transform.Translate(-(vel * Time.deltaTime), 0, 0);
        }
        if(Input.GetKey(KeyCode.W)){
            transform.Translate(0, 0, vel * Time.deltaTime);
        }else if(Input.GetKey(KeyCode.S)){
            transform.Translate(0, 0, -(vel * Time.deltaTime));
        }

        //rotação
        rotX += Input.GetAxis("Mouse X") * sensiblidade;
        transform.eulerAngles = new Vector3(0,rotX,0);

        //Raycast para pulo
        //Se o botão direito do mouse for pressionado
        if(Input.GetKeyDown(KeyCode.Space)){
            //se o raio lançado para baixo, tocar um objeto, com um limite de 1.5f
            if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down), 1.5f)){
                //adiciona força para impulcionar para cima
                rb.AddForce(pulo * 2.0f, ForceMode.Impulse);
            }else{
                Debug.Log("no ar");
            }
        }

        if(Input.GetMouseButton(0)){
            raio = Camera.main.ScreenPointToRay(Input.mousePosition);
            Lancar(raio);
        }
    }
    private void Lancar(Ray raio){
        if(Physics.Raycast(raio, out hit)){

            Vector3 hitPosition = hit.point;

            float hitDistance = hit.distance;

            string tag = hit.collider.tag;

            GameObject obj = hit.transform.gameObject;

           
            if(tag == "Alvo"){
                Destroy(obj);
                Debug.DrawRay(raio.origin, hitPosition * hitDistance, Color.green);
                //Instancia um prefab de um alvo destruido
                Instantiate(botao, hitPosition, Quaternion.identity);
            }else{
                Debug.Log("errou");
                Debug.DrawRay(raio.origin, raio.direction * 1000, Color.red);
            }
        }
    }
}
