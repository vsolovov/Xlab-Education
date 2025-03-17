using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX; // Подключаем пространство имен для VFX Graph

namespace TZ
{
    public class Cloud : MonoBehaviour
    {
        [SerializeField] private VisualEffect m_vfx; // Используем VisualEffect вместо ParticleSystem

        public void PlayFX()
        {
            m_vfx.Play(); // Запуск эффекта
        }

        public void StopFX()
        {
            m_vfx.Stop(); // Остановка эффекта
        }

        private void Start() // Исправляем: убираем public, должен быть private или protected
        {
            m_vfx.Stop(); // Останавливаем эффект при запуске
        }
    }
}
