using UnityEngine.UI;

namespace UnityEngine.XR.Interaction.Toolkit.Samples.StarterAssets
{
    public class Countdown : MonoBehaviour
    {
        public Text m_Text;
        bool started = false;
        int m_Count = 10;
        float t = 0;


        private void Update()
        {
            Debug.Log("............ " +m_Count);
            if (!started)
            {
                t += Time.deltaTime;

                if (t > 1)
                {
                    m_Count--;

                    if (m_Count >= 0)
                    {
                        m_Text.text = "" + m_Count;

                    }
                    else
                    {
                        m_Text.text = "Lift-off";
                        started = true;
                    }
                    t = 0;
                }


            }
        }


        protected void Start()
        {
            m_Text.text = "10";


        }

    }
}
