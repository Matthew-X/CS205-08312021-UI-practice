using UnityEngine;

public class EventTriggersInspector : MonoBehaviour {
    public void Test(bool _isTrue) {
        Foo.Bar(_isTrue);
    }
}
