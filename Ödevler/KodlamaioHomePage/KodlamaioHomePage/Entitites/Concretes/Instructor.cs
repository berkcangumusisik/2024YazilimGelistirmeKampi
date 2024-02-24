using KodlamaioHomePage.Entitites.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioHomePage.Entitites.Concretes;

public class Instructor :IEntity
{
    public int Id { get; set; }
    public string InstructorFirstName { get; set; }
    public string InstructorLastName { get; set; }

}
