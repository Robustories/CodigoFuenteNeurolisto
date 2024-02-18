using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoHorizontal : MonoBehaviour
{
    public float speed = 1f;
    public float minX;
    public float maxX;
    public float waitingTime = 2f;

    private GameObject _target;
    // Start is called before the first frame update
    void Start()
    {
        UpdateTarget();
        StartCoroutine("PatrolToTarget");
    }

        private void UpdateTarget()
    {
        if (_target == null){
            _target = new GameObject("Target");
            _target.transform.position = new Vector2(minX, transform.position.y);
            transform.localScale = new Vector3(-1, 1, 1);
            return;
        }

        if (_target.transform.position.x == minX){
            _target.transform.position = new Vector2(maxX, transform.position.y);
            transform.localScale = new Vector3(1, 1, 1);
        }

        else if (_target.transform.position.x == maxX){
            _target.transform.position = new Vector2(minX, transform.position.y);
            transform.localScale = new Vector3(-1, 1, 1);
        }
    }

    private IEnumerator PatrolToTarget()
    {
        while(Vector2.Distance(transform.position, _target.transform.position) > 0.05f){
            Vector2 direction = _target.transform.position - transform.position;
            float xDirection = direction.x;

            transform.Translate(direction.normalized * speed * Time.deltaTime);

            yield return null;
        }

        Debug.Log("Target reached");
        transform.position = new Vector2(_target.transform.position.x, transform.position.y);

        Debug.Log("Waiting for" + waitingTime + "seconds");
        yield return new WaitForSeconds(waitingTime);

        Debug.Log("Waited enough, Let´s update the target and move again");
        UpdateTarget();
        StartCoroutine("PatrolToTarget");
    }
}
