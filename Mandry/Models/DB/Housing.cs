﻿namespace Mandry.Models.DB
{
    public class Housing
    {
        public Guid Id { get; set; }
        public decimal PricePerNight { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public string CategoryProperty { get; set; }
        public string Location { get; set; }
        public int MaxGuests { get; set; }

        public User Owner { get; set; }
        public Category Category { get; set; }
        public ICollection<Availability> Availabilities { get; set; } = new List<Availability>();
        public ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
        public ICollection<FeatureHousing> FeatureHousings { get; set; } = new List<FeatureHousing>();
        public ICollection<AccessbilityFeatureHousing> AccessbilitiyFeatureHousings { get; set; } = new List<AccessbilityFeatureHousing>();
        public ICollection<Bedroom> Bedrooms { get; set; } = new List<Bedroom>();
    }
}
