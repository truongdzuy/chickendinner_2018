using UnityEngine;

public class PlayerExample : MonoBehaviour {

    public float moveSpeed;
    public Joystick joystick;
    public float brakeForce;
    public GameObject m_Camera;
    public GameObject planet;
    private void Start()
    {
        m_Camera = Camera.main.gameObject;
        //transform.position = new Vector3(planet.transform.localScale.x * Vector3.up.x, planet.transform.localScale.z * Vector3.up.z, planet.transform.localScale.z * Vector3.up.z);
    }
    void Update () 
	{
       Vector3 moveVector = (m_Camera.transform.right * joystick.Horizontal + m_Camera.transform.forward * joystick.Vertical).normalized;
        transform.Translate(moveVector * moveSpeed * Time.deltaTime);
        
	}
    private void FixedUpdate()
    {


        Vector3 moveVector = (transform.right * joystick.Horizontal + transform.up * joystick.Vertical).normalized;

       // GetComponent<Rigidbody>().AddForce(moveVector * moveSpeed);
        //else
        //{

        //    //Vector3 v = GetComponent<Rigidbody>().velocity;
        //    //Vector3 planeV = new Vector3(v.x, 0, v.z);

        //    //moveVector = -planeV*brakeForce;
        //    //GetComponent<Rigidbody>().AddForce(moveVector);
        //}
    }
}