using System;
using System.Collections.Generic;
using System.Text;
using TMPro;
using UnityEngine;
using Object = UnityEngine.Object;
using UnityEngine.UI;

namespace KartGame.Track
{

    public class MainMenuRecord : MonoBehaviour
    {
        public Text textBestLapEver;
        float bestTime;
        string trackName;
        TrackRecord m_HistoricalBestLap;

        private void Awake()
        {
            m_HistoricalBestLap = TrackRecord.Load("ArtTest", 1);
            bestTime = m_HistoricalBestLap.time;
            if (m_HistoricalBestLap != null && m_HistoricalBestLap.time < float.PositiveInfinity)
            {
                textBestLapEver.text = "Best Time: " + bestTime.ToString(".##");
            }

        }

    }
}


/* float bestLapTime = trackManager.HistoricalBestLap;
   public TrackManager trackManager;

    public float HistoricalBestLap
        {
            get
            {
                if (m_HistoricalBestLap != null && m_HistoricalBestLap.time < float.PositiveInfinity)
                    return m_HistoricalBestLap.time;
                return -1f;
            }
        }


*/

