using System;
using System.ComponentModel.DataAnnotations;
using Formularz.Models;
namespace Formularz.Models
{
	public class FizzBuzz
	{
		[Display(Name = "Twój szczęśliwy numerek")]
		[Required]
		[Range(1, 1000, ErrorMessage = "Oczekiwana wartość {0} z zakresu {1} i {2}.")]
		[moduloDivisionValidation(divider1: 3, divider2: 5)]
		public int? Number { get; set; }

		public bool doesNumberExists()
		{
			if (Number != null)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		
	}
}

