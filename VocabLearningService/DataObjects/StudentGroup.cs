using Microsoft.Azure.Mobile.Server;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VocabLearningService.DataObjects
{
	public class StudentGroup : EntityData
	{
		public string Name { get; set; }
		public int GroupSize { get; set; }
		public virtual ICollection<User> Students { get; set; }
		public virtual ICollection<Assignment> Assignments { get; set; }

		[ForeignKey("Teacher_Id")]
		public User Teacher { get; set; }
		public string Teacher_Id { get; set; }

		public StudentGroup()
		{
			Students = new List<User>();
			Assignments = new List<Assignment>();
		}
	}
}