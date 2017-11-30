using Microsoft.Azure.Mobile.Server;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VocabLearningService.DataObjects
{
	public class Assignment : EntityData
	{
		public string Name { get; set; }
		public DateTime ValidFrom { get; set; }
		public DateTime ValidUntil { get; set; }
		public virtual ICollection<Exercise> Exercises { get; set; }

		[ForeignKey("StudentGroup_Id")]
		public StudentGroup StudentGroup { get; set; }
		public string StudentGroup_Id { get; set; }

		public Assignment()
		{
			Exercises = new List<Exercise>();
		}
	}
}