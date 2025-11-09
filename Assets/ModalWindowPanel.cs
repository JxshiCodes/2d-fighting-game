using UnityEngine;
using UnityEngine.UI;

public class ModalWindowPanel : MonoBehaviour
{
    [SerializeField] Transform Box;
    [Header("Header")]
    [SerializeField] 
    private Transform _headerArea;
    [SerializeField] 
    private Text _titleText;
    
    [Header("Content")]
    [SerializeField] 
    private Transform _contentArea;
    [SerializeField] 
    private Transform _verticalLayoutArea;
    [SerializeField] 
    private Text _heroText;
    [SerializeField] 
    private Transform _horizontalLayoutArea;
    
    [Header("Footer")]
    [SerializeField] 
    private Transform _footerArea;
    [SerializeField] 
    private Button _confirmButton;
    [SerializeField] 
    private Button _rejectButton;
    
    private System.Action onConfirmAction;
    private System.Action onRejectAction;

    public void Confirm()
    {
        onConfirmAction?.Invoke();
        Close();
    }
    public void Reject()
    {
        onRejectAction?.Invoke();
        Close();
    }
    public void Close()
    {
        onConfirmAction.UIObject.SetActive(false);
        onRejectAction.UIObject.SetActive(false);
    }
}
