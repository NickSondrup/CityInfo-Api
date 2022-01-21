using CityInfo.API.Models;
using System.Collections.Generic;

namespace CityInfo.API
{
    public class CitiesDataStore
    {
        public static CitiesDataStore Current { get; } = new CitiesDataStore();
        public List<CityDto> Cities { get; set; }

        public CitiesDataStore()
        {
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id = 1,
                    Name = "New York City",
                    Description = "The one with that big park",
                    PointsOfInterest = new List<PointsOfInterestDto>()
                    {
                        new PointsOfInterestDto()
                        {
                            Id= 1,
                            Name = "Central Park",
                            Description="big park"
                        },
                        new PointsOfInterestDto()
                        {
                            Id= 2,
                            Name = "Empire State Building",
                            Description="big Pointy building"
                        }
                    },
                },
                new CityDto()
                {
                    Id=2,
                    Name = "Antwerp",
                    Description= "The one with the cathedral that was never really finished.",
                     PointsOfInterest = new List<PointsOfInterestDto>()
                    {
                        new PointsOfInterestDto()
                        {
                            Id= 3,
                            Name = "Cathedral of Our Lady",
                            Description="Our Lady was never finished"
                        },
                        new PointsOfInterestDto()
                        {
                            Id= 4,
                            Name = "Antwerp Central Station",
                            Description="big Trainy thing"
                        }
                    },
                },
                new CityDto()
                {
                    Id = 3,
                    Name ="Paris",
                    Description = "The one with that big tower.",
                     PointsOfInterest = new List<PointsOfInterestDto>()
                    {
                        new PointsOfInterestDto()
                        {
                            Id= 5,
                            Name = "Eiffel Tower",
                            Description="big pointier building"
                        },
                        new PointsOfInterestDto()
                        {
                            Id= 6,
                            Name = "The Louvre",
                            Description="wait this stuff isn't french."
                        }
                    },
                }
            };
        }
    }
}
