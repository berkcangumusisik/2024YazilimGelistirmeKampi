using KodlamaioHomePage.Business.Abstract;
using KodlamaioHomePage.DataAccess.Abstract;
using KodlamaioHomePage.Entitites.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioHomePage.Business.Concrete;

public class CategoryManager : ICategoryService
{
    ICategoryDal _categoryDal;
    public CategoryManager(ICategoryDal categoryDal)
    {
        _categoryDal = categoryDal;
    }

  

    public void Add(Category category)
    {
        _categoryDal.Add(category);
    }

    public void Delete(int id)
    {
        _categoryDal.Delete(id);
    }

    public List<Category> GetAll()
    {
        return _categoryDal.GetAll();
    }


    public void Update(Category category)
    {
        _categoryDal.Update(category);
    }
}
