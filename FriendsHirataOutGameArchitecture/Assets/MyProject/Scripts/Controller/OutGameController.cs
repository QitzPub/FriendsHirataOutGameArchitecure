
using UnityEngine;
using Qitz.ArchitectureCore;

namespace Qitz.OuteGame
{
    public class OutGameController : AController<OutGameRepository>
    {
        [SerializeField]
        OutGameRepository repository;


        protected override OutGameRepository Repository { get { return repository; } }


        private void Awake()
        {

        }

    }
}