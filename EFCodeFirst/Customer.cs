﻿using System.ComponentModel.DataAnnotations;

namespace EFCodeFirst
{
    class Customer
    {
        private int id;
        private string name, city;

        [Key]
        public int CID
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }
        public string City
        {
            get
            {
                return city;
            }

            set
            {
                city = value;
            }
        }
    }
}
