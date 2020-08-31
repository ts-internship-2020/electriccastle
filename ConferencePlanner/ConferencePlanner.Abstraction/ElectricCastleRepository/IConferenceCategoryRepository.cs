using ConferencePlanner.Abstraction.ElectricCastleModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConferencePlanner.Abstraction.ElectricCastleRepository
{
    public interface IConferenceCategoryRepository
    {
        public void AddCategory(ConferenceCategoryModel conferenceCategory);

        public void EditCategory(ConferenceCategoryModel conferenceCategory);

        public void DeleteCategory(int categoryId);

        public List<ConferenceCategoryModel> GetAllCategories();

        public ConferenceCategoryModel GetCategoryForConference(int conferenceId);

        public int GetNextId();

        public ConferenceCategoryModel GetCategory(int categoryId);
    }
}
