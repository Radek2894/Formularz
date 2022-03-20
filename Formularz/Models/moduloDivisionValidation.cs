using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Formularz.Models
{
	public class moduloDivisionValidation : ValidationAttribute
	{

		private int divider1, divider2;
		public moduloDivisionValidation(int divider1, int divider2)
		{
			this.divider1 = divider1;
			this.divider2 = divider2;
		}
		public override bool IsValid(object? value)
		{
			if (value == null)
			{
				return true;
			}
			
			int number = (int)value;

			if (number % divider1 == 0 && number % divider2 == 0)
			{
				ErrorMessage = "FizzBuzz";
				return false;
			}

			else if (number % divider1 == 0)
			{
				ErrorMessage = "Fizz";
				return false;
			}

			else if (number % divider2 == 0)
			{
				ErrorMessage = "Buzz";
				return false;
			}

			else
			{
				ErrorMessage = "Podana przez użytkownika liczba nie spełnia kryteriów FizzBuzz";
				return false;
			}
		}

	

	}
}

