using UnityEngine;

// Step 1: write the TreeOfBirds class in this file!
public class TreeOfBirds : MonoBehaviour
{
    [SerializeField] private float _interactDistance;
    [SerializeField] private Transform _player;
    [SerializeField] private Bird[] _birds;
    private bool _birdsActivated = false;
    private void Update()
    {
        if (Vector3.Distance(transform.position, _player.position) <= _interactDistance && !_birdsActivated )
        {
            _birdsActivated = true;

            for (int i = 0; i < _birds.Length; i++)
            {
                Bird sparrow = _birds[i];


                sparrow.transform.gameObject.SetActive(true);

            }
        }
    }
}
            
        
            

