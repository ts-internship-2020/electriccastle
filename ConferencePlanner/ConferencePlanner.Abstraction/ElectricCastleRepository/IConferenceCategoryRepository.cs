using ConferencePlanner.Abstraction.ElectricCastleModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConferencePlanner.Abstraction.ElectricCastleRepository
{
    public interface IConferenceCategoryRepository
    {
        public void addCategory(ConferenceCategoryModel conferenceCategory);

        public void editCategory(ConferenceCategoryModel conferenceCategory);

        public void deleteCategory(int categoryId);

        public List<ConferenceCategoryModel> getAllCategories();

        public ConferenceCategoryModel getCategoryForConference(int conferenceId);

        public int getNextId();

        public ConferenceCategoryModel getCategory(int categoryId);
    }
}
