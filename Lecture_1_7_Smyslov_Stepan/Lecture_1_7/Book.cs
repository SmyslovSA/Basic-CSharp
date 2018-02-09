﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_1_7
{
    class Book
    {
        public string Name;
        public Genre Genre;
        public Author AuthorName;
        public bool IsInStock;

        public void SetBookAvailable()
        {
            IsInStock = true;
        }
        public void SetBookUnavailable()
        {
            IsInStock = false;
        }
    }
}