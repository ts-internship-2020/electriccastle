using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConferencePlanner.Abstraction.Helpers
{
    public class PaginationHelper<T>
    {
        private List<T> items = new List<T>();

        public int pageNumber { get; set; }

        private int pageSize;

        private int lastPageNumber;

        public PaginationHelper(List<T> items, int pageSize)
        {
            pageNumber = 1;
            this.pageSize = pageSize;
            lastPageNumber = (int)Math.Ceiling(items.Count / (double)pageSize);
            this.items.AddRange(items);
        }

        public List<T> GetPage()
        {
            return items.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
        }

        public void PreviousPage()
        {
            if (pageNumber > 1)
            {
                pageNumber -= 1;
            }
        }

        public void NextPage()
        {
            if (pageNumber < lastPageNumber)
            {
                pageNumber += 1;
            }
        }

        public bool HasPreviousPage()
        {
            return (pageNumber > 1);
        }

        public bool HasNextPage()
        {
            return (pageNumber < lastPageNumber);
        }

        public int GetPageForIndex(int index)
        {
            return (int)Math.Ceiling(index / (double)pageSize);
        }
    }
}
