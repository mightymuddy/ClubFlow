using System.Globalization;
using System.Collections.Generic;
using Vereinsportal.Interfaces;
using System.Collections.ObjectModel;
using ClubFlow.Components;

namespace ClubFlow.Models
{
    public static class UserClub
    {
        private static readonly Collection<IClub> clubs ;
        public static void createClub(string Name, Location location, string type = "general")
        {
            IClub club;
            switch(type)
            {
                case "music": club = new MusicClub(); break;
                case "sports": club = new SportsClub(); break;
                default: club = new Club(); break;
            }

            club.Name = Name;
            club.LocationId = location.LocationId;
            addClub(club);
        }

        public static void addClub(IClub club) => clubs.Add(club);

        public static IClub getClub(string name)
        {
            int i = 0;
            while (i < clubs.Count)
            {
                if (clubs[i].Name == name)
                    i++;
            }
            return clubs[i];
        }

        
    }
}
