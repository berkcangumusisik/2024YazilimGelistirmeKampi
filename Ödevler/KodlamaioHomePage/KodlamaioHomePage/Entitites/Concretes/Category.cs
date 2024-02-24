using KodlamaioHomePage.Entitites.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioHomePage.Entitites.Concretes;

public class Category : IEntity
{
    public int Id { get; set; }
    public string CategoryName { get; set; }

}
