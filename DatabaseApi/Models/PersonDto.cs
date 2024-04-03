namespace DatabaseApi.Models
{
	public class PersonDto
	{
		public int? PersonId { get; set; }
		public string? Name { get; set; }
		public float? Age { get; set; }
		public DateTime? BirthDate { get; set; }
		public int? NationalityId { get; set; }
		public string? NationalityName { get; set; }
		
	}
}
