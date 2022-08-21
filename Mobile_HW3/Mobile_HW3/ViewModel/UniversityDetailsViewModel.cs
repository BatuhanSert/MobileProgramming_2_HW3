using Mobile_HW3.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Mobile_HW3.ViewModel
{
    class UniversityDetailsViewModel
    {
        string logo;
        string name;
        string type;
        string location;
        string url;

        public string Name
        {
            set
            {
                if (name != value)
                {
                    name = value;
                }
            }
            get
            {
                return name;
            }
        }
        public string Logo
        {
            set
            {
                if (logo != value)
                {
                    logo = value;

                }
            }
            get
            {
                return logo;
            }
        }

        public string Type
        {
            set
            {
                if (type != value)
                {
                    type = value;

                }
            }
            get
            {
                return type;
            }
        }
        public string Location
        {
            set
            {
                if (location != value)
                {
                    location = value;

                }
            }
            get
            {
                return location;
            }
        }
        public string Url
        {
            set
            {
                if (url != value)
                {
                    url = value;
                }
            }
            get
            {
                return url;
            }
        }
    }
}
