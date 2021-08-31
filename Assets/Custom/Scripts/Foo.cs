using UnityEngine;

public static class Foo {
    public static void Bar(bool isTrue) {
        if (isTrue) {
            Debug.Log("<color=green>Yay!</color>");
        } else {
            Debug.Log("<color=red>Aw nu!</color>");
        }
    }
}
