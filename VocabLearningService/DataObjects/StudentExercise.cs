using Microsoft.Azure.Mobile.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VocabLearningService.DataObjects
{
	public class StudentExercise : EntityData
	{
		[ForeignKey("Student_Id")]
		public User Student { get; set; }
		public string Student_Id { get; set; }

		[ForeignKey("Exercise_Id")]
		public Exercise Exercise { get; set; }
		public string Exercise_Id { get; set; }

		public string Type_Id { get; set; }
		public bool Passed { get; set; }
		public int Attempt { get; set; }
	}
}