﻿using OnlineEdu.WebUI.DTOs.CourseCategoryDtos;

namespace OnlineEdu.WebUI.DTOs.CourseDtos
{
    public class ResultCourseDto
	{
		public int CourseId { get; set; }
		public string CourseName { get; set; }
		public string ImageUrl { get; set; }
		public int CourseCategoryId { get; set; }
		public ResultCourseCategoryDto CourseCategory { get; set; }
		public decimal Price { get; set; }
		public bool IsShown { get; set; }
	}
}
