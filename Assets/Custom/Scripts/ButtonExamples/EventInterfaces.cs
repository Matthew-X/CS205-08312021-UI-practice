using UnityEngine;
using UnityEngine.EventSystems;

public class EventInterfaces : MonoBehaviour, IPointerDownHandler {
    public bool isTrue;

    public void OnPointerDown(PointerEventData eventData) {
        Foo.Bar(isTrue);
    }
}
