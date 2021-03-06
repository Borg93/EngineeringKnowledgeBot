﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Linq;

namespace CoreBot1.CognitiveModels
{
    // Extends the partial FlightBooking class with methods and properties that simplify accessing entities in the luis results
    public partial class FlightBooking
    {
        public (string From, string Airport) FromEntities
        {
            get
            {
                var fromValue = Entities?._instance?.From?.FirstOrDefault()?.Text;
                var fromAirportValue = Entities?.From?.FirstOrDefault()?.Airport?.FirstOrDefault()?.FirstOrDefault();
                return (fromValue, fromAirportValue);
            }
        }

        public (string To, string Airport) ToEntities
        {
            get
            {
                var toValue = Entities?._instance?.To?.FirstOrDefault()?.Text;
                var toAirportValue = Entities?.To?.FirstOrDefault()?.Airport?.FirstOrDefault()?.FirstOrDefault();
                return (toValue, toAirportValue);
            }
        }

        public string Country
        {
            get
            {
                //var toValue = Entities?._instance?.To?.FirstOrDefault()?.Text;
                var countryValue = Entities?._instance.Country?.FirstOrDefault()?.Text;
                //var toAirportValue = Entities?.To?.FirstOrDefault()?.Airport?.FirstOrDefault()?.FirstOrDefault();
                return countryValue;
            }
        }

        public string MaxSpan
        {
            get
            {
                //var toValue = Entities?._instance?.To?.FirstOrDefault()?.Text;
                var countryValue = Entities?._instance.MaxSpan?.FirstOrDefault()?.Text;
                //var toAirportValue = Entities?.To?.FirstOrDefault()?.Airport?.FirstOrDefault()?.FirstOrDefault();
                return countryValue;
            }
        }

        public string Material
        {
            get
            {
                //var toValue = Entities?._instance?.To?.FirstOrDefault()?.Text;
                var countryValue = Entities?._instance.Material?.FirstOrDefault()?.Text;
                //var toAirportValue = Entities?.To?.FirstOrDefault()?.Airport?.FirstOrDefault()?.FirstOrDefault();
                return countryValue;
            }
        }

        public string Levels
        {
            get
            {
                //var toValue = Entities?._instance?.To?.FirstOrDefault()?.Text;
                var levelsValue = Entities?._instance.Levels?.FirstOrDefault()?.Text;
                //var toAirportValue = Entities?.To?.FirstOrDefault()?.Airport?.FirstOrDefault()?.FirstOrDefault();
                return levelsValue;
            }
        }

        public string Curviness
        {
            get
            {
                //var toValue = Entities?._instance?.To?.FirstOrDefault()?.Text;
                var curvinessValue = Entities?._instance.Curviness?.FirstOrDefault()?.Text;
                //var toAirportValue = Entities?.To?.FirstOrDefault()?.Airport?.FirstOrDefault()?.FirstOrDefault();
                return curvinessValue;
            }
        }

        public string Skill
        {
            get
            {
                //var toValue = Entities?._instance?.To?.FirstOrDefault()?.Text;
                var countryValue = Entities?._instance.Skill?.FirstOrDefault()?.Text;
                //var toAirportValue = Entities?.To?.FirstOrDefault()?.Airport?.FirstOrDefault()?.FirstOrDefault();
                return countryValue;
            }
        }

        public string Word
        {
            get
            {
                //var toValue = Entities?._instance?.To?.FirstOrDefault()?.Text;
                var countryValue = Entities?._instance.Word?.FirstOrDefault()?.Text;
                //var toAirportValue = Entities?.To?.FirstOrDefault()?.Airport?.FirstOrDefault()?.FirstOrDefault();
                return countryValue;
            }
        }

        public string Typology
        {
            get
            {
                //var toValue = Entities?._instance?.To?.FirstOrDefault()?.Text;
                var countryValue = Entities?._instance.Typology?.FirstOrDefault()?.Text;
                //var toAirportValue = Entities?.To?.FirstOrDefault()?.Airport?.FirstOrDefault()?.FirstOrDefault();
                return countryValue;
            }
        }

        public string Language
        {
            get
            {
                //var toValue = Entities?._instance?.To?.FirstOrDefault()?.Text;
                var countryValue = Entities?._instance.Language?.FirstOrDefault()?.Text;
                //var toAirportValue = Entities?.To?.FirstOrDefault()?.Airport?.FirstOrDefault()?.FirstOrDefault();
                return countryValue;
            }
        }


        public string Project
        {
            get
            {
                //var toValue = Entities?._instance?.To?.FirstOrDefault()?.Text;
                var countryValue = Entities?._instance.Project?.FirstOrDefault()?.Text;
                //var toAirportValue = Entities?.To?.FirstOrDefault()?.Airport?.FirstOrDefault()?.FirstOrDefault();
                return countryValue;
            }
        }

        // This value will be a TIMEX. And we are only interested in a Date so grab the first result and drop the Time part.
        // TIMEX is a format that represents DateTime expressions that include some ambiguity. e.g. missing a Year.
        public string TravelDate
            => Entities.datetime?.FirstOrDefault()?.Expressions.FirstOrDefault()?.Split('T')[0];
    }
}
