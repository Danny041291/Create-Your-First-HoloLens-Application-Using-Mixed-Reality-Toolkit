using TMPro;
using UnityEngine;

namespace Assets.Scripts
{
    public class CanvasSpeechHandler : MonoBehaviour
    {

        public TextMeshProUGUI Message;

        public void OnKeyboardKeywordRecognized()
        {
#if UNITY_EDITOR
            Message.text = "No available on editor.";
#elif UNITY_WSA
             Message.text = TouchScreenKeyboard.Open(string.Empty, TouchScreenKeyboardType.Default, false, false, false, false).text;
#endif
        }

    }
}
