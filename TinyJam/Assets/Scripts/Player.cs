using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D m_rb;

    private string terrainmask = "Terrain";

    private int m_nLayerMask;

    private void Awake()
    {
        m_nLayerMask = LayerMask.GetMask(terrainmask);
    }

    // Use this for initialization
    void Start()
    {
        m_rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // stop exponential velocity
        //m_rb.velocity = Vector2.zero;

        // constantly flying to the right
        //m_rb.AddForce(new Vector2(2.0f, 0.0f), ForceMode2D.Impulse);

        // if you hold space you fall
        if (Input.GetKey(KeyCode.Space))
        {
            m_rb.AddForce(-Vector2.up * 5);
            //m_rb.AddForce(new Vector2(0.0f, -100.0f), ForceMode2D.Force);
        }
    }

    private void OnCollisionStay2D(Collision2D col)
    {
        RaycastHit2D hit2d = Physics2D.Raycast(gameObject.transform.position, Vector2.down, Mathf.Infinity, m_nLayerMask);

        Vector2 a = Vector2.Perpendicular(hit2d.normal);
        a = -a;
        m_rb.AddForce((a * 0.05f), ForceMode2D.Impulse);
        //m_rb.AddForce(new Vector2(100.0f, -100.0f), ForceMode2D.Force);
        Debug.Log("cld ground");
    }
}

