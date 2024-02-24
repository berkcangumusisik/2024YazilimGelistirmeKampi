using KodlamaioHomePage.Entitites.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioHomePage.Business.Abstract;

public interface ICourseService
{
    List<Course> GetAll();
    void Add(Course course);
    void Update(Course course);
    void Delete(int id);
}
