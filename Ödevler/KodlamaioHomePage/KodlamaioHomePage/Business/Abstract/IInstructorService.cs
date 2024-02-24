using KodlamaioHomePage.Entitites.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioHomePage.Business.Abstract;

public interface IInstructorService
{
    List<Instructor> GetAll();
    void Add(Instructor instructor);
    void Update(Instructor instructor);
    void Delete(int id);
}
