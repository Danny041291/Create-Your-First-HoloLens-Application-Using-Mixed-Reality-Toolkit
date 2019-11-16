
using Microsoft.MixedReality.Toolkit.Input;
using TMPro;
using UnityEngine;

namespace Assets.Scripts
{
    public class CanvasSpeechHandler : MonoBehaviour, IMixedRealitySpeechHandler
    {

        public TextMeshProUGUI Message;

        public void OnSpeechKeywordRecognized(SpeechEventData eventData)
        {
            if(eventData.Command.KeyCode == KeyCode.Alpha4)
            {
                Message.text = "Hello there!";
            }
        }

    }
}
