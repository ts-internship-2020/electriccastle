using ConferencePlanner.Abstraction.ElectricCastleModel;
using ConferencePlanner.Abstraction.ElectricCastleRepository;
using ConferencePlanner.Repository.Ef.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConferencePlanner.Repository.Ef.Repository
{
    public class CategoryRepository : IConferenceCategoryRepository
    {

        private readonly electriccastleContext _electriccastleContextCategory;

        public CategoryRepository(electriccastleContext electriccastleContext)
        {
            _electriccastleContextCategory = electriccastleContext;

        }
        public void AddCategory(ConferenceCategoryModel conferenceCategory)
        {
            var result = _electriccastleContextCategory.DictionaryConferenceCategory.ToList();
           
        }

        public void DeleteCategory(int categoryId)
        {
            var conferenceCategory = _electriccastleContextCategory.DictionaryConferenceCategory.FirstOrDefault(x => x.DictionaryConferenceCategoryId == categoryId);
            _electriccastleContextCategory.DictionaryConferenceCategory.Remove(conferenceCategory);
            _electriccastleContextCategory.SaveChanges();
        }

        public void EditCategory(ConferenceCategoryModel conferenceCategory)
        {
            var result = _electriccastleContextCategory.DictionaryConferenceCategory.FirstOrDefault(a => a.DictionaryConferenceCategoryId == conferenceCategory.ConferenceCategoryId);
            result.ConferenceCategoryCode = conferenceCategory.ConferenceCategoryCode;
            result.DictionaryConferenceCategoryName = conferenceCategory.ConferenceCategoryName;
            

            _electriccastleContextCategory.SaveChanges();
        }

        public List<ConferenceCategoryModel> GetAllCategories()
        {
            List<DictionaryConferenceCategory> category = _electriccastleContextCategory.DictionaryConferenceCategory.ToList();


            List<ConferenceCategoryModel> allCategories = category.Select(a => new ConferenceCategoryModel() { ConferenceCategoryId = a.DictionaryConferenceCategoryId, ConferenceCategoryName = a.DictionaryConferenceCategoryName, ConferenceCategoryCode = a.ConferenceCategoryCode }).ToList();


            return allCategories;
        }

        public ConferenceCategoryModel GetCategory(int categoryId)
        {
            throw new NotImplementedException();
        }

        public ConferenceCategoryModel GetCategoryForConference(int conferenceId)
        {
            throw new NotImplementedException();
        }

        public int GetNextId()
        {
            throw new NotImplementedException();
        }
    }
}
