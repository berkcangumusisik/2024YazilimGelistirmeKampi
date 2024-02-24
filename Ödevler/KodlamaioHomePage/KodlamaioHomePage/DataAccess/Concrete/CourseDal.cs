using KodlamaioHomePage.DataAccess.Abstract;
using KodlamaioHomePage.Entitites.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioHomePage.DataAccess.Concrete;

public class CourseDal : ICourseDal
{
    List<Course> courses;
    public CourseDal()
    {
        courses = new List<Course>
        {
           new Course
           {
               Id=1,
               CategoryId=2,
               InstructorId=1,
               CourseName ="2024 Yazılım Geliştirici Yetiştirme Kampı (C#)",
               CourseDescription="Sıfırdan ileri seviyeye götürecek bir kamp olacak",
               CoursePrice=0,
           },
           new Course
           {
                Id=2,
                CategoryId=3,
                InstructorId=1,
                CourseName ="Yazılım Geliştirici Yetiştirme Kampı (JAVA+REACT)",
                CourseDescription="Sıfırdan ileri seviyeye götürecek bir kamp olacak",
                CoursePrice=0,
              },
           new Course
           {
                 Id=3,
                 CategoryId=1,
                 InstructorId=2,
                 CourseName ="Front End Geliştirici Yetiştirme Kampı (REACT)",
                 CourseDescription="Sıfırdan ileri seviyeye götürecek bir kamp olacak",
                 CoursePrice=0,
                  },
        };
    }
    public void Add(Course entity)
    {
        courses.Add(entity);
    }

    public void Delete(int id)
    {
        var courseToDelete = courses.SingleOrDefault(c => c.Id == id);
        if (courseToDelete != null)
        {
            courses.Remove(courseToDelete);
        }
        else
        {
            Console.WriteLine("Böyle bir kurs bulunamadı.");
        }
    }

    public Course Get(int id)
    {
        return courses.SingleOrDefault(c => c.Id == id);
    }

    public List<Course> GetAll()
    {
        return courses;
    }

    public void Update(Course entity)
    {
        var courseToUpdate = courses.SingleOrDefault(c => c.Id == entity.Id);
        if (courseToUpdate != null)
        {
            courseToUpdate.CategoryId = entity.CategoryId;
            courseToUpdate.InstructorId = entity.InstructorId;
            courseToUpdate.CourseName = entity.CourseName;
            courseToUpdate.CourseDescription = entity.CourseDescription;
            courseToUpdate.CoursePrice = entity.CoursePrice;
        }
        else
        {
            Console.WriteLine("Böyle bir kurs bulunamadı.");
        }
    }
}
