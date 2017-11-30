using Microsoft.Azure.Mobile.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VocabLearningService.DataObjects
{
	public class User : EntityData
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }
		public string AzureId { get; set; }
		public bool IsTeacher { get; set; }

		[ForeignKey("StudentGroup_Id")]
		public StudentGroup StudentGroup { get; set; }
		public string StudentGroup_Id { get; set; }

		public virtual ICollection<StudentGroup> StudentGroups { get; set; }

		public User()
		{
			StudentGroups = new List<StudentGroup>();
		}
	}
}