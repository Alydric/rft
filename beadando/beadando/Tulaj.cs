﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beadando
{
    class Tulaj
    {
        private int id;
        private string név;
        private DateTime dateOfBirth;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Név
        {
            get
            {
                return név;
            }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("A név nem lehet üres!");
                if (250 < value.Length)
                    throw new ArgumentOutOfRangeException("A mező max 250 karakter lehet!");
                név = value;
            }
        }

        public DateTime DateOfBirth
        {
            get
            {
                return dateOfBirth;
            }
            set
            {
                if (value > DateTime.Now)
                    throw new Exception("Nem lehet a mai naptól későbbi dátumot beállítani!");
                dateOfBirth = value;
            }
        }

        public override string ToString()
        {
            return név;
        }
    }
}
