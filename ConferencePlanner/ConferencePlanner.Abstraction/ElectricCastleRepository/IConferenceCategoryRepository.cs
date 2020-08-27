using ConferencePlanner.Abstraction.ElectricCastleModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConferencePlanner.Abstraction.ElectricCastleRepository
{
    public interface IConferenceCategoryRepository
    {
        public List<ConferenceCategoryModel> getAllCategories();

        public ConferenceCategoryModel getCategoryForConference(int conferenceId);

        public void deleteCategory(int categoryId);
    }
}
