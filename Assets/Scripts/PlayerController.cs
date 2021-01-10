using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float restartDelay = 1f; 
    public float speed = 0;
    public TextMeshProUGUI countText;
    public GameObject setWinner;
    public GameObject snakeAttack;
    private Rigidbody rb;
    private int count ;
    private float movementX;
    private float movementY;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 1;
        // SetCountText();
       // setWinner.SetActive(false);
    }

    void SetCountText(){
      countText.text = "LEVEL "+count.ToString();
    }

    private void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();

        movementX = movementVector.x;
        movementY = movementVector.y;
    }

    private void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);

        rb.AddForce(movement * speed);
    }

    private void OnTriggerEnter(Collider other){
     if (other.gameObject.CompareTag("PickUp"))
      {
        other.gameObject.SetActive(false);
        count = count + 1;
        // SetCountText();
        if (count==2){
          speed = 0;
          Invoke("Win",restartDelay);
      
       }
     }
    }

     void OnCollisionEnter(Collision info){
          if (info.collider.tag == "Snakes"){
            speed=0;
           Invoke("Attack",restartDelay);
             
          }
     }
      
     public void Attack(){
      snakeAttack.SetActive(true);
     // Invoke("restart",restartDelay);
     }
      
     public void Win()
     {
       setWinner.SetActive(true);
       //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
      // SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    // 
    }

}
