using KodlamaioHomePage.DataAccess.Abstract;
using KodlamaioHomePage.Entitites.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioHomePage.DataAccess.Concrete;

public class InstructorDal : IInstructorDal
{
    List<Instructor> _instructors;
    public InstructorDal()
    {
        _instructors = new List<Instructor>
        {
            new Instructor{Id=1,InstructorFirstName="Engin", InstructorLastName="Demiroğ"},
            new Instructor{Id=2,InstructorFirstName="Berkcan", InstructorLastName="Gümüşışık"},
            new Instructor{Id=3,InstructorFirstName="Halit Enes", InstructorLastName="Kalaycı"}

        };
    }
    public void Add(Instructor entity)
    {
        _instructors.Add(entity);
    }

    public void Delete(int id)
    {
        var instructorToDelete = _instructors.SingleOrDefault(i => i.Id == id);
        _instructors.Remove(instructorToDelete);
    }

    public Instructor Get(int id)
    {
        return _instructors.SingleOrDefault(i => i.Id == id);
    }

    public List<Instructor> GetAll()
    {
        return _instructors;
    }

    public void Update(Instructor entity)
    {
        var instructorToUpdate = _instructors.SingleOrDefault(i => i.Id == entity.Id);
        if(instructorToUpdate != null)
        {
            instructorToUpdate.InstructorFirstName = entity.InstructorFirstName;
            instructorToUpdate.InstructorLastName = entity.InstructorLastName;
        }
        else
        {
            Console.WriteLine("Böyle bir eğitmen bulunamadı.");
        }

    }
}
