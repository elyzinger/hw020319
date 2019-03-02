using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camp
{
    class Camp
    {
        private readonly int ID;
        public int Latitude { get; set; }
        public int Longtitude { get; set; }
        public int NumberOfPeople { get; set; }
        public int NumberOfTents { get; set; }
        public int NumberOfFlashLights { get; set; }
        private static int lastCompld = 0;
        public Camp(int latitude,int longtitude,int numberOfPeople,int numberOfTents,int numberOfFlashLights)
        {
            this.Latitude = latitude;
            this.Longtitude = longtitude;
            this.NumberOfPeople = numberOfPeople;
            this.NumberOfTents = numberOfTents;
            this.NumberOfFlashLights = numberOfFlashLights;
        }
        public Camp(int numberOfPeople, int numberOfTents, int numberOfFlashLights)
        {
            this.NumberOfPeople = numberOfPeople;
            this.NumberOfTents = numberOfTents;
            this.NumberOfFlashLights = numberOfFlashLights;
        }
        public static bool operator == (Camp a, Camp b)
        {
            if (a.ID == b.ID)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Camp a, Camp b)
        {
                return !(a.ID == b.ID);
        }
        public static bool operator >(Camp a, Camp b)
        {
            if (a.NumberOfPeople == b.NumberOfPeople)
            {
                return false;
            }

                return (a.NumberOfPeople > b.NumberOfPeople);
        }
        public static bool operator <(Camp a, Camp b)
        {
            if( a.NumberOfPeople == b.NumberOfPeople)
            {
                return false;
            }
            return (a.NumberOfPeople > b.NumberOfPeople);
        }
        public static Camp operator +(Camp a, Camp b)
        {
            return new Camp(a.NumberOfPeople + b.NumberOfPeople, a.NumberOfTents + b.NumberOfTents ,a.NumberOfFlashLights + b.NumberOfFlashLights);
        }

        public override bool Equals(object obj)
        {
            Camp other = obj as Camp;
            return this == other;
        }

        public override int GetHashCode()
        {
            return this.ID;
        }

        public override string ToString()
        {
            return $"camp detailse: Latitude {Latitude} Longtitude {Longtitude} NumberOfPeople {NumberOfPeople} NumberOfTents {NumberOfTents} NumberOfFlashLights {NumberOfFlashLights}";
        }
    }
}
