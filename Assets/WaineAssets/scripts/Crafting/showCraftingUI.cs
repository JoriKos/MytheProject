using UnityEditor.UIElements;
using UnityEngine;

public class showCraftingUI : MonoBehaviour
{
    bool wasInteracted { get; set; }
    bool displayingCraftingUI { get; set; }
    float radius =2.5f;
    LayerMask playerLayer;

    [SerializeField] private GameObject interactableDisplay;
    [SerializeField] private GameObject craftingUI;

	// Start is called before the first frame update
	private void Start()
	{
        playerLayer = LayerMask.GetMask("PlayerLayer");
	}
	// Update is called once per frame
	void Update()
    {
        CheckForPlayer();
		if (Input.GetKeyDown(KeyCode.F))
		{
			if (wasInteracted)
			{
            interactableDisplay.SetActive(false);
            craftingUI.SetActive(true);
            displayingCraftingUI = true;
			}
		}
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			if (displayingCraftingUI)
			{
                craftingUI.SetActive(false);
                displayingCraftingUI = false;
			}
		}
    }

    void CheckForPlayer()
	{
    
        Collider[] hitColliders = Physics.OverlapSphere(transform.position, radius, playerLayer);
        int i = 0;
        if (i >= hitColliders.Length)
		{
            interactableDisplay.SetActive(false);
            wasInteracted = false;       
		}
        if(i < hitColliders.Length)
		{
			if (hitColliders[0].CompareTag("Player"))
			{
                interactableDisplay.SetActive(true);
                wasInteracted = true;
			}
		}
        
	}
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.white;
        Gizmos.DrawWireSphere(transform.position, radius);
    }
}
