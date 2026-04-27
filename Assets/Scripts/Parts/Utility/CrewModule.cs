using SFS.Variables;
using Sirenix.OdinInspector;
using System;
using System.Linq;
using SFS.Career;
using UnityEngine;
using SFS.Parts;
using SFS.UI;
using SFS.Builds;
using SFS.Parts.Modules;
using SFS.Translations;

namespace SFS.World
{
    public class CrewModule : MonoBehaviour, Rocket.INJ_Rocket, I_PartMenu, I_InitializePartModule
    {
        public float baseMass;
        public Bool_Reference hasControl;
        public Bool_Reference needsCrewForControl;
        public Seat[] seats;

        public GameObject interior, hatch;

        public bool HasCrew => seats.Any(s => !string.IsNullOrEmpty(s.astronaut.Value));

        Part part;
        public Rocket Rocket { get; set; }


        int I_InitializePartModule.Priority => 0;
        void I_InitializePartModule.Initialize()
        {
            part = GetComponentInParent<Part>();

            needsCrewForControl.OnChange += OnSeatChange;
            foreach (Seat seat in seats)
            {
                seat.OnStart();
                seat.astronaut.OnChange += OnSeatChange;
            }


        }
        void OnSeatChange()
        {
            bool hasCrew = seats.Any(s => s.HasAstronaut) || !needsCrewForControl.Value;
            hasControl.Value = hasCrew;

            if (hatch != null)
                hatch.SetActive(hasCrew);
            if (interior != null)
                interior.SetActive(!hasCrew);

            part.mass.Value = baseMass + seats.Sum(s => s.HasAstronaut ? 0.2f : 0);
        }
        void OnDestroy()
        {
            foreach (Seat seat in seats)
                seat.OnDestroy();
        }

        // On part used
        public void OpenPartMenu_Seats()
        {

        }
        // From astronaut
        public void OpenPartMenu(bool canBoardWorld)
        {


        }

        void I_PartMenu.Draw(StatsMenu drawer, PartDrawSettings settings)
        {

            bool drawSeats = settings.build || settings.game;

            drawer.DrawStat(90, () =>
            {
                string seatCount = drawSeats ? (seats.Count(seat => seat.HasAstronaut) + " / " + seats.Length) : seats.Length.ToString();
                return Loc.main.Crew_Count.Inject(seatCount, "count");
            },
            null,
            update =>
            {
                foreach (Seat seat in seats)
                    seat.astronaut.OnChange += update;
            },
            update =>
            {
                foreach (Seat seat in seats)
                    seat.astronaut.OnChange -= update;
            });

            if (drawSeats)
                DrawSeats(drawer, settings);
        }
        void DrawSeats(StatsMenu drawer, PartDrawSettings settings)
        {

        }

        // World
        void EVA_Board(Seat seat)
        {

        }
        void EVA_Exit(Seat seat)
        {

        }


        [Serializable]
        public class Seat
        {
            public String_Reference astronaut;
            public Vector2 hatchPosition;

            public bool externalSeat;
            [ShowIf("externalSeat"), Required] public GameObject astronautModel;
            [ShowIf("externalSeat"), Required] public EVA_Resources resources;

            public bool HasAstronaut => !string.IsNullOrEmpty(astronaut.Value);

            public void OnStart()
            {
                if (!HasAstronaut)
                    return;


                Debug.Log("Astronaut " + astronaut.Value + " is not available");
                astronaut.Value = "";

                if (externalSeat)
                    resources.fuelPercent.Value = -1;

            }
            public void OnDestroy()
            {
                if (!HasAstronaut)
                    return;

            }

            public void Board(string astronautName, double fuelPercent, float temperature)
            {

                if (externalSeat)
                {
                    AddSeatedAstronaut();
                    resources.fuelPercent.Value = fuelPercent;
                    resources.temperature.Value = temperature;
                }
            }
            public void Exit()
            {
                astronaut.Value = "";

                if (externalSeat)
                    RemoveSeatedAstronaut();
            }

            void AddSeatedAstronaut()
            {
                if (externalSeat)
                    astronautModel.SetActive(true);
            }
            void RemoveSeatedAstronaut()
            {
                if (externalSeat)
                    astronautModel.SetActive(false);
            }
        }
    }
}