using DatabaseApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace DatabaseApi.Controllers
{

	public class DataBaseController : Controller
	{
		private readonly DataBaseContextModel _dbContext;

		public DataBaseController(DataBaseContextModel dbContext)
		{
			_dbContext = dbContext;
		}




		[Route("GetAllUsers")]
		public IActionResult PersonsView()
		{
			var query = _dbContext.Persons.Include(p => p.Nationality);

			List<PersonDto> personData =  query.Select(person => new PersonDto
			{
				PersonId = person.PersonId,
				Name = person.Name,
				Age = person.Age,
				BirthDate = person.BirthDate,
				NationalityId = person.NationalityId,
				NationalityName = person.Nationality.NationalityName
			}).ToList();

			return View(personData);
		}


		[Route("/insert-user")]

		public IActionResult CreateUser([FromQuery] Person person)
		{
			_dbContext.Persons.Add(person);
			_dbContext.SaveChanges();

			return View();
		}

		[Route("/remove-user/{id}")]

		public IActionResult RemoveUser(int id)
		{

			Person? person = _dbContext.Persons.Find(id);
			if (person is null)
			{
				return View("Error");
			}
			_dbContext.Persons.Remove(person);
			_dbContext.SaveChanges();
			return View();
		}

		[Route("/find-user/{id}")]

		public IActionResult FindUser(int id)
		{

			Person? person = _dbContext.Persons
								.Include(p => p.Nationality)
								.FirstOrDefault(p => p.PersonId == id);

			if (person != null)
			{
				PersonDto personDto = new PersonDto
				{
					PersonId = person.PersonId,
					Name = person.Name,
					Age = person.Age,
					BirthDate = person.BirthDate,
					NationalityId = person.NationalityId,
					NationalityName = person.Nationality?.NationalityName 
				};

				return View(personDto);
			}
			return View("Error");

		}

		[Route("/update-user/{id}")]

		public IActionResult UpdateUser([FromQuery] Person person)
		{
			if (person is null)
			{
				return View("Error");
			}
			_dbContext.Persons.Update(person);
			_dbContext.SaveChanges();



			return View();
		}





	}
}
