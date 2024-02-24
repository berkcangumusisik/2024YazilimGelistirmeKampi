using KodlamaioHomePage.Entitites.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioHomePage.Business.Abstract;

public interface ICategoryService
{
    List<Category> GetAll();
    void Add(Category category);
    void Update(Category category);
    void Delete(int id);
}
