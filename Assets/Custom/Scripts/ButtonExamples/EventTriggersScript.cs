using UnityEngine;
using UnityEngine.EventSystems;

public class EventTriggersScript : MonoBehaviour {
    public bool isTrue;

    private void Awake() {
        ButtonSetUp();
    }

    void ButtonSetUp() {
        EventTrigger.Entry entry = new EventTrigger.Entry();
        entry.eventID = EventTriggerType.PointerClick;
        entry.callback.AddListener((e) => Foo.Bar(isTrue));

        EventTrigger trigger = gameObject.AddComponent<EventTrigger>();
        trigger.triggers.Add(entry);
    }
}
