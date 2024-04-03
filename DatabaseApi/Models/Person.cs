namespace DatabaseApi.Models
{
    public class Person
    {
        public int? PersonId { get; set; }
        public string? Name { get; set; }    
        public float? Age { get; set; }
        public int? NationalityId { get; set; }  
        public DateTime? BirthDate { get; set; }
        public Nationality? Nationality { get; set; }    
    }
}
