using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
    private int m_score = 0;
	private float m_speed = 1;
	private int m_turnSpeed = 0;

    // Update is called once per frame
    void Update()
    {
		Debug.Log ("Score = " + m_score);

        //beweeg de speler naar rechts
        this.transform.position += Vector3.right * Time.deltaTime * m_speed;
		this.transform.Rotate(Vector3.forward, m_turnSpeed * Time.deltaTime);
    }
    
	public int ChangeScore
	{
		get {return m_score; }
		set {m_score += value; }
	}

    public float ChangeSpeed
    {
		get {return m_speed; }
		set {m_speed -= value; }
    }

	public int ChangeRotateSpeed
	{
		get {return m_turnSpeed; }
		set {m_turnSpeed += value; }
	}
}
