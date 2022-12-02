using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    [SerializeField]private LayerMask rayLayer;
    private GameObject hit;
    [SerializeField]private float timer = 5f;
    public Text timerText;

     public IEnumerator Cont()
    {

        Debug.Log("Quedan " + timer + " segundos para teletransportarse");
        yield return new WaitForSeconds(1f);
        timer--;
        timerText.text = timer.ToString(); 
        Debug.Log("Quedan " + timer + " segundos para teletransportarse");
        yield return new WaitForSeconds(1f);
        timer--;
        timerText.text = timer.ToString(); 
        Debug.Log("Quedan " + timer + " segundos para teletransportarse");
        yield return new WaitForSeconds(1f);
        timer--;
        timerText.text = timer.ToString(); 
        Debug.Log("Quedan " + timer + " segundos para teletransportarse");
        yield return new WaitForSeconds(1f);
        timer--;
        timerText.text = timer.ToString(); 
        Debug.Log("Quedan " + timer + " segundos para teletransportarse");
        yield return new WaitForSeconds(1f);
        timer--;
        timerText.text = timer.ToString(); 
        Debug.Log("Quedan " + timer + " segundos para teletransportarse");

        Debug.Log("Teletransportandose...");

        LoadLevel();

    }    

    void Update()
    { 

	//Si le damos al botón de disparar(botón izquierdo del ratón), que nos muestre los nombres de los objetos que clickamos 
	if(Input.GetButtonDown("Fire1"))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit rayHit;
            StartCoroutine(Cont());                

            if(Physics.Raycast(ray, out rayHit, rayLayer))
            {
  
                hit = rayHit.transform.gameObject;               
                
            }
        }        
    }

    void LoadLevel()
    {

        if(hit.gameObject.layer == 6)
        {

            SceneManager.LoadScene(1);

        }
        if(hit.gameObject.layer == 7)
        {

            SceneManager.LoadScene(2);

        }
        if(hit.gameObject.layer == 8)
        {

            SceneManager.LoadScene(3);

        }

    }
}